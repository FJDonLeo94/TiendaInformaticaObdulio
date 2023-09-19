using Microsoft.EntityFrameworkCore;
using PCObdulioWebApi.Services;
using PruebaComponentesObdulio.Data;
using System;
using PCObdulioWebApi.Data;
using PCObdulioWebApi.Models;


namespace PCObdulioWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped(c =>
            {
                var connectionString = builder.Configuration.GetConnectionString("Default") ?? "";
                var dataDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\.."));
                connectionString = connectionString.Replace("|DataDirectory|", dataDirectory);

                return new ADOContext(connectionString);
            });


            builder.Services.AddScoped<IRepositorio<Componente>, RepositorioComponentes>();
            builder.Services.AddScoped<IRepositorio<Ordenador>, RepositorioOrdenadores>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}