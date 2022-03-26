using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.WeatherApi;
using WeatherApplication.WeatherModels.ConcreteModels;

namespace WeatherApplication
{
    public partial class Form1 : Form
    {
        private string _key = "f30670630717bd98e09434e0aa7d078e";

        public Form1()
        {
            InitializeComponent();
        }

        private void GetWeatherButton_Click(object sender, EventArgs e)
        {
            if (countryNameTextBox.Text != String.Empty)
            {
                ThreadPool.QueueUserWorkItem(GetWeather);
            }
        }

        private void GetWeather(object sender)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    //http://api.openweathermap.org/data/2.5/forecast/daily?q=london&units=metric&APPID=value&cnt=7


                    string url;
                    if (!getWholeWeekCheckBox.Checked)
                        url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", countryNameTextBox.Text, _key);
                    else
                        url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", countryNameTextBox.Text, _key);

                    var json = client.DownloadString(url);
                    Root root = JsonConvert.DeserializeObject<Root>(json);

                    FillResultTextBox(root);
                }
            }
            catch (Exception)
            {
                resultTextBox.Text = String.Empty;
                resultTextBox.Text += "Invalid Town Name";
            }
        }

        private void FillResultTextBox(Root root)
        {
            resultTextBox.Text = String.Empty;

            resultTextBox.Text += $"Weater general: {root.Weather[0].Main}\r\n";
            resultTextBox.Text += $"Weater Description: {root.Weather[0].Description}\r\n";
            resultTextBox.Text += $"Temp: {Math.Round(root.Main.Temp-273.15, 2)}°C\r\n";
            resultTextBox.Text += $"Humidity: {root.Main.Humidity}%\r\n";
            resultTextBox.Text += $"Wind speed: {root.Wind.Speed} m/sec\r\n";

            DateTime day = new DateTime(1970, 1,1, 0, 0,0, DateTimeKind.Utc).ToLocalTime();

            resultTextBox.Text += $"Sunrise: {day.AddSeconds(root.Sys.Sunrise).ToLocalTime().ToShortTimeString()}\r\n";
            resultTextBox.Text += $"Sunset: {day.AddSeconds(root.Sys.Sunset).ToLocalTime().ToShortTimeString()}\r\n";

        }
    }
}
