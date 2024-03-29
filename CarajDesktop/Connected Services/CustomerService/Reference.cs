﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarajDesktop.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerResponseDto", Namespace="http://tempuri.org")]
    [System.SerializableAttribute()]
    public partial class CustomerResponseDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CustomerIdField;
        
        private System.DateTime CustomerBirthdateField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.DateTime CustomerBirthdate {
            get {
                return this.CustomerBirthdateField;
            }
            set {
                if ((this.CustomerBirthdateField.Equals(value) != true)) {
                    this.CustomerBirthdateField = value;
                    this.RaisePropertyChanged("CustomerBirthdate");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="CustomerService.CustomerServiceSoap")]
    public interface CustomerServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateRentalRequest", ReplyAction="*")]
        void CreateRentalRequest(int CarID, int CustomerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateRentalRequest", ReplyAction="*")]
        System.Threading.Tasks.Task CreateRentalRequestAsync(int CarID, int CustomerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteRentalRequest", ReplyAction="*")]
        void DeleteRentalRequest(int RentalRequestID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteRentalRequest", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteRentalRequestAsync(int RentalRequestID);
        
        // CODEGEN: Generating message contract since element name GetAllCustomerResult from namespace http://tempuri.org is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCustomer", ReplyAction="*")]
        CarajDesktop.CustomerService.GetAllCustomerResponse GetAllCustomer(CarajDesktop.CustomerService.GetAllCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCustomer", ReplyAction="*")]
        System.Threading.Tasks.Task<CarajDesktop.CustomerService.GetAllCustomerResponse> GetAllCustomerAsync(CarajDesktop.CustomerService.GetAllCustomerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCustomer", Namespace="http://tempuri.org", Order=0)]
        public CarajDesktop.CustomerService.GetAllCustomerRequestBody Body;
        
        public GetAllCustomerRequest() {
        }
        
        public GetAllCustomerRequest(CarajDesktop.CustomerService.GetAllCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllCustomerRequestBody {
        
        public GetAllCustomerRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCustomerResponse", Namespace="http://tempuri.org", Order=0)]
        public CarajDesktop.CustomerService.GetAllCustomerResponseBody Body;
        
        public GetAllCustomerResponse() {
        }
        
        public GetAllCustomerResponse(CarajDesktop.CustomerService.GetAllCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org")]
    public partial class GetAllCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarajDesktop.CustomerService.CustomerResponseDto[] GetAllCustomerResult;
        
        public GetAllCustomerResponseBody() {
        }
        
        public GetAllCustomerResponseBody(CarajDesktop.CustomerService.CustomerResponseDto[] GetAllCustomerResult) {
            this.GetAllCustomerResult = GetAllCustomerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomerServiceSoapChannel : CarajDesktop.CustomerService.CustomerServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceSoapClient : System.ServiceModel.ClientBase<CarajDesktop.CustomerService.CustomerServiceSoap>, CarajDesktop.CustomerService.CustomerServiceSoap {
        
        public CustomerServiceSoapClient() {
        }
        
        public CustomerServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateRentalRequest(int CarID, int CustomerID) {
            base.Channel.CreateRentalRequest(CarID, CustomerID);
        }
        
        public System.Threading.Tasks.Task CreateRentalRequestAsync(int CarID, int CustomerID) {
            return base.Channel.CreateRentalRequestAsync(CarID, CustomerID);
        }
        
        public void DeleteRentalRequest(int RentalRequestID) {
            base.Channel.DeleteRentalRequest(RentalRequestID);
        }
        
        public System.Threading.Tasks.Task DeleteRentalRequestAsync(int RentalRequestID) {
            return base.Channel.DeleteRentalRequestAsync(RentalRequestID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarajDesktop.CustomerService.GetAllCustomerResponse CarajDesktop.CustomerService.CustomerServiceSoap.GetAllCustomer(CarajDesktop.CustomerService.GetAllCustomerRequest request) {
            return base.Channel.GetAllCustomer(request);
        }
        
        public CarajDesktop.CustomerService.CustomerResponseDto[] GetAllCustomer() {
            CarajDesktop.CustomerService.GetAllCustomerRequest inValue = new CarajDesktop.CustomerService.GetAllCustomerRequest();
            inValue.Body = new CarajDesktop.CustomerService.GetAllCustomerRequestBody();
            CarajDesktop.CustomerService.GetAllCustomerResponse retVal = ((CarajDesktop.CustomerService.CustomerServiceSoap)(this)).GetAllCustomer(inValue);
            return retVal.Body.GetAllCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarajDesktop.CustomerService.GetAllCustomerResponse> CarajDesktop.CustomerService.CustomerServiceSoap.GetAllCustomerAsync(CarajDesktop.CustomerService.GetAllCustomerRequest request) {
            return base.Channel.GetAllCustomerAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarajDesktop.CustomerService.GetAllCustomerResponse> GetAllCustomerAsync() {
            CarajDesktop.CustomerService.GetAllCustomerRequest inValue = new CarajDesktop.CustomerService.GetAllCustomerRequest();
            inValue.Body = new CarajDesktop.CustomerService.GetAllCustomerRequestBody();
            return ((CarajDesktop.CustomerService.CustomerServiceSoap)(this)).GetAllCustomerAsync(inValue);
        }
    }
}
