using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfAppWther
{
    [Serializable]
    public class GrafConst
    {
        public List<double>? midTemp { get; set; }
  
        public List<DateTime>? dates { get; set; }
    }
}
