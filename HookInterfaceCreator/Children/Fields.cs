using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Children
{
    class Fields
    {
        public string Field { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public int Access { get; set; }
        public string Descriptor { get; set; }
        public long Decoder { get; set; }

        public override string ToString()
        {
            return $"    field: \"{Field}\"\n    owner: \"{Owner}\"\n    name: \"{Name}\"\n    access: \"{Access}\"\n    descriptor: \"{Descriptor}\"\n    decoder: \"{Decoder}\"";
        }
    }
}
