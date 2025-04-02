using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using Newtonsoft.Json.Linq;

namespace ucne_guia_desktop.Controllers
{
    public class Auth
    {
        private readonly string apiUrl = "http://192.168.1.83:5000";
        private static readonly HttpClient client = new HttpClient();
        public async Task<bool> Login(string email, string password)
        {
            try
            {
                var credentials = new { email, password };
                string jsonData = JsonConvert.SerializeObject(credentials);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl + "/auth/login", content);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic result = JObject.Parse(responseBody);
                    if ((bool)result["mensaje"] == true)
                    {
                        Properties.Settings.Default.userId = (int)result["user"]["id"];
                        Properties.Settings.Default.userName = result["user"]["name"].ToString();
                        Properties.Settings.Default.userEmail = result["user"]["email"].ToString();
                    }
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Signup(string user_name, string matricula, string email, string password)
        {
            try
            {
                var credentials = new { user_name, email, matricula, password };
                string jsonData = JsonConvert.SerializeObject(credentials);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl + "/auth/signup", content);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
