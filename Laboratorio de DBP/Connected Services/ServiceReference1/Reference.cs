﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio_de_DBP.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGet")]
    public interface IGet {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/getciudades", ReplyAction="http://tempuri.org/IGet/getciudadesResponse")]
        string[] getciudades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/getciudades", ReplyAction="http://tempuri.org/IGet/getciudadesResponse")]
        System.Threading.Tasks.Task<string[]> getciudadesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetChannel : Laboratorio_de_DBP.ServiceReference1.IGet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetClient : System.ServiceModel.ClientBase<Laboratorio_de_DBP.ServiceReference1.IGet>, Laboratorio_de_DBP.ServiceReference1.IGet {
        
        public GetClient() {
        }
        
        public GetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getciudades() {
            return base.Channel.getciudades();
        }
        
        public System.Threading.Tasks.Task<string[]> getciudadesAsync() {
            return base.Channel.getciudadesAsync();
        }
    }
}
