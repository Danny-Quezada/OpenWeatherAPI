using OpenWeatherApi.AppCore.IServices;
using OpenWeatherAPI.Domain.Entities.Climate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWeatherAPI
{
    public partial class Form1 : Form
    {
        IServices<Climate> services;
        private HttpClient htttp;
        private const string token = "2c0b0ee017cd6d4aa779d5afb4c38a41";
        public  Form1(IServices<Climate> CServices)
        {
            this.services = CServices;
            InitializeComponent();
           
            htttp = new HttpClient();
           
        }

        private async void PBSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Texts))
            {
                //var response = await htttp.GetAsync("https://api.openweathermap.org/data/2.5/weather?q="+txtSearch.Texts+"&units=metric&lang=sp&appid="+token);
                //  if (response.IsSuccessStatusCode)
                //{
                //   // var body = await response.Content.ReadAsStringAsync();
                //    Climate climate = services.Get(body);
                //    Rellenar(climate);
                //}
                Climate climate = services.Get(txtSearch.Texts);
                if (climate != null)
                {
                    Rellenar(climate);
                }
                
            }
            
        }
        private void Rellenar(Climate climate)
        {
            pbClimaImagen.ImageLocation = "http://openweathermap.org/img/w/"+climate.weather[0].icon+".png";
            lblName.Text = climate.name;
            lblDescription.Text = climate.weather[0].description;
            lblHumidity.Text = climate.main.humidity + "%";
            lblMaxima.Text = climate.main.temp_max.ToString()+ "°C";
            lblMinima.Text = climate.main.temp_min.ToString() + "°C";
            lblTemperatura.Text = climate.main.temp.ToString() + "°C";
            lblVisibility.Text = (climate.visibility / 1000).ToString() + "km";
            lblLa.Text = climate.coord.lat.ToString();
            lblLn.Text = climate.coord.lon.ToString();
            lblGrado.Text = climate.main.temp.ToString() + "°C"; 
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("NO SE PUEDEN NUMEROS");

            }
        }
    }
}
