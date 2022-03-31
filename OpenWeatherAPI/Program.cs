using Autofac;
using OpenWeatherApi.AppCore.IServices;
using OpenWeatherApi.AppCore.Services;
using OpenWeatherAPI.Domain.Entities.Climate;
using OpenWeatherAPI.Domain.Interfaces;
using OpenWeatherAPI.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWeatherAPI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterType<JsonOpenWeatherAPI>().As<IModel<Climate>>();
            builder.RegisterType<JsonClimateServices>().As<IServices<Climate>>();
            var container = builder.Build();

            Application.Run(new Form1(container.Resolve<IServices<Climate>>()));
        }
    }
}
