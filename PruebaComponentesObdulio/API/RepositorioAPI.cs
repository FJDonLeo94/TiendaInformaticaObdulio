using Newtonsoft.Json;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Services;
using System.Text;
using System.Xml.Linq;

namespace PruebaComponentesObdulio.API
{
    public class RepositorioAPI : IRepositoryComponentes
    {

        private readonly HttpClient _httpClient;

        public RepositorioAPI(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MyHttpClient");
        }
        public Componente TomaComponente(int Id)
        {
            var url = $"http://localhost:5102/api/Componentes/{Id}";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Componente>(response);
        }

        public void BorraComponente(int Id)
        {
            var url = $"http://localhost:5102/api/Componentes/{Id}";
            _httpClient.DeleteAsync(url);
        }

        public void EditComponente(Componente componente)
        {
            var url = "http://localhost:5102/api/Componentes";
            var json = JsonConvert.SerializeObject(componente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(content);
            _httpClient.PutAsync(url, content);
        }

        public void AddComponente(Componente componente)
        {
            var url = "http://localhost:5102/api/Componentes";
            var json = JsonConvert.SerializeObject(componente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.PostAsync(url, content);
        }

        public List<Componente> ListaComponentes()
        {
            var url = "http://localhost:5102/api/Componentes";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;
            var lista = JsonConvert.DeserializeObject<List<Componente>>(response);
            if (lista == null) return new();

            return lista;
        }
    }
}
