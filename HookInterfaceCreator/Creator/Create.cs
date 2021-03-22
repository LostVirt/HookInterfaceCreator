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
                else if (parent.Clazz.Equals("NodeDeque"))
                {
                    AddExtraNodeDequeFields(file);
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
                            file.WriteLine(InlineWhiteSpace(1) + $"{Utils.GetJavaArrayString(arrayCount, FindInterface(returnType))} get{field.Field.FirstCharToUpper()}();");
                        }
                        else
                        {
                            file.WriteLine(InlineWhiteSpace(1) + $"{Utils.GetJavaArrayString(arrayCount, returnType)} get{field.Field.FirstCharToUpper()}();");
                        }
                    }
                }
                

                file.WriteLine("}");
            }
            Console.WriteLine($"Done Creating Interface: {name}");
        }

        private void AddExtraClientFields(StreamWriter file)
        {
            file.WriteLine(InlineWhiteSpace(1) + "Thread getGameThread();");
            file.WriteLine(InlineWhiteSpace(1) + "int getMouseX();");
            file.WriteLine(InlineWhiteSpace(1) + "int getMouseY();");
            file.WriteLine(InlineWhiteSpace(1) + "void sendKeyEventPressed(KeyEvent keyEvent);");
            file.WriteLine(InlineWhiteSpace(1) + "void sendKeyEventTyped(KeyEvent keyEvent);");
            file.WriteLine(InlineWhiteSpace(1) + "void sendKeyEventReleased(KeyEvent keyEvent);");
            file.WriteLine(InlineWhiteSpace(1) + "void sendMouseEventPressed(MouseEvent mouseEvent);");
            file.WriteLine(InlineWhiteSpace(1) + "void sendMouseEventReleased(MouseEvent mouseEvent);");
            file.WriteLine(InlineWhiteSpace(1) + "void sendMouseEventMoved(MouseEvent mouseEvent);");
            file.WriteLine(InlineWhiteSpace(1) + "void setAction(RSMenuAction menuAction);");
            file.WriteLine(InlineWhiteSpace(1) + "void setDisableAll(boolean bool);");
            file.WriteLine(InlineWhiteSpace(1) + "RSInventory getItemContainer(long tableID);");
            file.WriteLine(InlineWhiteSpace(1) + "int getVarbit(int index);");
            file.WriteLine(InlineWhiteSpace(1) + "void login(String username, String password);");
            file.WriteLine(InlineWhiteSpace(1) + "void setWorld(int id);");
            file.WriteLine(InlineWhiteSpace(1) + "boolean loadWorlds();");
            file.WriteLine(InlineWhiteSpace(1) + "void setWorldSelect(boolean bool);");
            file.WriteLine(InlineWhiteSpace(1) + "boolean getWorldSelect();");
            file.WriteLine(InlineWhiteSpace(1) + "void addMessage(int type, String sender, String text, String prefix);");
            file.WriteLine(InlineWhiteSpace(1) + "void doAction(int secondary, int tertiary, int opcode, int primary, String menuOption, String menuTarget, int mouseX, int mouseY, int trash);");
            file.WriteLine(InlineWhiteSpace(1) + "RSObjType getItemDefinition(int itemID);");
            file.WriteLine(InlineWhiteSpace(1) + "RSComponent getMeSlayerContinueWidget();");
            file.WriteLine(InlineWhiteSpace(1) + "void setScene_selectedX(int x);");
            file.WriteLine(InlineWhiteSpace(1) + "void setScene_selectedY(int y);");
            file.WriteLine(InlineWhiteSpace(1) + "void setViewportWalking();");
        }

        private void AddExtraSceneFields(StreamWriter file)
        {
            file.WriteLine(InlineWhiteSpace(1) + "void setDestinationX(int var1);");
            file.WriteLine(InlineWhiteSpace(1) + "void setDestinationY(int var1);");
            file.WriteLine(InlineWhiteSpace(1) + "void setWalking();");
        }

        private void AddExtraNodeDequeFields(StreamWriter file)
        {
            file.WriteLine(InlineWhiteSpace(1) + "default RSNode[] getNodes() {");
            file.WriteLine(InlineWhiteSpace(2) + "ArrayList<RSNode> list = new ArrayList();");
            file.WriteLine(InlineWhiteSpace(2) + "RSNode iter = this.getSentinel();");
            file.WriteLine(InlineWhiteSpace(2) + "while(true) {");
            file.WriteLine(InlineWhiteSpace(3) + "RSNode previous = iter.getPrevious();");
            file.WriteLine(InlineWhiteSpace(3) + "if (previous == this.getSentinel()) {");
            file.WriteLine(InlineWhiteSpace(4) + "return (RSNode[])list.toArray(new RSNode[0]);");
            file.WriteLine(InlineWhiteSpace(3) + "}");
            file.WriteLine(InlineWhiteSpace(3) + "iter = previous;");
            file.WriteLine(InlineWhiteSpace(3) + "list.add(previous);");
            file.WriteLine(InlineWhiteSpace(2) + "}");
            file.WriteLine(InlineWhiteSpace(1) + "}");
        }

        private string InlineWhiteSpace(int count)
        {
            return new String(' ', 4 * count);
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
