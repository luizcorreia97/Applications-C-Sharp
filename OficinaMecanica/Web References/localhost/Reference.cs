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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace OficinaMecanica.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSOrdemServicoSoap", Namespace="http://tempuri.org/")]
    public partial class WSOrdemServico : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback BuscarOrdemOperationCompleted;
        
        private System.Threading.SendOrPostCallback SalvarOperationCompleted;
        
        private System.Threading.SendOrPostCallback AlterarOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeletarOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarMarcaOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSOrdemServico() {
            this.Url = global::OficinaMecanica.Properties.Settings.Default.OficinaMecanica_localhost_WSOrdemServico;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event BuscarOrdemCompletedEventHandler BuscarOrdemCompleted;
        
        /// <remarks/>
        public event SalvarCompletedEventHandler SalvarCompleted;
        
        /// <remarks/>
        public event AlterarCompletedEventHandler AlterarCompleted;
        
        /// <remarks/>
        public event DeletarCompletedEventHandler DeletarCompleted;
        
        /// <remarks/>
        public event BuscarMarcaCompletedEventHandler BuscarMarcaCompleted;
        
        /// <remarks/>
        public event BuscarStatusCompletedEventHandler BuscarStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarOrdem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable BuscarOrdem() {
            object[] results = this.Invoke("BuscarOrdem", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarOrdemAsync() {
            this.BuscarOrdemAsync(null);
        }
        
        /// <remarks/>
        public void BuscarOrdemAsync(object userState) {
            if ((this.BuscarOrdemOperationCompleted == null)) {
                this.BuscarOrdemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarOrdemOperationCompleted);
            }
            this.InvokeAsync("BuscarOrdem", new object[0], this.BuscarOrdemOperationCompleted, userState);
        }
        
        private void OnBuscarOrdemOperationCompleted(object arg) {
            if ((this.BuscarOrdemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarOrdemCompleted(this, new BuscarOrdemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Salvar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Salvar(Ordem ordem) {
            this.Invoke("Salvar", new object[] {
                        ordem});
        }
        
        /// <remarks/>
        public void SalvarAsync(Ordem ordem) {
            this.SalvarAsync(ordem, null);
        }
        
        /// <remarks/>
        public void SalvarAsync(Ordem ordem, object userState) {
            if ((this.SalvarOperationCompleted == null)) {
                this.SalvarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSalvarOperationCompleted);
            }
            this.InvokeAsync("Salvar", new object[] {
                        ordem}, this.SalvarOperationCompleted, userState);
        }
        
        private void OnSalvarOperationCompleted(object arg) {
            if ((this.SalvarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SalvarCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Alterar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Alterar(Ordem ordem) {
            this.Invoke("Alterar", new object[] {
                        ordem});
        }
        
        /// <remarks/>
        public void AlterarAsync(Ordem ordem) {
            this.AlterarAsync(ordem, null);
        }
        
        /// <remarks/>
        public void AlterarAsync(Ordem ordem, object userState) {
            if ((this.AlterarOperationCompleted == null)) {
                this.AlterarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAlterarOperationCompleted);
            }
            this.InvokeAsync("Alterar", new object[] {
                        ordem}, this.AlterarOperationCompleted, userState);
        }
        
        private void OnAlterarOperationCompleted(object arg) {
            if ((this.AlterarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AlterarCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Deletar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Deletar(int id) {
            this.Invoke("Deletar", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void DeletarAsync(int id) {
            this.DeletarAsync(id, null);
        }
        
        /// <remarks/>
        public void DeletarAsync(int id, object userState) {
            if ((this.DeletarOperationCompleted == null)) {
                this.DeletarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeletarOperationCompleted);
            }
            this.InvokeAsync("Deletar", new object[] {
                        id}, this.DeletarOperationCompleted, userState);
        }
        
        private void OnDeletarOperationCompleted(object arg) {
            if ((this.DeletarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeletarCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarMarca", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable BuscarMarca() {
            object[] results = this.Invoke("BuscarMarca", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarMarcaAsync() {
            this.BuscarMarcaAsync(null);
        }
        
        /// <remarks/>
        public void BuscarMarcaAsync(object userState) {
            if ((this.BuscarMarcaOperationCompleted == null)) {
                this.BuscarMarcaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarMarcaOperationCompleted);
            }
            this.InvokeAsync("BuscarMarca", new object[0], this.BuscarMarcaOperationCompleted, userState);
        }
        
        private void OnBuscarMarcaOperationCompleted(object arg) {
            if ((this.BuscarMarcaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarMarcaCompleted(this, new BuscarMarcaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable BuscarStatus() {
            object[] results = this.Invoke("BuscarStatus", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarStatusAsync() {
            this.BuscarStatusAsync(null);
        }
        
        /// <remarks/>
        public void BuscarStatusAsync(object userState) {
            if ((this.BuscarStatusOperationCompleted == null)) {
                this.BuscarStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarStatusOperationCompleted);
            }
            this.InvokeAsync("BuscarStatus", new object[0], this.BuscarStatusOperationCompleted, userState);
        }
        
        private void OnBuscarStatusOperationCompleted(object arg) {
            if ((this.BuscarStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarStatusCompleted(this, new BuscarStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Ordem {
        
        private int idOrdemField;
        
        private string nomeField;
        
        private string dataAberturaField;
        
        private string dataFinalizacaoField;
        
        private string placaField;
        
        private int idMarcaField;
        
        private string descricaoField;
        
        private int idStatusField;
        
        /// <remarks/>
        public int idOrdem {
            get {
                return this.idOrdemField;
            }
            set {
                this.idOrdemField = value;
            }
        }
        
        /// <remarks/>
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string dataAbertura {
            get {
                return this.dataAberturaField;
            }
            set {
                this.dataAberturaField = value;
            }
        }
        
        /// <remarks/>
        public string dataFinalizacao {
            get {
                return this.dataFinalizacaoField;
            }
            set {
                this.dataFinalizacaoField = value;
            }
        }
        
        /// <remarks/>
        public string placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
            }
        }
        
        /// <remarks/>
        public int idMarca {
            get {
                return this.idMarcaField;
            }
            set {
                this.idMarcaField = value;
            }
        }
        
        /// <remarks/>
        public string descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        public int idStatus {
            get {
                return this.idStatusField;
            }
            set {
                this.idStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void BuscarOrdemCompletedEventHandler(object sender, BuscarOrdemCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarOrdemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarOrdemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void SalvarCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void AlterarCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void DeletarCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void BuscarMarcaCompletedEventHandler(object sender, BuscarMarcaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarMarcaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarMarcaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void BuscarStatusCompletedEventHandler(object sender, BuscarStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591