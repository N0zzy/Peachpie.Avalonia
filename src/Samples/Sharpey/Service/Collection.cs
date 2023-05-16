using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Sharpey.Service
{
    public abstract class Collection
    {
        public const string VERSION = "0.1.0";
        protected static readonly string Root = Directory.GetCurrentDirectory();
        protected Helper sdk = new Helper();
        protected Ini ini = new Ini();
        protected List<string> PhpScriptCollection = new List<string>();
        protected List<string> PhpScriptElementCollection = new List<string>();
        protected List<string> PhpScriptCommentsCollection = new List<string>();
        protected List<string> PhpUsesCollection = new List<string>();
        protected List<string> PhpFieldsCollection = new List<string>();
        protected List<string> PhpPropertiesCollection = new List<string>();
        protected List<string> PhpPropertiesMethodsCollection = new List<string>();
        protected List<string> PhpMethodsCollection = new List<string>();
        protected List<string> PhpEventsCollection = new List<string>();
        protected List<string> PhpMembers = new List<string>();
        protected string TypeName = "class";

        protected BindingFlags _flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                                        BindingFlags.NonPublic;

        protected string SdkDir { get; } = "SharpeySDK";

        protected void AddPhpTypeInfo(Type type)
        {
            if (sdk.IsPhpErrorName(string.IsNullOrEmpty(type.Namespace) ? "" : type.Namespace))
                return;
            PhpSetTypeName(type);
            sdk.NameTemplate = type.Name;
            sdk.NamespaceTemplate = type.Namespace?.Replace('.', '\\');
            sdk.ExtendsTemplate = sdk.GetExtendsClass(PhpUsesCollection, type, type.Name);
            PhpScriptCollection.Add("<?php");
            PhpScriptCommentsCollection.Add("/**");
            if (!string.IsNullOrEmpty(sdk.ExtendsTemplate))
            {
                if (IsEnum())
                {
                    PhpScriptCommentsCollection.Add(" * @extends \\" + sdk.NamespaceTemplate + "\\" +
                                                    sdk.ExtendsTemplate);
                    sdk.ExtendsTemplate = "";
                }
                else
                    sdk.ExtendsTemplate = " extends " + sdk.ExtendsTemplate + " ";
            }

            string str1 = "";
            List<string> stringList = new List<string>();
            foreach (Type type1 in type.GetInterfaces())
            {
                str1 = sdk.ReplaceDotToSlash(type1.Namespace + "." + type1.Name, true);
                if (str1 == sdk.NamespaceTemplate + "\\" + sdk.NameTemplate)
                    str1 = "";
                else
                    stringList.Add(str1);
            }

            if (stringList.Count > 0)
            {
                if (IsClass())
                {
                    str1 = " \n\timplements \n\t\t\\" + string.Join(",\n\t\t\\", (IEnumerable<string>)stringList) +
                           "\n";
                }
                else
                {
                    str1 = "";
                    foreach (string str2 in stringList.ToList<string>())
                        PhpScriptCommentsCollection.Add(" * @implements \\" + str2);
                }
            }

            stringList.Clear();
            if (!string.IsNullOrEmpty(sdk.NamespaceTemplate))
                PhpScriptCollection.Add("namespace " + sdk.NamespaceTemplate + ";\n");
            PhpScriptElementCollection.Add((!IsClass() || !type.IsAbstract ? "" : "abstract ") + TypeName + " " +
                                           sdk.NameTemplate + sdk.ExtendsTemplate + str1 + "{");
        }

        protected void AddPhpUsesInfo(string space, string name)
        {
            if (name == "T")
                return;
            PhpUsesCollection.Add("use " + sdk.ReplaceDotToSlash(sdk.PhpClassParse(space + "." + name)) + ";");
        }

        protected void AddPhpFieldInfo(Type type, FieldInfo field, bool isGeneric = false)
        {
            if (sdk.IsElementExists(PhpMembers, field.Name) || sdk.IsPhpErrorName(field.Name))
                return;
            PhpMembers.Add(field.Name);
            if (field.IsPrivate || field.IsAssembly || field.IsFamilyAndAssembly)
                return;
            string str1 = "" + (field.IsPublic ? "\tpublic " : "\tprotected ") + (field.IsStatic ? "static " : "");
            string str2;
            if (field.IsLiteral && !field.IsInitOnly)
            {
                if (IsClass())
                    str2 = "\tconst " + field.Name + " = '" + field.Name + "';";
                else
                    str2 = !IsEnum() ? "" : "\tcase " + field.Name + ";";
            }
            else
                str2 = str1 + "$" + field.Name + ";";

            string stringTypes = sdk.PhpExtractStringTypes(field.FieldType.ToString(), PhpUsesCollection);
            if (!IsEnum())
            {
                PhpFieldsCollection.Add("\t/**");
                if (isGeneric)
                {
                    PhpFieldsCollection.Add("\t * field generic");
                    PhpFieldsCollection.Add("\t * @generic");
                }

                PhpFieldsCollection.Add("\t * @field");
                if (field.IsInitOnly)
                    PhpFieldsCollection.Add("\t * @readonly");
                if (sdk.IsFieldHidden(field))
                {
                    PhpFieldsCollection.Add("\t * @deprecated this is a hidden property and may not be available.");
                    PhpFieldsCollection.Add("\t * @hidden ");
                }

                PhpFieldsCollection.Add("\t * @provider " + type.Name);
                PhpFieldsCollection.Add("\t * @var " + stringTypes);
                PhpFieldsCollection.Add("\t*/");
            }
            else if (!sdk.IsFieldHidden(field))
            {
                PhpScriptCommentsCollection.Add(" * @property " + stringTypes + " $" + field.Name);
                return;
            }

            PhpFieldsCollection.Add(str2);
        }

        protected void AddPhpPropertyInfo(Type type, PropertyInfo property, bool isGeneric = false)
        {
            if (sdk.IsElementExists(PhpMembers, property.Name) || sdk.IsPhpErrorName(property.Name))
                return;
            string str1 = "";
            string str2;
            try
            {
                MethodInfo methodInfo = property.GetGetMethod();
                if (methodInfo == (MethodInfo)null)
                    methodInfo = property.GetSetMethod();
                if (methodInfo.IsPrivate || methodInfo.IsAssembly || methodInfo.IsFamilyAndAssembly)
                    return;
                str2 = methodInfo.IsPublic ? "public " : "protected ";
                str1 = methodInfo.IsStatic ? "static " : "";
            }
            catch (Exception ex)
            {
                str2 = "protected ";
            }

            PhpMembers.Add(property.Name);
            string stringTypes = sdk.PhpExtractStringTypes(property.PropertyType.ToString(), PhpUsesCollection);
            if (!IsClass())
            {
                DefaultInterpolatedStringHandler
                    interpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 3);
                interpolatedStringHandler.AppendLiteral(" * @property ");
                interpolatedStringHandler.AppendFormatted(str1);
                interpolatedStringHandler.AppendFormatted(stringTypes);
                interpolatedStringHandler.AppendLiteral(" $");
                interpolatedStringHandler.AppendFormatted(property.Name);
                PhpScriptCommentsCollection.Add(interpolatedStringHandler.ToStringAndClear());
            }
            else
            {
                PhpPropertiesCollection.Add("\t/**");
                if (isGeneric)
                {
                    PhpPropertiesCollection.Add("\t * property generic");
                    PhpPropertiesCollection.Add("\t * @generic");
                }

                PhpPropertiesCollection.Add("\t * @provider " + type.Name);
                PhpPropertiesCollection.Add("\t * @property");
                if (!property.CanRead && !property.CanWrite)
                {
                    PhpPropertiesCollection.Add("\t * @hidden");
                    PhpPropertiesCollection.Add("\t * @deprecated");
                }

                if (property.CanRead && !property.CanWrite)
                    PhpPropertiesCollection.Add("\t * @readonly");
                foreach (MemberInfo memberInfo in
                         ((IEnumerable<MethodInfo>)property.GetAccessors()).ToList<MethodInfo>())
                    PhpPropertiesCollection.Add("\t * @method " + memberInfo.Name + "()");
                PhpPropertiesCollection.Add("\t * @var " + stringTypes);
                PhpPropertiesCollection.Add("\t */");
                PhpPropertiesCollection.Add("\t" + str2 + str1 + "$" + property.Name + ";");
            }
        }

        protected void AddPhpMethodInfo(Type type, MethodInfo method, bool isGeneric = false)
        {
            if (sdk.IsElementExists(PhpMembers, method.Name) || sdk.IsPhpErrorName(method.Name) || method.IsPrivate ||
                method.IsAssembly || method.IsFamilyAndAssembly)
                return;
            PhpMembers.Add(method.Name);
            string str1 = "";
            if (IsEnum())
            {
                string str2 = AddPhpArguments(method, false);
                PhpScriptCommentsCollection.Add(str1 + " * @method " +
                                                sdk.PhpExtractStringTypes(method.ReturnType.ToString(),
                                                    PhpUsesCollection) + " " + method.Name + "(" + str2 + ")" +
                                                (method.IsPublic ? " <b>public</b>" : " <b>protected</b>") +
                                                (method.IsStatic ? " <b>static</b>" : ""));
            }
            else
            {
                PhpMethodsCollection.Add("\t/**");
                if (isGeneric)
                {
                    PhpMethodsCollection.Add("\t * method generic");
                    PhpMethodsCollection.Add("\t * @generic");
                }

                string str3 = !IsClass() || method.IsAbstract ? ";" : "{}";
                string str4 = AddPhpArguments(method, true);
                string str5 = str1 + (method.IsPublic ? "\tpublic " : "\tprotected ") +
                              (IsInterface() || !method.IsAbstract ? "" : "abstract ") +
                              (method.IsStatic ? "static " : "") + "function " + method.Name + "(" + str4 + ")" + str3;
                PhpMethodsCollection.Add("\t * @provider " + type.Name);
                if (type.Name == "T")
                    PhpMethodsCollection.Add("\t * @deprecated");
                PhpMethodsCollection.Add("\t * @return " +
                                         sdk.PhpExtractStringTypes(method.ReturnType.ToString(), PhpUsesCollection));
                PhpMethodsCollection.Add("\t */");
                PhpMethodsCollection.Add(str5);
            }
        }

        protected void AddPhpEventInfo(Type type, EventInfo events, bool isGeneric = false)
        {
            if (sdk.IsElementExists(PhpMembers, events.Name)) return;

            PhpMembers.Add(events.Name);
            string str1 = "";
            if (IsEnum())
            {
                PhpScriptCommentsCollection.Add(str1 + " * @method " + " " + events.Name + "()");
            }
            else
            {
                string str2 = IsClass() ? "{}" : ";";
                string str3 = str1 + "\tpublic function " + events.Name + "()" + str2;
                PhpEventsCollection.Add("\t/**");
                if (isGeneric)
                {
                    PhpEventsCollection.Add("\t * event generic");
                    PhpEventsCollection.Add("\t * @generic");
                }

                PhpEventsCollection.Add("\t * @provider " + type.Name);
                PhpEventsCollection.Add("\t * @warning event does not exist in php");

                if (type.Name == "T") PhpEventsCollection.Add("\t * @deprecated");

                PhpEventsCollection.Add("\t * @return void");
                PhpEventsCollection.Add("\t */");
                PhpEventsCollection.Add(str3);
            }
        }

        private void PhpSetTypeName(Type type)
        {
            TypeName = "class";
            if (type.IsEnum)
            {
                TypeName = "enum";
            }
            else
            {
                if (!type.IsInterface)
                    return;
                TypeName = "interface";
            }
        }

        private string AddPhpArguments(MethodInfo method, bool isComments)
        {
            List<string> values = new List<string>();
            foreach (ParameterInfo parameter in method.GetParameters())
            {
                string stringTypes = sdk.PhpExtractStringTypes(parameter.ParameterType.ToString(), PhpUsesCollection);
                if (isComments)
                {
                    PhpMethodsCollection.Add("\t * @param " + stringTypes + " $" + parameter.Name);
                    values.Add("$" + parameter.Name);
                }
                else
                    values.Add(stringTypes + " $" + parameter.Name);
            }

            return string.Join(", ", values);
        }

        private bool IsClass() => TypeName == "class";

        private bool IsEnum() => TypeName == "enum";

        private bool IsInterface() => TypeName == "interface";

        protected class Helper
        {
            public int PathLevel = 6;

            public string NamespaceTemplate { get; set; } = "";

            public string NameTemplate { get; set; } = "";

            public string ExtendsTemplate { get; set; } = "";

            public string GetAssemblyParseName(Assembly assem) => ReplaceDotToSlash(assem.GetName().Name);

            public DirectoryInfo GetParentPath(string path)
            {
                DirectoryInfo parentPath = new DirectoryInfo(path);
                for (int index = 0; index < PathLevel; ++index)
                    parentPath = parentPath?.Parent;
                return parentPath;
            }

            public bool IsFieldHidden(FieldInfo field)
            {
                try
                {
                    return new Regex(field.GetValue((object)null)?.ToString() ?? "").Match(field.Name).Length > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            public string GetExtendsClass(List<string> collection, Type type, string start, string end = null)
            {
                if (type.BaseType == (Type)null)
                    return end;
                end = PhpClassParse(type.BaseType.Name);
                ExtractAndAddFullName(type.BaseType, collection, end);
                return start != end ? end : GetExtendsClass(collection, type.BaseType, start, end);
            }

            public void ExtractAndAddFullName(Type type, List<string> collection, string name)
            {
                string str = PhpClassParse(ReplaceDotToSlash(PhpClassParse(type.Namespace)) + "\\" + name);
                if (str.Split("\\").Length <= 1)
                    return;
                collection.Add("use " + str + ";");
            }

            public bool IsElementExists(List<string> collection, string name) => collection.IndexOf(name, 0) != -1;

            public string PhpClassParse(string value) => value == null ? "" : Regex.Replace(value, "[\\`\\+\\<].+", "");

            public string ReplaceDotToSlash(string str, bool isParse = false) =>
                !isParse ? str.Replace('.', '\\') : PhpClassParse(str.Replace('.', '\\'));

            public string PhpExtractStringTypes(string str, List<string> collection)
            {
                MatchCollection matchCollection =
                    new Regex("[_a-z][a-z0-9\\\\._]+", RegexOptions.IgnoreCase).Matches(str);
                List<string> values = new List<string>();
                string __str = "";
                string __last = "";
                foreach (Match match in matchCollection)
                {
                    __str = ReplaceDotToSlash(PhpClassParse(match.Value));
                    __last = __str.Split("\\").Last();
                    if (collection.FindAll((Predicate<string>)(i =>
                            Regex.IsMatch(i, __last + ";$", RegexOptions.IgnoreCase))).ToList<string>().Count == 0 &&
                        __str.Split("\\").Length > 1)
                        collection.Add("use " + __str + ";");
                }

                foreach (Match match in matchCollection)
                {
                    __str = ReplaceDotToSlash(PhpClassParse(match.Value));
                    __last = __str.Split("\\").Last();
                    if (collection.FindAll((Predicate<string>)(x => x == "use " + __str + ";")).ToList<string>()
                            .Count == 0)
                        values.Add("\\" + __str);
                    else
                        values.Add(__last);
                }

                return string.Join("|", values);
            }

            public bool IsPhpErrorName(string name) => name.IndexOf('<') != -1;
        }

        protected class Ini
        {
            public string Path { get; set; }

            public bool IsFind()
            {
                Console.WriteLine("[SDK] path: " + Path);
                return GetFile() == null;
            }

            public string GetFile() => "";
        }
    }
}