﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WuQiang.WCF.Test.WCFTCPConsoleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WCFUser", Namespace="http://schemas.datacontract.org/2004/07/WuQiang.WCF.Model")]
    [System.SerializableAttribute()]
    public partial class WCFUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SexField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sex {
            get {
                return this.SexField;
            }
            set {
                if ((this.SexField.Equals(value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFTCPConsoleService.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/PlusInt", ReplyAction="http://tempuri.org/IMathService/PlusIntResponse")]
        int PlusInt(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/PlusInt", ReplyAction="http://tempuri.org/IMathService/PlusIntResponse")]
        System.Threading.Tasks.Task<int> PlusIntAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/GetUser", ReplyAction="http://tempuri.org/IMathService/GetUserResponse")]
        WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser GetUser(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/GetUser", ReplyAction="http://tempuri.org/IMathService/GetUserResponse")]
        System.Threading.Tasks.Task<WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser> GetUserAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/UserList", ReplyAction="http://tempuri.org/IMathService/UserListResponse")]
        WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser[] UserList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/UserList", ReplyAction="http://tempuri.org/IMathService/UserListResponse")]
        System.Threading.Tasks.Task<WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser[]> UserListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : WuQiang.WCF.Test.WCFTCPConsoleService.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<WuQiang.WCF.Test.WCFTCPConsoleService.IMathService>, WuQiang.WCF.Test.WCFTCPConsoleService.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int PlusInt(int x, int y) {
            return base.Channel.PlusInt(x, y);
        }
        
        public System.Threading.Tasks.Task<int> PlusIntAsync(int x, int y) {
            return base.Channel.PlusIntAsync(x, y);
        }
        
        public WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser GetUser(int x, int y) {
            return base.Channel.GetUser(x, y);
        }
        
        public System.Threading.Tasks.Task<WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser> GetUserAsync(int x, int y) {
            return base.Channel.GetUserAsync(x, y);
        }
        
        public WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser[] UserList() {
            return base.Channel.UserList();
        }
        
        public System.Threading.Tasks.Task<WuQiang.WCF.Test.WCFTCPConsoleService.WCFUser[]> UserListAsync() {
            return base.Channel.UserListAsync();
        }
    }
}
