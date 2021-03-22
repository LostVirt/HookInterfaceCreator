using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Deserialized.Children
{
    class Methods
    {
        public string Method { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public int Access { get; set; }
        public List<string> Parameters { get; set; }
        public string Descriptor { get; set; }
        public long FinalArgument { get; set; }

        public override string ToString()
        {
            var parameters = "";
            int totalCount = Parameters != null ? Parameters.Count : 0;
            for (int count = 0; count < totalCount; count++)
            {
                if ((count + 1) == totalCount)
                {
                    parameters += ($"\"{Parameters[count]}\"");
                }
                else
                {
                    parameters += ($"\"{Parameters[count]},\"\n");
                }
            }

            return $"    method: \"{Method}\"\n    owner: \"{Owner}\"\n    name: \"{Name}\"\n    access: \"{Access}\"\n    parameters: [\n{parameters}\n    ]\n    descriptor: \"{Descriptor}\"\n    finalArgument: \"{FinalArgument}\"";
        }
    }
}
