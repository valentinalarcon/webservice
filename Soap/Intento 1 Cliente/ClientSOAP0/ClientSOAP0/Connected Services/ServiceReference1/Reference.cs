﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://serv", ConfigurationName="ServiceReference1.funciones")]
    public interface funciones
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.mainResponse main(ServiceReference1.mainRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.mainResponse> mainAsync(ServiceReference1.mainRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.separar_nombresResponse separar_nombres(ServiceReference1.separar_nombresRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.separar_nombresResponse> separar_nombresAsync(ServiceReference1.separar_nombresRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.dv_rutResponse dv_rut(ServiceReference1.dv_rutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.dv_rutResponse> dv_rutAsync(ServiceReference1.dv_rutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.separar_apellidosResponse separar_apellidos(ServiceReference1.separar_apellidosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.separar_apellidosResponse> separar_apellidosAsync(ServiceReference1.separar_apellidosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.digito_verificadorResponse digito_verificador(ServiceReference1.digito_verificadorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.digito_verificadorResponse> digito_verificadorAsync(ServiceReference1.digito_verificadorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.validar_nombreResponse validar_nombre(ServiceReference1.validar_nombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.validar_nombreResponse> validar_nombreAsync(ServiceReference1.validar_nombreRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="main", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class mainRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("args")]
        public string[] args;
        
        public mainRequest()
        {
        }
        
        public mainRequest(string[] args)
        {
            this.args = args;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mainResponse", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class mainResponse
    {
        
        public mainResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="separar_nombres", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class separar_nombresRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string Nombre;
        
        public separar_nombresRequest()
        {
        }
        
        public separar_nombresRequest(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="separar_nombresResponse", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class separar_nombresResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string separar_nombresReturn;
        
        public separar_nombresResponse()
        {
        }
        
        public separar_nombresResponse(string separar_nombresReturn)
        {
            this.separar_nombresReturn = separar_nombresReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dv_rut", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class dv_rutRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string Rut;
        
        public dv_rutRequest(string Rut)
        {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dv_rutResponse", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class dv_rutResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string dv_rutReturn;
        
        public dv_rutResponse()
        {
        }
        
        public dv_rutResponse(string dv_rutReturn)
        {
            this.dv_rutReturn = dv_rutReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="separar_apellidos", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class separar_apellidosRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string Nombre;
        
        public separar_apellidosRequest()
        {
        }
        
        public separar_apellidosRequest(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="separar_apellidosResponse", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class separar_apellidosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string separar_apellidosReturn;
        
        public separar_apellidosResponse()
        {
        }
        
        public separar_apellidosResponse(string separar_apellidosReturn)
        {
            this.separar_apellidosReturn = separar_apellidosReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="digito_verificador", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class digito_verificadorRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string Rut;
        
        public digito_verificadorRequest()
        {
        }
        
        public digito_verificadorRequest(string Rut)
        {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="digito_verificadorResponse", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class digito_verificadorResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string digito_verificadorReturn;
        
        public digito_verificadorResponse()
        {
        }
        
        public digito_verificadorResponse(string digito_verificadorReturn)
        {
            this.digito_verificadorReturn = digito_verificadorReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validar_nombre", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class validar_nombreRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string Nombre;
        
        public validar_nombreRequest()
        {
        }
        
        public validar_nombreRequest(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validar_nombreResponse", WrapperNamespace="http://serv", IsWrapped=true)]
    public partial class validar_nombreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serv", Order=0)]
        public string validar_nombreReturn;
        
        public validar_nombreResponse()
        {
        }
        
        public validar_nombreResponse(string validar_nombreReturn)
        {
            this.validar_nombreReturn = validar_nombreReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface funcionesChannel : ServiceReference1.funciones, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class funcionesClient : System.ServiceModel.ClientBase<ServiceReference1.funciones>, ServiceReference1.funciones
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public funcionesClient() : 
                base(funcionesClient.GetDefaultBinding(), funcionesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.funciones.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public funcionesClient(EndpointConfiguration endpointConfiguration) : 
                base(funcionesClient.GetBindingForEndpoint(endpointConfiguration), funcionesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public funcionesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(funcionesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public funcionesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(funcionesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public funcionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.mainResponse main(ServiceReference1.mainRequest request)
        {
            return base.Channel.main(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.mainResponse> mainAsync(ServiceReference1.mainRequest request)
        {
            return base.Channel.mainAsync(request);
        }
        
        public ServiceReference1.separar_nombresResponse separar_nombres(ServiceReference1.separar_nombresRequest request)
        {
            return base.Channel.separar_nombres(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.separar_nombresResponse> separar_nombresAsync(ServiceReference1.separar_nombresRequest request)
        {
            return base.Channel.separar_nombresAsync(request);
        }
        
        public ServiceReference1.dv_rutResponse dv_rut(ServiceReference1.dv_rutRequest request)
        {
            return base.Channel.dv_rut(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.dv_rutResponse> dv_rutAsync(ServiceReference1.dv_rutRequest request)
        {
            return base.Channel.dv_rutAsync(request);
        }
        
        public ServiceReference1.separar_apellidosResponse separar_apellidos(ServiceReference1.separar_apellidosRequest request)
        {
            return base.Channel.separar_apellidos(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.separar_apellidosResponse> separar_apellidosAsync(ServiceReference1.separar_apellidosRequest request)
        {
            return base.Channel.separar_apellidosAsync(request);
        }
        
        public ServiceReference1.digito_verificadorResponse digito_verificador(ServiceReference1.digito_verificadorRequest request)
        {
            return base.Channel.digito_verificador(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.digito_verificadorResponse> digito_verificadorAsync(ServiceReference1.digito_verificadorRequest request)
        {
            return base.Channel.digito_verificadorAsync(request);
        }
        
        public ServiceReference1.validar_nombreResponse validar_nombre(ServiceReference1.validar_nombreRequest request)
        {
            return base.Channel.validar_nombre(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.validar_nombreResponse> validar_nombreAsync(ServiceReference1.validar_nombreRequest request)
        {
            return base.Channel.validar_nombreAsync(request);
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
            if ((endpointConfiguration == EndpointConfiguration.funciones))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.funciones))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/WebServiceProject/services/funciones");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return funcionesClient.GetBindingForEndpoint(EndpointConfiguration.funciones);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return funcionesClient.GetEndpointAddress(EndpointConfiguration.funciones);
        }
        
        public enum EndpointConfiguration
        {
            
            funciones,
        }
    }
}
