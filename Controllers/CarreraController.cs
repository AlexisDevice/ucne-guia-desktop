using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ucne_guia_desktop.Models;

namespace ucne_guia_desktop.Controllers
{
    internal class CarreraController
    {
        private readonly string UrlApi = "http://192.168.0.104:5000";
        private readonly HttpClient client = new HttpClient();

        public async Task<List<Carrera>> GetCarreras()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(UrlApi + "/carreras");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Carrera> carreras = JsonSerializer.Deserialize<List<Carrera>>(responseBody);
                    return carreras;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
