using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ucne_guia_desktop.Models;

namespace ucne_guia_desktop.Controllers
{
   internal class MateriaController
    {


        private readonly string UrlApi = Auth.apiUrl;
        private readonly HttpClient client = new HttpClient();
        public async Task<List<Materia>> getmateria()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(UrlApi + "/materias");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Materia> materia = System.Text.Json.JsonSerializer.Deserialize<List<Materia>>(responseBody);
                    return materia;
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
