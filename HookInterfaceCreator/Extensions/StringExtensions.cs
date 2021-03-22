using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookInterfaceCreator.Extensions
{
    public static class StringExtensions
    {
        public static string Add(this String str, string text, int count)
        {
            for (int i = 0; i < count; i++)
            {
                str += text;
            }
            return str;
        }
    }
}
