﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Slb.InversionOptimization.RobotController.RobotServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Slb.InversionOptimization.RobotService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RobotServiceReference.IRobotService")]
    public interface IRobotService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/GetData", ReplyAction="http://tempuri.org/IRobotService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IRobotService/GetDataUsingDataContractResponse")]
        Slb.InversionOptimization.RobotController.RobotServiceReference.CompositeType GetDataUsingDataContract(Slb.InversionOptimization.RobotController.RobotServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/InitInversion", ReplyAction="http://tempuri.org/IRobotService/InitInversionResponse")]
        bool InitInversion(System.Guid wellID, System.Guid inversionID, System.Guid ownerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/StartInversion", ReplyAction="http://tempuri.org/IRobotService/StartInversionResponse")]
        bool StartInversion(System.Guid ownerID, System.Guid inversionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/StopInversion", ReplyAction="http://tempuri.org/IRobotService/StopInversionResponse")]
        bool StopInversion(System.Guid ownerID, System.Guid inversionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/QueryInversion", ReplyAction="http://tempuri.org/IRobotService/QueryInversionResponse")]
        System.Collections.Generic.Dictionary<System.Guid, object> QueryInversion(System.Guid wellID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRobotService/RetrieveInversion", ReplyAction="http://tempuri.org/IRobotService/RetrieveInversionResponse")]
        bool RetrieveInversion(System.Guid inversionID, string accessCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRobotServiceChannel : Slb.InversionOptimization.RobotController.RobotServiceReference.IRobotService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RobotServiceClient : System.ServiceModel.ClientBase<Slb.InversionOptimization.RobotController.RobotServiceReference.IRobotService>, Slb.InversionOptimization.RobotController.RobotServiceReference.IRobotService {
        
        public RobotServiceClient() {
        }
        
        public RobotServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RobotServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RobotServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RobotServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public Slb.InversionOptimization.RobotController.RobotServiceReference.CompositeType GetDataUsingDataContract(Slb.InversionOptimization.RobotController.RobotServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public bool InitInversion(System.Guid wellID, System.Guid inversionID, System.Guid ownerID) {
            return base.Channel.InitInversion(wellID, inversionID, ownerID);
        }
        
        public bool StartInversion(System.Guid ownerID, System.Guid inversionID) {
            return base.Channel.StartInversion(ownerID, inversionID);
        }
        
        public bool StopInversion(System.Guid ownerID, System.Guid inversionID) {
            return base.Channel.StopInversion(ownerID, inversionID);
        }
        
        public System.Collections.Generic.Dictionary<System.Guid, object> QueryInversion(System.Guid wellID) {
            return base.Channel.QueryInversion(wellID);
        }
        
        public bool RetrieveInversion(System.Guid inversionID, string accessCode) {
            return base.Channel.RetrieveInversion(inversionID, accessCode);
        }
    }
}
