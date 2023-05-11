using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WpfAppWther
{
    internal class Model
    {
        public AllWeatherAPI AllWeatherAP = new AllWeatherAPI();
        public GrafConst GrafConst = new GrafConst() { midTemp = new List<double>() , dates = new List<DateTime>()};
        public  void Load (FileStream fileStream, AllWeatherAPI allWeatherAPI)
        {           
            AllWeatherAP=JsonSerializer.Deserialize<AllWeatherAPI>(fileStream);
            fileStream.Close();
         
        }
        public void Load(FileStream fileStream, GrafConst grafConst)
        {
            //var aSerializer = new XmlSerializer(typeof(GrafConst));
            //GrafConst = (GrafConst)aSerializer.Deserialize(fileStream);
            GrafConst = JsonSerializer.Deserialize<GrafConst>(fileStream);
            fileStream.Close();

        }
        public async void Save(FileStream fileStream,AllWeatherAPI allWeatherAPI) 
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            await JsonSerializer.SerializeAsync(fileStream, allWeatherAPI, options);
            await fileStream.DisposeAsync();
        }
        public async void Save(FileStream fileStream, GrafConst grafConst)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            await JsonSerializer.SerializeAsync(fileStream, grafConst, options);
            await fileStream.DisposeAsync();
            //string xmlString;
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(GrafConst));
            //using (var stringWriter = new StringWriter())
            //{
            //    xmlSerializer.Serialize(stringWriter, GrafConst);
            //    xmlString = stringWriter.ToString();
            //}
            //xmlSerializer.Serialize(fileStream, grafConst);
            //fileStream.Close();
        }
    }
}
