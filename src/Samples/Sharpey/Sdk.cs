using Sharpey.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Sharpey
{
    public class Sdk : Collection
    {
        public Sdk()
        {
            ConsoleStart();
            InitIni();
        }

        public void Execute()
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                string path = ini.Path + "/" + sdk.GetAssemblyParseName(assembly);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                foreach (Type type in assembly.GetTypes())
                {
                    AddPhpTypeInfo(type);
                    MembersIterators(type);
                    BaseTypeIterators(type);
                    if (new Regex("[\\`\\<\\>\\|\\=]+").Matches(type.Name).Count > 0)
                    {
                        PhpScriptElementCollection.Clear();
                    }
                    else
                    {
                        PhpScriptCommentsCollection.Add("*/");
                        MakeFile(path + "\\" + type.Name + ".php");
                    }
                }
            }
        }

        private void ConsoleStart() => Console.WriteLine("[SDK] started...");

        private void MembersIterators(Type type)
        {
            foreach (FieldInfo field in type.GetFields(_flags))
                AddPhpFieldInfo(type, field);
            foreach (PropertyInfo property in type.GetProperties(_flags))
                AddPhpPropertyInfo(type, property);
            foreach (MethodInfo method in type.GetMethods(_flags))
                AddPhpMethodInfo(type, method);
            foreach (EventInfo events in type.GetEvents(_flags))
                AddPhpEventInfo(type, events, true);
        }

        private void BaseTypeIterators(Type type)
        {
            Type baseType = type.BaseType;
            int num1;
            if ((object)baseType == null)
            {
                num1 = 0;
            }
            else
            {
                int num2 = baseType.IsGenericType ? 1 : 0;
                num1 = 1;
            }

            if (num1 == 0)
                return;
            foreach (Type genericTypeArgument in type.BaseType.GenericTypeArguments)
            {
                AddPhpUsesInfo(genericTypeArgument.Namespace, genericTypeArgument.Name);
                foreach (FieldInfo field in genericTypeArgument.GetFields(_flags))
                    AddPhpFieldInfo(type, field, true);
                foreach (PropertyInfo property in genericTypeArgument.GetProperties(_flags))
                    AddPhpPropertyInfo(type, property, true);
                foreach (MethodInfo method in genericTypeArgument.GetMethods(_flags))
                    AddPhpMethodInfo(genericTypeArgument, method, true);
                foreach (EventInfo events in genericTypeArgument.GetEvents(_flags))
                    AddPhpEventInfo(genericTypeArgument, events, true);
            }
        }

        private void MakeFile(string filePath)
        {
            RemoveFullNameOriginal();

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                List<string>[] main =
                {
                    PhpScriptCollection,
                    PhpUsesCollection,
                    PhpScriptCommentsCollection,
                    PhpScriptElementCollection
                };
                List<string>[] slave =
                {
                    PhpFieldsCollection,
                    PhpPropertiesCollection,
                    PhpMethodsCollection,
                    PhpEventsCollection
                };
                foreach (var source in main.ToList())
                {
                    foreach (string str in source.Distinct().ToList())
                        streamWriter.WriteLine(str);
                    source.Clear();
                }

                foreach (var source in slave.ToList())
                {
                    foreach (string str in source.ToList())
                        streamWriter.WriteLine(str);
                    source.Clear();
                }

                PhpMembers.Clear();
                PhpPropertiesMethodsCollection.Clear();
                streamWriter.WriteLine("}");
                streamWriter.Close();
            }
        }

        private void RemoveFullNameOriginal()
        {
            List<string> phpUsesCollection = PhpUsesCollection;
            DefaultInterpolatedStringHandler str = new DefaultInterpolatedStringHandler(6, 2);
            str.AppendLiteral("use ");
            str.AppendFormatted(sdk.NamespaceTemplate);
            str.AppendLiteral("\\");
            str.AppendFormatted(sdk.NameTemplate);
            str.AppendLiteral(";");
            string stringAndClear = str.ToStringAndClear();
            phpUsesCollection.Remove(stringAndClear);
        }

        private void InitIni()
        {
            sdk.PathLevel = 6;
            ini.Path = sdk.GetParentPath(Root).FullName + "/" + SdkDir;
            if (ini.IsFind()) ;
        }
    }
}