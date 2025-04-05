using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ucne_guia_desktop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ucne_guia_desktop.Controllers
{
    internal class ComentariosController
    {
        private readonly string UrlApi = "http://192.168.1.83:5000";
        private readonly HttpClient client = new HttpClient();

        public async Task<List<Comentario>> getComentarios()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(UrlApi + "/comentarios");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Comentario> comentarios = System.Text.Json.JsonSerializer.Deserialize<List<Comentario>>(responseBody);
                    return comentarios;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> postComentario(string contenido, string materiaId)
        {
            try
            {
                int usuarioId = Properties.Settings.Default.userId;
                var credentials = new { contenido, materiaId, usuarioId };
                string jsonData = JsonConvert.SerializeObject(credentials);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(UrlApi + "/new/comentario", content);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch
            {
                return false;
            }
            return false;
        }
    }
}
