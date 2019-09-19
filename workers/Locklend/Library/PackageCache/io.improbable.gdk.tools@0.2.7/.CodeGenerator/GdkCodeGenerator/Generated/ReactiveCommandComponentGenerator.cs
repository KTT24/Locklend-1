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
    
    
    public partial class ReactiveCommandComponentGenerator : ReactiveCommandComponentGeneratorBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "Templates/ReactiveCommandComponentGenerator.tt"

    var componentDetails = GetComponentDetails();
    var generatedHeader = CommonGeneratorUtils.GetGeneratedHeader();
    var commandDetailsList = GetCommandDetailsList();
    var componentNamespace = $"global::{qualifiedNamespace}.{componentDetails.ComponentName}";

            
            #line default
            #line hidden
            
            #line 9 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( generatedHeader ));
            
            #line default
            #line hidden
            
            #line 9 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@"

#if USE_LEGACY_REACTIVE_COMPONENTS
using System;
using System.Collections.Generic;
using Unity.Entities;
using Improbable.Gdk.Core;
using Improbable.Gdk.Core.Commands;
using Improbable.Gdk.ReactiveComponents;
using Improbable.Worker.CInterop;
using Entity = Unity.Entities.Entity;

namespace ");
            
            #line default
            #line hidden
            
            #line 21 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 21 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("\r\n{\r\n    public partial class ");
            
            #line default
            #line hidden
            
            #line 23 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 23 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 25 "Templates/ReactiveCommandComponentGenerator.tt"
 foreach (var command in commandDetailsList) {
        var requestType = command.CommandName + ".Request";
        var receivedRequestType = command.CommandName + ".ReceivedRequest";
        var responseType = command.CommandName + ".Response";
        var receivedResponseType = command.CommandName + ".ReceivedResponse";

        var commandResponseBufferType = $"{componentNamespace}.CommandResponses.{command.CommandName}";
        var commandRequestBufferType = $"{componentNamespace}.CommandRequests.{command.CommandName}";

            
            #line default
            #line hidden
            
            #line 34 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("        public class ");
            
            #line default
            #line hidden
            
            #line 34 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 34 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@"ReactiveCommandComponentManager : IReactiveCommandComponentManager
        {
            public void PopulateReactiveCommandComponents(CommandSystem commandSystem, EntityManager entityManager, WorkerSystem workerSystem, World world)
            {
                var receivedRequests = commandSystem.GetRequests<");
            
            #line default
            #line hidden
            
            #line 38 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( receivedRequestType ));
            
            #line default
            #line hidden
            
            #line 38 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@">();
                // todo Not efficient if it keeps jumping all over entities but don't care right now
                for (int i = 0; i < receivedRequests.Count; ++i)
                {
                    if (!workerSystem.TryGetEntity(receivedRequests[i].EntityId, out var entity))
                    {
                        continue;
                    }

                    List<");
            
            #line default
            #line hidden
            
            #line 47 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( receivedRequestType ));
            
            #line default
            #line hidden
            
            #line 47 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("> requests;\r\n                    if (entityManager.HasComponent<");
            
            #line default
            #line hidden
            
            #line 48 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandRequestBufferType ));
            
            #line default
            #line hidden
            
            #line 48 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(">(entity))\r\n                    {\r\n                        requests = entityManag" +
                    "er.GetComponentData<");
            
            #line default
            #line hidden
            
            #line 50 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandRequestBufferType ));
            
            #line default
            #line hidden
            
            #line 50 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(">(entity).Requests;\r\n                    }\r\n                    else\r\n           " +
                    "         {\r\n                        var data = new ");
            
            #line default
            #line hidden
            
            #line 54 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandRequestBufferType ));
            
            #line default
            #line hidden
            
            #line 54 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("\r\n                        {\r\n                            CommandListHandle = Refe" +
                    "renceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 56 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 56 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("RequestsProvider.Allocate(world)\r\n                        };\r\n                   " +
                    "     data.Requests = new List<");
            
            #line default
            #line hidden
            
            #line 58 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( receivedRequestType ));
            
            #line default
            #line hidden
            
            #line 58 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@">();
                        requests = data.Requests;
                        entityManager.AddComponentData(entity, data);
                    }

                    requests.Add(receivedRequests[i]);
                }


                var receivedResponses = commandSystem.GetResponses<");
            
            #line default
            #line hidden
            
            #line 67 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( receivedResponseType ));
            
            #line default
            #line hidden
            
            #line 67 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@">();
                // todo Not efficient if it keeps jumping all over entities but don't care right now
                for (int i = 0; i < receivedResponses.Count; ++i)
                {
                    ref readonly var response = ref receivedResponses[i];

                    if (response.SendingEntity == Unity.Entities.Entity.Null || !entityManager.Exists(response.SendingEntity))
                    {
                        continue;
                    }

                    List<");
            
            #line default
            #line hidden
            
            #line 78 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( receivedResponseType ));
            
            #line default
            #line hidden
            
            #line 78 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("> responses;\r\n                    if (entityManager.HasComponent<");
            
            #line default
            #line hidden
            
            #line 79 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandResponseBufferType ));
            
            #line default
            #line hidden
            
            #line 79 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(">(response.SendingEntity))\r\n                    {\r\n                        respon" +
                    "ses = entityManager.GetComponentData<");
            
            #line default
            #line hidden
            
            #line 81 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandResponseBufferType ));
            
            #line default
            #line hidden
            
            #line 81 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(">(response.SendingEntity).Responses;\r\n                    }\r\n                    " +
                    "else\r\n                    {\r\n                        var data = new ");
            
            #line default
            #line hidden
            
            #line 85 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandResponseBufferType ));
            
            #line default
            #line hidden
            
            #line 85 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("\r\n                        {\r\n                            CommandListHandle = Refe" +
                    "renceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 87 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 87 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("ResponsesProvider.Allocate(world)\r\n                        };\r\n                  " +
                    "      data.Responses = new List<");
            
            #line default
            #line hidden
            
            #line 89 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( receivedResponseType ));
            
            #line default
            #line hidden
            
            #line 89 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@">();
                        responses = data.Responses;
                        entityManager.AddComponentData(response.SendingEntity, data);
                    }

                    responses.Add(response);
                }
            }

            public void Clean(World world)
            {
                ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 100 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 100 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("RequestsProvider.CleanDataInWorld(world);\r\n                ReferenceTypeProviders" +
                    ".");
            
            #line default
            #line hidden
            
            #line 101 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 101 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("ResponsesProvider.CleanDataInWorld(world);\r\n            }\r\n        }\r\n\r\n        p" +
                    "ublic class ");
            
            #line default
            #line hidden
            
            #line 105 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 105 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@"CommandSenderComponentManager : ICommandSenderComponentManager
        {
            private Dictionary<EntityId, (uint Sender, uint Responder)> entityIdToAllocatedHandles =
                new Dictionary<EntityId, (uint Sender, uint Responder)>();

            public void AddComponents(Entity entity, EntityManager entityManager, World world)
            {
                // todo error message if not the worker entity or spatial entity
                EntityId entityId = entityManager.HasComponent<SpatialEntityId>(entity)
                    ? entityManager.GetComponentData<SpatialEntityId>(entity).EntityId
                    : new EntityId(0);

                var commandSender = new ");
            
            #line default
            #line hidden
            
            #line 117 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 117 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".CommandSenders.");
            
            #line default
            #line hidden
            
            #line 117 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 117 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("();\r\n                commandSender.CommandListHandle = ");
            
            #line default
            #line hidden
            
            #line 118 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 118 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 118 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 118 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("SenderProvider.Allocate(world);\r\n                commandSender.RequestsToSend = n" +
                    "ew List<");
            
            #line default
            #line hidden
            
            #line 119 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 119 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 119 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 119 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".Request>();\r\n\r\n                entityManager.AddComponentData(entity, commandSen" +
                    "der);\r\n\r\n                var commandResponder = new ");
            
            #line default
            #line hidden
            
            #line 123 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 123 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".CommandResponders.");
            
            #line default
            #line hidden
            
            #line 123 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 123 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("();\r\n                commandResponder.CommandListHandle =\r\n                    ");
            
            #line default
            #line hidden
            
            #line 125 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 125 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 125 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 125 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("ResponderProvider.Allocate(world);\r\n                commandResponder.ResponsesToS" +
                    "end = new List<");
            
            #line default
            #line hidden
            
            #line 126 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentNamespace ));
            
            #line default
            #line hidden
            
            #line 126 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(".");
            
            #line default
            #line hidden
            
            #line 126 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 126 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@".Response>();

                entityManager.AddComponentData(entity, commandResponder);

                entityIdToAllocatedHandles.Add(entityId, (commandSender.CommandListHandle, commandResponder.CommandListHandle));
            }

            public void RemoveComponents(EntityId entityId, EntityManager entityManager, World world)
            {
                var workerSystem = world.GetExistingSystem<WorkerSystem>();

                workerSystem.TryGetEntity(entityId, out var entity);

                if (entity != Entity.Null)
                {
                    entityManager.RemoveComponent<CommandSenders.");
            
            #line default
            #line hidden
            
            #line 141 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 141 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(">(entity);\r\n                    entityManager.RemoveComponent<CommandResponders.");
            
            #line default
            #line hidden
            
            #line 142 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 142 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(@">(entity);
                }

                if (!entityIdToAllocatedHandles.TryGetValue(entityId, out var handles))
                {
                    throw new ArgumentException(""Command components not added to entity"");
                }

                entityIdToAllocatedHandles.Remove(entityId);

                ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 152 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 152 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("SenderProvider.Free(handles.Sender);\r\n                ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 153 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 153 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("ResponderProvider.Free(handles.Responder);\r\n            }\r\n\r\n            public v" +
                    "oid Clean(World world)\r\n            {\r\n                ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 158 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 158 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("SenderProvider.CleanDataInWorld(world);\r\n                ReferenceTypeProviders.");
            
            #line default
            #line hidden
            
            #line 159 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( command.CommandName ));
            
            #line default
            #line hidden
            
            #line 159 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("ResponderProvider.CleanDataInWorld(world);\r\n            }\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 163 "Templates/ReactiveCommandComponentGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 164 "Templates/ReactiveCommandComponentGenerator.tt"
            this.Write("    }\r\n}\r\n#endif\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class ReactiveCommandComponentGeneratorBase {
        
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
