using HookInterfaceCreator.Deserialization.Children;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Deserialization
{
    class Parent
    {
        // Json Parent
        public string Clazz { get; set; }
        public string Name { get; set; }
        public string SuperClass { get; set; }
        public int Access { get; set; }
        public List<string> Interfaces { get; set; }
        public List<Fields> Fields { get; set; }
        public List<Methods> Methods { get; set; }
        public Constructor Constructor { get; set; }


        public void Print()
        {
            Console.WriteLine($"clazz: \"{Clazz}\",");
            Console.WriteLine($"name: \"{Name}\",");
            Console.WriteLine($"superClass: \"{SuperClass}\",");
            Console.WriteLine($"access: {Access},");
            Console.WriteLine($"interfaces: [{Interfaces}],");
            Console.WriteLine("fields: [");
            if (Fields != null) 
            {
                foreach (var field in Fields)
                {
                    Console.WriteLine($"{{\n{field}\n}}");
                }
            }
            
            Console.WriteLine("],");
            Console.WriteLine("methods: [");
            if (Methods != null) 
            {
                foreach (var method in Methods)
                {
                    Console.WriteLine($"{{\n{method}\n}},");
                }
            }
            
            Console.WriteLine("],");
            Console.WriteLine($"constructor: [{Constructor}]");
        }
    }
}
