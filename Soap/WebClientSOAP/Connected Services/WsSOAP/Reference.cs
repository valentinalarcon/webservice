﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WsSOAP
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://serv", ConfigurationName="ServiceReference2.funciones")]
    public interface funciones
    {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Rut del espacio de nombres http://serv no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.digito_verificadorResponse digito_verificador(WsSOAP.digito_verificadorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.digito_verificadorResponse> digito_verificadorAsync(WsSOAP.digito_verificadorRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Rut del espacio de nombres http://serv no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.dv_rutResponse dv_rut(WsSOAP.dv_rutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.dv_rutResponse> dv_rutAsync(WsSOAP.dv_rutRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Nombre del espacio de nombres http://serv no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.validar_nombreResponse validar_nombre(WsSOAP.validar_nombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.validar_nombreResponse> validar_nombreAsync(WsSOAP.validar_nombreRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Nombre del espacio de nombres http://serv no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.separar_nombreResponse separar_nombre(WsSOAP.separar_nombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.separar_nombreResponse> separar_nombreAsync(WsSOAP.separar_nombreRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class digito_verificadorRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="digito_verificador", Namespace="http://serv", Order=0)]
        public WsSOAP.digito_verificadorRequestBody Body;
        
        public digito_verificadorRequest()
        {
        }
        
        public digito_verificadorRequest(WsSOAP.digito_verificadorRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class digito_verificadorRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Rut;
        
        public digito_verificadorRequestBody()
        {
        }
        
        public digito_verificadorRequestBody(string Rut)
        {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class digito_verificadorResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="digito_verificadorResponse", Namespace="http://serv", Order=0)]
        public WsSOAP.digito_verificadorResponseBody Body;
        
        public digito_verificadorResponse()
        {
        }
        
        public digito_verificadorResponse(WsSOAP.digito_verificadorResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class digito_verificadorResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string digito_verificadorReturn;
        
        public digito_verificadorResponseBody()
        {
        }
        
        public digito_verificadorResponseBody(string digito_verificadorReturn)
        {
            this.digito_verificadorReturn = digito_verificadorReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class dv_rutRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="dv_rut", Namespace="http://serv", Order=0)]
        public WsSOAP.dv_rutRequestBody Body;
        
        public dv_rutRequest()
        {
        }
        
        public dv_rutRequest(WsSOAP.dv_rutRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class dv_rutRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Rut;
        
        public dv_rutRequestBody()
        {
        }
        
        public dv_rutRequestBody(string Rut)
        {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class dv_rutResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="dv_rutResponse", Namespace="http://serv", Order=0)]
        public WsSOAP.dv_rutResponseBody Body;
        
        public dv_rutResponse()
        {
        }
        
        public dv_rutResponse(WsSOAP.dv_rutResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class dv_rutResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string dv_rutReturn;
        
        public dv_rutResponseBody()
        {
        }
        
        public dv_rutResponseBody(string dv_rutReturn)
        {
            this.dv_rutReturn = dv_rutReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validar_nombreRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validar_nombre", Namespace="http://serv", Order=0)]
        public WsSOAP.validar_nombreRequestBody Body;
        
        public validar_nombreRequest()
        {
        }
        
        public validar_nombreRequest(WsSOAP.validar_nombreRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class validar_nombreRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nombre;
        
        public validar_nombreRequestBody()
        {
        }
        
        public validar_nombreRequestBody(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validar_nombreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validar_nombreResponse", Namespace="http://serv", Order=0)]
        public WsSOAP.validar_nombreResponseBody Body;
        
        public validar_nombreResponse()
        {
        }
        
        public validar_nombreResponse(WsSOAP.validar_nombreResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class validar_nombreResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool validar_nombreReturn;
        
        public validar_nombreResponseBody()
        {
        }
        
        public validar_nombreResponseBody(bool validar_nombreReturn)
        {
            this.validar_nombreReturn = validar_nombreReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class separar_nombreRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="separar_nombre", Namespace="http://serv", Order=0)]
        public WsSOAP.separar_nombreRequestBody Body;
        
        public separar_nombreRequest()
        {
        }
        
        public separar_nombreRequest(WsSOAP.separar_nombreRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class separar_nombreRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int x;
        
        public separar_nombreRequestBody()
        {
        }
        
        public separar_nombreRequestBody(string Nombre, int x)
        {
            this.Nombre = Nombre;
            this.x = x;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class separar_nombreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="separar_nombreResponse", Namespace="http://serv", Order=0)]
        public WsSOAP.separar_nombreResponseBody Body;
        
        public separar_nombreResponse()
        {
        }
        
        public separar_nombreResponse(WsSOAP.separar_nombreResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://serv")]
    public partial class separar_nombreResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string separar_nombreReturn;
        
        public separar_nombreResponseBody()
        {
        }
        
        public separar_nombreResponseBody(string separar_nombreReturn)
        {
            this.separar_nombreReturn = separar_nombreReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface funcionesChannel : WsSOAP.funciones, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class funcionesClient : System.ServiceModel.ClientBase<WsSOAP.funciones>, WsSOAP.funciones
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.digito_verificadorResponse WsSOAP.funciones.digito_verificador(WsSOAP.digito_verificadorRequest request)
        {
            return base.Channel.digito_verificador(request);
        }
        
        public string digito_verificador(string Rut)
        {
            WsSOAP.digito_verificadorRequest inValue = new WsSOAP.digito_verificadorRequest();
            inValue.Body = new WsSOAP.digito_verificadorRequestBody();
            inValue.Body.Rut = Rut;
            WsSOAP.digito_verificadorResponse retVal = ((WsSOAP.funciones)(this)).digito_verificador(inValue);
            return retVal.Body.digito_verificadorReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.digito_verificadorResponse> WsSOAP.funciones.digito_verificadorAsync(WsSOAP.digito_verificadorRequest request)
        {
            return base.Channel.digito_verificadorAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.digito_verificadorResponse> digito_verificadorAsync(string Rut)
        {
            WsSOAP.digito_verificadorRequest inValue = new WsSOAP.digito_verificadorRequest();
            inValue.Body = new WsSOAP.digito_verificadorRequestBody();
            inValue.Body.Rut = Rut;
            return ((WsSOAP.funciones)(this)).digito_verificadorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.dv_rutResponse WsSOAP.funciones.dv_rut(WsSOAP.dv_rutRequest request)
        {
            return base.Channel.dv_rut(request);
        }
        
        public string dv_rut(string Rut)
        {
            WsSOAP.dv_rutRequest inValue = new WsSOAP.dv_rutRequest();
            inValue.Body = new WsSOAP.dv_rutRequestBody();
            inValue.Body.Rut = Rut;
            WsSOAP.dv_rutResponse retVal = ((WsSOAP.funciones)(this)).dv_rut(inValue);
            return retVal.Body.dv_rutReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.dv_rutResponse> WsSOAP.funciones.dv_rutAsync(WsSOAP.dv_rutRequest request)
        {
            return base.Channel.dv_rutAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.dv_rutResponse> dv_rutAsync(string Rut)
        {
            WsSOAP.dv_rutRequest inValue = new WsSOAP.dv_rutRequest();
            inValue.Body = new WsSOAP.dv_rutRequestBody();
            inValue.Body.Rut = Rut;
            return ((WsSOAP.funciones)(this)).dv_rutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.validar_nombreResponse WsSOAP.funciones.validar_nombre(WsSOAP.validar_nombreRequest request)
        {
            return base.Channel.validar_nombre(request);
        }
        
        public bool validar_nombre(string Nombre)
        {
            WsSOAP.validar_nombreRequest inValue = new WsSOAP.validar_nombreRequest();
            inValue.Body = new WsSOAP.validar_nombreRequestBody();
            inValue.Body.Nombre = Nombre;
            WsSOAP.validar_nombreResponse retVal = ((WsSOAP.funciones)(this)).validar_nombre(inValue);
            return retVal.Body.validar_nombreReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.validar_nombreResponse> WsSOAP.funciones.validar_nombreAsync(WsSOAP.validar_nombreRequest request)
        {
            return base.Channel.validar_nombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.validar_nombreResponse> validar_nombreAsync(string Nombre)
        {
            WsSOAP.validar_nombreRequest inValue = new WsSOAP.validar_nombreRequest();
            inValue.Body = new WsSOAP.validar_nombreRequestBody();
            inValue.Body.Nombre = Nombre;
            return ((WsSOAP.funciones)(this)).validar_nombreAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.separar_nombreResponse WsSOAP.funciones.separar_nombre(WsSOAP.separar_nombreRequest request)
        {
            return base.Channel.separar_nombre(request);
        }
        
        public string separar_nombre(string Nombre, int x)
        {
            WsSOAP.separar_nombreRequest inValue = new WsSOAP.separar_nombreRequest();
            inValue.Body = new WsSOAP.separar_nombreRequestBody();
            inValue.Body.Nombre = Nombre;
            inValue.Body.x = x;
            WsSOAP.separar_nombreResponse retVal = ((WsSOAP.funciones)(this)).separar_nombre(inValue);
            return retVal.Body.separar_nombreReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.separar_nombreResponse> WsSOAP.funciones.separar_nombreAsync(WsSOAP.separar_nombreRequest request)
        {
            return base.Channel.separar_nombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.separar_nombreResponse> separar_nombreAsync(string Nombre, int x)
        {
            WsSOAP.separar_nombreRequest inValue = new WsSOAP.separar_nombreRequest();
            inValue.Body = new WsSOAP.separar_nombreRequestBody();
            inValue.Body.Nombre = Nombre;
            inValue.Body.x = x;
            return ((WsSOAP.funciones)(this)).separar_nombreAsync(inValue);
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
