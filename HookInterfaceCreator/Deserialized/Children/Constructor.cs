using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Deserialized.Children
{
    class Constructor
    {
        public int Access { get; set; }
        public string Descriptor { get; set; }

        public override string ToString()
        {
            return $"\naccess: {Access}\ndescriptor: {Descriptor}\n";
        }
    }
}
