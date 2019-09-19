﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Improbable.Gdk.CodeGenerator {
    using System;
    using Improbable.Gdk.CodeGeneration.Jobs;
    
    
    public partial class UnityTypeContent : UnityTypeContentBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "Templates/UnityTypeContent.tt"

    var typeDetails = GetTypeDetails();
    var fieldDetailsList = GetFieldDetailsList();
    var hasPartial = PartialDatabase.TryGetPartial(typeDetails.GetPartialResourceTypeName(), out var partial);

            
            #line default
            #line hidden
            
            #line 8 "Templates/UnityTypeContent.tt"
            this.Write("\r\n[global::System.Serializable]\r\npublic struct ");
            
            #line default
            #line hidden
            
            #line 10 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.CapitalisedName ));
            
            #line default
            #line hidden
            
            #line 10 "Templates/UnityTypeContent.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 12 "Templates/UnityTypeContent.tt"
 foreach (var fieldDetails in fieldDetailsList) { 
            
            #line default
            #line hidden
            
            #line 13 "Templates/UnityTypeContent.tt"
            this.Write("    public ");
            
            #line default
            #line hidden
            
            #line 13 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fieldDetails.Type ));
            
            #line default
            #line hidden
            
            #line 13 "Templates/UnityTypeContent.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 13 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fieldDetails.PascalCaseName ));
            
            #line default
            #line hidden
            
            #line 13 "Templates/UnityTypeContent.tt"
            this.Write(";\r\n");
            
            #line default
            #line hidden
            
            #line 14 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 15 "Templates/UnityTypeContent.tt"

if (fieldDetailsList.Count > 0)
{
    var constructorArgs = GetConstructorArgs();

            
            #line default
            #line hidden
            
            #line 20 "Templates/UnityTypeContent.tt"
            this.Write("\r\n    public ");
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.CapitalisedName ));
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityTypeContent.tt"
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( constructorArgs ));
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityTypeContent.tt"
            this.Write(")\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 23 "Templates/UnityTypeContent.tt"
 foreach (var fieldDetails in fieldDetailsList) { 
            
            #line default
            #line hidden
            
            #line 24 "Templates/UnityTypeContent.tt"
            this.Write("        ");
            
            #line default
            #line hidden
            
            #line 24 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fieldDetails.PascalCaseName ));
            
            #line default
            #line hidden
            
            #line 24 "Templates/UnityTypeContent.tt"
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 24 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fieldDetails.CamelCaseName ));
            
            #line default
            #line hidden
            
            #line 24 "Templates/UnityTypeContent.tt"
            this.Write(";\r\n");
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 26 "Templates/UnityTypeContent.tt"
            this.Write("    }\r\n");
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityTypeContent.tt"
 if (hasPartial) { 
            
            #line default
            #line hidden
            
            #line 29 "Templates/UnityTypeContent.tt"
            this.Write("\r\n    ");
            
            #line default
            #line hidden
            
            #line 30 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( CommonGeneratorUtils.IndentEveryNewline(partial) ));
            
            #line default
            #line hidden
            
            #line 30 "Templates/UnityTypeContent.tt"
            this.Write("\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 32 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 33 "Templates/UnityTypeContent.tt"
            this.Write("    public static class Serialization\r\n    {\r\n        public static void Serializ" +
                    "e(");
            
            #line default
            #line hidden
            
            #line 35 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.CapitalisedName ));
            
            #line default
            #line hidden
            
            #line 35 "Templates/UnityTypeContent.tt"
            this.Write(" instance, global::Improbable.Worker.CInterop.SchemaObject obj)\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 37 "Templates/UnityTypeContent.tt"
 if (typeDetails.HasSerializationOverride) { 
            
            #line default
            #line hidden
            
            #line 38 "Templates/UnityTypeContent.tt"
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 38 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.SerializationOverride.GetSerializationString("instance", "obj") ));
            
            #line default
            #line hidden
            
            #line 38 "Templates/UnityTypeContent.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 39 "Templates/UnityTypeContent.tt"
 } else { 
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityTypeContent.tt"
 foreach (var fieldDetails in fieldDetailsList) { 
            
            #line default
            #line hidden
            
            #line 41 "Templates/UnityTypeContent.tt"
            this.Write("            {\r\n                ");
            
            #line default
            #line hidden
            
            #line 42 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fieldDetails.GetSerializationString("instance." + fieldDetails.PascalCaseName, "obj", 4) ));
            
            #line default
            #line hidden
            
            #line 42 "Templates/UnityTypeContent.tt"
            this.Write("\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 44 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 45 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 46 "Templates/UnityTypeContent.tt"
            this.Write("        }\r\n\r\n        public static ");
            
            #line default
            #line hidden
            
            #line 48 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.CapitalisedName ));
            
            #line default
            #line hidden
            
            #line 48 "Templates/UnityTypeContent.tt"
            this.Write(" Deserialize(global::Improbable.Worker.CInterop.SchemaObject obj)\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 50 "Templates/UnityTypeContent.tt"
 if (typeDetails.HasSerializationOverride) { 
            
            #line default
            #line hidden
            
            #line 51 "Templates/UnityTypeContent.tt"
            this.Write("            return ");
            
            #line default
            #line hidden
            
            #line 51 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.SerializationOverride.GetDeserializeString("obj") ));
            
            #line default
            #line hidden
            
            #line 51 "Templates/UnityTypeContent.tt"
            this.Write(";\r\n");
            
            #line default
            #line hidden
            
            #line 52 "Templates/UnityTypeContent.tt"
 } else { 
            
            #line default
            #line hidden
            
            #line 53 "Templates/UnityTypeContent.tt"
            this.Write("            var instance = new ");
            
            #line default
            #line hidden
            
            #line 53 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( typeDetails.CapitalisedName ));
            
            #line default
            #line hidden
            
            #line 53 "Templates/UnityTypeContent.tt"
            this.Write("();\r\n");
            
            #line default
            #line hidden
            
            #line 54 "Templates/UnityTypeContent.tt"
 foreach (var fieldDetails in fieldDetailsList) { 
            
            #line default
            #line hidden
            
            #line 55 "Templates/UnityTypeContent.tt"
            this.Write("            {\r\n                ");
            
            #line default
            #line hidden
            
            #line 56 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fieldDetails.GetDeserializeString("instance." + fieldDetails.PascalCaseName, "obj", 4) ));
            
            #line default
            #line hidden
            
            #line 56 "Templates/UnityTypeContent.tt"
            this.Write("\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 58 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 59 "Templates/UnityTypeContent.tt"
            this.Write("            return instance;\r\n");
            
            #line default
            #line hidden
            
            #line 60 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 61 "Templates/UnityTypeContent.tt"
            this.Write("        }\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 63 "Templates/UnityTypeContent.tt"

    var typeGenerator = new UnityTypeContent();
    foreach (var nestedType in nestedTypes)
    {

            
            #line default
            #line hidden
            
            #line 68 "Templates/UnityTypeContent.tt"
            this.Write("\r\n    ");
            
            #line default
            #line hidden
            
            #line 69 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( CommonGeneratorUtils.IndentEveryNewline(typeGenerator.Generate(nestedType)) ));
            
            #line default
            #line hidden
            
            #line 69 "Templates/UnityTypeContent.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 70 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 71 "Templates/UnityTypeContent.tt"

    var enumGenerator = new UnityEnumContent();
    foreach (var nestedEnum in nestedEnums)
    {

            
            #line default
            #line hidden
            
            #line 76 "Templates/UnityTypeContent.tt"
            this.Write("\r\n    ");
            
            #line default
            #line hidden
            
            #line 77 "Templates/UnityTypeContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( CommonGeneratorUtils.IndentEveryNewline(enumGenerator.Generate(nestedEnum)) ));
            
            #line default
            #line hidden
            
            #line 77 "Templates/UnityTypeContent.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 78 "Templates/UnityTypeContent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 79 "Templates/UnityTypeContent.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class UnityTypeContentBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
