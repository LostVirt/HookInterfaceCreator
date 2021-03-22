using HookInterfaceCreator.Deserialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Creator
{
    class Create
    {
        private readonly string Path;
        private readonly string Package;
        private readonly JsonParser Json;

        public Create(string path, string package, JsonParser json)
        {
            Path = path;
            Package = package;
            Json = json;
        }

        public void Execute()
        {
            
        }
        private void CreateFile(string name)
        {

        }

    }
}
