﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="id", Namespace="http://schemas.datacontract.org/2004/07/WcfCommerce")]
    [System.SerializableAttribute()]
    public partial class id : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastnameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstname {
            get {
                return this.firstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstnameField, value) != true)) {
                    this.firstnameField = value;
                    this.RaisePropertyChanged("firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastnameField, value) != true)) {
                    this.lastnameField = value;
                    this.RaisePropertyChanged("lastname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICustomer")]
    public interface ICustomer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetOrderOfCustomer", ReplyAction="http://tempuri.org/ICustomer/GetOrderOfCustomerResponse")]
        ECommerce.ServiceReference1.id GetOrderOfCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetOrderOfCustomer", ReplyAction="http://tempuri.org/ICustomer/GetOrderOfCustomerResponse")]
        System.Threading.Tasks.Task<ECommerce.ServiceReference1.id> GetOrderOfCustomerAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerChannel : ECommerce.ServiceReference1.ICustomer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerClient : System.ServiceModel.ClientBase<ECommerce.ServiceReference1.ICustomer>, ECommerce.ServiceReference1.ICustomer {
        
        public CustomerClient() {
        }
        
        public CustomerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ECommerce.ServiceReference1.id GetOrderOfCustomer(int id) {
            return base.Channel.GetOrderOfCustomer(id);
        }
        
        public System.Threading.Tasks.Task<ECommerce.ServiceReference1.id> GetOrderOfCustomerAsync(int id) {
            return base.Channel.GetOrderOfCustomerAsync(id);
        }
    }
}