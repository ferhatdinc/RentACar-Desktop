﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarajDesktop.AuthService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerLoginResponseDto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CustomerLoginResponseDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerSurnameField;
        
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
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CustomerName {
            get {
                return this.CustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNameField, value) != true)) {
                    this.CustomerNameField = value;
                    this.RaisePropertyChanged("CustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CustomerSurname {
            get {
                return this.CustomerSurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerSurnameField, value) != true)) {
                    this.CustomerSurnameField = value;
                    this.RaisePropertyChanged("CustomerSurname");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyLoginResponseDto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CompanyLoginResponseDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CompanyIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
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
        public int CompanyID {
            get {
                return this.CompanyIDField;
            }
            set {
                if ((this.CompanyIDField.Equals(value) != true)) {
                    this.CompanyIDField = value;
                    this.RaisePropertyChanged("CompanyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerRequestDto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CustomerRequestDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyRequestDto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CompanyRequestDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyAdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyPasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string CompanyAdress {
            get {
                return this.CompanyAdressField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyAdressField, value) != true)) {
                    this.CompanyAdressField = value;
                    this.RaisePropertyChanged("CompanyAdress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string CompanyPassword {
            get {
                return this.CompanyPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyPasswordField, value) != true)) {
                    this.CompanyPasswordField = value;
                    this.RaisePropertyChanged("CompanyPassword");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthService.AuthServiceSoap")]
    public interface AuthServiceSoap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerLogin", ReplyAction="*")]
        CarajDesktop.AuthService.CustomerLoginResponse CustomerLogin(CarajDesktop.AuthService.CustomerLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CustomerLoginResponse> CustomerLoginAsync(CarajDesktop.AuthService.CustomerLoginRequest request);
        
        // CODEGEN: Generating message contract since element name companyname from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CompanyLogin", ReplyAction="*")]
        CarajDesktop.AuthService.CompanyLoginResponse CompanyLogin(CarajDesktop.AuthService.CompanyLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CompanyLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CompanyLoginResponse> CompanyLoginAsync(CarajDesktop.AuthService.CompanyLoginRequest request);
        
        // CODEGEN: Generating message contract since element name customerdto from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerRegister", ReplyAction="*")]
        CarajDesktop.AuthService.CustomerRegisterResponse CustomerRegister(CarajDesktop.AuthService.CustomerRegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerRegister", ReplyAction="*")]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CustomerRegisterResponse> CustomerRegisterAsync(CarajDesktop.AuthService.CustomerRegisterRequest request);
        
        // CODEGEN: Generating message contract since element name companyDto from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CompanyRegister", ReplyAction="*")]
        CarajDesktop.AuthService.CompanyRegisterResponse CompanyRegister(CarajDesktop.AuthService.CompanyRegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CompanyRegister", ReplyAction="*")]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CompanyRegisterResponse> CompanyRegisterAsync(CarajDesktop.AuthService.CompanyRegisterRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CustomerLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CustomerLogin", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CustomerLoginRequestBody Body;
        
        public CustomerLoginRequest() {
        }
        
        public CustomerLoginRequest(CarajDesktop.AuthService.CustomerLoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CustomerLoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public CustomerLoginRequestBody() {
        }
        
        public CustomerLoginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CustomerLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CustomerLoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CustomerLoginResponseBody Body;
        
        public CustomerLoginResponse() {
        }
        
        public CustomerLoginResponse(CarajDesktop.AuthService.CustomerLoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CustomerLoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarajDesktop.AuthService.CustomerLoginResponseDto CustomerLoginResult;
        
        public CustomerLoginResponseBody() {
        }
        
        public CustomerLoginResponseBody(CarajDesktop.AuthService.CustomerLoginResponseDto CustomerLoginResult) {
            this.CustomerLoginResult = CustomerLoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompanyLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompanyLogin", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CompanyLoginRequestBody Body;
        
        public CompanyLoginRequest() {
        }
        
        public CompanyLoginRequest(CarajDesktop.AuthService.CompanyLoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CompanyLoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string companyname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public CompanyLoginRequestBody() {
        }
        
        public CompanyLoginRequestBody(string companyname, string password) {
            this.companyname = companyname;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompanyLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompanyLoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CompanyLoginResponseBody Body;
        
        public CompanyLoginResponse() {
        }
        
        public CompanyLoginResponse(CarajDesktop.AuthService.CompanyLoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CompanyLoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarajDesktop.AuthService.CompanyLoginResponseDto CompanyLoginResult;
        
        public CompanyLoginResponseBody() {
        }
        
        public CompanyLoginResponseBody(CarajDesktop.AuthService.CompanyLoginResponseDto CompanyLoginResult) {
            this.CompanyLoginResult = CompanyLoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CustomerRegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CustomerRegister", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CustomerRegisterRequestBody Body;
        
        public CustomerRegisterRequest() {
        }
        
        public CustomerRegisterRequest(CarajDesktop.AuthService.CustomerRegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CustomerRegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarajDesktop.AuthService.CustomerRequestDto customerdto;
        
        public CustomerRegisterRequestBody() {
        }
        
        public CustomerRegisterRequestBody(CarajDesktop.AuthService.CustomerRequestDto customerdto) {
            this.customerdto = customerdto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CustomerRegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CustomerRegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CustomerRegisterResponseBody Body;
        
        public CustomerRegisterResponse() {
        }
        
        public CustomerRegisterResponse(CarajDesktop.AuthService.CustomerRegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CustomerRegisterResponseBody {
        
        public CustomerRegisterResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompanyRegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompanyRegister", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CompanyRegisterRequestBody Body;
        
        public CompanyRegisterRequest() {
        }
        
        public CompanyRegisterRequest(CarajDesktop.AuthService.CompanyRegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CompanyRegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarajDesktop.AuthService.CompanyRequestDto companyDto;
        
        public CompanyRegisterRequestBody() {
        }
        
        public CompanyRegisterRequestBody(CarajDesktop.AuthService.CompanyRequestDto companyDto) {
            this.companyDto = companyDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompanyRegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompanyRegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public CarajDesktop.AuthService.CompanyRegisterResponseBody Body;
        
        public CompanyRegisterResponse() {
        }
        
        public CompanyRegisterResponse(CarajDesktop.AuthService.CompanyRegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CompanyRegisterResponseBody {
        
        public CompanyRegisterResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthServiceSoapChannel : CarajDesktop.AuthService.AuthServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceSoapClient : System.ServiceModel.ClientBase<CarajDesktop.AuthService.AuthServiceSoap>, CarajDesktop.AuthService.AuthServiceSoap {
        
        public AuthServiceSoapClient() {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarajDesktop.AuthService.CustomerLoginResponse CarajDesktop.AuthService.AuthServiceSoap.CustomerLogin(CarajDesktop.AuthService.CustomerLoginRequest request) {
            return base.Channel.CustomerLogin(request);
        }
        
        public CarajDesktop.AuthService.CustomerLoginResponseDto CustomerLogin(string username, string password) {
            CarajDesktop.AuthService.CustomerLoginRequest inValue = new CarajDesktop.AuthService.CustomerLoginRequest();
            inValue.Body = new CarajDesktop.AuthService.CustomerLoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            CarajDesktop.AuthService.CustomerLoginResponse retVal = ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CustomerLogin(inValue);
            return retVal.Body.CustomerLoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CustomerLoginResponse> CarajDesktop.AuthService.AuthServiceSoap.CustomerLoginAsync(CarajDesktop.AuthService.CustomerLoginRequest request) {
            return base.Channel.CustomerLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarajDesktop.AuthService.CustomerLoginResponse> CustomerLoginAsync(string username, string password) {
            CarajDesktop.AuthService.CustomerLoginRequest inValue = new CarajDesktop.AuthService.CustomerLoginRequest();
            inValue.Body = new CarajDesktop.AuthService.CustomerLoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CustomerLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarajDesktop.AuthService.CompanyLoginResponse CarajDesktop.AuthService.AuthServiceSoap.CompanyLogin(CarajDesktop.AuthService.CompanyLoginRequest request) {
            return base.Channel.CompanyLogin(request);
        }
        
        public CarajDesktop.AuthService.CompanyLoginResponseDto CompanyLogin(string companyname, string password) {
            CarajDesktop.AuthService.CompanyLoginRequest inValue = new CarajDesktop.AuthService.CompanyLoginRequest();
            inValue.Body = new CarajDesktop.AuthService.CompanyLoginRequestBody();
            inValue.Body.companyname = companyname;
            inValue.Body.password = password;
            CarajDesktop.AuthService.CompanyLoginResponse retVal = ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CompanyLogin(inValue);
            return retVal.Body.CompanyLoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CompanyLoginResponse> CarajDesktop.AuthService.AuthServiceSoap.CompanyLoginAsync(CarajDesktop.AuthService.CompanyLoginRequest request) {
            return base.Channel.CompanyLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarajDesktop.AuthService.CompanyLoginResponse> CompanyLoginAsync(string companyname, string password) {
            CarajDesktop.AuthService.CompanyLoginRequest inValue = new CarajDesktop.AuthService.CompanyLoginRequest();
            inValue.Body = new CarajDesktop.AuthService.CompanyLoginRequestBody();
            inValue.Body.companyname = companyname;
            inValue.Body.password = password;
            return ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CompanyLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarajDesktop.AuthService.CustomerRegisterResponse CarajDesktop.AuthService.AuthServiceSoap.CustomerRegister(CarajDesktop.AuthService.CustomerRegisterRequest request) {
            return base.Channel.CustomerRegister(request);
        }
        
        public void CustomerRegister(CarajDesktop.AuthService.CustomerRequestDto customerdto) {
            CarajDesktop.AuthService.CustomerRegisterRequest inValue = new CarajDesktop.AuthService.CustomerRegisterRequest();
            inValue.Body = new CarajDesktop.AuthService.CustomerRegisterRequestBody();
            inValue.Body.customerdto = customerdto;
            CarajDesktop.AuthService.CustomerRegisterResponse retVal = ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CustomerRegister(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CustomerRegisterResponse> CarajDesktop.AuthService.AuthServiceSoap.CustomerRegisterAsync(CarajDesktop.AuthService.CustomerRegisterRequest request) {
            return base.Channel.CustomerRegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarajDesktop.AuthService.CustomerRegisterResponse> CustomerRegisterAsync(CarajDesktop.AuthService.CustomerRequestDto customerdto) {
            CarajDesktop.AuthService.CustomerRegisterRequest inValue = new CarajDesktop.AuthService.CustomerRegisterRequest();
            inValue.Body = new CarajDesktop.AuthService.CustomerRegisterRequestBody();
            inValue.Body.customerdto = customerdto;
            return ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CustomerRegisterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarajDesktop.AuthService.CompanyRegisterResponse CarajDesktop.AuthService.AuthServiceSoap.CompanyRegister(CarajDesktop.AuthService.CompanyRegisterRequest request) {
            return base.Channel.CompanyRegister(request);
        }
        
        public void CompanyRegister(CarajDesktop.AuthService.CompanyRequestDto companyDto) {
            CarajDesktop.AuthService.CompanyRegisterRequest inValue = new CarajDesktop.AuthService.CompanyRegisterRequest();
            inValue.Body = new CarajDesktop.AuthService.CompanyRegisterRequestBody();
            inValue.Body.companyDto = companyDto;
            CarajDesktop.AuthService.CompanyRegisterResponse retVal = ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CompanyRegister(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarajDesktop.AuthService.CompanyRegisterResponse> CarajDesktop.AuthService.AuthServiceSoap.CompanyRegisterAsync(CarajDesktop.AuthService.CompanyRegisterRequest request) {
            return base.Channel.CompanyRegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarajDesktop.AuthService.CompanyRegisterResponse> CompanyRegisterAsync(CarajDesktop.AuthService.CompanyRequestDto companyDto) {
            CarajDesktop.AuthService.CompanyRegisterRequest inValue = new CarajDesktop.AuthService.CompanyRegisterRequest();
            inValue.Body = new CarajDesktop.AuthService.CompanyRegisterRequestBody();
            inValue.Body.companyDto = companyDto;
            return ((CarajDesktop.AuthService.AuthServiceSoap)(this)).CompanyRegisterAsync(inValue);
        }
    }
}
