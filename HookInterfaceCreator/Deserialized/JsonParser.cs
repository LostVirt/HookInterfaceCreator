using HookInterfaceCreator.Deserialized.Children;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Deserialized
{
    class JsonParser
    {
        public readonly List<Parent> Parents = new List<Parent>();
        public JsonParser(string path)
        {
            JArray jsonArray = JArray.Parse(File.ReadAllText(path));

            Parents = jsonArray.Children().Select(parent => new Parent
            {
                Clazz = (string)parent["clazz"],
                Name = (string)parent["name"],
                SuperClass = (string)parent["superClass"],
                Access = (int)parent["access"],
                Interfaces = JsonConvert.DeserializeObject<List<string>>(parent["interfaces"] != null ? parent["interfaces"].ToString() : "[]"),
                Fields = parent["fields"].Select(field => new Fields
                {
                    Field = (string)field["field"],
                    Owner = (string)field["owner"],
                    Name = (string)field["name"],
                    Access = (int)field["access"],
                    Descriptor = (string)field["descriptor"],
                    Decoder = (long)(field["decoder"] ?? 0)
                }).ToList(),
                Methods = parent["methods"].Select(method => new Methods
                {
                    Method = (string)method["method"],
                    Owner = (string)method["owner"],
                    Name = (string)method["name"],
                    Parameters = JsonConvert.DeserializeObject<List<string>>(method["parameters"] != null ? method["parameters"].ToString() : "[]"),
                    Access = (int)method["access"],
                    Descriptor = (string)method["descriptor"],
                    FinalArgument = (long)(method["finalArgument"] ?? 0)
                }).ToList(),
                Constructor = parent["constructors"].ToString() == "[]" ? null : new Constructor
                {
                    Access = (int)parent["constructors"].First()["access"],
                    Descriptor = (string)parent["constructors"].First()["descriptor"]
                }

            }).ToList();
        }
    }
}
