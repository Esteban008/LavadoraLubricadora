﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LavadoraLubricadora.LavadoraService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aceite", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer")]
    [System.SerializableAttribute()]
    public partial class Aceite : LavadoraLubricadora.LavadoraService.Producto {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PresentacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoAceiteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoCombustibleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Api {
            get {
                return this.ApiField;
            }
            set {
                if ((object.ReferenceEquals(this.ApiField, value) != true)) {
                    this.ApiField = value;
                    this.RaisePropertyChanged("Api");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Presentacion {
            get {
                return this.PresentacionField;
            }
            set {
                if ((object.ReferenceEquals(this.PresentacionField, value) != true)) {
                    this.PresentacionField = value;
                    this.RaisePropertyChanged("Presentacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sae {
            get {
                return this.SaeField;
            }
            set {
                if ((object.ReferenceEquals(this.SaeField, value) != true)) {
                    this.SaeField = value;
                    this.RaisePropertyChanged("Sae");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoAceite {
            get {
                return this.TipoAceiteField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoAceiteField, value) != true)) {
                    this.TipoAceiteField = value;
                    this.RaisePropertyChanged("TipoAceite");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoCombustible {
            get {
                return this.TipoCombustibleField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoCombustibleField, value) != true)) {
                    this.TipoCombustibleField = value;
                    this.RaisePropertyChanged("TipoCombustible");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LavadoraLubricadora.LavadoraService.Aceite))]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadMinimaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoBarrasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioCompraConIvaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioCompraSinIvaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioMargenxMayorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioMargenxMenorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioVentaxMayorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioVentaxMenorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadMinima {
            get {
                return this.CantidadMinimaField;
            }
            set {
                if ((this.CantidadMinimaField.Equals(value) != true)) {
                    this.CantidadMinimaField = value;
                    this.RaisePropertyChanged("CantidadMinima");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoBarras {
            get {
                return this.CodigoBarrasField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoBarrasField, value) != true)) {
                    this.CodigoBarrasField = value;
                    this.RaisePropertyChanged("CodigoBarras");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecioCompraConIva {
            get {
                return this.PrecioCompraConIvaField;
            }
            set {
                if ((this.PrecioCompraConIvaField.Equals(value) != true)) {
                    this.PrecioCompraConIvaField = value;
                    this.RaisePropertyChanged("PrecioCompraConIva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecioCompraSinIva {
            get {
                return this.PrecioCompraSinIvaField;
            }
            set {
                if ((this.PrecioCompraSinIvaField.Equals(value) != true)) {
                    this.PrecioCompraSinIvaField = value;
                    this.RaisePropertyChanged("PrecioCompraSinIva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecioMargenxMayor {
            get {
                return this.PrecioMargenxMayorField;
            }
            set {
                if ((this.PrecioMargenxMayorField.Equals(value) != true)) {
                    this.PrecioMargenxMayorField = value;
                    this.RaisePropertyChanged("PrecioMargenxMayor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecioMargenxMenor {
            get {
                return this.PrecioMargenxMenorField;
            }
            set {
                if ((this.PrecioMargenxMenorField.Equals(value) != true)) {
                    this.PrecioMargenxMenorField = value;
                    this.RaisePropertyChanged("PrecioMargenxMenor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecioVentaxMayor {
            get {
                return this.PrecioVentaxMayorField;
            }
            set {
                if ((this.PrecioVentaxMayorField.Equals(value) != true)) {
                    this.PrecioVentaxMayorField = value;
                    this.RaisePropertyChanged("PrecioVentaxMayor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PrecioVentaxMenor {
            get {
                return this.PrecioVentaxMenorField;
            }
            set {
                if ((this.PrecioVentaxMenorField.Equals(value) != true)) {
                    this.PrecioVentaxMenorField = value;
                    this.RaisePropertyChanged("PrecioVentaxMenor");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LavadoraService.ILavadoraService")]
    public interface ILavadoraService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILavadoraService/GetAceite", ReplyAction="http://tempuri.org/ILavadoraService/GetAceiteResponse")]
        LavadoraLubricadora.LavadoraService.Aceite[] GetAceite();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILavadoraService/GetAceite", ReplyAction="http://tempuri.org/ILavadoraService/GetAceiteResponse")]
        System.Threading.Tasks.Task<LavadoraLubricadora.LavadoraService.Aceite[]> GetAceiteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILavadoraService/GetProducto", ReplyAction="http://tempuri.org/ILavadoraService/GetProductoResponse")]
        LavadoraLubricadora.LavadoraService.Producto GetProducto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILavadoraService/GetProducto", ReplyAction="http://tempuri.org/ILavadoraService/GetProductoResponse")]
        System.Threading.Tasks.Task<LavadoraLubricadora.LavadoraService.Producto> GetProductoAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILavadoraServiceChannel : LavadoraLubricadora.LavadoraService.ILavadoraService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LavadoraServiceClient : System.ServiceModel.ClientBase<LavadoraLubricadora.LavadoraService.ILavadoraService>, LavadoraLubricadora.LavadoraService.ILavadoraService {
        
        public LavadoraServiceClient() {
        }
        
        public LavadoraServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LavadoraServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LavadoraServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LavadoraServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LavadoraLubricadora.LavadoraService.Aceite[] GetAceite() {
            return base.Channel.GetAceite();
        }
        
        public System.Threading.Tasks.Task<LavadoraLubricadora.LavadoraService.Aceite[]> GetAceiteAsync() {
            return base.Channel.GetAceiteAsync();
        }
        
        public LavadoraLubricadora.LavadoraService.Producto GetProducto(int id) {
            return base.Channel.GetProducto(id);
        }
        
        public System.Threading.Tasks.Task<LavadoraLubricadora.LavadoraService.Producto> GetProductoAsync(int id) {
            return base.Channel.GetProductoAsync(id);
        }
    }
}
