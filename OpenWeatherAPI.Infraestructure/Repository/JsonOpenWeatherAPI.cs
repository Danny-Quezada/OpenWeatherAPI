using OpenWeatherAPI.Domain.Entities.Climate;
using OpenWeatherAPI.Domain.Interfaces;
using OpenWeatherAPI.Infraestructure.Providers;
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
        private TProviders<Climate> providers;

        private const string token = "2c0b0ee017cd6d4aa779d5afb4c38a41";
        public JsonOpenWeatherAPI()
        {
            providers = new TProviders<Climate>(token);
        }
        public  Climate Get(string body)
        {

            providers.url = "https://api.openweathermap.org/data/2.5/weather?q=" + body + "&units=metric&lang=sp&appid=" + token;
            Climate t=providers.Get();
            return t;
        }
       
        
    }
}
