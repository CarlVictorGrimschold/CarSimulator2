using CarSimulator2.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarSimulator2.Services
{
    public class DriverService
    {
        public async Task<RandomUserName> GetRandomUserDataAsync()
        {
            var user = new RandomUserName();
            try
            {
                var url = $"https://randomuser.me/api/";
                using var client = new HttpClient();
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(url);
                request.Method = HttpMethod.Get;
                var response = await client.SendAsync(request);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = JObject.Parse(responseString);
                    user = new RandomUserName {
                        FirstName = jsonObject["results"][0]["name"]["first"].ToString(),
                    LastName = jsonObject["results"][0]["name"]["last"].ToString(),
                    };
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return user;    
        }
        public int GetDriverTiredness(int tiredness)
        {
            return tiredness++;
        }
        public int Rest()
        {
            return 0;
        }
        public int Refuel()
        {
            return 100;
        }
    }
}
