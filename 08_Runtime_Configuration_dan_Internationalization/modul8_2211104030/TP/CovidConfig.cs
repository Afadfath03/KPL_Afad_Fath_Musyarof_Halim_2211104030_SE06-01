using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace TP
{
    class CovidConfig
    {
        private const string ConfigFile = "covid_config.json";

        public string Jenis { get; set; } = "celcius";
        public int Hari { get; set; } = 14;
        public string Terima { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public string Tolak { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        public static CovidConfig Load()
        {
            if (File.Exists(ConfigFile))
            {
                string json = File.ReadAllText(ConfigFile);
                return JsonConvert.DeserializeObject<CovidConfig>(json);
            }
            else
            {
                var defaultConfig = new CovidConfig();
                defaultConfig.Save();
                return defaultConfig;
            }
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(ConfigFile, json);
        }

        public void GantiJenis()
        {
            Jenis = Jenis == "celcius" ? "fahrenheit" : "celcius";
            Save();
        }
    }
}