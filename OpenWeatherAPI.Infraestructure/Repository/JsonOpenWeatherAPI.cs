using OpenWeatherAPI.Domain.Entities.Climate;
using OpenWeatherAPI.Domain.Interfaces;

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Infraestructure.Repository
{
    public class JsonOpenWeatherAPI : IModel<Climate>
    {
      
        public JsonOpenWeatherAPI()
        {
          
        }
        public  Climate Get(string body)
        {

            Climate t = JsonSerializer.Deserialize<Climate>(body);
            return t;
        }
       
        
    }
}
