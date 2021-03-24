using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StardewModdingAPI;
using StardewValley;
using Streamvalley.Console.Models;

namespace Streamvalley.Console
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
            => new ModEntry().StartAsync().GetAwaiter().GetResult();

        public async Task StartAsync()
        {
            new Config();
            var payloads = GetPayloads();
            RegisterPayloads(payloads);

        }

        public IList<MethodInfo> GetPayloads()
        {
            List<MethodInfo> payloads = new List<MethodInfo>();

            var payloadsDir = new DirectoryInfo(Path.Combine(Config.ConfigFolder, Config.PayloadFolder));
            var payloadProjects = payloadsDir.GetFiles("*.dll", SearchOption.AllDirectories);

            foreach (var payloadProject in payloadProjects)
            {
                var assembly = Assembly.LoadFile(payloadProject.FullName);
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    payloads.AddRange(type.GetMethods().Where(m => m.Name.EndsWith("Payload")).ToArray());
                }
            }
            return payloads;
        }

        public void RegisterPayloads(IList<MethodInfo> payloads)
        {

        }

    }
}