using System.Configuration;
using Microsoft.EntityFrameworkCore;
using NLog;
using Polly.Extensions.Http;
using Polly;
using PruebaComponentesObdulio.API;
using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Services;

namespace PruebaComponentesObdulio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = LogManager.Setup().LoadConfigurationFromFile().GetCurrentClassLogger();
            logger.Debug("init main");
            
            var builder = WebApplication.CreateBuilder(args);

            //Servicios del Logger
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            builder.Services.AddSingleton<ILoggerManager, LoggerManager>();


            //Servicios del repositorio para API
            builder.Services.AddScoped<IRepositoryComponentes, RepositorioAPI>();
            builder.Services.AddScoped<IRepositoryOrdenadores, RepositorioAPIPC>();


            //Servicios el repositorio para BBDD
            //builder.Services.AddScoped<IRepositoryComponentes, EFRepositorioComponentes>();
            //builder.Services.AddScoped<IRepositoryOrdenadores, EFRepositorioOrdenadores>();


            builder.Services.AddHttpClient("MyHttpClient")
                .AddPolicyHandler(GetCircuitBreakerPolicy());


            // Add services to the container.

            builder.Services.AddControllersWithViews();

            string path = Directory.GetCurrentDirectory();

            builder.Services.AddDbContext<TiendaOrdenadoresContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")
                    ?.Replace("[DataDirectory]", path)));

            var app = builder.Build();




            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Componentes}/{action=Index}/{id?}");

            app.Run();
        }

        private static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(
                    handledEventsAllowedBeforeBreaking: 3,
                    durationOfBreak: TimeSpan.FromSeconds(30)
                );
        }
    }
}