﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DicomLoaderManager.LocalImageResourceServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocalImageResourceServiceReference1.ILocalImageResourceManager")]
    public interface ILocalImageResourceManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetImageResourceIds", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetImageResourceIdsResponse")]
        System.Collections.Generic.List<System.Guid> GetImageResourceIds(string patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetImageIdsBySeries", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetImageIdsBySeriesResponse")]
        System.Collections.Generic.List<System.Guid> GetImageIdsBySeries(string seriesInstanceUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetImage", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetImageResponse")]
        PheonixRt.DataContracts.ImageDataContract GetImage(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/AddImage", ReplyAction="http://tempuri.org/ILocalImageResourceManager/AddImageResponse")]
        PheonixRt.DataContracts.ImageDataContract AddImage(PheonixRt.DataContracts.ImageDataContract idc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/RemoveImage", ReplyAction="http://tempuri.org/ILocalImageResourceManager/RemoveImageResponse")]
        void RemoveImage(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetImageVolumeResourceIds", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetImageVolumeResourceIdsResponse")]
        System.Collections.Generic.List<System.Guid> GetImageVolumeResourceIds(string patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetImageVolume", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetImageVolumeResponse")]
        PheonixRt.DataContracts.UniformImageVolumeDataContract GetImageVolume(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetImageVolumeBySeriesInstanceUID", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetImageVolumeBySeriesInstanceUIDRe" +
            "sponse")]
        PheonixRt.DataContracts.UniformImageVolumeDataContract GetImageVolumeBySeriesInstanceUID(string seriesInstanceUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/AddImageVolume", ReplyAction="http://tempuri.org/ILocalImageResourceManager/AddImageVolumeResponse")]
        PheonixRt.DataContracts.UniformImageVolumeDataContract AddImageVolume(PheonixRt.DataContracts.UniformImageVolumeDataContract idc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/RemoveImageVolume", ReplyAction="http://tempuri.org/ILocalImageResourceManager/RemoveImageVolumeResponse")]
        void RemoveImageVolume(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetPatientIds", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetPatientIdsResponse")]
        System.Collections.Generic.List<string> GetPatientIds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalImageResourceManager/GetRepositorySizeGB", ReplyAction="http://tempuri.org/ILocalImageResourceManager/GetRepositorySizeGBResponse")]
        double GetRepositorySizeGB();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ILocalImageResourceManager/PrefetchBuffer")]
        void PrefetchBuffer(PheonixRt.DataContracts.SharedBuffer sb);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ILocalImageResourceManager/ClearPrefetchStack")]
        void ClearPrefetchStack();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILocalImageResourceManagerChannel : DicomLoaderManager.LocalImageResourceServiceReference1.ILocalImageResourceManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LocalImageResourceManagerClient : System.ServiceModel.ClientBase<DicomLoaderManager.LocalImageResourceServiceReference1.ILocalImageResourceManager>, DicomLoaderManager.LocalImageResourceServiceReference1.ILocalImageResourceManager {
        
        public LocalImageResourceManagerClient() {
        }
        
        public LocalImageResourceManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LocalImageResourceManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocalImageResourceManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocalImageResourceManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<System.Guid> GetImageResourceIds(string patientId) {
            return base.Channel.GetImageResourceIds(patientId);
        }
        
        public System.Collections.Generic.List<System.Guid> GetImageIdsBySeries(string seriesInstanceUID) {
            return base.Channel.GetImageIdsBySeries(seriesInstanceUID);
        }
        
        public PheonixRt.DataContracts.ImageDataContract GetImage(System.Guid id) {
            return base.Channel.GetImage(id);
        }
        
        public PheonixRt.DataContracts.ImageDataContract AddImage(PheonixRt.DataContracts.ImageDataContract idc) {
            return base.Channel.AddImage(idc);
        }
        
        public void RemoveImage(System.Guid guid) {
            base.Channel.RemoveImage(guid);
        }
        
        public System.Collections.Generic.List<System.Guid> GetImageVolumeResourceIds(string patientId) {
            return base.Channel.GetImageVolumeResourceIds(patientId);
        }
        
        public PheonixRt.DataContracts.UniformImageVolumeDataContract GetImageVolume(System.Guid id) {
            return base.Channel.GetImageVolume(id);
        }
        
        public PheonixRt.DataContracts.UniformImageVolumeDataContract GetImageVolumeBySeriesInstanceUID(string seriesInstanceUID) {
            return base.Channel.GetImageVolumeBySeriesInstanceUID(seriesInstanceUID);
        }
        
        public PheonixRt.DataContracts.UniformImageVolumeDataContract AddImageVolume(PheonixRt.DataContracts.UniformImageVolumeDataContract idc) {
            return base.Channel.AddImageVolume(idc);
        }
        
        public void RemoveImageVolume(System.Guid guid) {
            base.Channel.RemoveImageVolume(guid);
        }
        
        public System.Collections.Generic.List<string> GetPatientIds() {
            return base.Channel.GetPatientIds();
        }
        
        public double GetRepositorySizeGB() {
            return base.Channel.GetRepositorySizeGB();
        }
        
        public void PrefetchBuffer(PheonixRt.DataContracts.SharedBuffer sb) {
            base.Channel.PrefetchBuffer(sb);
        }
        
        public void ClearPrefetchStack() {
            base.Channel.ClearPrefetchStack();
        }
    }
}
