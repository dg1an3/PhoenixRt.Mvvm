﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PheonixRt.ResampleManagerService.ResampleEngineServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ResampleEngineServiceReference1.IResampleEngine")]
    public interface IResampleEngine {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResampleEngine/ResampleImageVolume", ReplyAction="http://tempuri.org/IResampleEngine/ResampleImageVolumeResponse")]
        PheonixRt.ResampleServiceContracts.ImageVolumeResampleResponse ResampleImageVolume(PheonixRt.ResampleServiceContracts.ImageVolumeResampleRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResampleEngineChannel : PheonixRt.ResampleManagerService.ResampleEngineServiceReference1.IResampleEngine, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResampleEngineClient : System.ServiceModel.ClientBase<PheonixRt.ResampleManagerService.ResampleEngineServiceReference1.IResampleEngine>, PheonixRt.ResampleManagerService.ResampleEngineServiceReference1.IResampleEngine {
        
        public ResampleEngineClient() {
        }
        
        public ResampleEngineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResampleEngineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResampleEngineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResampleEngineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PheonixRt.ResampleServiceContracts.ImageVolumeResampleResponse ResampleImageVolume(PheonixRt.ResampleServiceContracts.ImageVolumeResampleRequest request) {
            return base.Channel.ResampleImageVolume(request);
        }
    }
}