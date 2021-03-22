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

            foreach (var interfaces in Json.Parents)
            {
                CreateFile(interfaces, "RS" + interfaces.Clazz);
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
                    file.WriteLine($"public interface {name} extends {FindInterface(parent.SuperClass.Split('.').Last())} {{");
                }
                else
                {
                    file.WriteLine($"public interface {name} {{");
                }

                if (parent.Clazz.Equals("Client"))
                {
                    AddExtraClientFields(file);
                    file.WriteLine("");
                } 
                else if (parent.Clazz.Equals("Scene"))
                {
                    AddExtraSceneFields(file);
                    file.WriteLine("");
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

        private void AddExtraClientFields(StreamWriter file)
        {
            string whiteSpace = "    ";
            file.WriteLine(whiteSpace + "Thread getGameThread();");
            file.WriteLine(whiteSpace + "int getMouseX();");
            file.WriteLine(whiteSpace + "int getMouseY();");
            file.WriteLine(whiteSpace + "void sendKeyEventPressed(KeyEvent keyEvent);");
            file.WriteLine(whiteSpace + "void sendKeyEventTyped(KeyEvent keyEvent);");
            file.WriteLine(whiteSpace + "void sendKeyEventReleased(KeyEvent keyEvent);");
            file.WriteLine(whiteSpace + "void sendMouseEventPressed(MouseEvent mouseEvent);");
            file.WriteLine(whiteSpace + "void sendMouseEventReleased(MouseEvent mouseEvent);");
            file.WriteLine(whiteSpace + "void sendMouseEventMoved(MouseEvent mouseEvent);");
            file.WriteLine(whiteSpace + "void setAction(RSMenuAction menuAction);");
            file.WriteLine(whiteSpace + "void setDisableAll(boolean bool);");
            file.WriteLine(whiteSpace + "RSInventory getItemContainer(long tableID);");
            file.WriteLine(whiteSpace + "int getVarbit(int index);");
            file.WriteLine(whiteSpace + "void login(String username, String password);");
            file.WriteLine(whiteSpace + "void setWorld(int id);");
            file.WriteLine(whiteSpace + "boolean loadWorlds();");
            file.WriteLine(whiteSpace + "void setWorldSelect(boolean bool);");
            file.WriteLine(whiteSpace + "boolean getWorldSelect();");
            file.WriteLine(whiteSpace + "void addMessage(int type, String sender, String text, String prefix);");
            file.WriteLine(whiteSpace + "void doAction(int secondary, int tertiary, int opcode, int primary, String menuOption, String menuTarget, int mouseX, int mouseY, int trash);");
            file.WriteLine(whiteSpace + "RSObjType getItemDefinition(int itemID);");
            file.WriteLine(whiteSpace + "RSComponent getMeSlayerContinueWidget();");
            file.WriteLine(whiteSpace + "void setScene_selectedX(int x);");
            file.WriteLine(whiteSpace + "void setScene_selectedY(int y);");
            file.WriteLine(whiteSpace + "void setViewportWalking();");
        }

        private void AddExtraSceneFields(StreamWriter file)
        {
            string whiteSpace = "    ";
            file.WriteLine(whiteSpace + "void setDestinationX(int var1);");
            file.WriteLine(whiteSpace + "void setDestinationY(int var1);");
            file.WriteLine(whiteSpace + "void setWalking();");
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
