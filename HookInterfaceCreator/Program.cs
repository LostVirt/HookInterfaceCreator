using HookInterfaceCreator.Deserialized;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Collections.Specialized;

namespace HookInterfaceCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParser ParsedJson = new JsonParser(ConfigurationManager.AppSettings.Get("JsonPath"));


            
        }
    }
}
