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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://redes", ConfigurationName="ServiceReference1.funciones")]
    public interface funciones
    {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Rut del espacio de nombres http://redes no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.VerificadorRutResponse VerificadorRut(WsSOAP.VerificadorRutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.VerificadorRutResponse> VerificadorRutAsync(WsSOAP.VerificadorRutRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Nombre del espacio de nombres http://redes no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.SepararNombreResponse SepararNombre(WsSOAP.SepararNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.SepararNombreResponse> SepararNombreAsync(WsSOAP.SepararNombreRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Rut del espacio de nombres http://redes no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.DigitoVerificadorResponse DigitoVerificador(WsSOAP.DigitoVerificadorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.DigitoVerificadorResponse> DigitoVerificadorAsync(WsSOAP.DigitoVerificadorRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Nombre del espacio de nombres http://redes no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WsSOAP.ValidarNombreResponse ValidarNombre(WsSOAP.ValidarNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WsSOAP.ValidarNombreResponse> ValidarNombreAsync(WsSOAP.ValidarNombreRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificadorRutRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificadorRut", Namespace="http://redes", Order=0)]
        public WsSOAP.VerificadorRutRequestBody Body;
        
        public VerificadorRutRequest()
        {
        }
        
        public VerificadorRutRequest(WsSOAP.VerificadorRutRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class VerificadorRutRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Rut;
        
        public VerificadorRutRequestBody()
        {
        }
        
        public VerificadorRutRequestBody(string Rut)
        {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificadorRutResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificadorRutResponse", Namespace="http://redes", Order=0)]
        public WsSOAP.VerificadorRutResponseBody Body;
        
        public VerificadorRutResponse()
        {
        }
        
        public VerificadorRutResponse(WsSOAP.VerificadorRutResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class VerificadorRutResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VerificadorRutReturn;
        
        public VerificadorRutResponseBody()
        {
        }
        
        public VerificadorRutResponseBody(string VerificadorRutReturn)
        {
            this.VerificadorRutReturn = VerificadorRutReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SepararNombreRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SepararNombre", Namespace="http://redes", Order=0)]
        public WsSOAP.SepararNombreRequestBody Body;
        
        public SepararNombreRequest()
        {
        }
        
        public SepararNombreRequest(WsSOAP.SepararNombreRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class SepararNombreRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nombre;
        
        public SepararNombreRequestBody()
        {
        }
        
        public SepararNombreRequestBody(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SepararNombreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SepararNombreResponse", Namespace="http://redes", Order=0)]
        public WsSOAP.SepararNombreResponseBody Body;
        
        public SepararNombreResponse()
        {
        }
        
        public SepararNombreResponse(WsSOAP.SepararNombreResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class SepararNombreResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SepararNombreReturn;
        
        public SepararNombreResponseBody()
        {
        }
        
        public SepararNombreResponseBody(string SepararNombreReturn)
        {
            this.SepararNombreReturn = SepararNombreReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DigitoVerificadorRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DigitoVerificador", Namespace="http://redes", Order=0)]
        public WsSOAP.DigitoVerificadorRequestBody Body;
        
        public DigitoVerificadorRequest()
        {
        }
        
        public DigitoVerificadorRequest(WsSOAP.DigitoVerificadorRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class DigitoVerificadorRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Rut;
        
        public DigitoVerificadorRequestBody()
        {
        }
        
        public DigitoVerificadorRequestBody(string Rut)
        {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DigitoVerificadorResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DigitoVerificadorResponse", Namespace="http://redes", Order=0)]
        public WsSOAP.DigitoVerificadorResponseBody Body;
        
        public DigitoVerificadorResponse()
        {
        }
        
        public DigitoVerificadorResponse(WsSOAP.DigitoVerificadorResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class DigitoVerificadorResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DigitoVerificadorReturn;
        
        public DigitoVerificadorResponseBody()
        {
        }
        
        public DigitoVerificadorResponseBody(string DigitoVerificadorReturn)
        {
            this.DigitoVerificadorReturn = DigitoVerificadorReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarNombreRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarNombre", Namespace="http://redes", Order=0)]
        public WsSOAP.ValidarNombreRequestBody Body;
        
        public ValidarNombreRequest()
        {
        }
        
        public ValidarNombreRequest(WsSOAP.ValidarNombreRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class ValidarNombreRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nombre;
        
        public ValidarNombreRequestBody()
        {
        }
        
        public ValidarNombreRequestBody(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarNombreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarNombreResponse", Namespace="http://redes", Order=0)]
        public WsSOAP.ValidarNombreResponseBody Body;
        
        public ValidarNombreResponse()
        {
        }
        
        public ValidarNombreResponse(WsSOAP.ValidarNombreResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://redes")]
    public partial class ValidarNombreResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ValidarNombreReturn;
        
        public ValidarNombreResponseBody()
        {
        }
        
        public ValidarNombreResponseBody(bool ValidarNombreReturn)
        {
            this.ValidarNombreReturn = ValidarNombreReturn;
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
        WsSOAP.VerificadorRutResponse WsSOAP.funciones.VerificadorRut(WsSOAP.VerificadorRutRequest request)
        {
            return base.Channel.VerificadorRut(request);
        }
        
        public string VerificadorRut(string Rut)
        {
            WsSOAP.VerificadorRutRequest inValue = new WsSOAP.VerificadorRutRequest();
            inValue.Body = new WsSOAP.VerificadorRutRequestBody();
            inValue.Body.Rut = Rut;
            WsSOAP.VerificadorRutResponse retVal = ((WsSOAP.funciones)(this)).VerificadorRut(inValue);
            return retVal.Body.VerificadorRutReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.VerificadorRutResponse> WsSOAP.funciones.VerificadorRutAsync(WsSOAP.VerificadorRutRequest request)
        {
            return base.Channel.VerificadorRutAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.VerificadorRutResponse> VerificadorRutAsync(string Rut)
        {
            WsSOAP.VerificadorRutRequest inValue = new WsSOAP.VerificadorRutRequest();
            inValue.Body = new WsSOAP.VerificadorRutRequestBody();
            inValue.Body.Rut = Rut;
            return ((WsSOAP.funciones)(this)).VerificadorRutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.SepararNombreResponse WsSOAP.funciones.SepararNombre(WsSOAP.SepararNombreRequest request)
        {
            return base.Channel.SepararNombre(request);
        }
        
        public string SepararNombre(string Nombre)
        {
            WsSOAP.SepararNombreRequest inValue = new WsSOAP.SepararNombreRequest();
            inValue.Body = new WsSOAP.SepararNombreRequestBody();
            inValue.Body.Nombre = Nombre;
            WsSOAP.SepararNombreResponse retVal = ((WsSOAP.funciones)(this)).SepararNombre(inValue);
            return retVal.Body.SepararNombreReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.SepararNombreResponse> WsSOAP.funciones.SepararNombreAsync(WsSOAP.SepararNombreRequest request)
        {
            return base.Channel.SepararNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.SepararNombreResponse> SepararNombreAsync(string Nombre)
        {
            WsSOAP.SepararNombreRequest inValue = new WsSOAP.SepararNombreRequest();
            inValue.Body = new WsSOAP.SepararNombreRequestBody();
            inValue.Body.Nombre = Nombre;
            return ((WsSOAP.funciones)(this)).SepararNombreAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.DigitoVerificadorResponse WsSOAP.funciones.DigitoVerificador(WsSOAP.DigitoVerificadorRequest request)
        {
            return base.Channel.DigitoVerificador(request);
        }
        
        public string DigitoVerificador(string Rut)
        {
            WsSOAP.DigitoVerificadorRequest inValue = new WsSOAP.DigitoVerificadorRequest();
            inValue.Body = new WsSOAP.DigitoVerificadorRequestBody();
            inValue.Body.Rut = Rut;
            WsSOAP.DigitoVerificadorResponse retVal = ((WsSOAP.funciones)(this)).DigitoVerificador(inValue);
            return retVal.Body.DigitoVerificadorReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.DigitoVerificadorResponse> WsSOAP.funciones.DigitoVerificadorAsync(WsSOAP.DigitoVerificadorRequest request)
        {
            return base.Channel.DigitoVerificadorAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.DigitoVerificadorResponse> DigitoVerificadorAsync(string Rut)
        {
            WsSOAP.DigitoVerificadorRequest inValue = new WsSOAP.DigitoVerificadorRequest();
            inValue.Body = new WsSOAP.DigitoVerificadorRequestBody();
            inValue.Body.Rut = Rut;
            return ((WsSOAP.funciones)(this)).DigitoVerificadorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WsSOAP.ValidarNombreResponse WsSOAP.funciones.ValidarNombre(WsSOAP.ValidarNombreRequest request)
        {
            return base.Channel.ValidarNombre(request);
        }
        
        public bool ValidarNombre(string Nombre)
        {
            WsSOAP.ValidarNombreRequest inValue = new WsSOAP.ValidarNombreRequest();
            inValue.Body = new WsSOAP.ValidarNombreRequestBody();
            inValue.Body.Nombre = Nombre;
            WsSOAP.ValidarNombreResponse retVal = ((WsSOAP.funciones)(this)).ValidarNombre(inValue);
            return retVal.Body.ValidarNombreReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsSOAP.ValidarNombreResponse> WsSOAP.funciones.ValidarNombreAsync(WsSOAP.ValidarNombreRequest request)
        {
            return base.Channel.ValidarNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsSOAP.ValidarNombreResponse> ValidarNombreAsync(string Nombre)
        {
            WsSOAP.ValidarNombreRequest inValue = new WsSOAP.ValidarNombreRequest();
            inValue.Body = new WsSOAP.ValidarNombreRequestBody();
            inValue.Body.Nombre = Nombre;
            return ((WsSOAP.funciones)(this)).ValidarNombreAsync(inValue);
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
