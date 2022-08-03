using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigsLoaderMockUp
{
    public class ReadGlobalConfig : ReadFromFile
    {
        private readonly string folderPath = @"C:\Users\MynDe\Desktop\ConfigsDir\";
        private readonly string defaultPath = @"C:\Users\MynDe\Desktop\ConfigsDir\config.txt";

        public ReadGlobalConfig()
        {

        }

        public override void Read(bool all = false)
        {
            if (all)
            {
                ReadAllFiles();
            }
            else
            {
                ReadSingleFile(defaultPath);
            }
        }

        public override void UpdateConfig(string line)
        {
            string[] split = line.Split(new char[] { ':' }, 2);
            if (split.Length == 2)
            {
                var name = split[0].Trim();
                var value = split[1].Trim();
                switch (name)
                {
                    case "ordersPerHour":
                        DataConfig.OrdersPerHour = Validator.ValidateIntValues(name, value);
                        break;
                    case "orderLinesPerOrder":
                        DataConfig.OrderLinesPerOrder = Validator.ValidateIntValues(name, value);
                        break;
                    case "inboundStrategy":
                        DataConfig.InboundStrategy = Validator.ValidateInboundValues(name, value);
                        break;
                    case "powerSupply":
                        DataConfig.PowerSupply = Validator.ValidateSupplyValues(name, value);
                        break;
                    case "resultStartTime":
                        DataConfig.ResultStartTime = Validator.ValidateTime(name, value);
                        break;
                    case "resultInterval":
                        DataConfig.ResultInterval = Validator.ValidateIntValues(name, value);
                        break;
                    case "numberOfAisles":
                        DataConfig.NumberOfAisles = Validator.ValidateIntValues(name, value);
                        break;
                }
            }
        }

        private void ReadAllFiles()
        {
            List<string> filePaths = Directory.GetFiles(folderPath).Where(x => x != defaultPath).ToList();

            filePaths.Insert(0, defaultPath);

            foreach (string filePath in filePaths)
            {
                ReadSingleFile(filePath);
            }
        }
    }
}
