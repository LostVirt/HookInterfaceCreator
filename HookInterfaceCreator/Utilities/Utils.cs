using HookInterfaceCreator.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Utilities
{
    class Utils
    {

        public static string CleanType(string descriptor) => StripDescriptorType(StripArray(descriptor));

        public static bool IsBaseType(string descriptor)
        {
            return CleanType(descriptor) switch
            {
                ("C") or ("B") or ("S") or ("Z") or ("D") or ("J") or ("I") or ("F") or ("java/lang/String") => true,
                _ => false,
            };
        }

        public static string GetType(string descriptor)
        {
            return descriptor switch
            {
                ("C") => "Character",
                ("B") => "Byte",
                ("S") => "Short",
                ("Z") => "Boolean",
                ("D") => "Double",
                ("J") => "Long",
                ("I") => "Integer",
                ("F") => "Float",
                ("java/lang/String") => "String",
                _ => descriptor.Split("/").Last(),
            };
        }

        public static string GetJavaType(string descriptor)
        {
            return descriptor switch
            {
                ("C") => "char",
                ("B") => "byte",
                ("S") => "short",
                ("Z") => "boolean",
                ("D") => "double",
                ("J") => "long",
                ("I") => "int",
                ("F") => "float",
                ("java/lang/String") => "String",
                _ => descriptor.Split("/").Last(),
            };
        }

        public static string GetJavaArrayString(int count, string type) => $"{type}".Add("[]", count);

        public static string StripDescriptorType(string descriptor)
        {
            if (!descriptor.Contains(";")) return descriptor;

            descriptor = descriptor.Substring(1);
            return descriptor.Substring(0, descriptor.Length - 1);
        }

        public static string StripArray(string descriptor)
        {
            int count = descriptor.Count(c => c == '[');
            return count > 0 ? descriptor.Substring(count) : descriptor;
        }
    }
}
