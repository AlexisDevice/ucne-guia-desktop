using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ucne_guia_desktop.Models;

namespace ucne_guia_desktop.Controllers
{
    internal class ProfesorController
    {
        private readonly string UrlApi = Auth.apiUrl;
        private readonly HttpClient client = new HttpClient();

        public async Task<List<Profesor>> GetProfesores()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(UrlApi + "/profesores");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Profesor> profesores = JsonSerializer.Deserialize<List<Profesor>>(responseBody);
                    return profesores;
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
