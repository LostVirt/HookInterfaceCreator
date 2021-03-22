using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace HookInterfaceCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject jsonInterfaces = JObject.Parse(File.ReadAllText(@"c:\videogames.json"));

            
        }
    }
}
