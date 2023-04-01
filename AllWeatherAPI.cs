using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWther
{
    public class AllWeatherAPI
    {
        string nonInformationAboutLocation = "Локация не найдена";
        public string NonInformationAboutLocation { get { return nonInformationAboutLocation; } }
        public OpenWeather? openWeather { get; set; }
        public Weatherstack? weatherstack { get; set; } 
        public WeatherApi? weatherapi { get; set; } 
        public VisCrossWeather? visCross { get; set; } 
    }
}
