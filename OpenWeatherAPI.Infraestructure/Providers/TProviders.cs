using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Infraestructure.Providers
{
    public class TProviders<T>
    {
        HttpClient client;
        string body;
        string Token;
        public string url { get; set; }
        public  TProviders(string cToken){
            this.Token = cToken;
            
            client = new HttpClient();
        }
        public T  Get()
        {
            string urlM = url + Token;
           Task.Run((Func<Task>) Body).Wait();
            try
            {
                T t = JsonSerializer.Deserialize<T>(body);
                return t;

            }
            catch
            {
                return default(T);
            }



        }
        private async Task Body()
        {
            var response = await client.GetAsync(url);
            body = await response.Content.ReadAsStringAsync();
        
        }

    }
}
