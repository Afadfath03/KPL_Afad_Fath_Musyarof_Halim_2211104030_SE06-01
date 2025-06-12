using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace JURNAL
{
    class BankTransferConfig
    {
        public string Lang { get; set; }
        public Transfer Transfer { get; set; }
        public List<string> Methods { get; set; }
        public Confirmation Confirmation { get; set; }

        private const string ConfigFile = "bank_transfer_config.json";

        public static BankTransferConfig LoadOrCreateConfig()
        {
            if (File.Exists(ConfigFile))
            {
                string json = File.ReadAllText(ConfigFile);
                return JsonConvert.DeserializeObject<BankTransferConfig>(json);
            }
            else
            {
                Console.WriteLine("Pilih bahasa / Select language:");
                Console.WriteLine("1. Bahasa Indonesia");
                Console.WriteLine("2. English");
                Console.Write("Pilihan (1/2): ");
                string choice = Console.ReadLine();

                string selectedLang = choice == "1" ? "id" : "en";

                var defaultConfig = new BankTransferConfig
                {
                    Lang = selectedLang,
                    Transfer = new Transfer
                    {
                        Threshold = 25000000,
                        LowFee = 6500,
                        HighFee = 15000
                    },
                    Methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                    Confirmation = new Confirmation
                    {
                        En = "yes",
                        Id = "ya"
                    }
                };

                File.WriteAllText(ConfigFile, JsonConvert.SerializeObject(defaultConfig, Formatting.Indented));
                return defaultConfig;
            }
        }
    }

    class Transfer
    {
        public int Threshold { get; set; }
        public int LowFee { get; set; }
        public int HighFee { get; set; }
    }

    class Confirmation
    {
        public string En { get; set; }
        public string Id { get; set; }
    }
}
