using NewTiendaInformatica.Componentes;
using Newtonsoft.Json;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Services;
using System.Text;

namespace PruebaComponentesObdulio.API
{
    public class RepositorioAPIPC : IRepositoryOrdenadores
    {
        private readonly HttpClient _httpClient;

        public RepositorioAPIPC(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MyHttpClient");
        }
        public Ordenador TomaOrdenador(int Id)
        {
            var url = $"http://localhost:5102/api/Ordenador/{Id}";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Ordenador>(response);
        }

        public void BorraOrdenador(int Id)
        {
            var url = $"http://localhost:5102/api/Ordenador/{Id}";
            _httpClient.DeleteAsync(url);
        }

        public void EditOrdenador(Ordenador ordenador)
        {
            var url = "http://localhost:5102/api/Ordenador";
            var json = JsonConvert.SerializeObject(ordenador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(content);
            _httpClient.PutAsync(url, content);
        }

        public void AddOrdenador(Ordenador ordenador)
        {
            var url = "http://localhost:5102/api/Ordenador";
            var json = JsonConvert.SerializeObject(ordenador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.PostAsync(url, content);
        }

        public List<Ordenador> ListaOrdenadores()
        {
            var url = "http://localhost:5102/api/Ordenador";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;
            var lista = JsonConvert.DeserializeObject<List<Ordenador>>(response);
            if (lista == null) return new();

            return lista;
        }
    }
}
