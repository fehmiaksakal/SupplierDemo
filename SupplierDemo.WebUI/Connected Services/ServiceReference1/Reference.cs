﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupplierDemo.WebUI.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStocks", ReplyAction="http://tempuri.org/IService1/GetStocksResponse")]
        SupplierDemo.StockServices.Model.MainVM GetStocks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStocks", ReplyAction="http://tempuri.org/IService1/GetStocksResponse")]
        System.Threading.Tasks.Task<SupplierDemo.StockServices.Model.MainVM> GetStocksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOnlyStock", ReplyAction="http://tempuri.org/IService1/GetOnlyStockResponse")]
        System.Collections.Generic.List<SupplierDemo.StockServices.Model.StockVM> GetOnlyStock();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOnlyStock", ReplyAction="http://tempuri.org/IService1/GetOnlyStockResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SupplierDemo.StockServices.Model.StockVM>> GetOnlyStockAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SupplierDemo.WebUI.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SupplierDemo.WebUI.ServiceReference1.IService1>, SupplierDemo.WebUI.ServiceReference1.IService1 {
        
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
        
        public SupplierDemo.StockServices.Model.MainVM GetStocks() {
            return base.Channel.GetStocks();
        }
        
        public System.Threading.Tasks.Task<SupplierDemo.StockServices.Model.MainVM> GetStocksAsync() {
            return base.Channel.GetStocksAsync();
        }
        
        public System.Collections.Generic.List<SupplierDemo.StockServices.Model.StockVM> GetOnlyStock() {
            return base.Channel.GetOnlyStock();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SupplierDemo.StockServices.Model.StockVM>> GetOnlyStockAsync() {
            return base.Channel.GetOnlyStockAsync();
        }
    }
}
