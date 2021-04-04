﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwinfieldProcessXmlService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.twinfield.com/", ConfigurationName="TwinfieldProcessXmlService.ProcessXmlSoap")]
    public interface ProcessXmlSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/ProcessXmlString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlStringResponse> ProcessXmlStringAsync(TwinfieldProcessXmlService.ProcessXmlStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/ProcessXmlDocument", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlDocumentResponse> ProcessXmlDocumentAsync(TwinfieldProcessXmlService.ProcessXmlDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/ProcessXmlCompressed", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlCompressedResponse> ProcessXmlCompressedAsync(TwinfieldProcessXmlService.ProcessXmlCompressedRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public partial class Header
    {
        
        private string sessionIDField;
        
        private string accessTokenField;
        
        private string companyCodeField;
        
        private System.Nullable<System.Guid> companyIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SessionID
        {
            get
            {
                return this.sessionIDField;
            }
            set
            {
                this.sessionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AccessToken
        {
            get
            {
                return this.accessTokenField;
            }
            set
            {
                this.accessTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CompanyCode
        {
            get
            {
                return this.companyCodeField;
            }
            set
            {
                this.companyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.Guid> CompanyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessXmlString", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ProcessXmlStringRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public TwinfieldProcessXmlService.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string xmlRequest;
        
        public ProcessXmlStringRequest()
        {
        }
        
        public ProcessXmlStringRequest(TwinfieldProcessXmlService.Header Header, string xmlRequest)
        {
            this.Header = Header;
            this.xmlRequest = xmlRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessXmlStringResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ProcessXmlStringResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string ProcessXmlStringResult;
        
        public ProcessXmlStringResponse()
        {
        }
        
        public ProcessXmlStringResponse(string ProcessXmlStringResult)
        {
            this.ProcessXmlStringResult = ProcessXmlStringResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessXmlDocument", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ProcessXmlDocumentRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public TwinfieldProcessXmlService.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public System.Xml.XmlNode xmlRequest;
        
        public ProcessXmlDocumentRequest()
        {
        }
        
        public ProcessXmlDocumentRequest(TwinfieldProcessXmlService.Header Header, System.Xml.XmlNode xmlRequest)
        {
            this.Header = Header;
            this.xmlRequest = xmlRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessXmlDocumentResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ProcessXmlDocumentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public System.Xml.XmlNode ProcessXmlDocumentResult;
        
        public ProcessXmlDocumentResponse()
        {
        }
        
        public ProcessXmlDocumentResponse(System.Xml.XmlNode ProcessXmlDocumentResult)
        {
            this.ProcessXmlDocumentResult = ProcessXmlDocumentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessXmlCompressed", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ProcessXmlCompressedRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public TwinfieldProcessXmlService.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] xmlRequest;
        
        public ProcessXmlCompressedRequest()
        {
        }
        
        public ProcessXmlCompressedRequest(TwinfieldProcessXmlService.Header Header, byte[] xmlRequest)
        {
            this.Header = Header;
            this.xmlRequest = xmlRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessXmlCompressedResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ProcessXmlCompressedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] ProcessXmlCompressedResult;
        
        public ProcessXmlCompressedResponse()
        {
        }
        
        public ProcessXmlCompressedResponse(byte[] ProcessXmlCompressedResult)
        {
            this.ProcessXmlCompressedResult = ProcessXmlCompressedResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ProcessXmlSoapChannel : TwinfieldProcessXmlService.ProcessXmlSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ProcessXmlSoapClient : System.ServiceModel.ClientBase<TwinfieldProcessXmlService.ProcessXmlSoap>, TwinfieldProcessXmlService.ProcessXmlSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ProcessXmlSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ProcessXmlSoapClient.GetBindingForEndpoint(endpointConfiguration), ProcessXmlSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessXmlSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ProcessXmlSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessXmlSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ProcessXmlSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessXmlSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlStringResponse> TwinfieldProcessXmlService.ProcessXmlSoap.ProcessXmlStringAsync(TwinfieldProcessXmlService.ProcessXmlStringRequest request)
        {
            return base.Channel.ProcessXmlStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlStringResponse> ProcessXmlStringAsync(TwinfieldProcessXmlService.Header Header, string xmlRequest)
        {
            TwinfieldProcessXmlService.ProcessXmlStringRequest inValue = new TwinfieldProcessXmlService.ProcessXmlStringRequest();
            inValue.Header = Header;
            inValue.xmlRequest = xmlRequest;
            return ((TwinfieldProcessXmlService.ProcessXmlSoap)(this)).ProcessXmlStringAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlDocumentResponse> TwinfieldProcessXmlService.ProcessXmlSoap.ProcessXmlDocumentAsync(TwinfieldProcessXmlService.ProcessXmlDocumentRequest request)
        {
            return base.Channel.ProcessXmlDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlDocumentResponse> ProcessXmlDocumentAsync(TwinfieldProcessXmlService.Header Header, System.Xml.XmlNode xmlRequest)
        {
            TwinfieldProcessXmlService.ProcessXmlDocumentRequest inValue = new TwinfieldProcessXmlService.ProcessXmlDocumentRequest();
            inValue.Header = Header;
            inValue.xmlRequest = xmlRequest;
            return ((TwinfieldProcessXmlService.ProcessXmlSoap)(this)).ProcessXmlDocumentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlCompressedResponse> TwinfieldProcessXmlService.ProcessXmlSoap.ProcessXmlCompressedAsync(TwinfieldProcessXmlService.ProcessXmlCompressedRequest request)
        {
            return base.Channel.ProcessXmlCompressedAsync(request);
        }
        
        public System.Threading.Tasks.Task<TwinfieldProcessXmlService.ProcessXmlCompressedResponse> ProcessXmlCompressedAsync(TwinfieldProcessXmlService.Header Header, byte[] xmlRequest)
        {
            TwinfieldProcessXmlService.ProcessXmlCompressedRequest inValue = new TwinfieldProcessXmlService.ProcessXmlCompressedRequest();
            inValue.Header = Header;
            inValue.xmlRequest = xmlRequest;
            return ((TwinfieldProcessXmlService.ProcessXmlSoap)(this)).ProcessXmlCompressedAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ProcessXmlSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ProcessXmlSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ProcessXmlSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://accounting.twinfield.com/webservices/processxml.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ProcessXmlSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://accounting.twinfield.com/webservices/processxml.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ProcessXmlSoap,
            
            ProcessXmlSoap12,
        }
    }
}
