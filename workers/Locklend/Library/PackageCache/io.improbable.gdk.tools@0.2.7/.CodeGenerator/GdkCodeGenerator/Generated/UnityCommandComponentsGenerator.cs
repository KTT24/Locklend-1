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
    
    
    public partial class UnityCommandComponentsGenerator : UnityCommandComponentsGeneratorBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "Templates/UnityCommandComponentsGenerator.tt"

    var generatedHeader = CommonGeneratorUtils.GetGeneratedHeader();
    var componentDetails = GetComponentDetails();
    var commandDetailsList = GetCommandDetailsList();
    var componentNamespace = $"global::{qualifiedNamespace}.{componentDetails.ComponentName}";

            
            #line default
            #line hidden
            
            #line 9 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( generatedHeader ));
            
            #line default
            #line hidden
            
            #line 9 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("\r\n\r\n#if USE_LEGACY_REACTIVE_COMPONENTS\r\nusing System.Collections.Generic;\r\nusing " +
                    "Unity.Entities;\r\n\r\nnamespace ");
            
            #line default
            #line hidden
            
            #line 15 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 15 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("\r\n{\r\n    public partial class ");
            
            #line default
            #line hidden
            
            #line 17 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 17 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("\r\n    {\r\n        public class CommandSenders\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityCommandComponentsGenerator.tt"
 foreach (var command in commandDetailsList) { 
            
            #line default
            #line hidden
            
            #line 22 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("            public struct ");
            
            #line default
            #line hidden
            
            #line 22 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 22 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(" : IComponentData\r\n            {\r\n                internal uint CommandListHandle" +
                    ";\r\n                public List<global::");
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".Request> RequestsToSend\r\n                {\r\n                    get => global::");
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("SenderProvider.Get(CommandListHandle);\r\n                    set => global::");
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 28 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("SenderProvider.Set(CommandListHandle, value);\r\n                }\r\n            }\r\n" +
                    "");
            
            #line default
            #line hidden
            
            #line 31 "Templates/UnityCommandComponentsGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 32 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("        }\r\n\r\n        public class CommandRequests\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 36 "Templates/UnityCommandComponentsGenerator.tt"
 foreach (var command in commandDetailsList) { 
            
            #line default
            #line hidden
            
            #line 37 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("            public struct ");
            
            #line default
            #line hidden
            
            #line 37 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 37 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(" : IComponentData\r\n            {\r\n                internal uint CommandListHandle" +
                    ";\r\n                public List<");
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReceivedRequest> Requests\r\n                {\r\n                    get => ");
            
            #line default
            #line hidden
            
            #line 42 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 42 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 42 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 42 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("RequestsProvider.Get(CommandListHandle);\r\n                    set => ");
            
            #line default
            #line hidden
            
            #line 43 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 43 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 43 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 43 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("RequestsProvider.Set(CommandListHandle, value);\r\n                }\r\n            }" +
                    "\r\n");
            
            #line default
            #line hidden
            
            #line 46 "Templates/UnityCommandComponentsGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 47 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("        }\r\n\r\n        public class CommandResponders\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 51 "Templates/UnityCommandComponentsGenerator.tt"
 foreach (var command in commandDetailsList) { 
            
            #line default
            #line hidden
            
            #line 52 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("            public struct ");
            
            #line default
            #line hidden
            
            #line 52 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 52 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(" : IComponentData\r\n            {\r\n                internal uint CommandListHandle" +
                    ";\r\n                public List<");
            
            #line default
            #line hidden
            
            #line 55 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 55 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 55 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 55 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".Response> ResponsesToSend\r\n                {\r\n                    get => ");
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("ResponderProvider.Get(CommandListHandle);\r\n                    set => ");
            
            #line default
            #line hidden
            
            #line 58 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 58 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 58 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 58 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("ResponderProvider.Set(CommandListHandle, value);\r\n                }\r\n            " +
                    "}\r\n");
            
            #line default
            #line hidden
            
            #line 61 "Templates/UnityCommandComponentsGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 62 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("        }\r\n\r\n        public class CommandResponses\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 66 "Templates/UnityCommandComponentsGenerator.tt"
 foreach (var command in commandDetailsList) { 
            
            #line default
            #line hidden
            
            #line 67 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("            public struct ");
            
            #line default
            #line hidden
            
            #line 67 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 67 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(" : IComponentData\r\n            {\r\n                internal uint CommandListHandle" +
                    ";\r\n                public List<");
            
            #line default
            #line hidden
            
            #line 70 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 70 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 70 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 70 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReceivedResponse> Responses\r\n                {\r\n                    get => ");
            
            #line default
            #line hidden
            
            #line 72 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 72 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 72 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 72 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("ResponsesProvider.Get(CommandListHandle);\r\n                    set => ");
            
            #line default
            #line hidden
            
            #line 73 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 73 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 73 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 73 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("ResponsesProvider.Set(CommandListHandle, value);\r\n                }\r\n            " +
                    "}\r\n");
            
            #line default
            #line hidden
            
            #line 76 "Templates/UnityCommandComponentsGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 77 "Templates/UnityCommandComponentsGenerator.tt"
            this.Write("        }\r\n    }\r\n}\r\n#endif\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class UnityCommandComponentsGeneratorBase {
        
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
