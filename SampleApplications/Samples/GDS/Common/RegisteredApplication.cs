#pragma warning disable 1591 
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Opc.Ua.Gds.Client {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/schemas/GDS/RegisteredApplication.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opcfoundation.org/schemas/GDS/RegisteredApplication.xsd", IsNullable=false)]
    public partial class RegisteredApplication {
        
        private string applicationUriField;
        
        private string applicationNameField;
        
        private string productUriField;
        
        private string[] discoveryUrlField;
        
        private string[] serverCapabilityField;
        
        private string configurationFileField;
        
        private string serverUrlField;
        
        private string certificateStorePathField;
        
        private string certificateSubjectNameField;
        
        private string certificatePublicKeyPathField;
        
        private string certificatePrivateKeyPathField;
        
        private string trustListStorePathField;
        
        private string issuerListStorePathField;
        
        private string httpsCertificatePublicKeyPathField;
        
        private string httpsCertificatePrivateKeyPathField;
        
        private string httpsTrustListStorePathField;
        
        private string httpsIssuerListStorePathField;
        
        private string certificateRequestIdField;
        
        private string domainsField;
        
        private RegistrationType registrationTypeField;
        
        /// <remarks/>
        public string ApplicationUri {
            get {
                return this.applicationUriField;
            }
            set {
                this.applicationUriField = value;
            }
        }
        
        /// <remarks/>
        public string ApplicationName {
            get {
                return this.applicationNameField;
            }
            set {
                this.applicationNameField = value;
            }
        }
        
        /// <remarks/>
        public string ProductUri {
            get {
                return this.productUriField;
            }
            set {
                this.productUriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscoveryUrl")]
        public string[] DiscoveryUrl {
            get {
                return this.discoveryUrlField;
            }
            set {
                this.discoveryUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServerCapability")]
        public string[] ServerCapability {
            get {
                return this.serverCapabilityField;
            }
            set {
                this.serverCapabilityField = value;
            }
        }
        
        /// <remarks/>
        public string ConfigurationFile {
            get {
                return this.configurationFileField;
            }
            set {
                this.configurationFileField = value;
            }
        }
        
        /// <remarks/>
        public string ServerUrl {
            get {
                return this.serverUrlField;
            }
            set {
                this.serverUrlField = value;
            }
        }
        
        /// <remarks/>
        public string CertificateStorePath {
            get {
                return this.certificateStorePathField;
            }
            set {
                this.certificateStorePathField = value;
            }
        }
        
        /// <remarks/>
        public string CertificateSubjectName {
            get {
                return this.certificateSubjectNameField;
            }
            set {
                this.certificateSubjectNameField = value;
            }
        }
        
        /// <remarks/>
        public string CertificatePublicKeyPath {
            get {
                return this.certificatePublicKeyPathField;
            }
            set {
                this.certificatePublicKeyPathField = value;
            }
        }
        
        /// <remarks/>
        public string CertificatePrivateKeyPath {
            get {
                return this.certificatePrivateKeyPathField;
            }
            set {
                this.certificatePrivateKeyPathField = value;
            }
        }
        
        /// <remarks/>
        public string TrustListStorePath {
            get {
                return this.trustListStorePathField;
            }
            set {
                this.trustListStorePathField = value;
            }
        }
        
        /// <remarks/>
        public string IssuerListStorePath {
            get {
                return this.issuerListStorePathField;
            }
            set {
                this.issuerListStorePathField = value;
            }
        }
        
        /// <remarks/>
        public string HttpsCertificatePublicKeyPath {
            get {
                return this.httpsCertificatePublicKeyPathField;
            }
            set {
                this.httpsCertificatePublicKeyPathField = value;
            }
        }
        
        /// <remarks/>
        public string HttpsCertificatePrivateKeyPath {
            get {
                return this.httpsCertificatePrivateKeyPathField;
            }
            set {
                this.httpsCertificatePrivateKeyPathField = value;
            }
        }
        
        /// <remarks/>
        public string HttpsTrustListStorePath {
            get {
                return this.httpsTrustListStorePathField;
            }
            set {
                this.httpsTrustListStorePathField = value;
            }
        }
        
        /// <remarks/>
        public string HttpsIssuerListStorePath {
            get {
                return this.httpsIssuerListStorePathField;
            }
            set {
                this.httpsIssuerListStorePathField = value;
            }
        }
        
        /// <remarks/>
        public string CertificateRequestId {
            get {
                return this.certificateRequestIdField;
            }
            set {
                this.certificateRequestIdField = value;
            }
        }
        
        /// <remarks/>
        public string Domains {
            get {
                return this.domainsField;
            }
            set {
                this.domainsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RegistrationType RegistrationType {
            get {
                return this.registrationTypeField;
            }
            set {
                this.registrationTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/schemas/GDS/RegisteredApplication.xsd")]
    public enum RegistrationType {
        
        /// <remarks/>
        ClientPull,
        
        /// <remarks/>
        ServerPull,
        
        /// <remarks/>
        ServerPush,
    }
}
