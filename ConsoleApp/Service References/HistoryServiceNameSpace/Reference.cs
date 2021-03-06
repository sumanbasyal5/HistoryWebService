﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp.HistoryServiceNameSpace {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HistoryPage", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class HistoryPage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int historyIdField;
        
        private System.Nullable<int> monthField;
        
        private System.Nullable<int> dayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string eventsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int historyId {
            get {
                return this.historyIdField;
            }
            set {
                if ((this.historyIdField.Equals(value) != true)) {
                    this.historyIdField = value;
                    this.RaisePropertyChanged("historyId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> month {
            get {
                return this.monthField;
            }
            set {
                if ((this.monthField.Equals(value) != true)) {
                    this.monthField = value;
                    this.RaisePropertyChanged("month");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<int> day {
            get {
                return this.dayField;
            }
            set {
                if ((this.dayField.Equals(value) != true)) {
                    this.dayField = value;
                    this.RaisePropertyChanged("day");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string events {
            get {
                return this.eventsField;
            }
            set {
                if ((object.ReferenceEquals(this.eventsField, value) != true)) {
                    this.eventsField = value;
                    this.RaisePropertyChanged("events");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HistoryServiceNameSpace.HistoryWebServiceSoap")]
    public interface HistoryWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ConsoleApp.HistoryServiceNameSpace.HelloWorldResponse HelloWorld(ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.HelloWorldResponse> HelloWorldAsync(ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name events from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddToFile", ReplyAction="*")]
        ConsoleApp.HistoryServiceNameSpace.AddToFileResponse AddToFile(ConsoleApp.HistoryServiceNameSpace.AddToFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddToFile", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.AddToFileResponse> AddToFileAsync(ConsoleApp.HistoryServiceNameSpace.AddToFileRequest request);
        
        // CODEGEN: Generating message contract since element name GetFromFileResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFromFile", ReplyAction="*")]
        ConsoleApp.HistoryServiceNameSpace.GetFromFileResponse GetFromFile(ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFromFile", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.GetFromFileResponse> GetFromFileAsync(ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ConsoleApp.HistoryServiceNameSpace.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ConsoleApp.HistoryServiceNameSpace.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddToFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddToFile", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.AddToFileRequestBody Body;
        
        public AddToFileRequest() {
        }
        
        public AddToFileRequest(ConsoleApp.HistoryServiceNameSpace.AddToFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddToFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int month;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int day;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string events;
        
        public AddToFileRequestBody() {
        }
        
        public AddToFileRequestBody(int month, int day, string events) {
            this.month = month;
            this.day = day;
            this.events = events;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddToFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddToFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.AddToFileResponseBody Body;
        
        public AddToFileResponse() {
        }
        
        public AddToFileResponse(ConsoleApp.HistoryServiceNameSpace.AddToFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddToFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddToFileResult;
        
        public AddToFileResponseBody() {
        }
        
        public AddToFileResponseBody(int AddToFileResult) {
            this.AddToFileResult = AddToFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFromFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFromFile", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.GetFromFileRequestBody Body;
        
        public GetFromFileRequest() {
        }
        
        public GetFromFileRequest(ConsoleApp.HistoryServiceNameSpace.GetFromFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFromFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int month;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int day;
        
        public GetFromFileRequestBody() {
        }
        
        public GetFromFileRequestBody(int month, int day) {
            this.month = month;
            this.day = day;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFromFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFromFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.GetFromFileResponseBody Body;
        
        public GetFromFileResponse() {
        }
        
        public GetFromFileResponse(ConsoleApp.HistoryServiceNameSpace.GetFromFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFromFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApp.HistoryServiceNameSpace.HistoryPage[] GetFromFileResult;
        
        public GetFromFileResponseBody() {
        }
        
        public GetFromFileResponseBody(ConsoleApp.HistoryServiceNameSpace.HistoryPage[] GetFromFileResult) {
            this.GetFromFileResult = GetFromFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HistoryWebServiceSoapChannel : ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HistoryWebServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap>, ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap {
        
        public HistoryWebServiceSoapClient() {
        }
        
        public HistoryWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HistoryWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HistoryWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HistoryWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.HistoryServiceNameSpace.HelloWorldResponse ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap.HelloWorld(ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest inValue = new ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest();
            inValue.Body = new ConsoleApp.HistoryServiceNameSpace.HelloWorldRequestBody();
            ConsoleApp.HistoryServiceNameSpace.HelloWorldResponse retVal = ((ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.HelloWorldResponse> ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap.HelloWorldAsync(ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.HelloWorldResponse> HelloWorldAsync() {
            ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest inValue = new ConsoleApp.HistoryServiceNameSpace.HelloWorldRequest();
            inValue.Body = new ConsoleApp.HistoryServiceNameSpace.HelloWorldRequestBody();
            return ((ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.HistoryServiceNameSpace.AddToFileResponse ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap.AddToFile(ConsoleApp.HistoryServiceNameSpace.AddToFileRequest request) {
            return base.Channel.AddToFile(request);
        }
        
        public int AddToFile(int month, int day, string events) {
            ConsoleApp.HistoryServiceNameSpace.AddToFileRequest inValue = new ConsoleApp.HistoryServiceNameSpace.AddToFileRequest();
            inValue.Body = new ConsoleApp.HistoryServiceNameSpace.AddToFileRequestBody();
            inValue.Body.month = month;
            inValue.Body.day = day;
            inValue.Body.events = events;
            ConsoleApp.HistoryServiceNameSpace.AddToFileResponse retVal = ((ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap)(this)).AddToFile(inValue);
            return retVal.Body.AddToFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.AddToFileResponse> ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap.AddToFileAsync(ConsoleApp.HistoryServiceNameSpace.AddToFileRequest request) {
            return base.Channel.AddToFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.AddToFileResponse> AddToFileAsync(int month, int day, string events) {
            ConsoleApp.HistoryServiceNameSpace.AddToFileRequest inValue = new ConsoleApp.HistoryServiceNameSpace.AddToFileRequest();
            inValue.Body = new ConsoleApp.HistoryServiceNameSpace.AddToFileRequestBody();
            inValue.Body.month = month;
            inValue.Body.day = day;
            inValue.Body.events = events;
            return ((ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap)(this)).AddToFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.HistoryServiceNameSpace.GetFromFileResponse ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap.GetFromFile(ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest request) {
            return base.Channel.GetFromFile(request);
        }
        
        public ConsoleApp.HistoryServiceNameSpace.HistoryPage[] GetFromFile(int month, int day) {
            ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest inValue = new ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest();
            inValue.Body = new ConsoleApp.HistoryServiceNameSpace.GetFromFileRequestBody();
            inValue.Body.month = month;
            inValue.Body.day = day;
            ConsoleApp.HistoryServiceNameSpace.GetFromFileResponse retVal = ((ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap)(this)).GetFromFile(inValue);
            return retVal.Body.GetFromFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.GetFromFileResponse> ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap.GetFromFileAsync(ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest request) {
            return base.Channel.GetFromFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.HistoryServiceNameSpace.GetFromFileResponse> GetFromFileAsync(int month, int day) {
            ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest inValue = new ConsoleApp.HistoryServiceNameSpace.GetFromFileRequest();
            inValue.Body = new ConsoleApp.HistoryServiceNameSpace.GetFromFileRequestBody();
            inValue.Body.month = month;
            inValue.Body.day = day;
            return ((ConsoleApp.HistoryServiceNameSpace.HistoryWebServiceSoap)(this)).GetFromFileAsync(inValue);
        }
    }
}
