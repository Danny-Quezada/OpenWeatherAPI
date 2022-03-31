using OpenWeatherApi.AppCore.IServices;
using OpenWeatherAPI.Domain.Entities.Climate;
using OpenWeatherAPI.Domain.Interfaces;
using OpenWeatherAPI.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApi.AppCore.Services
{
    public class JsonClimateServices : IServices<Climate>
    {
        private IModel<Climate> model;
       
        public JsonClimateServices(IModel<Climate> CClima)
        {
            this.model = CClima;
        }
        public Climate Get(string nameCity)
        {
            return model.Get(nameCity);
        }
    }
}
