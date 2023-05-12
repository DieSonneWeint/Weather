using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWther
{
    public class OpenWeather : AllWeatherAPI
    {
        public string NonInformationAboutLocation { get { return $"{nonInformationAboutLocation}\nOW"; } }
        public Main? main { get; set; }
        public string? name { get; set; }

    }
}
