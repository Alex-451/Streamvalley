using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using StardewModdingAPI;
using Streamvalley.Console.Models;

namespace Streamvalley.Console
{
    public class Config
    {
        public const string ConfigFolder = "streamvalley-resources";
        public const string PayloadFolder = "Payloads";
        public const string ConfigFile = "config.json";

        public static Payload Mod;

        static Config()
        {
            if (!Directory.Exists(ConfigFolder)) Directory.CreateDirectory(ConfigFolder);
            if (!Directory.Exists(Path.Combine(ConfigFolder, PayloadFolder))) Directory.CreateDirectory(Path.Combine(ConfigFolder, PayloadFolder));

            if (!File.Exists(Path.Combine(ConfigFolder, ConfigFile)))
            {
                File.Create(Path.Combine(ConfigFolder, ConfigFile));
            }
            else
            {
                string json = File.ReadAllText(Path.Combine(ConfigFolder, ConfigFile));
                Mod = JsonConvert.DeserializeObject<Payload>(json);
            }
        }
    }

}