using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CountriesCurrency.CrossCutting.Helpers
{
    public static class HttpClientHelpers
    {
        public static async Task<T> GetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url).ConfigureAwait(false))
                {
                    try
                    {
                        response.EnsureSuccessStatusCode();
                        var content = await response.Content.ReadAsStringAsync();
                        var asd = JsonConvert.DeserializeObject<dynamic>(content);
                        return JsonConvert.DeserializeObject<T>(content);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    
                }
            }
        }
    }
}
