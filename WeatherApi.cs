using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWther
{
   public class WeatherApi
    {

        public Location? location { get; set; }
        public Current? current { get; set; }
    } 

        public class Location
        {
            public string? name { get; set; }      
        }

        public class Current
        {
            public float? temp_c { get; set; }
        }
   
}
