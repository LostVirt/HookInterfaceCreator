using HookInterfaceCreator.Deserialization;
using HookInterfaceCreator.Deserialization.Children;
using HookInterfaceCreator.Extensions;
using HookInterfaceCreator.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
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
        private DirectoryInfo Directory;

        public Create(string path, string package, JsonParser json)
        {
            Path = path;
            Package = package;
            Json = json;
            Directory = new DirectoryInfo(Path);
        }

        public void Execute()
        {
            DeleteFiles();

            int i = 0;
            foreach (var interfaces in Json.Parents)
            {
                CreateFile(interfaces, "RS" + interfaces.Clazz);
                //if (i >= ) break;
                //i++;
            }
        }

        private void CreateFile(Parent parent, string name)
        {
            Console.WriteLine($"Creating Interface: {name}");
            using (StreamWriter file = File.AppendText(Path + name + ".java"))
            {
                file.WriteLine($"package {Package};");
                file.WriteLine("");
                file.WriteLine("");

                if (!parent.SuperClass.Equals("java.lang.Object"))
                {
                    file.WriteLine($"public interface {name} extends {parent.SuperClass.Split('.').Last()} {{");
                }
                else
                {
                    file.WriteLine($"public interface {name} {{");
                }

                if (parent.Fields != null)
                {
                    foreach (Fields field in parent.Fields)
                    {
                        string descriptor = field.Descriptor;
                        int arrayCount = descriptor.Count(c => c == '[');

                        descriptor = Utils.StripArray(descriptor);

                        descriptor = Utils.StripDescriptorType(descriptor);

                        string returnType = Utils.GetJavaType(descriptor);

                        if (!Utils.IsBaseType(descriptor))
                        {
                            file.WriteLine($"    {Utils.GetJavaArrayString(arrayCount, FindInterface(returnType))} get{field.Field.FirstCharToUpper()}();");
                        }
                        else
                        {
                            file.WriteLine($"    {Utils.GetJavaArrayString(arrayCount, returnType)} get{field.Field.FirstCharToUpper()}();");
                        }
                    }
                }
                

                file.WriteLine("}");
            }
            Console.WriteLine($"Done Creating Interface: {name}");
        }

        private void DeleteFiles()
        {
            Console.WriteLine("Deleting Files:");
            foreach (FileInfo file in Directory.GetFiles())
            {
                Console.WriteLine($"Deleting File: {file.FullName}");
                file.Delete();
            }
            Console.WriteLine("Done Deleting Files.");
        }

        private string FindInterface(string returnType)
        {
            foreach (Parent parent in Json.Parents)
            {
                if (parent.Name.Equals(returnType))
                {
                    return "RS" + parent.Clazz;
                }
            }

            return returnType;
        }

    }
}
