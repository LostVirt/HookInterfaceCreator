using HookInterfaceCreator.Deserialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using HookInterfaceCreator.Creator;
using System.Collections.Specialized;

namespace HookInterfaceCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection config = ConfigurationManager.AppSettings;

            JsonParser ParsedJson = new JsonParser(config.Get("JsonPath"));

            Create create = new Create(config.Get("Output"), config.Get("Package"), ParsedJson);

            create.Execute();
        }
    }
}
