﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.TcrmService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/", ConfigurationName="TcrmService.TcrmServicesInterface")]
    public interface TcrmServicesInterface {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(tcrm))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp2.TcrmService.queryTCRMResponse queryTCRM(ConsoleApp2.TcrmService.queryTCRM request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.TcrmService.queryTCRMResponse> queryTCRMAsync(ConsoleApp2.TcrmService.queryTCRM request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/")]
    public partial class tcrmResponse : tcrm {
        
        private string messageField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
                this.RaisePropertyChanged("success");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool successSpecified {
            get {
                return this.successFieldSpecified;
            }
            set {
                this.successFieldSpecified = value;
                this.RaisePropertyChanged("successSpecified");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(tcrmResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/")]
    public partial class tcrm : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool displayToUserField;
        
        private bool displayToUserFieldSpecified;
        
        private long idField;
        
        private bool idFieldSpecified;
        
        private string unitField;
        
        private System.DateTime validityFromField;
        
        private bool validityFromFieldSpecified;
        
        private System.DateTime validityToField;
        
        private bool validityToFieldSpecified;
        
        private float valueField;
        
        private bool valueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool displayToUser {
            get {
                return this.displayToUserField;
            }
            set {
                this.displayToUserField = value;
                this.RaisePropertyChanged("displayToUser");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displayToUserSpecified {
            get {
                return this.displayToUserFieldSpecified;
            }
            set {
                this.displayToUserFieldSpecified = value;
                this.RaisePropertyChanged("displayToUserSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
                this.RaisePropertyChanged("unit");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime validityFrom {
            get {
                return this.validityFromField;
            }
            set {
                this.validityFromField = value;
                this.RaisePropertyChanged("validityFrom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validityFromSpecified {
            get {
                return this.validityFromFieldSpecified;
            }
            set {
                this.validityFromFieldSpecified = value;
                this.RaisePropertyChanged("validityFromSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime validityTo {
            get {
                return this.validityToField;
            }
            set {
                this.validityToField = value;
                this.RaisePropertyChanged("validityTo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validityToSpecified {
            get {
                return this.validityToFieldSpecified;
            }
            set {
                this.validityToFieldSpecified = value;
                this.RaisePropertyChanged("validityToSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public float value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
                this.RaisePropertyChanged("valueSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="queryTCRM", WrapperNamespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/", IsWrapped=true)]
    public partial class queryTCRM {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tcrmQueryAssociatedDate;
        
        public queryTCRM() {
        }
        
        public queryTCRM(string tcrmQueryAssociatedDate) {
            this.tcrmQueryAssociatedDate = tcrmQueryAssociatedDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="queryTCRMResponse", WrapperNamespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/", IsWrapped=true)]
    public partial class queryTCRMResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConsoleApp2.TcrmService.tcrmResponse @return;
        
        public queryTCRMResponse() {
        }
        
        public queryTCRMResponse(ConsoleApp2.TcrmService.tcrmResponse @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TcrmServicesInterfaceChannel : ConsoleApp2.TcrmService.TcrmServicesInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TcrmServicesInterfaceClient : System.ServiceModel.ClientBase<ConsoleApp2.TcrmService.TcrmServicesInterface>, ConsoleApp2.TcrmService.TcrmServicesInterface {
        
        public TcrmServicesInterfaceClient() {
        }
        
        public TcrmServicesInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TcrmServicesInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TcrmServicesInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TcrmServicesInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.TcrmService.queryTCRMResponse ConsoleApp2.TcrmService.TcrmServicesInterface.queryTCRM(ConsoleApp2.TcrmService.queryTCRM request) {
            return base.Channel.queryTCRM(request);
        }
        
        public ConsoleApp2.TcrmService.tcrmResponse queryTCRM(string tcrmQueryAssociatedDate) {
            ConsoleApp2.TcrmService.queryTCRM inValue = new ConsoleApp2.TcrmService.queryTCRM();
            inValue.tcrmQueryAssociatedDate = tcrmQueryAssociatedDate;
            ConsoleApp2.TcrmService.queryTCRMResponse retVal = ((ConsoleApp2.TcrmService.TcrmServicesInterface)(this)).queryTCRM(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.TcrmService.queryTCRMResponse> ConsoleApp2.TcrmService.TcrmServicesInterface.queryTCRMAsync(ConsoleApp2.TcrmService.queryTCRM request) {
            return base.Channel.queryTCRMAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.TcrmService.queryTCRMResponse> queryTCRMAsync(string tcrmQueryAssociatedDate) {
            ConsoleApp2.TcrmService.queryTCRM inValue = new ConsoleApp2.TcrmService.queryTCRM();
            inValue.tcrmQueryAssociatedDate = tcrmQueryAssociatedDate;
            return ((ConsoleApp2.TcrmService.TcrmServicesInterface)(this)).queryTCRMAsync(inValue);
        }
    }
}
