﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemberRegistrationAppln.MemberServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/MemberRegistrationFormService")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[] HouseholdInfoMembersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswrdField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Employeeid {
            get {
                return this.EmployeeidField;
            }
            set {
                if ((this.EmployeeidField.Equals(value) != true)) {
                    this.EmployeeidField = value;
                    this.RaisePropertyChanged("Employeeid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[] HouseholdInfoMembers {
            get {
                return this.HouseholdInfoMembersField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseholdInfoMembersField, value) != true)) {
                    this.HouseholdInfoMembersField = value;
                    this.RaisePropertyChanged("HouseholdInfoMembers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Passwrd {
            get {
                return this.PasswrdField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswrdField, value) != true)) {
                    this.PasswrdField = value;
                    this.RaisePropertyChanged("Passwrd");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HouseholdInfoMember", Namespace="http://schemas.datacontract.org/2004/07/MemberRegistrationFormService")]
    [System.SerializableAttribute()]
    public partial class HouseholdInfoMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplicationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MemberRegistrationAppln.MemberServiceReference1.Employee EmployeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EmployeeidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleInitialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RelationshipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuffixField;
        
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
        public int ApplicationID {
            get {
                return this.ApplicationIDField;
            }
            set {
                if ((this.ApplicationIDField.Equals(value) != true)) {
                    this.ApplicationIDField = value;
                    this.RaisePropertyChanged("ApplicationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((object.ReferenceEquals(this.DOBField, value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MemberRegistrationAppln.MemberServiceReference1.Employee Employee {
            get {
                return this.EmployeeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeField, value) != true)) {
                    this.EmployeeField = value;
                    this.RaisePropertyChanged("Employee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Employeeid {
            get {
                return this.EmployeeidField;
            }
            set {
                if ((this.EmployeeidField.Equals(value) != true)) {
                    this.EmployeeidField = value;
                    this.RaisePropertyChanged("Employeeid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleInitial {
            get {
                return this.MiddleInitialField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleInitialField, value) != true)) {
                    this.MiddleInitialField = value;
                    this.RaisePropertyChanged("MiddleInitial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Relationship {
            get {
                return this.RelationshipField;
            }
            set {
                if ((object.ReferenceEquals(this.RelationshipField, value) != true)) {
                    this.RelationshipField = value;
                    this.RaisePropertyChanged("Relationship");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Suffix {
            get {
                return this.SuffixField;
            }
            set {
                if ((object.ReferenceEquals(this.SuffixField, value) != true)) {
                    this.SuffixField = value;
                    this.RaisePropertyChanged("Suffix");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MemberServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OneUser", ReplyAction="http://tempuri.org/IService1/OneUserResponse")]
        void OneUser(MemberRegistrationAppln.MemberServiceReference1.Employee userObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OneUser", ReplyAction="http://tempuri.org/IService1/OneUserResponse")]
        System.Threading.Tasks.Task OneUserAsync(MemberRegistrationAppln.MemberServiceReference1.Employee userObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Users", ReplyAction="http://tempuri.org/IService1/UsersResponse")]
        MemberRegistrationAppln.MemberServiceReference1.Employee[] Users();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Users", ReplyAction="http://tempuri.org/IService1/UsersResponse")]
        System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.Employee[]> UsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AuthenticateEmployee", ReplyAction="http://tempuri.org/IService1/AuthenticateEmployeeResponse")]
        bool AuthenticateEmployee(MemberRegistrationAppln.MemberServiceReference1.Employee obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AuthenticateEmployee", ReplyAction="http://tempuri.org/IService1/AuthenticateEmployeeResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateEmployeeAsync(MemberRegistrationAppln.MemberServiceReference1.Employee obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmpId", ReplyAction="http://tempuri.org/IService1/GetEmpIdResponse")]
        int GetEmpId(MemberRegistrationAppln.MemberServiceReference1.Employee empObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmpId", ReplyAction="http://tempuri.org/IService1/GetEmpIdResponse")]
        System.Threading.Tasks.Task<int> GetEmpIdAsync(MemberRegistrationAppln.MemberServiceReference1.Employee empObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddApplicant", ReplyAction="http://tempuri.org/IService1/AddApplicantResponse")]
        void AddApplicant(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember memberObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddApplicant", ReplyAction="http://tempuri.org/IService1/AddApplicantResponse")]
        System.Threading.Tasks.Task AddApplicantAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember memberObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/members", ReplyAction="http://tempuri.org/IService1/membersResponse")]
        MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[] members(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/members", ReplyAction="http://tempuri.org/IService1/membersResponse")]
        System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[]> membersAsync(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetApplicationId", ReplyAction="http://tempuri.org/IService1/GetApplicationIdResponse")]
        MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember GetApplicationId(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetApplicationId", ReplyAction="http://tempuri.org/IService1/GetApplicationIdResponse")]
        System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember> GetApplicationIdAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddRelation", ReplyAction="http://tempuri.org/IService1/AddRelationResponse")]
        void AddRelation(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddRelation", ReplyAction="http://tempuri.org/IService1/AddRelationResponse")]
        System.Threading.Tasks.Task AddRelationAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEditedApplicant", ReplyAction="http://tempuri.org/IService1/AddEditedApplicantResponse")]
        void AddEditedApplicant(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEditedApplicant", ReplyAction="http://tempuri.org/IService1/AddEditedApplicantResponse")]
        System.Threading.Tasks.Task AddEditedApplicantAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchApplicant", ReplyAction="http://tempuri.org/IService1/SearchApplicantResponse")]
        MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[] SearchApplicant(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchApplicant", ReplyAction="http://tempuri.org/IService1/SearchApplicantResponse")]
        System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[]> SearchApplicantAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MemberRegistrationAppln.MemberServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MemberRegistrationAppln.MemberServiceReference1.IService1>, MemberRegistrationAppln.MemberServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void OneUser(MemberRegistrationAppln.MemberServiceReference1.Employee userObj) {
            base.Channel.OneUser(userObj);
        }
        
        public System.Threading.Tasks.Task OneUserAsync(MemberRegistrationAppln.MemberServiceReference1.Employee userObj) {
            return base.Channel.OneUserAsync(userObj);
        }
        
        public MemberRegistrationAppln.MemberServiceReference1.Employee[] Users() {
            return base.Channel.Users();
        }
        
        public System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.Employee[]> UsersAsync() {
            return base.Channel.UsersAsync();
        }
        
        public bool AuthenticateEmployee(MemberRegistrationAppln.MemberServiceReference1.Employee obj) {
            return base.Channel.AuthenticateEmployee(obj);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateEmployeeAsync(MemberRegistrationAppln.MemberServiceReference1.Employee obj) {
            return base.Channel.AuthenticateEmployeeAsync(obj);
        }
        
        public int GetEmpId(MemberRegistrationAppln.MemberServiceReference1.Employee empObj) {
            return base.Channel.GetEmpId(empObj);
        }
        
        public System.Threading.Tasks.Task<int> GetEmpIdAsync(MemberRegistrationAppln.MemberServiceReference1.Employee empObj) {
            return base.Channel.GetEmpIdAsync(empObj);
        }
        
        public void AddApplicant(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember memberObj) {
            base.Channel.AddApplicant(memberObj);
        }
        
        public System.Threading.Tasks.Task AddApplicantAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember memberObj) {
            return base.Channel.AddApplicantAsync(memberObj);
        }
        
        public MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[] members(int empId) {
            return base.Channel.members(empId);
        }
        
        public System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[]> membersAsync(int empId) {
            return base.Channel.membersAsync(empId);
        }
        
        public MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember GetApplicationId(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            return base.Channel.GetApplicationId(member);
        }
        
        public System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember> GetApplicationIdAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            return base.Channel.GetApplicationIdAsync(member);
        }
        
        public void AddRelation(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            base.Channel.AddRelation(member);
        }
        
        public System.Threading.Tasks.Task AddRelationAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            return base.Channel.AddRelationAsync(member);
        }
        
        public void AddEditedApplicant(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            base.Channel.AddEditedApplicant(member);
        }
        
        public System.Threading.Tasks.Task AddEditedApplicantAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            return base.Channel.AddEditedApplicantAsync(member);
        }
        
        public MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[] SearchApplicant(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            return base.Channel.SearchApplicant(member);
        }
        
        public System.Threading.Tasks.Task<MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember[]> SearchApplicantAsync(MemberRegistrationAppln.MemberServiceReference1.HouseholdInfoMember member) {
            return base.Channel.SearchApplicantAsync(member);
        }
    }
}