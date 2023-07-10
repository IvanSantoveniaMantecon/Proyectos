﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainPruebas.ReferenciaGestion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaGestion.IGestion")]
    public interface IGestion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/añadirJugador", ReplyAction="http://tempuri.org/IGestion/añadirJugadorResponse")]
        void añadirJugador(Negocio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/añadirJugador", ReplyAction="http://tempuri.org/IGestion/añadirJugadorResponse")]
        System.Threading.Tasks.Task añadirJugadorAsync(Negocio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/verListaJugadores", ReplyAction="http://tempuri.org/IGestion/verListaJugadoresResponse")]
        string verListaJugadores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/verListaJugadores", ReplyAction="http://tempuri.org/IGestion/verListaJugadoresResponse")]
        System.Threading.Tasks.Task<string> verListaJugadoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/bajaJugador", ReplyAction="http://tempuri.org/IGestion/bajaJugadorResponse")]
        void bajaJugador(Negocio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/bajaJugador", ReplyAction="http://tempuri.org/IGestion/bajaJugadorResponse")]
        System.Threading.Tasks.Task bajaJugadorAsync(Negocio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/añadirEquipo", ReplyAction="http://tempuri.org/IGestion/añadirEquipoResponse")]
        void añadirEquipo(Negocio.Equipo equipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/añadirEquipo", ReplyAction="http://tempuri.org/IGestion/añadirEquipoResponse")]
        System.Threading.Tasks.Task añadirEquipoAsync(Negocio.Equipo equipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/bajaEquipo", ReplyAction="http://tempuri.org/IGestion/bajaEquipoResponse")]
        void bajaEquipo(Negocio.Equipo equipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/bajaEquipo", ReplyAction="http://tempuri.org/IGestion/bajaEquipoResponse")]
        System.Threading.Tasks.Task bajaEquipoAsync(Negocio.Equipo equipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/verListaEquipos", ReplyAction="http://tempuri.org/IGestion/verListaEquiposResponse")]
        string verListaEquipos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/verListaEquipos", ReplyAction="http://tempuri.org/IGestion/verListaEquiposResponse")]
        System.Threading.Tasks.Task<string> verListaEquiposAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/verJugadoresEquipo", ReplyAction="http://tempuri.org/IGestion/verJugadoresEquipoResponse")]
        string verJugadoresEquipo(string nombreEquipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/verJugadoresEquipo", ReplyAction="http://tempuri.org/IGestion/verJugadoresEquipoResponse")]
        System.Threading.Tasks.Task<string> verJugadoresEquipoAsync(string nombreEquipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/hacerJsonJugadores", ReplyAction="http://tempuri.org/IGestion/hacerJsonJugadoresResponse")]
        string hacerJsonJugadores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/hacerJsonJugadores", ReplyAction="http://tempuri.org/IGestion/hacerJsonJugadoresResponse")]
        System.Threading.Tasks.Task<string> hacerJsonJugadoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/hacerJsonEquipos", ReplyAction="http://tempuri.org/IGestion/hacerJsonEquiposResponse")]
        string hacerJsonEquipos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/hacerJsonEquipos", ReplyAction="http://tempuri.org/IGestion/hacerJsonEquiposResponse")]
        System.Threading.Tasks.Task<string> hacerJsonEquiposAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/recuperarDatos", ReplyAction="http://tempuri.org/IGestion/recuperarDatosResponse")]
        void recuperarDatos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/recuperarDatos", ReplyAction="http://tempuri.org/IGestion/recuperarDatosResponse")]
        System.Threading.Tasks.Task recuperarDatosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/recuperarDatosEquipos", ReplyAction="http://tempuri.org/IGestion/recuperarDatosEquiposResponse")]
        void recuperarDatosEquipos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestion/recuperarDatosEquipos", ReplyAction="http://tempuri.org/IGestion/recuperarDatosEquiposResponse")]
        System.Threading.Tasks.Task recuperarDatosEquiposAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestionChannel : MainPruebas.ReferenciaGestion.IGestion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestionClient : System.ServiceModel.ClientBase<MainPruebas.ReferenciaGestion.IGestion>, MainPruebas.ReferenciaGestion.IGestion {
        
        public GestionClient() {
        }
        
        public GestionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GestionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void añadirJugador(Negocio.Jugador jugador) {
            base.Channel.añadirJugador(jugador);
        }
        
        public System.Threading.Tasks.Task añadirJugadorAsync(Negocio.Jugador jugador) {
            return base.Channel.añadirJugadorAsync(jugador);
        }
        
        public string verListaJugadores() {
            return base.Channel.verListaJugadores();
        }
        
        public System.Threading.Tasks.Task<string> verListaJugadoresAsync() {
            return base.Channel.verListaJugadoresAsync();
        }
        
        public void bajaJugador(Negocio.Jugador jugador) {
            base.Channel.bajaJugador(jugador);
        }
        
        public System.Threading.Tasks.Task bajaJugadorAsync(Negocio.Jugador jugador) {
            return base.Channel.bajaJugadorAsync(jugador);
        }
        
        public void añadirEquipo(Negocio.Equipo equipo) {
            base.Channel.añadirEquipo(equipo);
        }
        
        public System.Threading.Tasks.Task añadirEquipoAsync(Negocio.Equipo equipo) {
            return base.Channel.añadirEquipoAsync(equipo);
        }
        
        public void bajaEquipo(Negocio.Equipo equipo) {
            base.Channel.bajaEquipo(equipo);
        }
        
        public System.Threading.Tasks.Task bajaEquipoAsync(Negocio.Equipo equipo) {
            return base.Channel.bajaEquipoAsync(equipo);
        }
        
        public string verListaEquipos() {
            return base.Channel.verListaEquipos();
        }
        
        public System.Threading.Tasks.Task<string> verListaEquiposAsync() {
            return base.Channel.verListaEquiposAsync();
        }
        
        public string verJugadoresEquipo(string nombreEquipo) {
            return base.Channel.verJugadoresEquipo(nombreEquipo);
        }
        
        public System.Threading.Tasks.Task<string> verJugadoresEquipoAsync(string nombreEquipo) {
            return base.Channel.verJugadoresEquipoAsync(nombreEquipo);
        }
        
        public string hacerJsonJugadores() {
            return base.Channel.hacerJsonJugadores();
        }
        
        public System.Threading.Tasks.Task<string> hacerJsonJugadoresAsync() {
            return base.Channel.hacerJsonJugadoresAsync();
        }
        
        public string hacerJsonEquipos() {
            return base.Channel.hacerJsonEquipos();
        }
        
        public System.Threading.Tasks.Task<string> hacerJsonEquiposAsync() {
            return base.Channel.hacerJsonEquiposAsync();
        }
        
        public void recuperarDatos() {
            base.Channel.recuperarDatos();
        }
        
        public System.Threading.Tasks.Task recuperarDatosAsync() {
            return base.Channel.recuperarDatosAsync();
        }
        
        public void recuperarDatosEquipos() {
            base.Channel.recuperarDatosEquipos();
        }
        
        public System.Threading.Tasks.Task recuperarDatosEquiposAsync() {
            return base.Channel.recuperarDatosEquiposAsync();
        }
    }
}