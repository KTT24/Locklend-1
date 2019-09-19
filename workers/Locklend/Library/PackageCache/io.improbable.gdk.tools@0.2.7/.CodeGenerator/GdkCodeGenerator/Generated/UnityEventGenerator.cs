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
    
    
    public partial class UnityEventGenerator : UnityEventGeneratorBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "Templates/UnityEventGenerator.tt"

    var generatedHeader = CommonGeneratorUtils.GetGeneratedHeader();
    var componentDetails = GetComponentDetails();
    var eventDetailsList = GetEventDetailsList();
    var componentNamespace = $"global::{qualifiedNamespace}.{componentDetails.ComponentName}";

            
            #line default
            #line hidden
            
            #line 9 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( generatedHeader ));
            
            #line default
            #line hidden
            
            #line 9 "Templates/UnityEventGenerator.tt"
            this.Write("\r\n\r\nusing System.Collections.Generic;\r\nusing Improbable.Gdk.Core;\r\nusing Improbab" +
                    "le.Worker;\r\nusing Unity.Entities;\r\n\r\nnamespace ");
            
            #line default
            #line hidden
            
            #line 16 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 16 "Templates/UnityEventGenerator.tt"
            this.Write("\r\n{\r\n    public partial class ");
            
            #line default
            #line hidden
            
            #line 18 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 18 "Templates/UnityEventGenerator.tt"
            this.Write("\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 20 "Templates/UnityEventGenerator.tt"
 foreach (var eventDetails in eventDetailsList) { 
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityEventGenerator.tt"
            this.Write("        public static class ");
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 21 "Templates/UnityEventGenerator.tt"
            this.Write("\r\n        {\r\n            public readonly struct Event : IEvent\r\n            {\r\n  " +
                    "              public readonly ");
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.FqnPayloadType ));
            
            #line default
            #line hidden
            
            #line 25 "Templates/UnityEventGenerator.tt"
            this.Write(" Payload;\r\n\r\n                public Event(");
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.FqnPayloadType ));
            
            #line default
            #line hidden
            
            #line 27 "Templates/UnityEventGenerator.tt"
            this.Write(" payload)\r\n                {\r\n                    Payload = payload;\r\n           " +
                    "     }\r\n            }\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 34 "Templates/UnityEventGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 35 "Templates/UnityEventGenerator.tt"
            this.Write("\r\n#if USE_LEGACY_REACTIVE_COMPONENTS\r\n        public static class ReceivedEvents\r" +
                    "\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 39 "Templates/UnityEventGenerator.tt"
 foreach (var eventDetails in eventDetailsList) { 
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityEventGenerator.tt"
            this.Write("            public struct ");
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 40 "Templates/UnityEventGenerator.tt"
            this.Write(" : IComponentData\r\n            {\r\n                internal uint handle;\r\n\r\n      " +
                    "          public List<");
            
            #line default
            #line hidden
            
            #line 44 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.FqnPayloadType ));
            
            #line default
            #line hidden
            
            #line 44 "Templates/UnityEventGenerator.tt"
            this.Write("> Events\r\n                {\r\n                    get => ");
            
            #line default
            #line hidden
            
            #line 46 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 46 "Templates/UnityEventGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 46 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 46 "Templates/UnityEventGenerator.tt"
            this.Write("Provider.Get(handle);\r\n                    internal set => ");
            
            #line default
            #line hidden
            
            #line 47 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 47 "Templates/UnityEventGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 47 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 47 "Templates/UnityEventGenerator.tt"
            this.Write("Provider.Set(handle, value);\r\n                }\r\n            }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 51 "Templates/UnityEventGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 52 "Templates/UnityEventGenerator.tt"
            this.Write("        }\r\n\r\n        public static class EventSender\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 56 "Templates/UnityEventGenerator.tt"
 foreach (var eventDetails in eventDetailsList) { 
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityEventGenerator.tt"
            this.Write("            public struct ");
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 57 "Templates/UnityEventGenerator.tt"
            this.Write(" : IComponentData\r\n            {\r\n                internal uint handle;\r\n\r\n      " +
                    "          public List<");
            
            #line default
            #line hidden
            
            #line 61 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.FqnPayloadType ));
            
            #line default
            #line hidden
            
            #line 61 "Templates/UnityEventGenerator.tt"
            this.Write("> Events\r\n                {\r\n                    get => ");
            
            #line default
            #line hidden
            
            #line 63 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 63 "Templates/UnityEventGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 63 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 63 "Templates/UnityEventGenerator.tt"
            this.Write("Provider.Get(handle);\r\n                    internal set => ");
            
            #line default
            #line hidden
            
            #line 64 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 64 "Templates/UnityEventGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 64 "Templates/UnityEventGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( eventDetails.EventName ));
            
            #line default
            #line hidden
            
            #line 64 "Templates/UnityEventGenerator.tt"
            this.Write("Provider.Set(handle, value);\r\n                }\r\n            }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 68 "Templates/UnityEventGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 69 "Templates/UnityEventGenerator.tt"
            this.Write("        }\r\n#endif\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class UnityEventGeneratorBase {
        
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
