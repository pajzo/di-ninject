using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLibary
{
    public class Config
    {
        public string Host { get; set; }
    }

    public static class ConfigReader
    {
        public static Config Read()
        {
            return new Config
            {
                Host = "mocked-config"
            };

            var configPath = System.IO.Directory.GetCurrentDirectory() + @"\config.json"; // azure functions
            
            var json = System.IO.File.ReadAllText(configPath);

            var config = JsonConvert.DeserializeObject<Config>(json);

            return config;
        }
    }
}
