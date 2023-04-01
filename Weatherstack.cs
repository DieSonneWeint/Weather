using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWther
{
    public class Weatherstack
    {
        public Locations? Location { get; set; }
        public Currents? Current { get; set; }
    }


    public class Locations
    {
        public string? name { get; set; }
    }

    public class Currents
    {
        public int? temperature { get; set; }
    }

}