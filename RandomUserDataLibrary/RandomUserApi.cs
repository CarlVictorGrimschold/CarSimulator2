using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RandomUserDataLibrary
{
    public class RandomUserApi
    {
        private const string ApiUrl = "https://randomuser.me/api/";

        public async Task<Driver> GetRandomUserDataAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(ApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Driver userData = JsonConvert.DeserializeObject<Driver>(json);
                    return userData;
                }
                else
                {
                    // Hantera fel om anropet misslyckas.
                    throw new Exception("Kunde inte hämta slumpmässig användardata från API:et.");
                }
            }
        }
    }
}