﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReadWriteExcel.DbNModels
{
    public partial class ELAVONTESTContext : DbContext
    {
        public ELAVONTESTContext()
        {
        }

        public ELAVONTESTContext(DbContextOptions<ELAVONTESTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BdActasAdmin> BdActasAdmin { get; set; }
        public virtual DbSet<BdAjustesInsumosPaso> BdAjustesInsumosPaso { get; set; }
        public virtual DbSet<BdAltaFecGarantia> BdAltaFecGarantia { get; set; }
        public virtual DbSet<BdAltaMasivaUnidadCa> BdAltaMasivaUnidadCa { get; set; }
        public virtual DbSet<BdAr> BdAr { get; set; }
        public virtual DbSet<BdArAccesorios> BdArAccesorios { get; set; }
        public virtual DbSet<BdArArchivosVarios> BdArArchivosVarios { get; set; }
        public virtual DbSet<BdArCausasCancelacion> BdArCausasCancelacion { get; set; }
        public virtual DbSet<BdArDatosComerciosExtra> BdArDatosComerciosExtra { get; set; }
        public virtual DbSet<BdArDesviacion> BdArDesviacion { get; set; }
        public virtual DbSet<BdArDiasAtencion> BdArDiasAtencion { get; set; }
        public virtual DbSet<BdArExtension> BdArExtension { get; set; }
        public virtual DbSet<BdArFecGarantia> BdArFecGarantia { get; set; }
        public virtual DbSet<BdArInsumo> BdArInsumo { get; set; }
        public virtual DbSet<BdArLogWs> BdArLogWs { get; set; }
        public virtual DbSet<BdArPrefacturacion> BdArPrefacturacion { get; set; }
        public virtual DbSet<BdArSparePart> BdArSparePart { get; set; }
        public virtual DbSet<BdArTerminalAsociadaAmex> BdArTerminalAsociadaAmex { get; set; }
        public virtual DbSet<BdArViatico> BdArViatico { get; set; }
        public virtual DbSet<BdArViaticoMotivo> BdArViaticoMotivo { get; set; }
        public virtual DbSet<BdArVisitas> BdArVisitas { get; set; }
        public virtual DbSet<BdArchivoDispersionSolicitudViaticos> BdArchivoDispersionSolicitudViaticos { get; set; }
        public virtual DbSet<BdArchivosConfirmaciones> BdArchivosConfirmaciones { get; set; }
        public virtual DbSet<BdArchivosDispersion> BdArchivosDispersion { get; set; }
        public virtual DbSet<BdArchivosPrefacturacion> BdArchivosPrefacturacion { get; set; }
        public virtual DbSet<BdAsignacionAutomaticaPaso> BdAsignacionAutomaticaPaso { get; set; }
        public virtual DbSet<BdAttach> BdAttach { get; set; }
        public virtual DbSet<BdAttachAcciones> BdAttachAcciones { get; set; }
        public virtual DbSet<BdAttachDhl> BdAttachDhl { get; set; }
        public virtual DbSet<BdAuditoriaReporte> BdAuditoriaReporte { get; set; }
        public virtual DbSet<BdAuditorias> BdAuditorias { get; set; }
        public virtual DbSet<BdBbvaPaso> BdBbvaPaso { get; set; }
        public virtual DbSet<BdBitacoraAcceso> BdBitacoraAcceso { get; set; }
        public virtual DbSet<BdBitacoraAgendados> BdBitacoraAgendados { get; set; }
        public virtual DbSet<BdBitacoraAlmacenResponsable> BdBitacoraAlmacenResponsable { get; set; }
        public virtual DbSet<BdBitacoraAlmacenStatus> BdBitacoraAlmacenStatus { get; set; }
        public virtual DbSet<BdBitacoraAplicativoUnidad> BdBitacoraAplicativoUnidad { get; set; }
        public virtual DbSet<BdBitacoraAr> BdBitacoraAr { get; set; }
        public virtual DbSet<BdBitacoraArAlta> BdBitacoraArAlta { get; set; }
        public virtual DbSet<BdBitacoraBorrarUnidad> BdBitacoraBorrarUnidad { get; set; }
        public virtual DbSet<BdBitacoraCambioMensajeria> BdBitacoraCambioMensajeria { get; set; }
        public virtual DbSet<BdBitacoraCambioNoInventario> BdBitacoraCambioNoInventario { get; set; }
        public virtual DbSet<BdBitacoraCambioSerie> BdBitacoraCambioSerie { get; set; }
        public virtual DbSet<BdBitacoraCambioUnidadNueva> BdBitacoraCambioUnidadNueva { get; set; }
        public virtual DbSet<BdBitacoraCompromisos> BdBitacoraCompromisos { get; set; }
        public virtual DbSet<BdBitacoraConectividadUnidad> BdBitacoraConectividadUnidad { get; set; }
        public virtual DbSet<BdBitacoraDiagnostico> BdBitacoraDiagnostico { get; set; }
        public virtual DbSet<BdBitacoraDoctosPrefacturacion> BdBitacoraDoctosPrefacturacion { get; set; }
        public virtual DbSet<BdBitacoraEnvio> BdBitacoraEnvio { get; set; }
        public virtual DbSet<BdBitacoraIgualas> BdBitacoraIgualas { get; set; }
        public virtual DbSet<BdBitacoraInsumos> BdBitacoraInsumos { get; set; }
        public virtual DbSet<BdBitacoraItemsBorrados> BdBitacoraItemsBorrados { get; set; }
        public virtual DbSet<BdBitacoraItemsSolicitudAlmacen> BdBitacoraItemsSolicitudAlmacen { get; set; }
        public virtual DbSet<BdBitacoraJobs> BdBitacoraJobs { get; set; }
        public virtual DbSet<BdBitacoraModeloUnidad> BdBitacoraModeloUnidad { get; set; }
        public virtual DbSet<BdBitacoraMovimientosRetornosInsumos> BdBitacoraMovimientosRetornosInsumos { get; set; }
        public virtual DbSet<BdBitacoraNoInsumoAr> BdBitacoraNoInsumoAr { get; set; }
        public virtual DbSet<BdBitacoraPropiedadCliente> BdBitacoraPropiedadCliente { get; set; }
        public virtual DbSet<BdBitacoraReasignacionTecnicos> BdBitacoraReasignacionTecnicos { get; set; }
        public virtual DbSet<BdBitacoraRechazosEnvios> BdBitacoraRechazosEnvios { get; set; }
        public virtual DbSet<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucion { get; set; }
        public virtual DbSet<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccion { get; set; }
        public virtual DbSet<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacen { get; set; }
        public virtual DbSet<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticos { get; set; }
        public virtual DbSet<BdBitacoraStatusTipoUsuario> BdBitacoraStatusTipoUsuario { get; set; }
        public virtual DbSet<BdBitacoraTransferencias> BdBitacoraTransferencias { get; set; }
        public virtual DbSet<BdBitacoraUnidad> BdBitacoraUnidad { get; set; }
        public virtual DbSet<BdBitacoraUnidadDanada> BdBitacoraUnidadDanada { get; set; }
        public virtual DbSet<BdBitacoraUnidadesFaltantesRecibo> BdBitacoraUnidadesFaltantesRecibo { get; set; }
        public virtual DbSet<BdBitacoraUsuariosActivos> BdBitacoraUsuariosActivos { get; set; }
        public virtual DbSet<BdBitacoraValidacionDevoluciones> BdBitacoraValidacionDevoluciones { get; set; }
        public virtual DbSet<BdBitacoraValidacionPrefacturacion> BdBitacoraValidacionPrefacturacion { get; set; }
        public virtual DbSet<BdBloqueos> BdBloqueos { get; set; }
        public virtual DbSet<BdBloqueosPaso> BdBloqueosPaso { get; set; }
        public virtual DbSet<BdCallCenterQ1> BdCallCenterQ1 { get; set; }
        public virtual DbSet<BdCallCenterSeguimiento> BdCallCenterSeguimiento { get; set; }
        public virtual DbSet<BdCallcenterRQ1> BdCallcenterRQ1 { get; set; }
        public virtual DbSet<BdCallcenterRQ10> BdCallcenterRQ10 { get; set; }
        public virtual DbSet<BdCallcenterRQ11> BdCallcenterRQ11 { get; set; }
        public virtual DbSet<BdCallcenterRQ12> BdCallcenterRQ12 { get; set; }
        public virtual DbSet<BdCallcenterRQ13> BdCallcenterRQ13 { get; set; }
        public virtual DbSet<BdCallcenterRQ14> BdCallcenterRQ14 { get; set; }
        public virtual DbSet<BdCallcenterRQ2> BdCallcenterRQ2 { get; set; }
        public virtual DbSet<BdCallcenterRQ3> BdCallcenterRQ3 { get; set; }
        public virtual DbSet<BdCallcenterRQ4> BdCallcenterRQ4 { get; set; }
        public virtual DbSet<BdCallcenterRQ5> BdCallcenterRQ5 { get; set; }
        public virtual DbSet<BdCallcenterRQ6> BdCallcenterRQ6 { get; set; }
        public virtual DbSet<BdCallcenterRQ7> BdCallcenterRQ7 { get; set; }
        public virtual DbSet<BdCallcenterRQ8> BdCallcenterRQ8 { get; set; }
        public virtual DbSet<BdCallcenterRQ9> BdCallcenterRQ9 { get; set; }
        public virtual DbSet<BdCambioStatusAr> BdCambioStatusAr { get; set; }
        public virtual DbSet<BdCambiosEstatusPermititdosUnidades> BdCambiosEstatusPermititdosUnidades { get; set; }
        public virtual DbSet<BdCargaChangeStatus> BdCargaChangeStatus { get; set; }
        public virtual DbSet<BdCargaEnviosDhlErrores> BdCargaEnviosDhlErrores { get; set; }
        public virtual DbSet<BdCargaEnviosDhlPaso> BdCargaEnviosDhlPaso { get; set; }
        public virtual DbSet<BdCargaEnviosEstafetaPaso> BdCargaEnviosEstafetaPaso { get; set; }
        public virtual DbSet<BdCargaUnidadNoInventario> BdCargaUnidadNoInventario { get; set; }
        public virtual DbSet<BdCargas> BdCargas { get; set; }
        public virtual DbSet<BdCargasConfirmaciones> BdCargasConfirmaciones { get; set; }
        public virtual DbSet<BdCargasEquipo> BdCargasEquipo { get; set; }
        public virtual DbSet<BdCargasMasivas> BdCargasMasivas { get; set; }
        public virtual DbSet<BdCargasOdtElavon> BdCargasOdtElavon { get; set; }
        public virtual DbSet<BdChangeMassiveStatus> BdChangeMassiveStatus { get; set; }
        public virtual DbSet<BdChangeStatusArPaso> BdChangeStatusArPaso { get; set; }
        public virtual DbSet<BdClaveEstado> BdClaveEstado { get; set; }
        public virtual DbSet<BdClienteModelo> BdClienteModelo { get; set; }
        public virtual DbSet<BdClienteModeloCambioStatusUnidad> BdClienteModeloCambioStatusUnidad { get; set; }
        public virtual DbSet<BdClienteProductoStatusAr> BdClienteProductoStatusAr { get; set; }
        public virtual DbSet<BdClienteWeekhour> BdClienteWeekhour { get; set; }
        public virtual DbSet<BdComentarioAr> BdComentarioAr { get; set; }
        public virtual DbSet<BdComprobacionSolicitudesViaticos> BdComprobacionSolicitudesViaticos { get; set; }
        public virtual DbSet<BdComprobacionViaticos> BdComprobacionViaticos { get; set; }
        public virtual DbSet<BdComprobacionViaticos2> BdComprobacionViaticos2 { get; set; }
        public virtual DbSet<BdCompromisoBlog> BdCompromisoBlog { get; set; }
        public virtual DbSet<BdCompromisoResponsable> BdCompromisoResponsable { get; set; }
        public virtual DbSet<BdCompromisos> BdCompromisos { get; set; }
        public virtual DbSet<BdCompromisosAcciones> BdCompromisosAcciones { get; set; }
        public virtual DbSet<BdCompromisosCompromiso> BdCompromisosCompromiso { get; set; }
        public virtual DbSet<BdConfiguracionMensajeria> BdConfiguracionMensajeria { get; set; }
        public virtual DbSet<BdConfirmaciones> BdConfirmaciones { get; set; }
        public virtual DbSet<BdConfirmacionesIntermedia> BdConfirmacionesIntermedia { get; set; }
        public virtual DbSet<BdConjuntoModeloConectividad> BdConjuntoModeloConectividad { get; set; }
        public virtual DbSet<BdConsumiblesUnidad> BdConsumiblesUnidad { get; set; }
        public virtual DbSet<BdControlAlertasAr> BdControlAlertasAr { get; set; }
        public virtual DbSet<BdControlInsumos> BdControlInsumos { get; set; }
        public virtual DbSet<BdControlInsumosDetalle> BdControlInsumosDetalle { get; set; }
        public virtual DbSet<BdControlInsumosEnvios> BdControlInsumosEnvios { get; set; }
        public virtual DbSet<BdControlKitTecnico> BdControlKitTecnico { get; set; }
        public virtual DbSet<BdControlMasivoDevoluciones> BdControlMasivoDevoluciones { get; set; }
        public virtual DbSet<BdCotizaciones3m> BdCotizaciones3m { get; set; }
        public virtual DbSet<BdCotizaciones3mDet> BdCotizaciones3mDet { get; set; }
        public virtual DbSet<BdCpAsignacionAutomatica> BdCpAsignacionAutomatica { get; set; }
        public virtual DbSet<BdCuentasBancarias> BdCuentasBancarias { get; set; }
        public virtual DbSet<BdCursos> BdCursos { get; set; }
        public virtual DbSet<BdCursosAsignados> BdCursosAsignados { get; set; }
        public virtual DbSet<BdDbBackup> BdDbBackup { get; set; }
        public virtual DbSet<BdDevoluciones> BdDevoluciones { get; set; }
        public virtual DbSet<BdDirecciones> BdDirecciones { get; set; }
        public virtual DbSet<BdDireccionesRelaciones> BdDireccionesRelaciones { get; set; }
        public virtual DbSet<BdElavonDispatches> BdElavonDispatches { get; set; }
        public virtual DbSet<BdElavonRecoveries> BdElavonRecoveries { get; set; }
        public virtual DbSet<BdEmails> BdEmails { get; set; }
        public virtual DbSet<BdEmails2> BdEmails2 { get; set; }
        public virtual DbSet<BdEnvioDoctosDocto> BdEnvioDoctosDocto { get; set; }
        public virtual DbSet<BdEnvioElavon> BdEnvioElavon { get; set; }
        public virtual DbSet<BdEnvioInsumos> BdEnvioInsumos { get; set; }
        public virtual DbSet<BdEnvioSims> BdEnvioSims { get; set; }
        public virtual DbSet<BdEnvioUnidad> BdEnvioUnidad { get; set; }
        public virtual DbSet<BdEnvios> BdEnvios { get; set; }
        public virtual DbSet<BdEnviosDoctos> BdEnviosDoctos { get; set; }
        public virtual DbSet<BdEquivaleciasModelo> BdEquivaleciasModelo { get; set; }
        public virtual DbSet<BdEquivalenciaEstado> BdEquivalenciaEstado { get; set; }
        public virtual DbSet<BdEspecificacionCausaRechazo> BdEspecificacionCausaRechazo { get; set; }
        public virtual DbSet<BdEspecificacionTipoFalla> BdEspecificacionTipoFalla { get; set; }
        public virtual DbSet<BdEtiquetaInformacionUnidadCliente> BdEtiquetaInformacionUnidadCliente { get; set; }
        public virtual DbSet<BdExistenciasConsumiblesTecnicos> BdExistenciasConsumiblesTecnicos { get; set; }
        public virtual DbSet<BdExtravioPorMensajeriaCargaPdf> BdExtravioPorMensajeriaCargaPdf { get; set; }
        public virtual DbSet<BdFallaConFallaEncontrada> BdFallaConFallaEncontrada { get; set; }
        public virtual DbSet<BdFallaEspecificaTipoFalla> BdFallaEspecificaTipoFalla { get; set; }
        public virtual DbSet<BdFestivos> BdFestivos { get; set; }
        public virtual DbSet<BdFotoAr> BdFotoAr { get; set; }
        public virtual DbSet<BdGarantiaAlmacen> BdGarantiaAlmacen { get; set; }
        public virtual DbSet<BdGastosOperacion> BdGastosOperacion { get; set; }
        public virtual DbSet<BdGruposClientes> BdGruposClientes { get; set; }
        public virtual DbSet<BdHistoricoPassword> BdHistoricoPassword { get; set; }
        public virtual DbSet<BdHorarioHorasMes> BdHorarioHorasMes { get; set; }
        public virtual DbSet<BdHorarioWeekhour> BdHorarioWeekhour { get; set; }
        public virtual DbSet<BdIgualas> BdIgualas { get; set; }
        public virtual DbSet<BdIgualasAlta> BdIgualasAlta { get; set; }
        public virtual DbSet<BdInformacionUnidadAr> BdInformacionUnidadAr { get; set; }
        public virtual DbSet<BdIngresoArchivoInsumos> BdIngresoArchivoInsumos { get; set; }
        public virtual DbSet<BdIngresoArchivosAlmacen> BdIngresoArchivosAlmacen { get; set; }
        public virtual DbSet<BdIngresoArchivosAsignacion> BdIngresoArchivosAsignacion { get; set; }
        public virtual DbSet<BdIngresoArchivosExito> BdIngresoArchivosExito { get; set; }
        public virtual DbSet<BdIngresoArchivosRechazo> BdIngresoArchivosRechazo { get; set; }
        public virtual DbSet<BdInstalaciones> BdInstalaciones { get; set; }
        public virtual DbSet<BdInsumos> BdInsumos { get; set; }
        public virtual DbSet<BdInsumosAlta> BdInsumosAlta { get; set; }
        public virtual DbSet<BdItemsSolicitudAlmacen> BdItemsSolicitudAlmacen { get; set; }
        public virtual DbSet<BdKitInsumos> BdKitInsumos { get; set; }
        public virtual DbSet<BdLoadFilterDhl> BdLoadFilterDhl { get; set; }
        public virtual DbSet<BdLoadFilterEstafeta> BdLoadFilterEstafeta { get; set; }
        public virtual DbSet<BdLogErroresEmailSolicitudes> BdLogErroresEmailSolicitudes { get; set; }
        public virtual DbSet<BdLoginUsers> BdLoginUsers { get; set; }
        public virtual DbSet<BdLogroBlog> BdLogroBlog { get; set; }
        public virtual DbSet<BdLogros> BdLogros { get; set; }
        public virtual DbSet<BdLogrosResponsables> BdLogrosResponsables { get; set; }
        public virtual DbSet<BdMcSims> BdMcSims { get; set; }
        public virtual DbSet<BdMcViaGeozonaCoordenadas> BdMcViaGeozonaCoordenadas { get; set; }
        public virtual DbSet<BdMcViaGeozonaCoordenadasZona> BdMcViaGeozonaCoordenadasZona { get; set; }
        public virtual DbSet<BdMcViaGeozonaTecnico> BdMcViaGeozonaTecnico { get; set; }
        public virtual DbSet<BdMenu> BdMenu { get; set; }
        public virtual DbSet<BdMenuTipoUsuario> BdMenuTipoUsuario { get; set; }
        public virtual DbSet<BdModeloAccesorio> BdModeloAccesorio { get; set; }
        public virtual DbSet<BdModeloCategoria> BdModeloCategoria { get; set; }
        public virtual DbSet<BdModeloCelular> BdModeloCelular { get; set; }
        public virtual DbSet<BdModeloConectividad> BdModeloConectividad { get; set; }
        public virtual DbSet<BdModeloInsumo> BdModeloInsumo { get; set; }
        public virtual DbSet<BdModeloLlave> BdModeloLlave { get; set; }
        public virtual DbSet<BdModeloModulo> BdModeloModulo { get; set; }
        public virtual DbSet<BdModeloPrecio> BdModeloPrecio { get; set; }
        public virtual DbSet<BdModeloServicio> BdModeloServicio { get; set; }
        public virtual DbSet<BdModeloSku> BdModeloSku { get; set; }
        public virtual DbSet<BdModeloSoftware> BdModeloSoftware { get; set; }
        public virtual DbSet<BdModeloSparePart> BdModeloSparePart { get; set; }
        public virtual DbSet<BdModeloSustituto> BdModeloSustituto { get; set; }
        public virtual DbSet<BdNegocioHorasMes> BdNegocioHorasMes { get; set; }
        public virtual DbSet<BdNegocios> BdNegocios { get; set; }
        public virtual DbSet<BdNegociosAlta> BdNegociosAlta { get; set; }
        public virtual DbSet<BdNegociosServiciosDobles> BdNegociosServiciosDobles { get; set; }
        public virtual DbSet<BdOnbaseInbox> BdOnbaseInbox { get; set; }
        public virtual DbSet<BdOnbaseInboxConfirmacion> BdOnbaseInboxConfirmacion { get; set; }
        public virtual DbSet<BdOrdenCompra> BdOrdenCompra { get; set; }
        public virtual DbSet<BdOrdenCompraInsumos> BdOrdenCompraInsumos { get; set; }
        public virtual DbSet<BdOrdenCompraNoFactura> BdOrdenCompraNoFactura { get; set; }
        public virtual DbSet<BdOrdenCompraUnidades> BdOrdenCompraUnidades { get; set; }
        public virtual DbSet<BdOrdenCompraVendedor> BdOrdenCompraVendedor { get; set; }
        public virtual DbSet<BdPaseListaTecnico> BdPaseListaTecnico { get; set; }
        public virtual DbSet<BdPasoArNumber> BdPasoArNumber { get; set; }
        public virtual DbSet<BdPasoCambioStatusUnidadMasivo> BdPasoCambioStatusUnidadMasivo { get; set; }
        public virtual DbSet<BdPeriodoUsuarioInactivo> BdPeriodoUsuarioInactivo { get; set; }
        public virtual DbSet<BdPestanasBitacoraAr> BdPestanasBitacoraAr { get; set; }
        public virtual DbSet<BdPlazaCp> BdPlazaCp { get; set; }
        public virtual DbSet<BdPreciosLicenciaAndroid> BdPreciosLicenciaAndroid { get; set; }
        public virtual DbSet<BdPreciosLicenciaWeb> BdPreciosLicenciaWeb { get; set; }
        public virtual DbSet<BdPresupuestos> BdPresupuestos { get; set; }
        public virtual DbSet<BdPresupuestosEjercido> BdPresupuestosEjercido { get; set; }
        public virtual DbSet<BdPresupuestosRegional> BdPresupuestosRegional { get; set; }
        public virtual DbSet<BdProductoStatusAr> BdProductoStatusAr { get; set; }
        public virtual DbSet<BdPruebasUnitarias> BdPruebasUnitarias { get; set; }
        public virtual DbSet<BdRecepcionElavon> BdRecepcionElavon { get; set; }
        public virtual DbSet<BdRecepcionInsumos> BdRecepcionInsumos { get; set; }
        public virtual DbSet<BdRecoverPassword> BdRecoverPassword { get; set; }
        public virtual DbSet<BdReglasAsignacionAutomatica> BdReglasAsignacionAutomatica { get; set; }
        public virtual DbSet<BdReglasModelos> BdReglasModelos { get; set; }
        public virtual DbSet<BdReglasStatusAlmacen> BdReglasStatusAlmacen { get; set; }
        public virtual DbSet<BdReglasStatusAr> BdReglasStatusAr { get; set; }
        public virtual DbSet<BdReingresoSim> BdReingresoSim { get; set; }
        public virtual DbSet<BdReingresoUnidad> BdReingresoUnidad { get; set; }
        public virtual DbSet<BdRelacionFacturaEnvio> BdRelacionFacturaEnvio { get; set; }
        public virtual DbSet<BdReparacionUnidad> BdReparacionUnidad { get; set; }
        public virtual DbSet<BdReparecionesCargaPdf> BdReparecionesCargaPdf { get; set; }
        public virtual DbSet<BdReporteCierre> BdReporteCierre { get; set; }
        public virtual DbSet<BdReporteCierreAr> BdReporteCierreAr { get; set; }
        public virtual DbSet<BdReporteMovInventario> BdReporteMovInventario { get; set; }
        public virtual DbSet<BdRetiros> BdRetiros { get; set; }
        public virtual DbSet<BdServicioCausa> BdServicioCausa { get; set; }
        public virtual DbSet<BdServicioCausaRechazoPrecio> BdServicioCausaRechazoPrecio { get; set; }
        public virtual DbSet<BdServicioMovInv> BdServicioMovInv { get; set; }
        public virtual DbSet<BdServicioSegmento> BdServicioSegmento { get; set; }
        public virtual DbSet<BdServicioSolucion> BdServicioSolucion { get; set; }
        public virtual DbSet<BdServicioSolucionPrecio> BdServicioSolucionPrecio { get; set; }
        public virtual DbSet<BdServicioTipoFalla> BdServicioTipoFalla { get; set; }
        public virtual DbSet<BdServicioWeekhour> BdServicioWeekhour { get; set; }
        public virtual DbSet<BdServiciosFallas> BdServiciosFallas { get; set; }
        public virtual DbSet<BdSims> BdSims { get; set; }
        public virtual DbSet<BdSimsAlta> BdSimsAlta { get; set; }
        public virtual DbSet<BdSoftelPaso> BdSoftelPaso { get; set; }
        public virtual DbSet<BdSolicitudAlmacenComentario> BdSolicitudAlmacenComentario { get; set; }
        public virtual DbSet<BdSolicitudCorreo> BdSolicitudCorreo { get; set; }
        public virtual DbSet<BdSolicitudCorreoLog> BdSolicitudCorreoLog { get; set; }
        public virtual DbSet<BdSolicitudCorreoOki> BdSolicitudCorreoOki { get; set; }
        public virtual DbSet<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
        public virtual DbSet<BdSolicitudRecoleccionInsumos> BdSolicitudRecoleccionInsumos { get; set; }
        public virtual DbSet<BdSolicitudRecoleccionModelo> BdSolicitudRecoleccionModelo { get; set; }
        public virtual DbSet<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        public virtual DbSet<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
        public virtual DbSet<BdSolicitudesDevolucion> BdSolicitudesDevolucion { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionInsumos> BdSolicitudesDevolucionInsumos { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionItems> BdSolicitudesDevolucionItems { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelo { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionUnidad> BdSolicitudesDevolucionUnidad { get; set; }
        public virtual DbSet<BdSolicitudesViaticos> BdSolicitudesViaticos { get; set; }
        public virtual DbSet<BdSolicitudesViaticosConceptos> BdSolicitudesViaticosConceptos { get; set; }
        public virtual DbSet<BdSoporteTecnico> BdSoporteTecnico { get; set; }
        public virtual DbSet<BdSparePartPrecio> BdSparePartPrecio { get; set; }
        public virtual DbSet<BdStatusDoctoTipoResponsablePrefacturacion> BdStatusDoctoTipoResponsablePrefacturacion { get; set; }
        public virtual DbSet<BdStatusTipoUsuario> BdStatusTipoUsuario { get; set; }
        public virtual DbSet<BdSustituciones> BdSustituciones { get; set; }
        public virtual DbSet<BdTempActualizaTipoPlazaCliente> BdTempActualizaTipoPlazaCliente { get; set; }
        public virtual DbSet<BdTempCorreccion> BdTempCorreccion { get; set; }
        public virtual DbSet<BdTempServicioCierrePda> BdTempServicioCierrePda { get; set; }
        public virtual DbSet<BdTerminales> BdTerminales { get; set; }
        public virtual DbSet<BdTipoPlan> BdTipoPlan { get; set; }
        public virtual DbSet<BdTipoPlazaClienteCp> BdTipoPlazaClienteCp { get; set; }
        public virtual DbSet<BdTipoServicioProducto> BdTipoServicioProducto { get; set; }
        public virtual DbSet<BdTpvsAlta> BdTpvsAlta { get; set; }
        public virtual DbSet<BdTransacciones> BdTransacciones { get; set; }
        public virtual DbSet<BdTransaccionesPaso> BdTransaccionesPaso { get; set; }
        public virtual DbSet<BdTransferencias> BdTransferencias { get; set; }
        public virtual DbSet<BdTransferenciasPaso> BdTransferenciasPaso { get; set; }
        public virtual DbSet<BdTransferenciasUnidad> BdTransferenciasUnidad { get; set; }
        public virtual DbSet<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
        public virtual DbSet<BdUnidades> BdUnidades { get; set; }
        public virtual DbSet<BdUnidadesNoReportadas> BdUnidadesNoReportadas { get; set; }
        public virtual DbSet<BdUnidadesPasoTest> BdUnidadesPasoTest { get; set; }
        public virtual DbSet<BdUnidadesPorRecibirAlmacen> BdUnidadesPorRecibirAlmacen { get; set; }
        public virtual DbSet<BdUnidadesProcesadasAlmacen> BdUnidadesProcesadasAlmacen { get; set; }
        public virtual DbSet<BdUnidadesRefaccionesAlta> BdUnidadesRefaccionesAlta { get; set; }
        public virtual DbSet<BdUnidadesReportadas> BdUnidadesReportadas { get; set; }
        public virtual DbSet<BdUpdateIsContractNegocios> BdUpdateIsContractNegocios { get; set; }
        public virtual DbSet<BdUploadDhl> BdUploadDhl { get; set; }
        public virtual DbSet<BdUploadEstafeta> BdUploadEstafeta { get; set; }
        public virtual DbSet<BdUsuarioAlmacen> BdUsuarioAlmacen { get; set; }
        public virtual DbSet<BdUsuarioArchivosVarios> BdUsuarioArchivosVarios { get; set; }
        public virtual DbSet<BdUsuarioCelular> BdUsuarioCelular { get; set; }
        public virtual DbSet<BdUsuarioCliente> BdUsuarioCliente { get; set; }
        public virtual DbSet<BdUsuarioProducto> BdUsuarioProducto { get; set; }
        public virtual DbSet<BdUsuarioStatusUnidad> BdUsuarioStatusUnidad { get; set; }
        public virtual DbSet<BdUsuarioTecnico> BdUsuarioTecnico { get; set; }
        public virtual DbSet<BdUsuarioVistaEscalamiento> BdUsuarioVistaEscalamiento { get; set; }
        public virtual DbSet<BdUsuarioZona> BdUsuarioZona { get; set; }
        public virtual DbSet<BdVacaciones> BdVacaciones { get; set; }
        public virtual DbSet<BdVistaEscalamientoStatusAr> BdVistaEscalamientoStatusAr { get; set; }
        public virtual DbSet<BdWincorClientes> BdWincorClientes { get; set; }
        public virtual DbSet<BdWincorClientesServicios> BdWincorClientesServicios { get; set; }
        public virtual DbSet<BdWincorServicios> BdWincorServicios { get; set; }
        public virtual DbSet<BdWorkload> BdWorkload { get; set; }
        public virtual DbSet<BdWsBancomer> BdWsBancomer { get; set; }
        public virtual DbSet<BdZonaCp> BdZonaCp { get; set; }
        public virtual DbSet<CAccesorios> CAccesorios { get; set; }
        public virtual DbSet<CActasAdmin> CActasAdmin { get; set; }
        public virtual DbSet<CAlmacenes> CAlmacenes { get; set; }
        public virtual DbSet<CArchivos> CArchivos { get; set; }
        public virtual DbSet<CAreas> CAreas { get; set; }
        public virtual DbSet<CBbvaMicroformasServicios> CBbvaMicroformasServicios { get; set; }
        public virtual DbSet<CBitacoraAgendadosComentarios> CBitacoraAgendadosComentarios { get; set; }
        public virtual DbSet<CCalifJunta> CCalifJunta { get; set; }
        public virtual DbSet<CCarrier> CCarrier { get; set; }
        public virtual DbSet<CCategoria> CCategoria { get; set; }
        public virtual DbSet<CCategoriaValidaDispositivos> CCategoriaValidaDispositivos { get; set; }
        public virtual DbSet<CCausaCancelacion> CCausaCancelacion { get; set; }
        public virtual DbSet<CCausaCancelacionSolicitudAlmacen> CCausaCancelacionSolicitudAlmacen { get; set; }
        public virtual DbSet<CCausaRetiro> CCausaRetiro { get; set; }
        public virtual DbSet<CCausas> CCausas { get; set; }
        public virtual DbSet<CCausasRechazo> CCausasRechazo { get; set; }
        public virtual DbSet<CCausasRechazoDefinitivoDoctoPrefacturacion> CCausasRechazoDefinitivoDoctoPrefacturacion { get; set; }
        public virtual DbSet<CCausasRechazoSegmento> CCausasRechazoSegmento { get; set; }
        public virtual DbSet<CChoferes> CChoferes { get; set; }
        public virtual DbSet<CClientes> CClientes { get; set; }
        public virtual DbSet<CClientesPmo> CClientesPmo { get; set; }
        public virtual DbSet<CCodigosIntervencionNivel0> CCodigosIntervencionNivel0 { get; set; }
        public virtual DbSet<CCodigosIntervencionNivel1> CCodigosIntervencionNivel1 { get; set; }
        public virtual DbSet<CCodigosIntervencionNivel2> CCodigosIntervencionNivel2 { get; set; }
        public virtual DbSet<CConceptoAr> CConceptoAr { get; set; }
        public virtual DbSet<CConceptosPmo> CConceptosPmo { get; set; }
        public virtual DbSet<CConectividad> CConectividad { get; set; }
        public virtual DbSet<CConsumibles> CConsumibles { get; set; }
        public virtual DbSet<CCpDarBbva94> CCpDarBbva94 { get; set; }
        public virtual DbSet<CCpProsa> CCpProsa { get; set; }
        public virtual DbSet<CDescripcionTrabajo> CDescripcionTrabajo { get; set; }
        public virtual DbSet<CDesviaciones> CDesviaciones { get; set; }
        public virtual DbSet<CDirecciones> CDirecciones { get; set; }
        public virtual DbSet<CDocsTir> CDocsTir { get; set; }
        public virtual DbSet<CDominiosEmail> CDominiosEmail { get; set; }
        public virtual DbSet<CElavonSantanderServicios> CElavonSantanderServicios { get; set; }
        public virtual DbSet<CEquipoCliente> CEquipoCliente { get; set; }
        public virtual DbSet<CEstadosDarBbva94> CEstadosDarBbva94 { get; set; }
        public virtual DbSet<CEtiquetaInformacionCierre> CEtiquetaInformacionCierre { get; set; }
        public virtual DbSet<CEtiquetaInformacionRechazo> CEtiquetaInformacionRechazo { get; set; }
        public virtual DbSet<CEtiquetaInformacionUnidad> CEtiquetaInformacionUnidad { get; set; }
        public virtual DbSet<CFallas> CFallas { get; set; }
        public virtual DbSet<CFallasEncontradas> CFallasEncontradas { get; set; }
        public virtual DbSet<CGrupos> CGrupos { get; set; }
        public virtual DbSet<CHorarios> CHorarios { get; set; }
        public virtual DbSet<CHoras> CHoras { get; set; }
        public virtual DbSet<CInsumos> CInsumos { get; set; }
        public virtual DbSet<CInsumosAlta> CInsumosAlta { get; set; }
        public virtual DbSet<CInsumosOld> CInsumosOld { get; set; }
        public virtual DbSet<CLlaves> CLlaves { get; set; }
        public virtual DbSet<CLogros> CLogros { get; set; }
        public virtual DbSet<CMarcas> CMarcas { get; set; }
        public virtual DbSet<CMcAutomoviles> CMcAutomoviles { get; set; }
        public virtual DbSet<CMcBoletos> CMcBoletos { get; set; }
        public virtual DbSet<CMcCasetas> CMcCasetas { get; set; }
        public virtual DbSet<CMcEstacionEvaluar> CMcEstacionEvaluar { get; set; }
        public virtual DbSet<CMcEstacionEvaluarReglas> CMcEstacionEvaluarReglas { get; set; }
        public virtual DbSet<CMcMedioTransporte> CMcMedioTransporte { get; set; }
        public virtual DbSet<CMcRutas> CMcRutas { get; set; }
        public virtual DbSet<CMcTopesMaximos> CMcTopesMaximos { get; set; }
        public virtual DbSet<CMcViaticosMotivos> CMcViaticosMotivos { get; set; }
        public virtual DbSet<CMcViaticosRazonesCancelacion> CMcViaticosRazonesCancelacion { get; set; }
        public virtual DbSet<CMenu> CMenu { get; set; }
        public virtual DbSet<CMenuCopia> CMenuCopia { get; set; }
        public virtual DbSet<CMinutos> CMinutos { get; set; }
        public virtual DbSet<CModelos> CModelos { get; set; }
        public virtual DbSet<CMonedas> CMonedas { get; set; }
        public virtual DbSet<CMovInv> CMovInv { get; set; }
        public virtual DbSet<CNivelReparacion> CNivelReparacion { get; set; }
        public virtual DbSet<CNombreCurso> CNombreCurso { get; set; }
        public virtual DbSet<CNombreJunta> CNombreJunta { get; set; }
        public virtual DbSet<COperadores> COperadores { get; set; }
        public virtual DbSet<CPlazas> CPlazas { get; set; }
        public virtual DbSet<CPrioridades> CPrioridades { get; set; }
        public virtual DbSet<CProductoDhl> CProductoDhl { get; set; }
        public virtual DbSet<CProductos> CProductos { get; set; }
        public virtual DbSet<CProductosNegocios> CProductosNegocios { get; set; }
        public virtual DbSet<CProveedoresUsuarios> CProveedoresUsuarios { get; set; }
        public virtual DbSet<CProyectos> CProyectos { get; set; }
        public virtual DbSet<CProyectosPmo> CProyectosPmo { get; set; }
        public virtual DbSet<CPuestos> CPuestos { get; set; }
        public virtual DbSet<CRazonDevolucion> CRazonDevolucion { get; set; }
        public virtual DbSet<CRegiones> CRegiones { get; set; }
        public virtual DbSet<CReparaciones> CReparaciones { get; set; }
        public virtual DbSet<CReporteMovInventario> CReporteMovInventario { get; set; }
        public virtual DbSet<CReportesRetipificados> CReportesRetipificados { get; set; }
        public virtual DbSet<CResponsables> CResponsables { get; set; }
        public virtual DbSet<CResponsablesAgendados> CResponsablesAgendados { get; set; }
        public virtual DbSet<CSedeCurso> CSedeCurso { get; set; }
        public virtual DbSet<CSegmentos> CSegmentos { get; set; }
        public virtual DbSet<CServicioMensajeria> CServicioMensajeria { get; set; }
        public virtual DbSet<CServicios> CServicios { get; set; }
        public virtual DbSet<CServiciosBancomer> CServiciosBancomer { get; set; }
        public virtual DbSet<CServiciosDobles> CServiciosDobles { get; set; }
        public virtual DbSet<CSoftware> CSoftware { get; set; }
        public virtual DbSet<CSoluciones> CSoluciones { get; set; }
        public virtual DbSet<CSpareParts> CSpareParts { get; set; }
        public virtual DbSet<CStatusAccesorio> CStatusAccesorio { get; set; }
        public virtual DbSet<CStatusAr> CStatusAr { get; set; }
        public virtual DbSet<CStatusArEq> CStatusArEq { get; set; }
        public virtual DbSet<CStatusCarga> CStatusCarga { get; set; }
        public virtual DbSet<CStatusCot3m> CStatusCot3m { get; set; }
        public virtual DbSet<CStatusCurso> CStatusCurso { get; set; }
        public virtual DbSet<CStatusDoctosPrefacturacion> CStatusDoctosPrefacturacion { get; set; }
        public virtual DbSet<CStatusEnvio> CStatusEnvio { get; set; }
        public virtual DbSet<CStatusInsumos> CStatusInsumos { get; set; }
        public virtual DbSet<CStatusItemsSolicitudAlmacen> CStatusItemsSolicitudAlmacen { get; set; }
        public virtual DbSet<CStatusJunta> CStatusJunta { get; set; }
        public virtual DbSet<CStatusOrdenCompra> CStatusOrdenCompra { get; set; }
        public virtual DbSet<CStatusReasonCodes> CStatusReasonCodes { get; set; }
        public virtual DbSet<CStatusReparacion> CStatusReparacion { get; set; }
        public virtual DbSet<CStatusReporteCierre> CStatusReporteCierre { get; set; }
        public virtual DbSet<CStatusSolicitudAlmacen> CStatusSolicitudAlmacen { get; set; }
        public virtual DbSet<CStatusSolicitudDevolucion> CStatusSolicitudDevolucion { get; set; }
        public virtual DbSet<CStatusSolicitudRecoleccion> CStatusSolicitudRecoleccion { get; set; }
        public virtual DbSet<CStatusSolicitudViaticos> CStatusSolicitudViaticos { get; set; }
        public virtual DbSet<CStatusUnidad> CStatusUnidad { get; set; }
        public virtual DbSet<CStatusUsuario> CStatusUsuario { get; set; }
        public virtual DbSet<CStatusValidacionPrefacturacion> CStatusValidacionPrefacturacion { get; set; }
        public virtual DbSet<CSubAlmacenes> CSubAlmacenes { get; set; }
        public virtual DbSet<CTecnicos> CTecnicos { get; set; }
        public virtual DbSet<CTiempoMedicion> CTiempoMedicion { get; set; }
        public virtual DbSet<CTiempoReferencia> CTiempoReferencia { get; set; }
        public virtual DbSet<CTiempos> CTiempos { get; set; }
        public virtual DbSet<CTimestamp> CTimestamp { get; set; }
        public virtual DbSet<CTipoAB> CTipoAB { get; set; }
        public virtual DbSet<CTipoArchivo> CTipoArchivo { get; set; }
        public virtual DbSet<CTipoAuditoria> CTipoAuditoria { get; set; }
        public virtual DbSet<CTipoCalculoUptime> CTipoCalculoUptime { get; set; }
        public virtual DbSet<CTipoCobro> CTipoCobro { get; set; }
        public virtual DbSet<CTipoCobroNegocio> CTipoCobroNegocio { get; set; }
        public virtual DbSet<CTipoDowntimeTrigger> CTipoDowntimeTrigger { get; set; }
        public virtual DbSet<CTipoFalla> CTipoFalla { get; set; }
        public virtual DbSet<CTipoFallaSegmento> CTipoFallaSegmento { get; set; }
        public virtual DbSet<CTipoInsumo> CTipoInsumo { get; set; }
        public virtual DbSet<CTipoInventario> CTipoInventario { get; set; }
        public virtual DbSet<CTipoItemOrdenCompra> CTipoItemOrdenCompra { get; set; }
        public virtual DbSet<CTipoItemSolicitudAlmacen> CTipoItemSolicitudAlmacen { get; set; }
        public virtual DbSet<CTipoLocalidad> CTipoLocalidad { get; set; }
        public virtual DbSet<CTipoPart> CTipoPart { get; set; }
        public virtual DbSet<CTipoPlaza> CTipoPlaza { get; set; }
        public virtual DbSet<CTipoPlazaCliente> CTipoPlazaCliente { get; set; }
        public virtual DbSet<CTipoPlazaNegocio> CTipoPlazaNegocio { get; set; }
        public virtual DbSet<CTipoPrecio> CTipoPrecio { get; set; }
        public virtual DbSet<CTipoProducto> CTipoProducto { get; set; }
        public virtual DbSet<CTipoResponsable> CTipoResponsable { get; set; }
        public virtual DbSet<CTipoResponsablePrefacturacion> CTipoResponsablePrefacturacion { get; set; }
        public virtual DbSet<CTipoServicio> CTipoServicio { get; set; }
        public virtual DbSet<CTipoServicioSolicitudAlmacen> CTipoServicioSolicitudAlmacen { get; set; }
        public virtual DbSet<CTipoSolicitudAlmacen> CTipoSolicitudAlmacen { get; set; }
        public virtual DbSet<CTipoSoporteTecnico> CTipoSoporteTecnico { get; set; }
        public virtual DbSet<CTipoSparePart> CTipoSparePart { get; set; }
        public virtual DbSet<CTipoUsuario> CTipoUsuario { get; set; }
        public virtual DbSet<CTipoZonaOld> CTipoZonaOld { get; set; }
        public virtual DbSet<CUnidadMensajeria> CUnidadMensajeria { get; set; }
        public virtual DbSet<CUpdateTablasBb> CUpdateTablasBb { get; set; }
        public virtual DbSet<CUrgenciaEnvio> CUrgenciaEnvio { get; set; }
        public virtual DbSet<CUrgenciaSolicitudAlmacen> CUrgenciaSolicitudAlmacen { get; set; }
        public virtual DbSet<CUsuarios> CUsuarios { get; set; }
        public virtual DbSet<CUsuariosCorporativo> CUsuariosCorporativo { get; set; }
        public virtual DbSet<CVendedores> CVendedores { get; set; }
        public virtual DbSet<CViaticos> CViaticos { get; set; }
        public virtual DbSet<CVistasEscalamiento> CVistasEscalamiento { get; set; }
        public virtual DbSet<CWeekDays> CWeekDays { get; set; }
        public virtual DbSet<CWeekhours> CWeekhours { get; set; }
        public virtual DbSet<CWincorEquivalenciasSgs> CWincorEquivalenciasSgs { get; set; }
        public virtual DbSet<CZonaAtencionSantander> CZonaAtencionSantander { get; set; }
        public virtual DbSet<CZonas> CZonas { get; set; }
        public virtual DbSet<CZonasAgenteCallCenter> CZonasAgenteCallCenter { get; set; }
        public virtual DbSet<ElavonInbox> ElavonInbox { get; set; }
        public virtual DbSet<ElavonOutbox> ElavonOutbox { get; set; }
        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<ErroresArPrefacturacion> ErroresArPrefacturacion { get; set; }
        public virtual DbSet<HistoricoElavon> HistoricoElavon { get; set; }
        public virtual DbSet<HistoricoElavonPaso> HistoricoElavonPaso { get; set; }
        public virtual DbSet<NegociosBanamex> NegociosBanamex { get; set; }
        public virtual DbSet<NegociosBansefi> NegociosBansefi { get; set; }
        public virtual DbSet<NegociosBbva> NegociosBbva { get; set; }
        public virtual DbSet<NegociosBbvaWincor> NegociosBbvaWincor { get; set; }
        public virtual DbSet<NegociosBmxAtm> NegociosBmxAtm { get; set; }
        public virtual DbSet<NegociosBmxpl> NegociosBmxpl { get; set; }
        public virtual DbSet<NegociosBmxtnm> NegociosBmxtnm { get; set; }
        public virtual DbSet<NegociosFujitsuBajio> NegociosFujitsuBajio { get; set; }
        public virtual DbSet<NegociosFujitsuBanjercito> NegociosFujitsuBanjercito { get; set; }
        public virtual DbSet<NegociosFujitsuHsbc> NegociosFujitsuHsbc { get; set; }
        public virtual DbSet<NegociosFujitsuInd> NegociosFujitsuInd { get; set; }
        public virtual DbSet<NegociosGnp> NegociosGnp { get; set; }
        public virtual DbSet<NegociosHsbc> NegociosHsbc { get; set; }
        public virtual DbSet<NegociosHsbcFujitsu> NegociosHsbcFujitsu { get; set; }
        public virtual DbSet<NegociosHsbcWincor> NegociosHsbcWincor { get; set; }
        public virtual DbSet<NegociosMontepio> NegociosMontepio { get; set; }
        public virtual DbSet<NegociosSantander> NegociosSantander { get; set; }
        public virtual DbSet<NegociosSantanderWincor> NegociosSantanderWincor { get; set; }
        public virtual DbSet<NegociosSat> NegociosSat { get; set; }
        public virtual DbSet<NegociosSoftel> NegociosSoftel { get; set; }
        public virtual DbSet<NegociosTelefonica> NegociosTelefonica { get; set; }
        public virtual DbSet<ReporteHojaServicios> ReporteHojaServicios { get; set; }
        public virtual DbSet<SantanderOutbox> SantanderOutbox { get; set; }
        public virtual DbSet<SantanderOutboxCierre> SantanderOutboxCierre { get; set; }
        public virtual DbSet<SepomexEstados> SepomexEstados { get; set; }
        public virtual DbSet<SepomexOld> SepomexOld { get; set; }
        public virtual DbSet<SiBdLog> SiBdLog { get; set; }
        public virtual DbSet<SiCServicios> SiCServicios { get; set; }
        public virtual DbSet<TempAfiliaciones> TempAfiliaciones { get; set; }
        public virtual DbSet<TempHorarios> TempHorarios { get; set; }
        public virtual DbSet<TempNegocios> TempNegocios { get; set; }
        public virtual DbSet<TempUpdateNoInventario> TempUpdateNoInventario { get; set; }
        public virtual DbSet<UnidadesBnmAtm> UnidadesBnmAtm { get; set; }

        // Unable to generate entity type for table 'dbo.TABLA_BANCO_BBVA_REPORTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ABREVIATURA_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ERRORES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TablaTemporalPMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEST_DEPURA_INSUMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIO_MULTIVA_FECHA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRUEBA_A'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DHL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_UPDATE_FEC_CIERRE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TAREA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_TIPO_PLAZA_CLIENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PREPORTE_INVENTARIOS_TPV_VERIFONE_SUSTITUCIONES_FECHA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_CALIFICA_PDF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TEMO_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_PRODUCTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TABLA_REMESA_BBVA_REPORTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_NEGOCIOS_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_INGENICO_BANBAJIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ALTA_CANCELACION_AR_MASIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_licencias_dhl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_INGENICO_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_NOMINA_DETALLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SEPOMEX_ANTERIOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_segmento_banamex'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_INGENICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_WINCOR_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRUEBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_horarios_santander'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_MIT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_OKI_SERVICIOS_CORRECTIVOS_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_CONSECUTIVO_3M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.respaldo_adam'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_SOLUCION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ASIENTOS_REGIONALES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ENVIO_UNIDAD_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIPO_CIERRE_TAREA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_TEDISA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temporal_respaldo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_CONSOLIDADO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PROSA_CORREGIDO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_VERIFON_ELAVON_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_TEMP_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO_FABRICANTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SEPOMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_STATUS_MODELO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICIOS_FEBRERO_2015'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO_INSTALADO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MOVMIENTOS_INV_ARCHIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICIOS_ENERO_2015'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO_STOCK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ENVIOS_CONSOLIDADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CANCELAR_AR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERROR_UNIDADES_DANIADAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICIOS_CERRADOS_MES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pruebas_errores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TIPOS_DE_SERVICIOS_COSTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERV_TEC_CLTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ENVIOS_SERVICIO_MENSAJERIAS_PRECIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERV_TEC_CLT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REFACCIONES_INSTALADAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_adam'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_SERVICIO_RETIRO_SIMS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_PRODUCTOS_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DIRECCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CANT_SERV_PROD_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_respaldo_afiliaciones'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AR_PDF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERRORES_CAMBIO_MODELOS_MASIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERROR_MASIVO_CONECTIVIDAD_APLICATIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPO_UNIDADES_SIM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_ALTA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VEHICULOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXISTENCIA_2_ALMACEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_errores_carga'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_INSUMOS_AR_TECNICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PROVISION_INGRESO_REGION_PROD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRODUCTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERRORES_MASIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FILL_RATE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_POR_RECIBIR_ALMACEN2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MODELO_CONECT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PRUEBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_VIATICOS_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WINCOR_OUTBOX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Query'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MF_DISPERSION_INGENIERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PRUEBA_SP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WINCOR_INBOX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_STATUS_DOCTOS_PREFACTURACION_archivo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.INGRESOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_BODY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_REFACCIONES_ALMACEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GUIAS_COSTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_FALLAS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GASOLINA_AVION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_QUESTS_CALLCENTER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_cARGAS_ARCHIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ARCHIVO1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ENVIOS_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_RESPONSABLE_CANCELACION_PROGRAMADO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EDO_RESULTADOS_REGION_PRODUCTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXISTENCIA_1_ALMACEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOG_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EDO_RESULTADOS_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EDO_RESULTADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MODELOS_VALIDOS_EGLOBAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DISPERSION_NOMINA_CLIENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_CARGA_LAYOUD_MASIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DISPERSION_NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.costo_ref_ms'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_STATUS_UNIDAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERRORES_CAMBIO_NO_SERIE_ACTUAL_NUEVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_REF_MICROSIP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_IS_2015_02_BIS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_IS_2015_02'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REP_TPV_EGLOBAL_GRAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_IS_2015_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_INGENIERO_2015_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SANTANDER_INBOX_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_INGENIERO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bd_iata'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CLIENTE_PROD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_FUJITSU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CONSUMO_TRIMESTRAL_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_REPORTE_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_AUDITORIA_INSUMOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_OKI_SERVICIOS_CORRECTIVOS_OKI'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_STATUS_SIM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_REPORTE_2_TRASH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_AUDITORIA_UNIDAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_REPORTE_INSUMO_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_NEW_PRODUCTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_AUDITORIA_UNIDAD_TRASH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_CONCEPTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TABLA_TEMPORAL_RETIRADA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIEMPOS_SERVICIOS_WINCOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_NEGOCIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_WINCOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUDITORIAS_REALIZADAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_OKI'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_BD_PRESUPUESTO_EJERCIDO_MENSUAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_MODEM_SOFTEL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ZONA_ESTADO_SEPOMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTES_AUDITORIA_INSUMO_ING_ALM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MC_CASETAS_RUTAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTES_AUDITORIA_UNIDAD_ING_ALM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_WINCOR_FUJITSU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ZONA_DAR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_RESPONSABLE_STATUS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ZONAS_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MC_BOLETOS_RUTAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BITACORA_ERROR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERROR_ASIGANACION_AUTOMATICA_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CAMBIO_ID_SEGMENTO_BANAMEX_TNM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BITACORA_MENSAJERIA_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_INGRESOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_COMPARATIVO_WINCOR_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BITACORA_SOLUCION_ERRORES_LEBERACION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_PROCESOS_INTERNOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_CLIENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_inv_insumos_paso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SERVICIO_SEGMENTO_TAREA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_inv_unidades_paso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPO_MARCA_MODELO_BANAMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DAR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LICENCIAS_REPORTE_ELAVON_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIPO_OUTBOX_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRESUPUESTOS_CUBO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_COSTOS_MENSAJERIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SERVICIOS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DIAGNOSTICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESULTADO_DIFERENCIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DIFERENCIAS_ULTIMA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEM_RESPALDO_BD_MENSAJERIA_COSTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_REGIONES_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_EMBARQUES_MENSAJERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEM_RESPALDO_COSTO_KG_ADD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SIMS_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_INFO_ERRORES_CARGA_MASIVA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CambioMasivoBdUnidades'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_ERROR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SI_DASHBOARD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_CONECTIVIDAD_SANTANDER_REPORTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_ERRORES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CambioMasivoBdUnidades2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AR_PRODUCTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_HORARIOS_PERSONAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_F11_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOG_CARGA_MASIVA_TABLA_TOTAL_PROCESADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_FILL_RATE_BANCOMER_DISPONIBLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIPO_REPARACION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO_C_PRODUCTOS_NEGOCIOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_EXTRAVIO_POR_MENSAJERIA_CARGA_MASIVA_PDF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_NEGOCIOS_BANAMEX_ATM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_FILL_RATE_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_ERRORES_CORREO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CONSUMO_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_UPDATE_DIRECCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_PROCESADOS_CORREO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DISPONIBLE_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AR_TECNICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DIR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_FILL_RATE_BBVA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CADENA_NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_CONTROL_INSUMOS_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_WINCOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MENSAJERIA_COSTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MENSAJERIA_CP_ZONAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DIRECCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_OKI_SERVICIOS_CORRECTIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_EXITO_LAYOUT_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_INGRESO_MOV_INVENTARIOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SOLICITUD_VIATICOS_CONCEPTOS_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_COSTO_REFACCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cdosysmail_failures'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_COSTO_VIATICOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_Carga_unidades'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BACKUP_BD_ZONAS_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ERRORES_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HISTORICO_BBVA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_QUERY_MODELO_CONECTIVIDAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_ERRORES_CORREO2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_NEW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_MEDIDA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_MODULO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_SUBMODULO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tabla_prueba_consolidado'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_TIPO_MEDIDA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_REPORTE_RETIROS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_DISPONIBLES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO_TABLA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_TRANSITO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FILL_RATE_ELAVON'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FILL_RATE_OTROS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_KG_ADD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REPORTE_F11'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ORDENES_COMPRA_EVIDENCIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SOLICITUDES_VIATICOS_CONCEPTOS_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_STATUS_USUARIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_SURTIDO_MENSAJERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MODELOS_HOMOLOGADOS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_BANCOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MODELOS_MODIFICADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_3M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MULTIVA_DIARIO_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_MASIVO_DANIADA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_NEGOCIOS_BANAMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_BANAMEX_TNM_FECHA'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.100.56;Initial Catalog=ELAVON-TEST;Persist Security Info=False;User Id=sa;Password=b4ckl45h;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<BdActasAdmin>(entity =>
            {
                entity.HasKey(e => e.IdActaAdmin)
                    .HasName("PK_BD_ACTA_ADMIN");

                entity.ToTable("BD_ACTAS_ADMIN");

                entity.Property(e => e.IdActaAdmin).HasColumnName("ID_ACTA_ADMIN");

                entity.Property(e => e.Comentarios)
                    .HasColumnName("COMENTARIOS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoActaAdmin).HasColumnName("ID_TIPO_ACTA_ADMIN");

                entity.Property(e => e.IdUsuarioActa).HasColumnName("ID_USUARIO_ACTA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.StatusActaAdmin)
                    .HasColumnName("STATUS_ACTA_ADMIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAjustesInsumosPaso>(entity =>
            {
                entity.HasKey(e => e.IdAjuste)
                    .HasName("PK__BD_AJUST__7C4D8AC8DBD55290");

                entity.ToTable("BD_AJUSTES_INSUMOS_PASO");

                entity.Property(e => e.IdAjuste).HasColumnName("ID_AJUSTE");

                entity.Property(e => e.Entrada).HasColumnName("ENTRADA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBdInsumo).HasColumnName("ID_BD_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.SalidaActual).HasColumnName("SALIDA_ACTUAL");

                entity.Property(e => e.SalidaAnterior).HasColumnName("SALIDA_ANTERIOR");

                entity.Property(e => e.Total).HasColumnName("TOTAL");
            });

            modelBuilder.Entity<BdAltaFecGarantia>(entity =>
            {
                entity.HasKey(e => e.IdAlta)
                    .HasName("PK__BD_ALTA___149699216FD7BF73");

                entity.ToTable("BD_ALTA_FEC_GARANTIA");

                entity.Property(e => e.IdAlta).HasColumnName("ID_ALTA");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAltaMasivaUnidadCa>(entity =>
            {
                entity.HasKey(e => e.IdUnidadCa)
                    .HasName("PK__BD_ALTA___052710832B92C76C");

                entity.ToTable("BD_ALTA_MASIVA_UNIDAD_CA");

                entity.Property(e => e.IdUnidadCa).HasColumnName("ID_UNIDAD_CA");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAr>(entity =>
            {
                entity.HasKey(e => e.IdAr);

                entity.ToTable("BD_AR");

                entity.HasIndex(e => e.IdCarga)
                    .HasName("missing_index_2708_2707");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("missing_index_4018_4017");

                entity.HasIndex(e => e.IdTecnico)
                    .HasName("missing_index_3618_3617");

                entity.HasIndex(e => e.IdZona)
                    .HasName("missing_index_61_60");

                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("missing_index_3491_3490");

                entity.HasIndex(e => e.NoAr)
                    .HasName("missing_index_167_166");

                entity.HasIndex(e => new { e.Cp, e.NoAr })
                    .HasName("missing_index_3318_3317");

                entity.HasIndex(e => new { e.FecAlta, e.NoAr })
                    .HasName("missing_index_1762_1761");

                entity.HasIndex(e => new { e.IdAr, e.IdStatusAr })
                    .HasName("missing_index_2815_2814");

                entity.HasIndex(e => new { e.IdAr, e.NoAr })
                    .HasName("missing_index_1760_1759");

                entity.HasIndex(e => new { e.IdCarga, e.Status })
                    .HasName("missing_index_903_902");

                entity.HasIndex(e => new { e.IdStatusAr, e.Status })
                    .HasName("missing_index_1096_1095");

                entity.HasIndex(e => new { e.NoAr, e.IdStatusAr })
                    .HasName("missing_index_2860_2859");

                entity.HasIndex(e => new { e.NoAr, e.Status })
                    .HasName("missing_index_6_5");

                entity.HasIndex(e => new { e.Status, e.IdCarga })
                    .HasName("missing_index_187_186");

                entity.HasIndex(e => new { e.Status, e.IdStatusAr })
                    .HasName("missing_index_118_117");

                entity.HasIndex(e => new { e.Status, e.NoAr })
                    .HasName("missing_index_2_1");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.Status })
                    .HasName("missing_index_184_183");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.IdCarga })
                    .HasName("missing_index_180_179");

                entity.HasIndex(e => new { e.IdCarga, e.IdCliente, e.NoAr })
                    .HasName("missing_index_161_160");

                entity.HasIndex(e => new { e.IdCarga, e.NoAr, e.IdStatusAr })
                    .HasName("missing_index_122_121");

                entity.HasIndex(e => new { e.IdCliente, e.NoAr, e.IdAr })
                    .HasName("missing_index_159_158");

                entity.HasIndex(e => new { e.IdCliente, e.NoAr, e.IdCarga })
                    .HasName("missing_index_178_177");

                entity.HasIndex(e => new { e.IdFalla, e.IdStatusAr, e.NoAfiliacion })
                    .HasName("missing_index_46_45");

                entity.HasIndex(e => new { e.IdServicio, e.Status, e.IdStatusAr })
                    .HasName("missing_index_1224_1223");

                entity.HasIndex(e => new { e.IdStatusAr, e.Status, e.IdProveedor })
                    .HasName("missing_index_1157_1156");

                entity.HasIndex(e => new { e.NoAfiliacion, e.IdFalla, e.IdStatusAr })
                    .HasName("missing_index_49_48");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Status, e.IdStatusAr })
                    .HasName("missing_index_2932_2931");

                entity.HasIndex(e => new { e.NoAr, e.IdStatusAr, e.Status })
                    .HasName("missing_index_3476_3475");

                entity.HasIndex(e => new { e.NoAr, e.Status, e.IdStatusAr })
                    .HasName("missing_index_252_251");

                entity.HasIndex(e => new { e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_63_62");

                entity.HasIndex(e => new { e.TerminalAmex, e.Status, e.IdStatusAr })
                    .HasName("missing_index_3478_3477");

                entity.HasIndex(e => new { e.IdNegocio, e.IdProyecto, e.FecCierre, e.IdStatusAr })
                    .HasName("missing_index_165_164");

                entity.HasIndex(e => new { e.IdServicio, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_2743_2742");

                entity.HasIndex(e => new { e.IdServicio, e.TerminalAmex, e.Status, e.IdStatusAr })
                    .HasName("missing_index_4016_4015");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_3487_3486");

                entity.HasIndex(e => new { e.NoAr, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_1145_1144");

                entity.HasIndex(e => new { e.IdAr, e.FecInicio, e.HorasGarantia, e.FecAlta, e.FecAtencion, e.FecGarantia, e.IdStatusAr, e.IdProyecto })
                    .HasName("missing_index_4135_4134");

                entity.HasIndex(e => new { e.FecGarantia, e.IdStatusAr, e.IdAr, e.FecInicio, e.HorasGarantia, e.FecAlta, e.FecAtencion, e.IdProyecto, e.IdServicio, e.IdFalla })
                    .HasName("missing_index_4132_4131");

                entity.HasIndex(e => new { e.IdSegmento, e.IdServicio, e.IdFalla, e.HorasGarantia, e.IdTecnico, e.IdAr, e.IdCliente, e.NoAr, e.Cp, e.IdCarga, e.Status })
                    .HasName("missing_index_189_188");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.NoAfiliacion, e.DescNegocio, e.Poblacion, e.Estado, e.Cp, e.IdSegmento, e.IdServicio, e.IdFalla, e.HorasGarantia, e.IdTecnico, e.IdCarga, e.Status })
                    .HasName("missing_index_192_191");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.Estado, e.Cp, e.Segmento, e.TipoServicio, e.TipoFalla, e.IdProyecto, e.NoAfiliacion, e.Telefono, e.DescNegocio, e.Direccion, e.Colonia, e.Poblacion, e.IdCarga, e.Status })
                    .HasName("missing_index_157_156");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.NoAfiliacion, e.Cp, e.HorasGarantia, e.PrecioExito, e.IdEstado, e.IdRegion, e.IdZona, e.IdTecnico, e.Segmento, e.TipoServicio, e.TipoFalla, e.IdSegmento, e.IdServicio, e.IdFalla, e.IdProyecto, e.IdCarga, e.Status })
                    .HasName("missing_index_198_197");

                entity.HasIndex(e => new { e.ClaveRechazo, e.IdAr, e.IdCarga, e.IdCliente, e.IdTecnico, e.FecGarantia, e.FecCierre, e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.IdStatusAr, e.Status, e.IdProveedor })
                    .HasName("missing_index_4101_4100");

                entity.HasIndex(e => new { e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.IdTecnico, e.FecGarantia, e.DescCorta, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.Concepto, e.FecCierre, e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.ClaveRechazo, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_4098_4097");

                entity.HasIndex(e => new { e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.ClaveRechazo, e.IdAr, e.IdRegion, e.IdZona, e.IdTecnico, e.FecAlta, e.FecGarantia, e.FecCierre, e.Bitacora, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdCarga, e.IdCliente, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_4007_4006");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.IsExito, e.IdProducto, e.ClaveRechazo, e.IdProveedor, e.IdZona, e.IdTecnico, e.FecAlta, e.FecGarantia, e.FecCierre, e.DescripcionTrabajo, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdRegion, e.IdCliente, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Bitacora, e.IdStatusAr, e.Status })
                    .HasName("missing_index_3806_3805");

                entity.HasIndex(e => new { e.ClaveRechazo, e.IdTipoEquipo, e.CorreoEjecutivo, e.TerminalAmex, e.DireccionAlternaComercio, e.IdProveedor, e.IdProyecto, e.IdProducto, e.MotivoRetipificado, e.DigitoVerificador, e.Insumos, e.Caja, e.FecGarantia, e.FecCierre, e.IntensidadSenial, e.DescripcionTrabajo, e.Atiende, e.IdCausaRechazo, e.FecInicio, e.IdSegmento, e.IdServicio, e.IdFalla, e.IdTecnico, e.FecAtencion, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Equipo, e.DescEquipo, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.Telefono, e.DescNegocio, e.Direccion, e.IdAr, e.NoAr, e.IdRegion, e.Status, e.IdStatusAr })
                    .HasName("missing_index_4014_4013");

                entity.HasIndex(e => new { e.CorreoEjecutivo, e.IdProveedor, e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.NoAfiliacion, e.VoltajeTierra, e.NoSim, e.IdConectividad, e.IdAplicativo, e.FolioTelecarga, e.IdTipoEquipo, e.IsSimRemplazada, e.IdCausaRechazo, e.CausaRechazo, e.CausaCancelacion, e.IsExito, e.IdProyecto, e.FecCierre, e.FecAltaHorasAtencion, e.IdUsuarioCierre, e.IdCausa, e.IdSolucion, e.NoEquipo, e.IdTipoPlaza, e.IdPlaza, e.IdTecnico, e.FecAlta, e.FecAtencion, e.FecGarantia, e.FecConvenio, e.IdSegmento, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.Estado, e.Cp, e.Equipo, e.Segmento, e.NoSerie, e.FecInicio, e.Status, e.IdStatusAr })
                    .HasName("missing_index_3620_3619");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.AgregarDiasAtencion).HasColumnName("AGREGAR_DIAS_ATENCION");

                entity.Property(e => e.Atiende)
                    .HasColumnName("ATIENDE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AutorizadorRechazo)
                    .HasColumnName("AUTORIZADOR_RECHAZO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Bitacora)
                    .HasColumnName("BITACORA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CadenaCierre)
                    .HasColumnName("CADENA_CIERRE")
                    .IsUnicode(false);

                entity.Property(e => e.CadenaCierreEscrita)
                    .HasColumnName("CADENA_CIERRE_ESCRITA")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Caja)
                    .HasColumnName("CAJA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CausaCancelacion)
                    .HasColumnName("CAUSA_CANCELACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CausaRechazo)
                    .HasColumnName("CAUSA_RECHAZO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveRechazo)
                    .HasColumnName("CLAVE_RECHAZO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoIntervencion)
                    .HasColumnName("CODIGO_INTERVENCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEjecutivo)
                    .HasColumnName("CORREO_EJECUTIVO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescCorta)
                    .HasColumnName("DESC_CORTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescEquipo)
                    .HasColumnName("DESC_EQUIPO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo)
                    .HasColumnName("DESCRIPCION_TRABAJO")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.DigitoVerificador)
                    .HasColumnName("DIGITO_VERIFICADOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionAlternaComercio)
                    .HasColumnName("DIRECCION_ALTERNA_COMERCIO")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.DueBy)
                    .HasColumnName("due_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duracion).HasColumnName("DURACION");

                entity.Property(e => e.Equipo)
                    .HasColumnName("EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FallaEncontrada)
                    .HasColumnName("FALLA_ENCONTRADA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecAltaHorasAtencion)
                    .HasColumnName("FEC_ALTA_HORAS_ATENCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAltaReglaStatusAr)
                    .HasColumnName("FEC_ALTA_REGLA_STATUS_AR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAtencion)
                    .HasColumnName("FEC_ATENCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAtencionOriginal)
                    .HasColumnName("FEC_ATENCION_ORIGINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecCarga)
                    .HasColumnName("FEC_CARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecCierre)
                    .HasColumnName("FEC_CIERRE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecConvenio)
                    .HasColumnName("FEC_CONVENIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecFinIngeniero)
                    .HasColumnName("FEC_FIN_INGENIERO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGarantia)
                    .HasColumnName("FEC_GARANTIA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIniIngeniero)
                    .HasColumnName("FEC_INI_INGENIERO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("FEC_INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIntento1)
                    .HasColumnName("FEC_INTENTO_1")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecIntento2)
                    .HasColumnName("FEC_INTENTO_2")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecIntento3)
                    .HasColumnName("FEC_INTENTO_3")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecIntento4)
                    .HasColumnName("FEC_INTENTO_4")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecLlegada)
                    .HasColumnName("FEC_LLEGADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecLlegadaTerceros)
                    .HasColumnName("FEC_LLEGADA_TERCEROS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatusAr)
                    .HasColumnName("FEC_STATUS_AR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FolioServicio)
                    .HasColumnName("FOLIO_SERVICIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolioTas)
                    .HasColumnName("FOLIO_TAS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FolioTelecarga).HasColumnName("FOLIO_TELECARGA");

                entity.Property(e => e.FolioTir)
                    .HasColumnName("FOLIO_TIR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolioValidacion)
                    .HasColumnName("FOLIO_VALIDACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoraAtencionFin).HasColumnName("HORA_ATENCION_FIN");

                entity.Property(e => e.HoraAtencionIni).HasColumnName("HORA_ATENCION_INI");

                entity.Property(e => e.HorasAtencion).HasColumnName("HORAS_ATENCION");

                entity.Property(e => e.HorasAtencionWincor)
                    .HasColumnName("HORAS_ATENCION_WINCOR")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HorasGarantia).HasColumnName("HORAS_GARANTIA");

                entity.Property(e => e.HorasGarantiaWincor)
                    .HasColumnName("HORAS_GARANTIA_WINCOR")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdArOriginal).HasColumnName("ID_AR_ORIGINAL");

                entity.Property(e => e.IdAttach1).HasColumnName("ID_ATTACH1");

                entity.Property(e => e.IdAttach2).HasColumnName("ID_ATTACH2");

                entity.Property(e => e.IdCalificaContacto).HasColumnName("ID_CALIFICA_CONTACTO");

                entity.Property(e => e.IdCalificaIntento1).HasColumnName("ID_CALIFICA_INTENTO_1");

                entity.Property(e => e.IdCalificaIntento2).HasColumnName("ID_CALIFICA_INTENTO_2");

                entity.Property(e => e.IdCalificaIntento3).HasColumnName("ID_CALIFICA_INTENTO_3");

                entity.Property(e => e.IdCalificaIntento4).HasColumnName("ID_CALIFICA_INTENTO_4");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdCausa).HasColumnName("ID_CAUSA");

                entity.Property(e => e.IdCausaRechazo).HasColumnName("ID_CAUSA_RECHAZO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConcepto).HasColumnName("ID_CONCEPTO");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdDescripcionTrabajo).HasColumnName("ID_DESCRIPCION_TRABAJO");

                entity.Property(e => e.IdDispatcher).HasColumnName("ID_DISPATCHER");

                entity.Property(e => e.IdEquipoCliente).HasColumnName("ID_EQUIPO_CLIENTE");

                entity.Property(e => e.IdEspecifTipoFalla).HasColumnName("ID_ESPECIF_TIPO_FALLA");

                entity.Property(e => e.IdEspecificaCausaRechazo).HasColumnName("ID_ESPECIFICA_CAUSA_RECHAZO");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdModeloFalla).HasColumnName("ID_MODELO_FALLA");

                entity.Property(e => e.IdModeloReq).HasColumnName("ID_MODELO_REQ");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdPlaza).HasColumnName("ID_PLAZA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_PROVEEDOR");

                entity.Property(e => e.IdProyecto).HasColumnName("ID_PROYECTO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdReglaStatusAr).HasColumnName("ID_REGLA_STATUS_AR");

                entity.Property(e => e.IdReporteCierre).HasColumnName("ID_REPORTE_CIERRE");

                entity.Property(e => e.IdResponsableCancelacionProgramado).HasColumnName("ID_RESPONSABLE_CANCELACION_PROGRAMADO");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdSolucion).HasColumnName("ID_SOLUCION");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.IdStatusReasonCodes).HasColumnName("ID_STATUS_REASON_CODES");

                entity.Property(e => e.IdStatusValidacionPrefacturacion).HasColumnName("ID_STATUS_VALIDACION_PREFACTURACION");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdTipoCobro).HasColumnName("ID_TIPO_COBRO");

                entity.Property(e => e.IdTipoEquipo).HasColumnName("ID_TIPO_EQUIPO");

                entity.Property(e => e.IdTipoFallaEncontrada).HasColumnName("ID_TIPO_FALLA_ENCONTRADA");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("ID_TIPO_PLAZA");

                entity.Property(e => e.IdTipoPrecio).HasColumnName("ID_TIPO_PRECIO");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TIPO_SERVICIO");

                entity.Property(e => e.IdUnidadAtendida).HasColumnName("ID_UNIDAD_ATENDIDA");

                entity.Property(e => e.IdUsuarioCierre).HasColumnName("ID_USUARIO_CIERRE");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.Insumos).HasColumnName("INSUMOS");

                entity.Property(e => e.IntensidadSenial)
                    .HasColumnName("INTENSIDAD_SENIAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntentoContacto).HasColumnName("INTENTO_CONTACTO");

                entity.Property(e => e.IsActualizacion).HasColumnName("IS_ACTUALIZACION");

                entity.Property(e => e.IsBoletin).HasColumnName("IS_BOLETIN");

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.IsDuplicada).HasColumnName("IS_DUPLICADA");

                entity.Property(e => e.IsExito).HasColumnName("IS_EXITO");

                entity.Property(e => e.IsFollowDispatch).HasColumnName("IS_FOLLOW_DISPATCH");

                entity.Property(e => e.IsGarantia).HasColumnName("IS_GARANTIA");

                entity.Property(e => e.IsIngresoManual).HasColumnName("IS_INGRESO_MANUAL");

                entity.Property(e => e.IsInstalacion).HasColumnName("IS_INSTALACION");

                entity.Property(e => e.IsInterfazBancomer).HasColumnName("IS_INTERFAZ_BANCOMER");

                entity.Property(e => e.IsLocal).HasColumnName("IS_LOCAL");

                entity.Property(e => e.IsPdf).HasColumnName("IS_PDF");

                entity.Property(e => e.IsProgramado).HasColumnName("IS_PROGRAMADO");

                entity.Property(e => e.IsRetipificado).HasColumnName("IS_RETIPIFICADO");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.IsSimRemplazada).HasColumnName("IS_SIM_REMPLAZADA");

                entity.Property(e => e.IsSoporteCliente).HasColumnName("IS_SOPORTE_CLIENTE");

                entity.Property(e => e.IsSustitucion).HasColumnName("IS_SUSTITUCION");

                entity.Property(e => e.IsTecnicoForaneo).HasColumnName("IS_TECNICO_FORANEO");

                entity.Property(e => e.MinsDowntime)
                    .HasColumnName("MINS_DOWNTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoCobro)
                    .HasColumnName("MOTIVO_COBRO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoRetipificado)
                    .HasColumnName("MOTIVO_RETIPIFICADO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoDiasLiberacion).HasColumnName("NO_DIAS_LIBERACION");

                entity.Property(e => e.NoEquipo)
                    .HasColumnName("NO_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventarioFalla)
                    .HasColumnName("NO_INVENTARIO_FALLA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoReincidencias).HasColumnName("NO_REINCIDENCIAS");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieFalla)
                    .HasColumnName("NO_SERIE_FALLA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotViaticos).HasColumnName("NOT_VIATICOS");

                entity.Property(e => e.NotasRemedy)
                    .HasColumnName("NOTAS_REMEDY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteSoporteCliente)
                    .HasColumnName("OTORGANTE_SOPORTE_CLIENTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteTas)
                    .HasColumnName("OTORGANTE_TAS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVobo)
                    .HasColumnName("OTORGANTE_VOBO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVoboCliente)
                    .HasColumnName("OTORGANTE_VOBO_CLIENTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVoboTerceros)
                    .HasColumnName("OTORGANTE_VOBO_TERCEROS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaAtenderaComercio)
                    .HasColumnName("PERSONA_ATENDERA_COMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioExito)
                    .HasColumnName("PRECIO_EXITO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProveedorAtenderaComercio)
                    .HasColumnName("PROVEEDOR_ATENDERA_COMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rp).HasColumnName("RP");

                entity.Property(e => e.Rs).HasColumnName("RS");

                entity.Property(e => e.Segmento).HasColumnName("SEGMENTO");

                entity.Property(e => e.Sintoma)
                    .HasColumnName("SINTOMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoComercio)
                    .HasColumnName("TELEFONO_COMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalAmex).HasColumnName("TERMINAL_AMEX");

                entity.Property(e => e.TipoFalla).HasColumnName("TIPO_FALLA");

                entity.Property(e => e.TipoServicio).HasColumnName("TIPO_SERVICIO");

                entity.Property(e => e.Traslado).HasColumnName("TRASLADO");

                entity.Property(e => e.VoltajeNeutro)
                    .HasColumnName("VOLTAJE_NEUTRO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoltajeTierra)
                    .HasColumnName("VOLTAJE_TIERRA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoltajeTierraNeutro)
                    .HasColumnName("VOLTAJE_TIERRA_NEUTRO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArAccesorios>(entity =>
            {
                entity.HasKey(e => e.IdArAccesorio)
                    .HasName("PK__BD_AR_AC__3C0DB632687A5639");

                entity.ToTable("BD_AR_ACCESORIOS");

                entity.Property(e => e.IdArAccesorio).HasColumnName("ID_AR_ACCESORIO");

                entity.Property(e => e.Base)
                    .HasColumnName("BASE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bateria)
                    .HasColumnName("BATERIA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CableAc)
                    .HasColumnName("CABLE_AC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Eliminador)
                    .HasColumnName("ELIMINADOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.Tapa)
                    .HasColumnName("TAPA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArArchivosVarios>(entity =>
            {
                entity.HasKey(e => e.IdArArchivoVarios);

                entity.ToTable("BD_AR_ARCHIVOS_VARIOS");

                entity.HasIndex(e => new { e.IdAr, e.Status })
                    .HasName("IX_BD_AR_ARCHIVOS_VARIOS_ID_AR, STATUS");

                entity.Property(e => e.IdArArchivoVarios).HasColumnName("ID_AR_ARCHIVO_VARIOS");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaStatus)
                    .HasColumnName("FECHA_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdTipoArchivo).HasColumnName("ID_TIPO_ARCHIVO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.NombreArchivoSistema)
                    .HasColumnName("NOMBRE_ARCHIVO_SISTEMA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoUsuario)
                    .HasColumnName("NOMBRE_ARCHIVO_USUARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArCausasCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdArCausaCancelacion)
                    .HasName("PK__BD_AR_CA__DCE7FEACEBEBAB20");

                entity.ToTable("BD_AR_CAUSAS_CANCELACION");

                entity.Property(e => e.IdArCausaCancelacion).HasColumnName("ID_AR_CAUSA_CANCELACION");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdCausaCancelacion).HasColumnName("ID_CAUSA_CANCELACION");
            });

            modelBuilder.Entity<BdArDatosComerciosExtra>(entity =>
            {
                entity.HasKey(e => e.IdArDatoComercioExtra)
                    .HasName("PK__BD_AR_DA__F4BBDEAE0F219F6C");

                entity.ToTable("BD_AR_DATOS_COMERCIOS_EXTRA");

                entity.Property(e => e.IdArDatoComercioExtra).HasColumnName("ID_AR_DATO_COMERCIO_EXTRA");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaAtendera)
                    .HasColumnName("PERSONA_ATENDERA")
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorAtendera)
                    .HasColumnName("PROVEEDOR_ATENDERA")
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArDesviacion>(entity =>
            {
                entity.HasKey(e => e.IdArDesviacion);

                entity.ToTable("BD_AR_DESVIACION");

                entity.Property(e => e.IdArDesviacion).HasColumnName("ID_AR_DESVIACION");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("FECHA_FIN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("FECHA_INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HaveDescripcion).HasColumnName("HAVE_DESCRIPCION");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdDesviacion).HasColumnName("ID_DESVIACION");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdDesviacionNavigation)
                    .WithMany(p => p.BdArDesviacion)
                    .HasForeignKey(d => d.IdDesviacion)
                    .HasConstraintName("FK_BD_AR_DESVIACION_C_DESVIACIONES");
            });

            modelBuilder.Entity<BdArDiasAtencion>(entity =>
            {
                entity.HasKey(e => e.IdArDiasAtencion)
                    .HasName("PK__BD_AR_DI__1FA76D7F34B45D23");

                entity.ToTable("BD_AR_DIAS_ATENCION");

                entity.Property(e => e.IdArDiasAtencion).HasColumnName("ID_AR_DIAS_ATENCION");

                entity.Property(e => e.Domingo).HasColumnName("DOMINGO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Jueves).HasColumnName("JUEVES");

                entity.Property(e => e.Lunes).HasColumnName("LUNES");

                entity.Property(e => e.Martes).HasColumnName("MARTES");

                entity.Property(e => e.Miercoles).HasColumnName("MIERCOLES");

                entity.Property(e => e.Sabado).HasColumnName("SABADO");

                entity.Property(e => e.Viernes).HasColumnName("VIERNES");
            });

            modelBuilder.Entity<BdArExtension>(entity =>
            {
                entity.ToTable("BD_AR_EXTENSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FecLlegadaIngPartner)
                    .HasColumnName("FEC_LLEGADA_ING_PARTNER")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.Is2TaquetesAdicionales).HasColumnName("IS_2_TAQUETES_ADICIONALES");

                entity.Property(e => e.IsBlindajeTuercaSeguridad).HasColumnName("IS_BLINDAJE_TUERCA_SEGURIDAD");

                entity.Property(e => e.IsFotografias).HasColumnName("IS_FOTOGRAFIAS");

                entity.Property(e => e.IsInstalacionPlacaFrontal).HasColumnName("IS_INSTALACION_PLACA_FRONTAL");

                entity.Property(e => e.IsInstalacionPlacaLateral).HasColumnName("IS_INSTALACION_PLACA_LATERAL");

                entity.Property(e => e.IsSustitucion4Tuercas).HasColumnName("IS_SUSTITUCION_4_TUERCAS");

                entity.Property(e => e.IsValidacionAlarmas).HasColumnName("IS_VALIDACION_ALARMAS");

                entity.Property(e => e.Motivo2TaquetesAdicionales)
                    .HasColumnName("MOTIVO_2_TAQUETES_ADICIONALES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoBlindajeTuercaSeguridad)
                    .HasColumnName("MOTIVO_BLINDAJE_TUERCA_SEGURIDAD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoFotografias)
                    .HasColumnName("MOTIVO_FOTOGRAFIAS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoInstalacionPlacaFrontal)
                    .HasColumnName("MOTIVO_INSTALACION_PLACA_FRONTAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoInstalacionPlacaLateral)
                    .HasColumnName("MOTIVO_INSTALACION_PLACA_LATERAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoSustitucion4Tuercas)
                    .HasColumnName("MOTIVO_SUSTITUCION_4_TUERCAS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVoboIngPartner)
                    .HasColumnName("OTORGANTE_VOBO_ING_PARTNER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalBanco)
                    .HasColumnName("PERSONAL_BANCO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReporteServicioPartner)
                    .HasColumnName("REPORTE_SERVICIO_PARTNER")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArFecGarantia>(entity =>
            {
                entity.HasKey(e => e.IdArFecGarantia)
                    .HasName("PK__BD_AR_FE__8E7CE109CCF2D87C");

                entity.ToTable("BD_AR_FEC_GARANTIA");

                entity.Property(e => e.IdArFecGarantia).HasColumnName("ID_AR_FEC_GARANTIA");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArInsumo>(entity =>
            {
                entity.HasKey(e => e.IdArInsumo);

                entity.ToTable("BD_AR_INSUMO");

                entity.HasIndex(e => new { e.IsMicrosip, e.ControlMicrosip })
                    .HasName("IX_BD_AR_INSUMO");

                entity.Property(e => e.IdArInsumo).HasColumnName("ID_AR_INSUMO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.ControlMicrosip).HasColumnName("CONTROL_MICROSIP");

                entity.Property(e => e.CostoTotal)
                    .HasColumnName("COSTO_TOTAL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostoUnitario)
                    .HasColumnName("COSTO_UNITARIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsMicrosip).HasColumnName("IS_MICROSIP");
            });

            modelBuilder.Entity<BdArLogWs>(entity =>
            {
                entity.HasKey(e => e.IdArLogWs)
                    .HasName("PK__BD_AR_LO__198419D80AD9AB5B");

                entity.ToTable("BD_AR_LOG_WS");

                entity.Property(e => e.IdArLogWs).HasColumnName("ID_AR_LOG_WS");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdArPrefacturacion);

                entity.ToTable("BD_AR_PREFACTURACION");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdAr, e.Counter, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.Status })
                    .HasName("IX_BD_AR_PREFACTURACION_ID_TIPO_RESPONSABLE_DOCTO_PREFACTURACION_FISICO, ID_STATUS_DOCTO_PREFACTURACION_FISICO, STATUS");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdAr, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.Status })
                    .HasName("IX_MI_BD_AR_PREFACTURACION_6509_6508");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdAr, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.Status })
                    .HasName("IX_MI_BD_AR_PREFACTURACION_122_121");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.IdAr, e.Status })
                    .HasName("IX_BD_AR_PREFACTURACION_ID_AR, STATUS");

                entity.HasIndex(e => new { e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.IdArPrefacturacion, e.IdAr, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.Status })
                    .HasName("IX_MI_BD_AR_PREFACTURACION_13804_13803");

                entity.Property(e => e.IdArPrefacturacion).HasColumnName("ID_AR_PREFACTURACION");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdBitacoraAgendado).HasColumnName("ID_BITACORA_AGENDADO");

                entity.Property(e => e.IdCausaRechazoDefinitivoDoctoPrefacturacion).HasColumnName("ID_CAUSA_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION");

                entity.Property(e => e.IdResponsableDoctoPrefacturacionDigital).HasColumnName("ID_RESPONSABLE_DOCTO_PREFACTURACION_DIGITAL");

                entity.Property(e => e.IdResponsableDoctoPrefacturacionFisico).HasColumnName("ID_RESPONSABLE_DOCTO_PREFACTURACION_FISICO");

                entity.Property(e => e.IdStatusArPrefacturacion).HasColumnName("ID_STATUS_AR_PREFACTURACION");

                entity.Property(e => e.IdStatusDoctoPrefacturacionDigital).HasColumnName("ID_STATUS_DOCTO_PREFACTURACION_DIGITAL");

                entity.Property(e => e.IdStatusDoctoPrefacturacionFisico).HasColumnName("ID_STATUS_DOCTO_PREFACTURACION_FISICO");

                entity.Property(e => e.IdTarea).HasColumnName("ID_TAREA");

                entity.Property(e => e.IdTipoResponsableDoctoPrefacturacionDigital).HasColumnName("ID_TIPO_RESPONSABLE_DOCTO_PREFACTURACION_DIGITAL");

                entity.Property(e => e.IdTipoResponsableDoctoPrefacturacionFisico).HasColumnName("ID_TIPO_RESPONSABLE_DOCTO_PREFACTURACION_FISICO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArSparePart>(entity =>
            {
                entity.HasKey(e => e.IdArSparePart);

                entity.ToTable("BD_AR_SPARE_PART");

                entity.Property(e => e.IdArSparePart).HasColumnName("ID_AR_SPARE_PART");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.PrecioTotal)
                    .HasColumnName("PRECIO_TOTAL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("PRECIO_UNITARIO")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdArSparePart)
                    .HasForeignKey(d => d.IdSparePart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_AR_SPARE_PART_C_SPARE_PARTS");
            });

            modelBuilder.Entity<BdArTerminalAsociadaAmex>(entity =>
            {
                entity.HasKey(e => e.IdArTerminalAsociadaAmex)
                    .HasName("PK__BD_AR_TE__007BB9C43669A860");

                entity.ToTable("BD_AR_TERMINAL_ASOCIADA_AMEX");

                entity.HasIndex(e => e.IdAr)
                    .HasName("missing_index_260_259");

                entity.Property(e => e.IdArTerminalAsociadaAmex).HasColumnName("ID_AR_TERMINAL_ASOCIADA_AMEX");

                entity.Property(e => e.AfiliacionTerminalAmex)
                    .HasColumnName("AFILIACION_TERMINAL_AMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdTerminalAmex)
                    .HasColumnName("ID_TERMINAL_AMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdArViatico>(entity =>
            {
                entity.HasKey(e => e.IdArViatico);

                entity.ToTable("BD_AR_VIATICO");

                entity.Property(e => e.IdArViatico).HasColumnName("ID_AR_VIATICO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdViatico).HasColumnName("ID_VIATICO");

                entity.HasOne(d => d.IdViaticoNavigation)
                    .WithMany(p => p.BdArViatico)
                    .HasForeignKey(d => d.IdViatico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_AR_VIATICO_C_VIATICOS");
            });

            modelBuilder.Entity<BdArViaticoMotivo>(entity =>
            {
                entity.HasKey(e => e.IdArViaticoMotivo);

                entity.ToTable("BD_AR_VIATICO_MOTIVO");

                entity.Property(e => e.IdArViaticoMotivo).HasColumnName("ID_AR_VIATICO_MOTIVO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdMotivo).HasColumnName("ID_MOTIVO");

                entity.Property(e => e.IdSolicitudViatico).HasColumnName("ID_SOLICITUD_VIATICO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArVisitas>(entity =>
            {
                entity.HasKey(e => e.IdArVisita);

                entity.ToTable("BD_AR_VISITAS");

                entity.Property(e => e.IdArVisita).HasColumnName("ID_AR_VISITA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecVisita)
                    .HasColumnName("FEC_VISITA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdTipoCobro).HasColumnName("ID_TIPO_COBRO");

                entity.Property(e => e.IdTipoPrecio).HasColumnName("ID_TIPO_PRECIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoCobroNavigation)
                    .WithMany(p => p.BdArVisitas)
                    .HasForeignKey(d => d.IdTipoCobro)
                    .HasConstraintName("FK_BD_AR_VISITAS_C_TIPO_COBRO");
            });

            modelBuilder.Entity<BdArchivoDispersionSolicitudViaticos>(entity =>
            {
                entity.HasKey(e => e.IdArchivoDispersionSolicitudViaticos);

                entity.ToTable("BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS");

                entity.HasIndex(e => e.IdArchivoDispersion)
                    .HasName("IX_MI_BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS_5743_5742");

                entity.HasIndex(e => e.IdSolicitudViaticos);

                entity.Property(e => e.IdArchivoDispersionSolicitudViaticos).HasColumnName("ID_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdArchivoDispersion).HasColumnName("ID_ARCHIVO_DISPERSION");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdArchivoDispersionNavigation)
                    .WithMany(p => p.BdArchivoDispersionSolicitudViaticos)
                    .HasForeignKey(d => d.IdArchivoDispersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS_BD_ARCHIVOS_DISPERSION");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdArchivoDispersionSolicitudViaticos)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdArchivosConfirmaciones>(entity =>
            {
                entity.HasKey(e => e.IdArchivoConfirmaciones);

                entity.ToTable("BD_ARCHIVOS_CONFIRMACIONES");

                entity.Property(e => e.IdArchivoConfirmaciones).HasColumnName("ID_ARCHIVO_CONFIRMACIONES");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCargaConfirmaciones).HasColumnName("ID_CARGA_CONFIRMACIONES");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreArchivoConfirmacionesSystem)
                    .HasColumnName("NOMBRE_ARCHIVO_CONFIRMACIONES_SYSTEM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoConfirmacionesUser)
                    .HasColumnName("NOMBRE_ARCHIVO_CONFIRMACIONES_USER")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargaConfirmacionesNavigation)
                    .WithMany(p => p.BdArchivosConfirmaciones)
                    .HasForeignKey(d => d.IdCargaConfirmaciones)
                    .HasConstraintName("FK_BD_ARCHIVOS_CONFIRMACIONES_BD_CARGAS_CONFIRMACIONES");
            });

            modelBuilder.Entity<BdArchivosDispersion>(entity =>
            {
                entity.HasKey(e => e.IdArchivoDispersion)
                    .HasName("PK_BD_ARCHIVO_DISPERSION");

                entity.ToTable("BD_ARCHIVOS_DISPERSION");

                entity.Property(e => e.IdArchivoDispersion).HasColumnName("ID_ARCHIVO_DISPERSION");

                entity.Property(e => e.Carpeta)
                    .HasColumnName("CARPETA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdBanco).HasColumnName("ID_BANCO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreArchivoDispersion)
                    .IsRequired()
                    .HasColumnName("NOMBRE_ARCHIVO_DISPERSION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdArchivosPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdArchivoPrefacturacion);

                entity.ToTable("BD_ARCHIVOS_PREFACTURACION");

                entity.HasIndex(e => new { e.IdArchivoPrefacturacion, e.NombreArchivoPrefacturacionSystem, e.IdArPrefacturacion })
                    .HasName("IX_BD_ARCHIVOS_PREFACTURACION_ID_AR_PREFACTURACION");

                entity.Property(e => e.IdArchivoPrefacturacion).HasColumnName("ID_ARCHIVO_PREFACTURACION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdArPrefacturacion).HasColumnName("ID_AR_PREFACTURACION");

                entity.Property(e => e.IdStatusCargaArchivoPrefacturacion).HasColumnName("ID_STATUS_CARGA_ARCHIVO_PREFACTURACION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreArchivoPrefacturacionSystem)
                    .HasColumnName("NOMBRE_ARCHIVO_PREFACTURACION_SYSTEM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoPrefacturacionUser)
                    .HasColumnName("NOMBRE_ARCHIVO_PREFACTURACION_USER")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAsignacionAutomaticaPaso>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionAutomaticaPaso)
                    .HasName("PK__BD_ASIGN__E220F956EE46FDF0");

                entity.ToTable("BD_ASIGNACION_AUTOMATICA_PASO");

                entity.Property(e => e.IdAsignacionAutomaticaPaso).HasColumnName("ID_ASIGNACION_AUTOMATICA_PASO");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAttach>(entity =>
            {
                entity.HasKey(e => e.IdAttach);

                entity.ToTable("BD_ATTACH");

                entity.HasIndex(e => new { e.DescAttach, e.SystemFilename, e.IdUsuarioAlta })
                    .HasName("IX_MI_BD_ATTACH_26_25");

                entity.Property(e => e.IdAttach).HasColumnName("ID_ATTACH");

                entity.Property(e => e.DescAttach)
                    .HasColumnName("DESC_ATTACH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTipoArchivo).HasColumnName("ID_TIPO_ARCHIVO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.SystemFilename)
                    .HasColumnName("SYSTEM_FILENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserFilename)
                    .HasColumnName("USER_FILENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAttachAcciones>(entity =>
            {
                entity.HasKey(e => e.IdAttachAcciones);

                entity.ToTable("BD_ATTACH_ACCIONES");

                entity.Property(e => e.IdAttachAcciones).HasColumnName("ID_ATTACH_ACCIONES");

                entity.Property(e => e.DescAttach)
                    .HasColumnName("DESC_ATTACH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompromisosAcciones).HasColumnName("ID_COMPROMISOS_ACCIONES");

                entity.Property(e => e.IdTipoArchivo).HasColumnName("ID_TIPO_ARCHIVO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemFilename)
                    .HasColumnName("SYSTEM_FILENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserFilename)
                    .HasColumnName("USER_FILENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAttachDhl>(entity =>
            {
                entity.HasKey(e => e.IdAttachDhl)
                    .HasName("PK__BD_ATTAC__9661FD0AB2A16046");

                entity.ToTable("BD_ATTACH_DHL");

                entity.Property(e => e.IdAttachDhl).HasColumnName("ID_ATTACH_DHL");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoFactura)
                    .HasColumnName("NO_FACTURA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoSistema)
                    .HasColumnName("NOMBRE_ARCHIVO_SISTEMA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoUsuario)
                    .HasColumnName("NOMBRE_ARCHIVO_USUARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdAuditoriaReporte>(entity =>
            {
                entity.HasKey(e => e.IdAuditoriaReporte);

                entity.ToTable("BD_AUDITORIA_REPORTE");

                entity.Property(e => e.IdAuditoriaReporte).HasColumnName("ID_AUDITORIA_REPORTE");

                entity.Property(e => e.Efectividad).HasColumnName("EFECTIVIDAD");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArchivoAttach).HasColumnName("ID_ARCHIVO_ATTACH");

                entity.Property(e => e.IdAuditoria).HasColumnName("ID_AUDITORIA");

                entity.Property(e => e.IdResponsableInventario).HasColumnName("ID_RESPONSABLE_INVENTARIO");

                entity.Property(e => e.IdTipoInventario).HasColumnName("ID_TIPO_INVENTARIO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.ItemsEnSistema).HasColumnName("ITEMS_EN_SISTEMA");

                entity.Property(e => e.Reporte)
                    .HasColumnName("REPORTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAuditoriaNavigation)
                    .WithMany(p => p.BdAuditoriaReporte)
                    .HasForeignKey(d => d.IdAuditoria)
                    .HasConstraintName("FK_BD_AUDITORIA_REPORTE_BD_AUDITORIAS");

                entity.HasOne(d => d.IdTipoInventarioNavigation)
                    .WithMany(p => p.BdAuditoriaReporte)
                    .HasForeignKey(d => d.IdTipoInventario)
                    .HasConstraintName("FK_BD_AUDITORIA_REPORTE_C_TIPO_INVENTARIO");
            });

            modelBuilder.Entity<BdAuditorias>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria);

                entity.ToTable("BD_AUDITORIAS");

                entity.Property(e => e.IdAuditoria).HasColumnName("ID_AUDITORIA");

                entity.Property(e => e.DescAuditoria)
                    .HasColumnName("DESC_AUDITORIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("FECHA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("FECHA_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdTipoAuditoria).HasColumnName("ID_TIPO_AUDITORIA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoAuditoriaNavigation)
                    .WithMany(p => p.BdAuditorias)
                    .HasForeignKey(d => d.IdTipoAuditoria)
                    .HasConstraintName("FK_BD_AUDITORIAS_C_TIPO_AUDITORIA");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdAuditorias)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_AUDITORIAS_C_USUARIOS");
            });

            modelBuilder.Entity<BdBbvaPaso>(entity =>
            {
                entity.HasKey(e => e.IdBbvaPaso)
                    .HasName("PK__BD_BBVA___E65BC1FA0EFA7622");

                entity.ToTable("BD_BBVA_PASO");

                entity.Property(e => e.IdBbvaPaso).HasColumnName("ID_BBVA_PASO");

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.From)
                    .HasColumnName("FROM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumberMsg).HasColumnName("NUMBER_MSG");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraAcceso>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK_BD_BITACORA");

                entity.ToTable("BD_BITACORA_ACCESO");

                entity.HasIndex(e => new { e.IdUsuario, e.Status })
                    .HasName("IX_BD_BITACORA_ACCESO_STATUS");

                entity.HasIndex(e => new { e.IdBitacora, e.Status, e.IdUsuario })
                    .HasName("IX_BD_BITACORA_ACCESO_ID_USUARIO");

                entity.Property(e => e.IdBitacora).HasColumnName("ID_BITACORA");

                entity.Property(e => e.Acceso)
                    .HasColumnName("ACCESO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Host)
                    .HasColumnName("HOST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IpCliente)
                    .HasColumnName("IP_CLIENTE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraAgendados>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraAgendado)
                    .HasName("PK_BD_BITACORA_AGENDADO");

                entity.ToTable("BD_BITACORA_AGENDADOS");

                entity.Property(e => e.IdBitacoraAgendado).HasColumnName("ID_BITACORA_AGENDADO");

                entity.Property(e => e.Autorizador)
                    .IsRequired()
                    .HasColumnName("AUTORIZADOR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAtencionFin)
                    .HasColumnName("FEC_ATENCION_FIN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAtencionIni)
                    .HasColumnName("FEC_ATENCION_INI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FolioTir)
                    .HasColumnName("FOLIO_TIR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdComentarioAgendado).HasColumnName("ID_COMENTARIO_AGENDADO");

                entity.Property(e => e.IdResponsableAgendado).HasColumnName("ID_RESPONSABLE_AGENDADO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsVisitaAgendado).HasColumnName("IS_VISITA_AGENDADO");

                entity.HasOne(d => d.IdResponsableAgendadoNavigation)
                    .WithMany(p => p.BdBitacoraAgendados)
                    .HasForeignKey(d => d.IdResponsableAgendado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_AGENDADOS_C_RESPONSABLES_AGENDADOS");
            });

            modelBuilder.Entity<BdBitacoraAlmacenResponsable>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraAlmacenResponsable)
                    .HasName("PK__BD_BITAC__C7B56735102FD125");

                entity.ToTable("BD_BITACORA_ALMACEN_RESPONSABLE");

                entity.Property(e => e.IdBitacoraAlmacenResponsable).HasColumnName("ID_BITACORA_ALMACEN_RESPONSABLE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdResponsableActual).HasColumnName("ID_RESPONSABLE_ACTUAL");

                entity.Property(e => e.IdResponsableAnterior).HasColumnName("ID_RESPONSABLE_ANTERIOR");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdBitacoraAlmacenStatus>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__BD_BITAC__44E70BF3CBD33EC1");

                entity.ToTable("BD_BITACORA_ALMACEN_STATUS");

                entity.Property(e => e.IdBitacora).HasColumnName("ID_BITACORA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.StatusActual)
                    .HasColumnName("STATUS_ACTUAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAnterior)
                    .HasColumnName("STATUS_ANTERIOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraAplicativoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdAplicativoUnidad)
                    .HasName("PK__BD_BITAC__5AD934711BCD189D");

                entity.ToTable("BD_BITACORA_APLICATIVO_UNIDAD");

                entity.Property(e => e.IdAplicativoUnidad).HasColumnName("ID_APLICATIVO_UNIDAD");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAplicativoNuevo).HasColumnName("ID_APLICATIVO_NUEVO");

                entity.Property(e => e.IdAplicativoViejo).HasColumnName("ID_APLICATIVO_VIEJO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraAr>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraAr);

                entity.ToTable("BD_BITACORA_AR");

                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_BD_BITACORA_AR");

                entity.HasIndex(e => new { e.IdAr, e.FecAlta, e.IdStatusArFin })
                    .HasName("IX_BD_BITACORA_AR_ID_STATUS_AR_FIN");

                entity.Property(e => e.IdBitacoraAr).HasColumnName("ID_BITACORA_AR");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdStatusArFin).HasColumnName("ID_STATUS_AR_FIN");

                entity.Property(e => e.IdStatusArIni).HasColumnName("ID_STATUS_AR_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsCambioValido).HasColumnName("IS_CAMBIO_VALIDO");

                entity.Property(e => e.IsPda).HasColumnName("IS_PDA");
            });

            modelBuilder.Entity<BdBitacoraArAlta>(entity =>
            {
                entity.HasKey(e => e.IdArBitacoraArAlta)
                    .HasName("PK__BD_BITAC__98F6235C730E7EEE");

                entity.ToTable("BD_BITACORA_AR_ALTA");

                entity.HasIndex(e => e.IdAr)
                    .HasName("missing_index_170_169");

                entity.Property(e => e.IdArBitacoraArAlta).HasColumnName("ID_AR_BITACORA_AR_ALTA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdBitacoraBorrarUnidad>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraBorrarUnidad);

                entity.ToTable("BD_BITACORA_BORRAR_UNIDAD");

                entity.Property(e => e.IdBitacoraBorrarUnidad).HasColumnName("ID_BITACORA_BORRAR_UNIDAD");

                entity.Property(e => e.FecBorrado)
                    .HasColumnName("FEC_BORRADO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioBorrado).HasColumnName("ID_USUARIO_BORRADO");
            });

            modelBuilder.Entity<BdBitacoraCambioMensajeria>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCambioMensajeria)
                    .HasName("PK__BD_BITAC__DE3FA500EC2545D0");

                entity.ToTable("BD_BITACORA_CAMBIO_MENSAJERIA");

                entity.Property(e => e.IdBitacoraCambioMensajeria).HasColumnName("ID_BITACORA_CAMBIO_MENSAJERIA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdMensajeriaFin).HasColumnName("ID_MENSAJERIA_FIN");

                entity.Property(e => e.IdMensajeriaIni).HasColumnName("ID_MENSAJERIA_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraCambioNoInventario>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCambioNoInventario)
                    .HasName("PK__BD_BITAC__F428328E38F56859");

                entity.ToTable("BD_BITACORA_CAMBIO_NO_INVENTARIO");

                entity.Property(e => e.IdBitacoraCambioNoInventario).HasColumnName("ID_BITACORA_CAMBIO_NO_INVENTARIO");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasColumnName("SERIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraCambioSerie>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__BD_BITAC__44E70BF307B4B974");

                entity.ToTable("BD_BITACORA_CAMBIO_SERIE");

                entity.Property(e => e.IdBitacora).HasColumnName("ID_BITACORA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.NoSerieNew)
                    .HasColumnName("NO_SERIE_NEW")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasColumnName("SERIE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraCambioUnidadNueva>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCambioUnidadNueva)
                    .HasName("PK__BD_BITAC__26B9B0F3A536F58F");

                entity.ToTable("BD_BITACORA_CAMBIO_UNIDAD_NUEVA");

                entity.Property(e => e.IdBitacoraCambioUnidadNueva).HasColumnName("ID_BITACORA_CAMBIO_UNIDAD_NUEVA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBitacoraUnidad).HasColumnName("ID_BITACORA_UNIDAD");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");
            });

            modelBuilder.Entity<BdBitacoraCompromisos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCompromisos);

                entity.ToTable("BD_BITACORA_COMPROMISOS");

                entity.Property(e => e.IdBitacoraCompromisos).HasColumnName("ID_BITACORA_COMPROMISOS");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompromiso).HasColumnName("ID_COMPROMISO");

                entity.Property(e => e.IdStatusJuntaFin).HasColumnName("ID_STATUS_JUNTA_FIN");

                entity.Property(e => e.IdStatusJuntaIni).HasColumnName("ID_STATUS_JUNTA_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraConectividadUnidad>(entity =>
            {
                entity.HasKey(e => e.IdConectividadUnidad)
                    .HasName("PK__BD_BITAC__0532997335CA4CCA");

                entity.ToTable("BD_BITACORA_CONECTIVIDAD_UNIDAD");

                entity.Property(e => e.IdConectividadUnidad).HasColumnName("ID_CONECTIVIDAD_UNIDAD");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdConectividadNueva).HasColumnName("ID_CONECTIVIDAD_NUEVA");

                entity.Property(e => e.IdConectividadVieja).HasColumnName("ID_CONECTIVIDAD_VIEJA");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraDiagnostico>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraDiagnostico)
                    .HasName("PK_BD_BITACORA_DIAGNOSTICO_1");

                entity.ToTable("BD_BITACORA_DIAGNOSTICO");

                entity.HasIndex(e => e.IdUnidad);

                entity.Property(e => e.IdBitacoraDiagnostico).HasColumnName("ID_BITACORA_DIAGNOSTICO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdNivelDiagnostico).HasColumnName("ID_NIVEL_DIAGNOSTICO");

                entity.Property(e => e.IdTecnicoCambio).HasColumnName("ID_TECNICO_CAMBIO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");
            });

            modelBuilder.Entity<BdBitacoraDoctosPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraDoctosPrefacturacion);

                entity.ToTable("BD_BITACORA_DOCTOS_PREFACTURACION");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdStatusDoctoPrefacturacionFin })
                    .HasName("IX_BD_BITACORA_DOCTOS_PREFACTURACION_ID_AR_PREFACTURACION, ID_STATUS_DOCTO_PREFACTURACION_FIN");

                entity.Property(e => e.IdBitacoraDoctosPrefacturacion).HasColumnName("ID_BITACORA_DOCTOS_PREFACTURACION");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdArPrefacturacion).HasColumnName("ID_AR_PREFACTURACION");

                entity.Property(e => e.IdResponsablePrefacturacion).HasColumnName("ID_RESPONSABLE_PREFACTURACION");

                entity.Property(e => e.IdStatusDoctoPrefacturacionFin).HasColumnName("ID_STATUS_DOCTO_PREFACTURACION_FIN");

                entity.Property(e => e.IdStatusDoctoPrefacturacionIni).HasColumnName("ID_STATUS_DOCTO_PREFACTURACION_INI");

                entity.Property(e => e.IdTipoDoctoPrefacturacion).HasColumnName("ID_TIPO_DOCTO_PREFACTURACION");

                entity.Property(e => e.IdTipoResponsablePrefacturacion)
                    .HasColumnName("ID_TIPO_RESPONSABLE_PREFACTURACION")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraEnvio>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraEnvio);

                entity.ToTable("BD_BITACORA_ENVIO");

                entity.HasIndex(e => e.IdEnvio)
                    .HasName("IX_MI_BD_BITACORA_ENVIO_9263_9262");

                entity.Property(e => e.IdBitacoraEnvio).HasColumnName("ID_BITACORA_ENVIO");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdStatusEnvioFin).HasColumnName("ID_STATUS_ENVIO_FIN");

                entity.Property(e => e.IdStatusEnvioIni).HasColumnName("ID_STATUS_ENVIO_INI");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraIgualas>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraIgualas);

                entity.ToTable("BD_BITACORA_IGUALAS");

                entity.Property(e => e.IdBitacoraIgualas).HasColumnName("ID_BITACORA_IGUALAS");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdIgualas).HasColumnName("ID_IGUALAS");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.StatusFin)
                    .HasColumnName("STATUS_FIN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusIni)
                    .HasColumnName("STATUS_INI")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraInsumo)
                    .HasName("PK_BD_BITACORA_INSUMO");

                entity.ToTable("BD_BITACORA_INSUMOS");

                entity.Property(e => e.IdBitacoraInsumo).HasColumnName("ID_BITACORA_INSUMO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusInsumoFin).HasColumnName("ID_STATUS_INSUMO_FIN");

                entity.Property(e => e.IdStatusInsumoIni).HasColumnName("ID_STATUS_INSUMO_INI");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdStatusInsumoFinNavigation)
                    .WithMany(p => p.BdBitacoraInsumosIdStatusInsumoFinNavigation)
                    .HasForeignKey(d => d.IdStatusInsumoFin)
                    .HasConstraintName("FK_BD_BITACORA_INSUMOS_C_STATUS_INSUMOS1");

                entity.HasOne(d => d.IdStatusInsumoIniNavigation)
                    .WithMany(p => p.BdBitacoraInsumosIdStatusInsumoIniNavigation)
                    .HasForeignKey(d => d.IdStatusInsumoIni)
                    .HasConstraintName("FK_BD_BITACORA_INSUMOS_C_STATUS_INSUMOS");

                entity.HasOne(d => d.IdTipoResponsableNavigation)
                    .WithMany(p => p.BdBitacoraInsumos)
                    .HasForeignKey(d => d.IdTipoResponsable)
                    .HasConstraintName("FK_BD_BITACORA_INSUMOS_C_TIPO_RESPONSABLE");
            });

            modelBuilder.Entity<BdBitacoraItemsBorrados>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraItemsBorrados)
                    .HasName("PK__BD_BITAC__7B29BB006838319E");

                entity.ToTable("BD_BITACORA_ITEMS_BORRADOS");

                entity.Property(e => e.IdBitacoraItemsBorrados).HasColumnName("ID_BITACORA_ITEMS_BORRADOS");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdStatusItemsSolicitudAlmacen).HasColumnName("ID_STATUS_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdBitacoraItemsSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraItemsSolicitudAlmacen)
                    .HasName("PK_C_BITACORA_ITEMS_SOLICITUD_ALMACEN");

                entity.ToTable("BD_BITACORA_ITEMS_SOLICITUD_ALMACEN");

                entity.HasIndex(e => e.IdItemsSolicitudAlmacen);

                entity.Property(e => e.IdBitacoraItemsSolicitudAlmacen).HasColumnName("ID_BITACORA_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdItemsSolicitudAlmacen).HasColumnName("ID_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdStatusItemsSolicitudAlmacenFin).HasColumnName("ID_STATUS_ITEMS_SOLICITUD_ALMACEN_FIN");

                entity.Property(e => e.IdStatusItemsSolicitudAlmacenIni).HasColumnName("ID_STATUS_ITEMS_SOLICITUD_ALMACEN_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraJobs>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraJob);

                entity.ToTable("BD_BITACORA_JOBS");

                entity.Property(e => e.IdBitacoraJob).HasColumnName("ID_BITACORA_JOB");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobName)
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BdBitacoraModeloUnidad>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraModeloUnidad);

                entity.ToTable("BD_BITACORA_MODELO_UNIDAD");

                entity.HasIndex(e => e.IdUnidad);

                entity.Property(e => e.IdBitacoraModeloUnidad).HasColumnName("ID_BITACORA_MODELO_UNIDAD");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModeloNuevo).HasColumnName("ID_MODELO_NUEVO");

                entity.Property(e => e.IdModeloViejo).HasColumnName("ID_MODELO_VIEJO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdModeloNuevoNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidadIdModeloNuevoNavigation)
                    .HasForeignKey(d => d.IdModeloNuevo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_C_MODELOS");

                entity.HasOne(d => d.IdModeloViejoNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidadIdModeloViejoNavigation)
                    .HasForeignKey(d => d.IdModeloViejo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_C_MODELOS1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_BD_UNIDADES");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidad)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_C_USUARIOS");
            });

            modelBuilder.Entity<BdBitacoraMovimientosRetornosInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraMri)
                    .HasName("PK__BD_BITAC__8E656FDB0DD2385A");

                entity.ToTable("BD_BITACORA_MOVIMIENTOS_RETORNOS_INSUMOS");

                entity.Property(e => e.IdBitacoraMri).HasColumnName("ID_BITACORA_MRI");

                entity.Property(e => e.Entrada).HasColumnName("ENTRADA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConsolidado)
                    .HasColumnName("ID_CONSOLIDADO")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(((((CONVERT([varchar],datepart(day,getdate()),(0))+CONVERT([varchar],datepart(month,getdate()),(0)))+CONVERT([varchar],datepart(year,getdate()),(0)))+'_')+CONVERT([varchar],datepart(hour,getdate()),(0)))+CONVERT([varchar],datepart(minute,getdate()),(0)))");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdStatusInsumo).HasColumnName("ID_STATUS_INSUMO");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraNoInsumoAr>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraNoInsumoAr)
                    .HasName("PK__BD_BITAC__126B50BDE7877995");

                entity.ToTable("BD_BITACORA_NO_INSUMO_AR");

                entity.Property(e => e.IdBitacoraNoInsumoAr).HasColumnName("ID_BITACORA_NO_INSUMO_AR");

                entity.Property(e => e.Causa)
                    .HasColumnName("CAUSA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");
            });

            modelBuilder.Entity<BdBitacoraPropiedadCliente>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraPropiedadCliente)
                    .HasName("PK__BD_BITAC__D07251D722B0844E");

                entity.ToTable("BD_BITACORA_PROPIEDAD_CLIENTE");

                entity.Property(e => e.IdBitacoraPropiedadCliente).HasColumnName("ID_BITACORA_PROPIEDAD_CLIENTE");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsPropiedadClienteActual).HasColumnName("IS_PROPIEDAD_CLIENTE_ACTUAL");

                entity.Property(e => e.IsPropiedadClienteNuevo).HasColumnName("IS_PROPIEDAD_CLIENTE_NUEVO");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraPropiedadCliente)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK__BD_BITACO__ID_UN__258CF0F9");
            });

            modelBuilder.Entity<BdBitacoraReasignacionTecnicos>(entity =>
            {
                entity.HasKey(e => e.IdBitacora);

                entity.ToTable("BD_BITACORA_REASIGNACION_TECNICOS");

                entity.HasIndex(e => new { e.IdBitacora, e.IdUsuarioAnterior, e.IdUsuarioAsignado, e.IdUsuarioCambio, e.IdReparacionUnidad })
                    .HasName("IX_MI_BD_BITACORA_REASIGNACION_TECNICOS_85_84");

                entity.Property(e => e.IdBitacora).HasColumnName("ID_BITACORA");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdReparacionUnidad).HasColumnName("ID_REPARACION_UNIDAD");

                entity.Property(e => e.IdUsuarioAnterior).HasColumnName("ID_USUARIO_ANTERIOR");

                entity.Property(e => e.IdUsuarioAsignado).HasColumnName("ID_USUARIO_ASIGNADO");

                entity.Property(e => e.IdUsuarioCambio).HasColumnName("ID_USUARIO_CAMBIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraRechazosEnvios>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraRechazo)
                    .HasName("PK__BD_BITAC__F048B2F65F2362EA");

                entity.ToTable("BD_BITACORA_RECHAZOS_ENVIOS");

                entity.Property(e => e.IdBitacoraRechazo).HasColumnName("ID_BITACORA_RECHAZO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdBitacoraSolicitudDevolucion>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSolicitudDevolucion);

                entity.ToTable("BD_BITACORA_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdBitacoraSolicitudDevolucion).HasColumnName("ID_BITACORA_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdStatusSolicitudDevolucionFin).HasColumnName("ID_STATUS_SOLICITUD_DEVOLUCION_FIN");

                entity.Property(e => e.IdStatusSolicitudDevolucionIni).HasColumnName("ID_STATUS_SOLICITUD_DEVOLUCION_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdStatusSolicitudDevolucionFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudDevolucionFin)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_DEVOLUCION_C_STATUS_SOLICITUD_DEVOLUCION1");

                entity.HasOne(d => d.IdStatusSolicitudDevolucionIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudDevolucionIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_DEVOLUCION_C_STATUS_SOLICITUD_DEVOLUCION");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudDevolucion)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_DEVOLUCION_C_USUARIOS");
            });

            modelBuilder.Entity<BdBitacoraSolicitudRecoleccion>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSolicitudRecoleccion);

                entity.ToTable("BD_BITACORA_SOLICITUD_RECOLECCION");

                entity.HasIndex(e => new { e.IdBitacoraSolicitudRecoleccion, e.IdUsuarioAlta, e.IdSolicitudRecoleccion })
                    .HasName("IX_MI_BD_BITACORA_SOLICITUD_RECOLECCION_132815_132814");

                entity.HasIndex(e => new { e.IdBitacoraSolicitudRecoleccion, e.IdStatusSolicitudRecoleccionIni, e.IdStatusSolicitudRecoleccionFin, e.IdUsuarioAlta, e.FecAlta, e.IdSolicitudRecoleccion })
                    .HasName("IX_BD_BITACORA_SOLICITUD_RECOLECCION_ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdBitacoraSolicitudRecoleccion).HasColumnName("ID_BITACORA_SOLICITUD_RECOLECCION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusSolicitudRecoleccionFin).HasColumnName("ID_STATUS_SOLICITUD_RECOLECCION_FIN");

                entity.Property(e => e.IdStatusSolicitudRecoleccionIni).HasColumnName("ID_STATUS_SOLICITUD_RECOLECCION_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdSolicitudRecoleccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_RECOLECCION_BD_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdStatusSolicitudRecoleccionFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudRecoleccionFin)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_RECOLECCION_C_STATUS_SOLICITUD_RECOLECCION1");

                entity.HasOne(d => d.IdStatusSolicitudRecoleccionIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudRecoleccionIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_RECOLECCION_C_STATUS_SOLICITUD_RECOLECCION");
            });

            modelBuilder.Entity<BdBitacoraSolicitudesAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSolicitudAlmacen)
                    .HasName("PK_BD_BITACORA_SOLICITUD_ALMACEN");

                entity.ToTable("BD_BITACORA_SOLICITUDES_ALMACEN");

                entity.HasIndex(e => e.IdSolicitudAlmacen);

                entity.Property(e => e.IdBitacoraSolicitudAlmacen).HasColumnName("ID_BITACORA_SOLICITUD_ALMACEN");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasColumnType("text");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdStatusSolicitudAlmacenFin).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN_FIN");

                entity.Property(e => e.IdStatusSolicitudAlmacenIni).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdStatusSolicitudAlmacenFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudAlmacenFin)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_ALMACEN_C_STATUS_SOLICITUD_ALMACEN1");

                entity.HasOne(d => d.IdStatusSolicitudAlmacenIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudAlmacenIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_ALMACEN_C_STATUS_SOLICITUD_ALMACEN");
            });

            modelBuilder.Entity<BdBitacoraSolicitudesViaticos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSolicitudViaticos);

                entity.ToTable("BD_BITACORA_SOLICITUDES_VIATICOS");

                entity.HasIndex(e => e.IdSolicitudViaticos);

                entity.Property(e => e.IdBitacoraSolicitudViaticos).HasColumnName("ID_BITACORA_SOLICITUD_VIATICOS");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdStatusSolicitudViaticosFin).HasColumnName("ID_STATUS_SOLICITUD_VIATICOS_FIN");

                entity.Property(e => e.IdStatusSolicitudViaticosIni).HasColumnName("ID_STATUS_SOLICITUD_VIATICOS_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesViaticos)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_VIATICOS_BD_SOLICITUDES_VIATICOS1");

                entity.HasOne(d => d.IdStatusSolicitudViaticosFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudViaticosFin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_VIATICOS_C_STATUS_SOLICITUD_VIATICOS");

                entity.HasOne(d => d.IdStatusSolicitudViaticosIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudViaticosIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_VIATICOS_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdBitacoraStatusTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraStatusTipoUsuario);

                entity.ToTable("BD_BITACORA_STATUS_TIPO_USUARIO");

                entity.Property(e => e.IdBitacoraStatusTipoUsuario).HasColumnName("ID_BITACORA_STATUS_TIPO_USUARIO");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecCambio)
                    .HasColumnName("FEC_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");

                entity.Property(e => e.IdUsuarioCambio).HasColumnName("ID_USUARIO_CAMBIO");
            });

            modelBuilder.Entity<BdBitacoraTransferencias>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTransferencia)
                    .HasName("PK__BD_BITAC__02A9C9E40A0794DC");

                entity.ToTable("BD_BITACORA_TRANSFERENCIAS");

                entity.Property(e => e.IdBitacoraTransferencia).HasColumnName("ID_BITACORA_TRANSFERENCIA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdResponsableActual).HasColumnName("ID_RESPONSABLE_ACTUAL");

                entity.Property(e => e.IdResponsableAnterior).HasColumnName("ID_RESPONSABLE_ANTERIOR");

                entity.Property(e => e.IdTipoResponsableActual).HasColumnName("ID_TIPO_RESPONSABLE_ACTUAL");

                entity.Property(e => e.IdTipoResponsableAnterior).HasColumnName("ID_TIPO_RESPONSABLE_ANTERIOR");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraUnidad>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUnidad)
                    .HasName("PK_BD_BITACORA_UNDIAD");

                entity.ToTable("BD_BITACORA_UNIDAD");

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdUnidad, e.IdUsuarioAlta, e.IdStatusUnidadIni, e.IdStatusUnidadFin })
                    .HasName("IX_BD_BITACORA_UNIDAD_ID_STATUS_UNIDAD_INI, ID_STATUS_UNIDAD_FIN");

                entity.Property(e => e.IdBitacoraUnidad).HasColumnName("ID_BITACORA_UNIDAD");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusUnidadFin).HasColumnName("ID_STATUS_UNIDAD_FIN");

                entity.Property(e => e.IdStatusUnidadIni).HasColumnName("ID_STATUS_UNIDAD_INI");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdStatusUnidadFinNavigation)
                    .WithMany(p => p.BdBitacoraUnidadIdStatusUnidadFinNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadFin)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_C_STATUS_UNIDAD1");

                entity.HasOne(d => d.IdStatusUnidadIniNavigation)
                    .WithMany(p => p.BdBitacoraUnidadIdStatusUnidadIniNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadIni)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_C_STATUS_UNIDAD");

                entity.HasOne(d => d.IdTipoResponsableNavigation)
                    .WithMany(p => p.BdBitacoraUnidad)
                    .HasForeignKey(d => d.IdTipoResponsable)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_BD_UNIDADES");
            });

            modelBuilder.Entity<BdBitacoraUnidadDanada>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUnidadDanada)
                    .HasName("PK__BD_BITAC__628C55831EDFF36A");

                entity.ToTable("BD_BITACORA_UNIDAD_DANADA");

                entity.Property(e => e.IdBitacoraUnidadDanada).HasColumnName("ID_BITACORA_UNIDAD_DANADA");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDaniadaActual).HasColumnName("IS_DANIADA_ACTUAL");

                entity.Property(e => e.IsDaniadaNuevo).HasColumnName("IS_DANIADA_NUEVO");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraUnidadDanada)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK__BD_BITACO__ID_UN__2498CCC0");
            });

            modelBuilder.Entity<BdBitacoraUnidadesFaltantesRecibo>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUnidadFaltante)
                    .HasName("PK__BD_BITAC__69286212EA1FF754");

                entity.ToTable("BD_BITACORA_UNIDADES_FALTANTES_RECIBO");

                entity.Property(e => e.IdBitacoraUnidadFaltante).HasColumnName("ID_BITACORA_UNIDAD_FALTANTE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdStatusEnvio).HasColumnName("ID_STATUS_ENVIO");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.NoUnidadesInsumosNoRecibidas).HasColumnName("NO_UNIDADES_INSUMOS_NO_RECIBIDAS");

                entity.Property(e => e.NoUnidadesNoRecibidas).HasColumnName("NO_UNIDADES_NO_RECIBIDAS");
            });

            modelBuilder.Entity<BdBitacoraUsuariosActivos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUsuariosActivos);

                entity.ToTable("BD_BITACORA_USUARIOS_ACTIVOS");

                entity.Property(e => e.IdBitacoraUsuariosActivos).HasColumnName("ID_BITACORA_USUARIOS_ACTIVOS");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TotalUsuariosActivos).HasColumnName("TOTAL_USUARIOS_ACTIVOS");

                entity.Property(e => e.UsuariosActivosPda).HasColumnName("USUARIOS_ACTIVOS_PDA");

                entity.Property(e => e.UsuariosActivosWeb).HasColumnName("USUARIOS_ACTIVOS_WEB");
            });

            modelBuilder.Entity<BdBitacoraValidacionDevoluciones>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraValidacionDevoluciones);

                entity.ToTable("BD_BITACORA_VALIDACION_DEVOLUCIONES");

                entity.Property(e => e.IdBitacoraValidacionDevoluciones).HasColumnName("ID_BITACORA_VALIDACION_DEVOLUCIONES");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdStatusFin).HasColumnName("ID_STATUS_FIN");

                entity.Property(e => e.IdStatusIni).HasColumnName("ID_STATUS_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBitacoraValidacionPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraValidacionPrefacturacion);

                entity.ToTable("BD_BITACORA_VALIDACION_PREFACTURACION");

                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_MI_BD_BITACORA_VALIDACION_PREFACTURACION_22_21");

                entity.HasIndex(e => new { e.IdAr, e.IdStatusFin })
                    .HasName("IX_MI_BD_BITACORA_VALIDACION_PREFACTURACION_7149_7148");

                entity.HasIndex(e => new { e.IdBitacoraValidacionPrefacturacion, e.FecAlta, e.IdAr })
                    .HasName("IX_MI_BD_BITACORA_VALIDACION_PREFACTURACION_20_19");

                entity.Property(e => e.IdBitacoraValidacionPrefacturacion).HasColumnName("ID_BITACORA_VALIDACION_PREFACTURACION");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdStatusFin).HasColumnName("ID_STATUS_FIN");

                entity.Property(e => e.IdStatusIni).HasColumnName("ID_STATUS_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdBloqueos>(entity =>
            {
                entity.HasKey(e => e.IdBloqueo);

                entity.ToTable("BD_BLOQUEOS");

                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("IX_BD_BLOQUEOS_2");

                entity.HasIndex(e => new { e.Proveedor, e.Territorio, e.NoAfiliacion })
                    .HasName("IX_BD_BLOQUEOS_1");

                entity.HasIndex(e => new { e.Month, e.Year, e.NoAfiliacion, e.Bloqueo })
                    .HasName("IX_BD_BLOQUEOS");

                entity.Property(e => e.IdBloqueo).HasColumnName("ID_BLOQUEO");

                entity.Property(e => e.Bloqueo).HasColumnName("BLOQUEO");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .HasMaxLength(200);

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NoAfiliacion)
                    .IsRequired()
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(30);

                entity.Property(e => e.Territorio)
                    .IsRequired()
                    .HasColumnName("TERRITORIO")
                    .HasMaxLength(30);

                entity.Property(e => e.TotalRollos).HasColumnName("TOTAL_ROLLOS");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdBloqueosPaso>(entity =>
            {
                entity.HasKey(e => e.IdBloqueoPaso);

                entity.ToTable("BD_BLOQUEOS_PASO");

                entity.Property(e => e.IdBloqueoPaso).HasColumnName("ID_BLOQUEO_PASO");

                entity.Property(e => e.Bloqueo).HasColumnName("BLOQUEO");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IsError).HasColumnName("IS_ERROR");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .HasMaxLength(200);

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NoAfiliacion)
                    .IsRequired()
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(30);

                entity.Property(e => e.Territorio)
                    .IsRequired()
                    .HasColumnName("TERRITORIO")
                    .HasMaxLength(30);

                entity.Property(e => e.TotalRollos).HasColumnName("TOTAL_ROLLOS");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdCallCenterQ1>(entity =>
            {
                entity.HasKey(e => e.IdCuestionario1);

                entity.ToTable("BD_CALL_CENTER_Q1");

                entity.Property(e => e.IdCuestionario1).HasColumnName("ID_CUESTIONARIO_1");

                entity.Property(e => e.IdCallCenter).HasColumnName("ID_CALL_CENTER");

                entity.Property(e => e.Pregunta1)
                    .HasColumnName("Pregunta_1")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta2)
                    .HasColumnName("Pregunta_2")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta3)
                    .HasColumnName("Pregunta_3")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta4)
                    .HasColumnName("Pregunta_4")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta5)
                    .HasColumnName("Pregunta_5")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta6)
                    .HasColumnName("Pregunta_6")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta7)
                    .HasColumnName("Pregunta_7")
                    .HasColumnType("text");

                entity.Property(e => e.Pregunta8)
                    .HasColumnName("Pregunta_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("Respuesta_1")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("REspuesta_2")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("Respuesta_3")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("Respuesta_4")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("Respuesta_5")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("Respuesta_6")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("Respuesta_7")
                    .HasMaxLength(30);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("Respuesta_8")
                    .HasMaxLength(30);

                entity.Property(e => e.Valida1).HasColumnName("Valida_1");

                entity.Property(e => e.Valida2).HasColumnName("Valida_2");

                entity.Property(e => e.Valida3).HasColumnName("Valida_3");

                entity.Property(e => e.Valida4).HasColumnName("Valida_4");

                entity.Property(e => e.Valida5).HasColumnName("Valida_5");

                entity.Property(e => e.Valida6).HasColumnName("Valida_6");

                entity.Property(e => e.Valida7).HasColumnName("Valida_7");

                entity.Property(e => e.Valida8).HasColumnName("Valida_8");
            });

            modelBuilder.Entity<BdCallCenterSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdCallCenter);

                entity.ToTable("BD_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdCallCenter).HasColumnName("ID_CALL_CENTER");

                entity.Property(e => e.AceptaServicio)
                    .HasColumnName("ACEPTA_SERVICIO")
                    .HasMaxLength(2);

                entity.Property(e => e.Contacto)
                    .HasColumnName("CONTACTO")
                    .HasMaxLength(80);

                entity.Property(e => e.Exito).HasColumnName("EXITO");

                entity.Property(e => e.IdAgente).HasColumnName("ID_AGENTE");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdMotivoNoContacto).HasColumnName("ID_MOTIVO_NO_CONTACTO");

                entity.Property(e => e.IdMotivoRechazo).HasColumnName("ID_MOTIVO_RECHAZO");

                entity.Property(e => e.Intento).HasColumnName("INTENTO");
            });

            modelBuilder.Entity<BdCallcenterRQ1>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ1);

                entity.ToTable("BD_CALLCENTER_R_Q1");

                entity.Property(e => e.IdRespuestaQ1).HasColumnName("ID_RESPUESTA_Q1");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ10>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ10);

                entity.ToTable("BD_CALLCENTER_R_Q10");

                entity.Property(e => e.IdRespuestaQ10).HasColumnName("ID_RESPUESTA_Q10");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ11>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ11);

                entity.ToTable("BD_CALLCENTER_R_Q11");

                entity.Property(e => e.IdRespuestaQ11).HasColumnName("ID_RESPUESTA_Q11");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ12>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ12);

                entity.ToTable("BD_CALLCENTER_R_Q12");

                entity.Property(e => e.IdRespuestaQ12).HasColumnName("ID_RESPUESTA_Q12");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ13>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ13);

                entity.ToTable("BD_CALLCENTER_R_Q13");

                entity.Property(e => e.IdRespuestaQ13).HasColumnName("ID_RESPUESTA_Q13");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo10).HasColumnName("COD_RECHAZO_10");

                entity.Property(e => e.CodRechazo11).HasColumnName("COD_RECHAZO_11");

                entity.Property(e => e.CodRechazo13).HasColumnName("COD_RECHAZO_13");

                entity.Property(e => e.CodRechazo14).HasColumnName("COD_RECHAZO_14");

                entity.Property(e => e.CodRechazo15).HasColumnName("COD_RECHAZO_15");

                entity.Property(e => e.CodRechazo16).HasColumnName("COD_RECHAZO_16");

                entity.Property(e => e.CodRechazo17).HasColumnName("COD_RECHAZO_17");

                entity.Property(e => e.CodRechazo18).HasColumnName("COD_RECHAZO_18");

                entity.Property(e => e.CodRechazo19).HasColumnName("COD_RECHAZO_19");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo20).HasColumnName("COD_RECHAZO_20");

                entity.Property(e => e.CodRechazo21).HasColumnName("COD_RECHAZO_21");

                entity.Property(e => e.CodRechazo22).HasColumnName("COD_RECHAZO_22");

                entity.Property(e => e.CodRechazo23).HasColumnName("COD_RECHAZO_23");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.CodRechazo9).HasColumnName("COD_RECHAZO_9");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota10)
                    .HasColumnName("NOTA_10")
                    .HasColumnType("text");

                entity.Property(e => e.Nota11)
                    .HasColumnName("NOTA_11")
                    .HasColumnType("text");

                entity.Property(e => e.Nota12)
                    .HasColumnName("NOTA_12")
                    .HasColumnType("text");

                entity.Property(e => e.Nota13)
                    .HasColumnName("NOTA_13")
                    .HasColumnType("text");

                entity.Property(e => e.Nota14)
                    .HasColumnName("NOTA_14")
                    .HasColumnType("text");

                entity.Property(e => e.Nota15)
                    .HasColumnName("NOTA_15")
                    .HasColumnType("text");

                entity.Property(e => e.Nota16)
                    .HasColumnName("NOTA_16")
                    .HasColumnType("text");

                entity.Property(e => e.Nota17)
                    .HasColumnName("NOTA_17")
                    .HasColumnType("text");

                entity.Property(e => e.Nota18)
                    .HasColumnName("NOTA_18")
                    .HasColumnType("text");

                entity.Property(e => e.Nota19)
                    .HasColumnName("NOTA_19")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota20)
                    .HasColumnName("NOTA_20")
                    .HasColumnType("text");

                entity.Property(e => e.Nota21)
                    .HasColumnName("NOTA_21")
                    .HasColumnType("text");

                entity.Property(e => e.Nota22)
                    .HasColumnName("NOTA_22")
                    .HasColumnType("text");

                entity.Property(e => e.Nota23)
                    .HasColumnName("NOTA_23")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Nota9)
                    .HasColumnName("NOTA_9")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta10)
                    .HasColumnName("RESPUESTA_10")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta11)
                    .HasColumnName("RESPUESTA_11")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta12)
                    .HasColumnName("RESPUESTA_12")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta13)
                    .HasColumnName("RESPUESTA_13")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta14)
                    .HasColumnName("RESPUESTA_14")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta15)
                    .HasColumnName("RESPUESTA_15")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta16)
                    .HasColumnName("RESPUESTA_16")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta17)
                    .HasColumnName("RESPUESTA_17")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta18)
                    .HasColumnName("RESPUESTA_18")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta19)
                    .HasColumnName("RESPUESTA_19")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta20)
                    .HasColumnName("RESPUESTA_20")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta21)
                    .HasColumnName("RESPUESTA_21")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta22)
                    .HasColumnName("RESPUESTA_22")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta23)
                    .HasColumnName("RESPUESTA_23")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta9)
                    .HasColumnName("RESPUESTA_9")
                    .HasMaxLength(22);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ14>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ14);

                entity.ToTable("BD_CALLCENTER_R_Q14");

                entity.Property(e => e.IdRespuestaQ14).HasColumnName("ID_RESPUESTA_Q14");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ2>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ2);

                entity.ToTable("BD_CALLCENTER_R_Q2");

                entity.Property(e => e.IdRespuestaQ2).HasColumnName("ID_RESPUESTA_Q2");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSerguimiento).HasColumnName("ID_CALL_CENTER_SERGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreRechazaElavon)
                    .HasColumnName("NOMBRE_RECHAZA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ3>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ3);

                entity.ToTable("BD_CALLCENTER_R_Q3");

                entity.Property(e => e.IdRespuestaQ3).HasColumnName("ID_RESPUESTA_Q3");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSerguimiento).HasColumnName("ID_CALL_CENTER_SERGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreRechazaElavon)
                    .HasColumnName("NOMBRE_RECHAZA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ4>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ4);

                entity.ToTable("BD_CALLCENTER_R_Q4");

                entity.Property(e => e.IdRespuestaQ4).HasColumnName("ID_RESPUESTA_Q4");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSerguimiento).HasColumnName("ID_CALL_CENTER_SERGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreRechazaElavon)
                    .HasColumnName("NOMBRE_RECHAZA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ5>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ5);

                entity.ToTable("BD_CALLCENTER_R_Q5");

                entity.Property(e => e.IdRespuestaQ5).HasColumnName("ID_RESPUESTA_Q5");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSerguimiento).HasColumnName("ID_CALL_CENTER_SERGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreRechazaElavon)
                    .HasColumnName("NOMBRE_RECHAZA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ6>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ6);

                entity.ToTable("BD_CALLCENTER_R_Q6");

                entity.Property(e => e.IdRespuestaQ6).HasColumnName("ID_RESPUESTA_Q6");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo10).HasColumnName("COD_RECHAZO_10");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.CodRechazo8).HasColumnName("COD_RECHAZO_8");

                entity.Property(e => e.CodRechazo9).HasColumnName("COD_RECHAZO_9");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSerguimiento).HasColumnName("ID_CALL_CENTER_SERGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreRechazaElavon)
                    .HasColumnName("NOMBRE_RECHAZA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota10)
                    .HasColumnName("NOTA_10")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Nota9)
                    .HasColumnName("NOTA_9")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta10).HasColumnName("RESPUESTA_10");

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta7).HasColumnName("RESPUESTA_7");

                entity.Property(e => e.Respuesta8).HasColumnName("RESPUESTA_8");

                entity.Property(e => e.Respuesta9).HasColumnName("RESPUESTA_9");

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ7>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ7);

                entity.ToTable("BD_CALLCENTER_R_Q7");

                entity.Property(e => e.IdRespuestaQ7).HasColumnName("ID_RESPUESTA_Q7");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo10).HasColumnName("COD_RECHAZO_10");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.CodRechazo8).HasColumnName("COD_RECHAZO_8");

                entity.Property(e => e.CodRechazo9).HasColumnName("COD_RECHAZO_9");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSerguimiento).HasColumnName("ID_CALL_CENTER_SERGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreRechazaElavon)
                    .HasColumnName("NOMBRE_RECHAZA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota10)
                    .HasColumnName("NOTA_10")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Nota9)
                    .HasColumnName("NOTA_9")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta10).HasColumnName("RESPUESTA_10");

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta7).HasColumnName("RESPUESTA_7");

                entity.Property(e => e.Respuesta8).HasColumnName("RESPUESTA_8");

                entity.Property(e => e.Respuesta9).HasColumnName("RESPUESTA_9");

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ8>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ8);

                entity.ToTable("BD_CALLCENTER_R_Q8");

                entity.Property(e => e.IdRespuestaQ8).HasColumnName("ID_RESPUESTA_Q8");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo10).HasColumnName("COD_RECHAZO_10");

                entity.Property(e => e.CodRechazo11).HasColumnName("COD_RECHAZO_11");

                entity.Property(e => e.CodRechazo13).HasColumnName("COD_RECHAZO_13");

                entity.Property(e => e.CodRechazo14).HasColumnName("COD_RECHAZO_14");

                entity.Property(e => e.CodRechazo15).HasColumnName("COD_RECHAZO_15");

                entity.Property(e => e.CodRechazo16).HasColumnName("COD_RECHAZO_16");

                entity.Property(e => e.CodRechazo17).HasColumnName("COD_RECHAZO_17");

                entity.Property(e => e.CodRechazo18).HasColumnName("COD_RECHAZO_18");

                entity.Property(e => e.CodRechazo19).HasColumnName("COD_RECHAZO_19");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo20).HasColumnName("COD_RECHAZO_20");

                entity.Property(e => e.CodRechazo21).HasColumnName("COD_RECHAZO_21");

                entity.Property(e => e.CodRechazo22).HasColumnName("COD_RECHAZO_22");

                entity.Property(e => e.CodRechazo23).HasColumnName("COD_RECHAZO_23");

                entity.Property(e => e.CodRechazo24).HasColumnName("COD_RECHAZO_24");

                entity.Property(e => e.CodRechazo25).HasColumnName("COD_RECHAZO_25");

                entity.Property(e => e.CodRechazo26).HasColumnName("COD_RECHAZO_26");

                entity.Property(e => e.CodRechazo27).HasColumnName("COD_RECHAZO_27");

                entity.Property(e => e.CodRechazo28).HasColumnName("COD_RECHAZO_28");

                entity.Property(e => e.CodRechazo29).HasColumnName("COD_RECHAZO_29");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo30).HasColumnName("COD_RECHAZO_30");

                entity.Property(e => e.CodRechazo31).HasColumnName("COD_RECHAZO_31");

                entity.Property(e => e.CodRechazo32).HasColumnName("COD_RECHAZO_32");

                entity.Property(e => e.CodRechazo33).HasColumnName("COD_RECHAZO_33");

                entity.Property(e => e.CodRechazo34).HasColumnName("COD_RECHAZO_34");

                entity.Property(e => e.CodRechazo35).HasColumnName("COD_RECHAZO_35");

                entity.Property(e => e.CodRechazo36).HasColumnName("COD_RECHAZO_36");

                entity.Property(e => e.CodRechazo37).HasColumnName("COD_RECHAZO_37");

                entity.Property(e => e.CodRechazo38).HasColumnName("COD_RECHAZO_38");

                entity.Property(e => e.CodRechazo39).HasColumnName("COD_RECHAZO_39");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo40).HasColumnName("COD_RECHAZO_40");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.CodRechazo9).HasColumnName("COD_RECHAZO_9");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota10)
                    .HasColumnName("NOTA_10")
                    .HasColumnType("text");

                entity.Property(e => e.Nota11)
                    .HasColumnName("NOTA_11")
                    .HasColumnType("text");

                entity.Property(e => e.Nota12)
                    .HasColumnName("NOTA_12")
                    .HasColumnType("text");

                entity.Property(e => e.Nota13)
                    .HasColumnName("NOTA_13")
                    .HasColumnType("text");

                entity.Property(e => e.Nota14)
                    .HasColumnName("NOTA_14")
                    .HasColumnType("text");

                entity.Property(e => e.Nota15)
                    .HasColumnName("NOTA_15")
                    .HasColumnType("text");

                entity.Property(e => e.Nota16)
                    .HasColumnName("NOTA_16")
                    .HasColumnType("text");

                entity.Property(e => e.Nota17)
                    .HasColumnName("NOTA_17")
                    .HasColumnType("text");

                entity.Property(e => e.Nota18)
                    .HasColumnName("NOTA_18")
                    .HasColumnType("text");

                entity.Property(e => e.Nota19)
                    .HasColumnName("NOTA_19")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota20)
                    .HasColumnName("NOTA_20")
                    .HasColumnType("text");

                entity.Property(e => e.Nota21)
                    .HasColumnName("NOTA_21")
                    .HasColumnType("text");

                entity.Property(e => e.Nota22)
                    .HasColumnName("NOTA_22")
                    .HasColumnType("text");

                entity.Property(e => e.Nota23)
                    .HasColumnName("NOTA_23")
                    .HasColumnType("text");

                entity.Property(e => e.Nota24)
                    .HasColumnName("NOTA_24")
                    .HasColumnType("text");

                entity.Property(e => e.Nota25)
                    .HasColumnName("NOTA_25")
                    .HasColumnType("text");

                entity.Property(e => e.Nota26)
                    .HasColumnName("NOTA_26")
                    .HasColumnType("text");

                entity.Property(e => e.Nota27)
                    .HasColumnName("NOTA_27")
                    .HasColumnType("text");

                entity.Property(e => e.Nota28)
                    .HasColumnName("NOTA_28")
                    .HasColumnType("text");

                entity.Property(e => e.Nota29)
                    .HasColumnName("NOTA_29")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota30)
                    .HasColumnName("NOTA_30")
                    .HasColumnType("text");

                entity.Property(e => e.Nota31)
                    .HasColumnName("NOTA_31")
                    .HasColumnType("text");

                entity.Property(e => e.Nota32)
                    .HasColumnName("NOTA_32")
                    .HasColumnType("text");

                entity.Property(e => e.Nota33)
                    .HasColumnName("NOTA_33")
                    .HasColumnType("text");

                entity.Property(e => e.Nota34)
                    .HasColumnName("NOTA_34")
                    .HasColumnType("text");

                entity.Property(e => e.Nota35)
                    .HasColumnName("NOTA_35")
                    .HasColumnType("text");

                entity.Property(e => e.Nota36)
                    .HasColumnName("NOTA_36")
                    .HasColumnType("text");

                entity.Property(e => e.Nota37)
                    .HasColumnName("NOTA_37")
                    .HasColumnType("text");

                entity.Property(e => e.Nota38)
                    .HasColumnName("NOTA_38")
                    .HasColumnType("text");

                entity.Property(e => e.Nota39)
                    .HasColumnName("NOTA_39")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota40)
                    .HasColumnName("NOTA_40")
                    .HasColumnType("text");

                entity.Property(e => e.Nota41)
                    .HasColumnName("NOTA_41")
                    .HasColumnType("text");

                entity.Property(e => e.Nota42)
                    .HasColumnName("NOTA_42")
                    .HasColumnType("text");

                entity.Property(e => e.Nota43)
                    .HasColumnName("NOTA_43")
                    .HasColumnType("text");

                entity.Property(e => e.Nota44)
                    .HasColumnName("NOTA_44")
                    .HasColumnType("text");

                entity.Property(e => e.Nota45)
                    .HasColumnName("NOTA_45")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Nota9)
                    .HasColumnName("NOTA_9")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta10)
                    .HasColumnName("RESPUESTA_10")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta11)
                    .HasColumnName("RESPUESTA_11")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta12)
                    .HasColumnName("RESPUESTA_12")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta13)
                    .HasColumnName("RESPUESTA_13")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta14)
                    .HasColumnName("RESPUESTA_14")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta15)
                    .HasColumnName("RESPUESTA_15")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta16)
                    .HasColumnName("RESPUESTA_16")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta17)
                    .HasColumnName("RESPUESTA_17")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta18)
                    .HasColumnName("RESPUESTA_18")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta19)
                    .HasColumnName("RESPUESTA_19")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta20)
                    .HasColumnName("RESPUESTA_20")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta21)
                    .HasColumnName("RESPUESTA_21")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta22)
                    .HasColumnName("RESPUESTA_22")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta23)
                    .HasColumnName("RESPUESTA_23")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta24)
                    .HasColumnName("RESPUESTA_24")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta25)
                    .HasColumnName("RESPUESTA_25")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta26)
                    .HasColumnName("RESPUESTA_26")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta27)
                    .HasColumnName("RESPUESTA_27")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta28)
                    .HasColumnName("RESPUESTA_28")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta29)
                    .HasColumnName("RESPUESTA_29")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta30)
                    .HasColumnName("RESPUESTA_30")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta31)
                    .HasColumnName("RESPUESTA_31")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta32)
                    .HasColumnName("RESPUESTA_32")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta33)
                    .HasColumnName("RESPUESTA_33")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta34)
                    .HasColumnName("RESPUESTA_34")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta35)
                    .HasColumnName("RESPUESTA_35")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta36)
                    .HasColumnName("RESPUESTA_36")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta37)
                    .HasColumnName("RESPUESTA_37")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta38)
                    .HasColumnName("RESPUESTA_38")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta39)
                    .HasColumnName("RESPUESTA_39")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta40)
                    .HasColumnName("RESPUESTA_40")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta41)
                    .HasColumnName("RESPUESTA_41")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta42)
                    .HasColumnName("RESPUESTA_42")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta43)
                    .HasColumnName("RESPUESTA_43")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta44)
                    .HasColumnName("RESPUESTA_44")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta45)
                    .HasColumnName("RESPUESTA_45")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta9)
                    .HasColumnName("RESPUESTA_9")
                    .HasMaxLength(22);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCallcenterRQ9>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaQ9);

                entity.ToTable("BD_CALLCENTER_R_Q9");

                entity.Property(e => e.IdRespuestaQ9).HasColumnName("ID_RESPUESTA_Q9");

                entity.Property(e => e.AtiendeLlamada)
                    .HasColumnName("ATIENDE_LLAMADA")
                    .HasMaxLength(100);

                entity.Property(e => e.CodRechazo1).HasColumnName("COD_RECHAZO_1");

                entity.Property(e => e.CodRechazo2).HasColumnName("COD_RECHAZO_2");

                entity.Property(e => e.CodRechazo3).HasColumnName("COD_RECHAZO_3");

                entity.Property(e => e.CodRechazo4).HasColumnName("COD_RECHAZO_4");

                entity.Property(e => e.CodRechazo5).HasColumnName("COD_RECHAZO_5");

                entity.Property(e => e.CodRechazo7).HasColumnName("COD_RECHAZO_7");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("FEC_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioCita)
                    .HasColumnName("HORARIO_CITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallCenterSeguimiento).HasColumnName("ID_CALL_CENTER_SEGUIMIENTO");

                entity.Property(e => e.IdLlamadaContacto)
                    .HasColumnName("ID_LLAMADA_CONTACTO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdLlamadaElavon)
                    .HasColumnName("ID_LLAMADA_ELAVON")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreAtenderaServicio)
                    .HasColumnName("NOMBRE_ATENDERA_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nota1)
                    .HasColumnName("NOTA_1")
                    .HasColumnType("text");

                entity.Property(e => e.Nota2)
                    .HasColumnName("NOTA_2")
                    .HasColumnType("text");

                entity.Property(e => e.Nota3)
                    .HasColumnName("NOTA_3")
                    .HasColumnType("text");

                entity.Property(e => e.Nota4)
                    .HasColumnName("NOTA_4")
                    .HasColumnType("text");

                entity.Property(e => e.Nota5)
                    .HasColumnName("NOTA_5")
                    .HasColumnType("text");

                entity.Property(e => e.Nota6)
                    .HasColumnName("NOTA_6")
                    .HasColumnType("text");

                entity.Property(e => e.Nota7)
                    .HasColumnName("NOTA_7")
                    .HasColumnType("text");

                entity.Property(e => e.Nota8)
                    .HasColumnName("NOTA_8")
                    .HasColumnType("text");

                entity.Property(e => e.Respuesta1)
                    .HasColumnName("RESPUESTA_1")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta2)
                    .HasColumnName("RESPUESTA_2")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta3)
                    .HasColumnName("RESPUESTA_3")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta4)
                    .HasColumnName("RESPUESTA_4")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta5)
                    .HasColumnName("RESPUESTA_5")
                    .HasMaxLength(22);

                entity.Property(e => e.Respuesta6)
                    .HasColumnName("RESPUESTA_6")
                    .HasMaxLength(10);

                entity.Property(e => e.Respuesta7)
                    .HasColumnName("RESPUESTA_7")
                    .HasMaxLength(2);

                entity.Property(e => e.Respuesta8)
                    .HasColumnName("RESPUESTA_8")
                    .HasMaxLength(2);

                entity.Property(e => e.TelefonoAtenderaServicio)
                    .HasColumnName("TELEFONO_ATENDERA_SERVICIO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdCambioStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdCambioStatusAr);

                entity.ToTable("BD_CAMBIO_STATUS_AR");

                entity.Property(e => e.IdCambioStatusAr).HasColumnName("ID_CAMBIO_STATUS_AR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdStatusArFin).HasColumnName("ID_STATUS_AR_FIN");

                entity.Property(e => e.IdStatusArIni).HasColumnName("ID_STATUS_AR_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStatusArFinNavigation)
                    .WithMany(p => p.BdCambioStatusArIdStatusArFinNavigation)
                    .HasForeignKey(d => d.IdStatusArFin)
                    .HasConstraintName("FK_BD_CAMBIO_STATUS_AR_C_STATUS_AR1");

                entity.HasOne(d => d.IdStatusArIniNavigation)
                    .WithMany(p => p.BdCambioStatusArIdStatusArIniNavigation)
                    .HasForeignKey(d => d.IdStatusArIni)
                    .HasConstraintName("FK_BD_CAMBIO_STATUS_AR_C_STATUS_AR");
            });

            modelBuilder.Entity<BdCambiosEstatusPermititdosUnidades>(entity =>
            {
                entity.HasKey(e => e.IdCambioEstatusPermitido)
                    .HasName("PK__BD_CAMBI__1400EDE2B204FB6C");

                entity.ToTable("BD_CAMBIOS_ESTATUS_PERMITITDOS_UNIDADES");

                entity.Property(e => e.IdCambioEstatusPermitido).HasColumnName("ID_CAMBIO_ESTATUS_PERMITIDO");

                entity.Property(e => e.ArchivoObligatorio).HasColumnName("ARCHIVO_OBLIGATORIO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusFin).HasColumnName("ID_STATUS_FIN");

                entity.Property(e => e.IdStatusIni).HasColumnName("ID_STATUS_INI");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IsValidacionEnvio).HasColumnName("IS_VALIDACION_ENVIO");

                entity.Property(e => e.LiberarEnvio).HasColumnName("LIBERAR_ENVIO");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<BdCargaChangeStatus>(entity =>
            {
                entity.HasKey(e => e.IdCarga)
                    .HasName("PK__BD_CARGA__6F4DBE3DE5A8AF5D");

                entity.ToTable("BD_CARGA_CHANGE_STATUS");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdCargaEnviosDhlErrores>(entity =>
            {
                entity.HasKey(e => e.IdCargaEnvioDhlError)
                    .HasName("PK__BD_CARGA__62D6306DF418DE4F");

                entity.ToTable("BD_CARGA_ENVIOS_DHL_ERRORES");

                entity.Property(e => e.IdCargaEnvioDhlError).HasColumnName("ID_CARGA_ENVIO_DHL_ERROR");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCargaEnvioDhl).HasColumnName("ID_CARGA_ENVIO_DHL");

                entity.Property(e => e.NoGuia)
                    .HasColumnName("NO_GUIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaEnviosDhlPaso>(entity =>
            {
                entity.HasKey(e => e.IdCargaEnvioDhl)
                    .HasName("PK__BD_CARGA__BC7F1400F3F8A6F1");

                entity.ToTable("BD_CARGA_ENVIOS_DHL_PASO");

                entity.Property(e => e.IdCargaEnvioDhl).HasColumnName("ID_CARGA_ENVIO_DHL");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento)
                    .HasColumnName("DESCUENTO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Destinatario)
                    .HasColumnName("DESTINATARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ff)
                    .HasColumnName("FF")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Fletes)
                    .HasColumnName("FLETES")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.ImpIva)
                    .HasColumnName("IMP_IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ImporteNeto)
                    .HasColumnName("IMPORTE_NETO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Kilos)
                    .HasColumnName("KILOS")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoFactura)
                    .HasColumnName("NO_FACTURA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoGuia)
                    .HasColumnName("NO_GUIA")
                    .IsUnicode(false);

                entity.Property(e => e.NoReferencia)
                    .HasColumnName("NO_REFERENCIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Oo)
                    .HasColumnName("OO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Org)
                    .HasColumnName("ORG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .HasColumnName("PROYECTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pza).HasColumnName("PZA");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Remitente)
                    .HasColumnName("REMITENTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Ye).HasColumnName("YE");

                entity.Property(e => e.ZonaProd)
                    .HasColumnName("ZONA_PROD")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaEnviosEstafetaPaso>(entity =>
            {
                entity.HasKey(e => e.IdCargaEnvioEstafetaPaso)
                    .HasName("PK__BD_CARGA__020B7B5CABCED9CF");

                entity.ToTable("BD_CARGA_ENVIOS_ESTAFETA_PASO");

                entity.Property(e => e.IdCargaEnvioEstafetaPaso).HasColumnName("ID_CARGA_ENVIO_ESTAFETA_PASO");

                entity.Property(e => e.AltoCm).HasColumnName("ALTO_CM");

                entity.Property(e => e.AnchoCm).HasColumnName("ANCHO_CM");

                entity.Property(e => e.Dest)
                    .HasColumnName("DEST")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DifKilos)
                    .HasColumnName("DIF_KILOS")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecEntrega)
                    .HasColumnName("FEC_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guia)
                    .HasColumnName("GUIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.LargoCm).HasColumnName("LARGO_CM");

                entity.Property(e => e.MontoSp)
                    .HasColumnName("MONTO_SP")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MtoCbServ)
                    .HasColumnName("MTO_CB_SERV")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MtoServ)
                    .HasColumnName("MTO_SERV")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Orig)
                    .HasColumnName("ORIG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Peso)
                    .HasColumnName("PESO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PesoFactura)
                    .HasColumnName("PESO_FACTURA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Recibe)
                    .HasColumnName("RECIBE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("REFERENCIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sobrepeso)
                    .HasColumnName("SOBREPESO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TiempoEntrega).HasColumnName("TIEMPO_ENTREGA");

                entity.Property(e => e.TipoEmpaque)
                    .HasColumnName("TIPO_EMPAQUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VolReal)
                    .HasColumnName("VOL_REAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasColumnName("ZONA");
            });

            modelBuilder.Entity<BdCargaUnidadNoInventario>(entity =>
            {
                entity.HasKey(e => e.IdCargaUnidadNoInventario)
                    .HasName("PK__BD_CARGA__E3B81BA20B8F49BE");

                entity.ToTable("BD_CARGA_UNIDAD_NO_INVENTARIO");

                entity.Property(e => e.IdCargaUnidadNoInventario).HasColumnName("ID_CARGA_UNIDAD_NO_INVENTARIO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.NoInventarion)
                    .HasColumnName("NO_INVENTARION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCargas>(entity =>
            {
                entity.HasKey(e => e.IdCarga);

                entity.ToTable("BD_CARGAS");

                entity.HasIndex(e => new { e.IdCarga, e.IdCliente, e.IdUsuarioAlta, e.Status })
                    .HasName("IX_BD_CARGAS_ID_USUARIO_ALTA, STATUS");

                entity.HasIndex(e => new { e.IdCarga, e.IdCliente, e.IdUsuarioAlta, e.Status, e.IdStatusCarga })
                    .HasName("IX_MI_BD_CARGAS_4850_4849");

                entity.HasIndex(e => new { e.IdCarga, e.IdUsuarioAlta, e.IdCliente, e.Status, e.IdStatusCarga })
                    .HasName("IX_MI_BD_CARGAS_3330_3329");

                entity.HasIndex(e => new { e.IdUsuarioAlta, e.IdCarga, e.IdCliente, e.Status, e.IdStatusCarga })
                    .HasName("IX_MI_BD_CARGAS_8_7");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAttachArchivo1).HasColumnName("ID_ATTACH_ARCHIVO1");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdStatusCarga).HasColumnName("ID_STATUS_CARGA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCargasConfirmaciones>(entity =>
            {
                entity.HasKey(e => e.IdCargaConfirmaciones)
                    .HasName("PK_BD_CARGAS_CONFIRMACION");

                entity.ToTable("BD_CARGAS_CONFIRMACIONES");

                entity.HasIndex(e => new { e.IdCargaConfirmaciones, e.IdUsuarioAlta, e.Status, e.IdStatusCargaConfirmaciones })
                    .HasName("IX_MI_BD_CARGAS_CONFIRMACIONES_5628_5627");

                entity.Property(e => e.IdCargaConfirmaciones).HasColumnName("ID_CARGA_CONFIRMACIONES");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdStatusCargaConfirmaciones).HasColumnName("ID_STATUS_CARGA_CONFIRMACIONES");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreCargaConfirmaciones)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CARGA_CONFIRMACIONES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCargasEquipo>(entity =>
            {
                entity.HasKey(e => e.IdCargaEquipo)
                    .HasName("PK__BD_CARGA__CD35B7D4765C8BF8");

                entity.ToTable("BD_CARGAS_EQUIPO");

                entity.Property(e => e.IdCargaEquipo).HasColumnName("ID_CARGA_EQUIPO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdCargasMasivas>(entity =>
            {
                entity.HasKey(e => e.IdCargaMasiva);

                entity.ToTable("BD_CARGAS_MASIVAS");

                entity.Property(e => e.IdCargaMasiva).HasColumnName("ID_CARGA_MASIVA");

                entity.Property(e => e.DescAttach)
                    .HasColumnName("DESC_ATTACH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga)
                    .HasColumnName("FECHA_CARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArchivoAttach).HasColumnName("ID_ARCHIVO_ATTACH");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCargasOdtElavon>(entity =>
            {
                entity.HasKey(e => e.IdCarga);

                entity.ToTable("BD_CARGAS_ODT_ELAVON");

                entity.HasIndex(e => e.Afiliacion)
                    .HasName("missing_index_4092_4091");

                entity.HasIndex(e => e.Ar)
                    .HasName("missing_index_3630_3629");

                entity.HasIndex(e => new { e.Afiliacion, e.Idproyecto })
                    .HasName("missing_index_4104_4103");

                entity.HasIndex(e => new { e.Ar, e.Estatus })
                    .HasName("missing_index_3722_3721");

                entity.HasIndex(e => new { e.IdCarga, e.Estatus })
                    .HasName("missing_index_3986_3985");

                entity.HasIndex(e => new { e.IdProceso, e.Ar })
                    .HasName("missing_index_4_3");

                entity.HasIndex(e => new { e.IdProceso, e.Estatus })
                    .HasName("missing_index_3669_3668");

                entity.HasIndex(e => new { e.Afiliacion, e.Estado, e.IdProceso })
                    .HasName("missing_index_24_23");

                entity.HasIndex(e => new { e.Estado, e.IdProceso, e.Afiliacion })
                    .HasName("missing_index_21_20");

                entity.HasIndex(e => new { e.IdProceso, e.Ar, e.Estatus })
                    .HasName("missing_index_3628_3627");

                entity.HasIndex(e => new { e.IdCarga, e.Ar, e.Concepto, e.DescCorta, e.Bitacora, e.Afiliacion, e.Cp, e.Producto, e.Estatus, e.IdProceso })
                    .HasName("missing_index_3663_3662");

                entity.HasIndex(e => new { e.Bitacora, e.Afiliacion, e.Cp, e.Producto, e.Estatus, e.Mensaje, e.IdCarga, e.Ar, e.Concepto, e.DescCorta, e.IdProceso })
                    .HasName("missing_index_4082_4081");

                entity.HasIndex(e => new { e.Ejecutivo, e.AfiliacionAmex, e.FolioTelecargaAmex, e.Producto, e.Sucursal, e.Estatus, e.Rollos, e.Rfc, e.IdEquipo, e.DescEquipo, e.Contacto2, e.TAfiliacion, e.Vip, e.Direccion, e.Colonia, e.Poblacion, e.Idproyecto, e.EmailChgb, e.NotasRemedy, e.DescCorta, e.Sintoma, e.Bitacora, e.IdSegmento, e.FechaInicio, e.Concepto, e.Afiliacion, e.Telefono, e.Negocio, e.Estado, e.Cp, e.Mensaje, e.Caja, e.Correo, e.Contacto1, e.IdCarga, e.FileName, e.Ruta, e.Ar, e.IdProceso })
                    .HasName("missing_index_3658_3657");

                entity.HasIndex(e => new { e.Correo, e.Extra, e.Contacto1, e.Contacto2, e.Vip, e.TAfiliacion, e.FolioTelecargaAmex, e.Producto, e.Idproyecto, e.EmailChgb, e.NotasRemedy, e.Caja, e.IdEquipo, e.DescEquipo, e.IdSegmento, e.FechaInicio, e.Negocio, e.AfiliacionAmex, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Concepto, e.Rfc, e.DescCorta, e.Sintoma, e.Bitacora, e.Afiliacion, e.Telefono, e.Direccion, e.Ejecutivo, e.Sucursal, e.Mensaje, e.IdUsuario, e.Rollos, e.IdCarga, e.IdProceso, e.FileName, e.Ruta, e.Ar, e.Estatus })
                    .HasName("missing_index_3632_3631");

                entity.HasIndex(e => new { e.IdCarga, e.IdProceso, e.FileName, e.AfiliacionAmex, e.Ejecutivo, e.Sucursal, e.Estatus, e.Mensaje, e.IdUsuario, e.Rfc, e.Correo, e.Extra, e.Contacto1, e.Contacto2, e.TAfiliacion, e.Direccion, e.FolioTelecargaAmex, e.Producto, e.Idproyecto, e.EmailChgb, e.Rollos, e.DescCorta, e.IdEquipo, e.DescEquipo, e.IdSegmento, e.FechaInicio, e.Vip, e.Negocio, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.NotasRemedy, e.Ruta, e.Ar, e.Sintoma, e.Bitacora, e.Afiliacion, e.Telefono, e.Caja, e.Concepto })
                    .HasName("missing_index_3831_3830");

                entity.HasIndex(e => new { e.IdCarga, e.IdProceso, e.FileName, e.Caja, e.AfiliacionAmex, e.Ejecutivo, e.Sucursal, e.Estatus, e.Mensaje, e.IdUsuario, e.NotasRemedy, e.Correo, e.Extra, e.Contacto1, e.Contacto2, e.TAfiliacion, e.Negocio, e.FolioTelecargaAmex, e.Producto, e.Idproyecto, e.EmailChgb, e.Rollos, e.Concepto, e.Rfc, e.IdEquipo, e.DescEquipo, e.FechaInicio, e.Vip, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Ruta, e.Ar, e.DescCorta, e.Sintoma, e.Bitacora, e.Afiliacion, e.IdSegmento })
                    .HasName("missing_index_3899_3898");

                entity.HasIndex(e => new { e.TAfiliacion, e.AfiliacionAmex, e.Ejecutivo, e.Sucursal, e.Estatus, e.Mensaje, e.Rollos, e.Rfc, e.Correo, e.Extra, e.Contacto1, e.Contacto2, e.Vip, e.Direccion, e.FolioTelecargaAmex, e.Producto, e.Idproyecto, e.EmailChgb, e.NotasRemedy, e.Concepto, e.IdEquipo, e.DescEquipo, e.IdSegmento, e.FechaInicio, e.Telefono, e.Negocio, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.FileName, e.Ruta, e.Ar, e.Sintoma, e.Bitacora, e.Afiliacion, e.IdCarga, e.IdProceso, e.IdUsuario, e.Caja, e.DescCorta })
                    .HasName("missing_index_3829_3828");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.Afiliacion).HasMaxLength(20);

                entity.Property(e => e.AfiliacionAmex)
                    .HasColumnName("AFILIACION_AMEX")
                    .HasMaxLength(50);

                entity.Property(e => e.Ar)
                    .HasColumnName("AR")
                    .HasMaxLength(50);

                entity.Property(e => e.Bitacora).HasMaxLength(255);

                entity.Property(e => e.Caja)
                    .HasColumnName("CAJA")
                    .HasMaxLength(10);

                entity.Property(e => e.Colonia).HasMaxLength(200);

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Contacto1)
                    .HasColumnName("CONTACTO1")
                    .HasMaxLength(100);

                entity.Property(e => e.Contacto2)
                    .HasColumnName("CONTACTO2")
                    .HasMaxLength(100);

                entity.Property(e => e.Correo)
                    .HasColumnName("CORREO")
                    .HasMaxLength(200);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(6);

                entity.Property(e => e.DescCorta).HasMaxLength(255);

                entity.Property(e => e.DescEquipo).HasMaxLength(255);

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Ejecutivo)
                    .HasColumnName("EJECUTIVO")
                    .HasMaxLength(80);

                entity.Property(e => e.EmailChgb)
                    .HasColumnName("EmailCHGB")
                    .HasMaxLength(100);

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.Extra)
                    .HasColumnName("EXTRA")
                    .HasMaxLength(100);

                entity.Property(e => e.FechaInicio).HasMaxLength(30);

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.FolioTelecargaAmex)
                    .HasColumnName("FOLIO_TELECARGA_AMEX")
                    .HasMaxLength(50);

                entity.Property(e => e.IdEquipo).HasMaxLength(50);

                entity.Property(e => e.IdProceso)
                    .IsRequired()
                    .HasColumnName("ID_PROCESO")
                    .HasMaxLength(50);

                entity.Property(e => e.IdSegmento).HasMaxLength(50);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Idproyecto)
                    .HasColumnName("IDProyecto")
                    .HasMaxLength(10);

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Negocio).HasMaxLength(200);

                entity.Property(e => e.NotasRemedy).HasMaxLength(255);

                entity.Property(e => e.Poblacion).HasMaxLength(200);

                entity.Property(e => e.Producto)
                    .HasColumnName("producto")
                    .HasMaxLength(50);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.Rollos)
                    .HasColumnName("ROLLOS")
                    .HasMaxLength(10);

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasMaxLength(200);

                entity.Property(e => e.Sintoma).HasMaxLength(255);

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(80);

                entity.Property(e => e.TAfiliacion)
                    .HasColumnName("T_AFILIACION")
                    .HasMaxLength(10);

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.Vip)
                    .HasColumnName("VIP")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdChangeMassiveStatus>(entity =>
            {
                entity.HasKey(e => e.IdChangeMassiveStatus)
                    .HasName("PK__BD_CHANG__46371A5FC374BDB2");

                entity.ToTable("BD_CHANGE_MASSIVE_STATUS");

                entity.Property(e => e.IdChangeMassiveStatus).HasColumnName("ID_CHANGE_MASSIVE_STATUS");

                entity.Property(e => e.Errores)
                    .HasColumnName("ERRORES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdChangeStatusArPaso>(entity =>
            {
                entity.HasKey(e => e.IdChangeStatusAr)
                    .HasName("PK__BD_CHANG__08C1AF99A16E8898");

                entity.ToTable("BD_CHANGE_STATUS_AR_PASO");

                entity.Property(e => e.IdChangeStatusAr).HasColumnName("ID_CHANGE_STATUS_AR");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdClaveEstado>(entity =>
            {
                entity.HasKey(e => e.IdClaveEstado)
                    .HasName("PK_BD_ESTADO_CLAVE");

                entity.ToTable("BD_CLAVE_ESTADO");

                entity.Property(e => e.IdClaveEstado).HasColumnName("ID_CLAVE_ESTADO");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.BdClaveEstado)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_BD_CLAVE_ESTADO_SEPOMEX_ESTADOS");
            });

            modelBuilder.Entity<BdClienteModelo>(entity =>
            {
                entity.HasKey(e => e.IdClienteModelo);

                entity.ToTable("BD_CLIENTE_MODELO");

                entity.Property(e => e.IdClienteModelo).HasColumnName("ID_CLIENTE_MODELO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsF11).HasColumnName("IS_F11");
            });

            modelBuilder.Entity<BdClienteModeloCambioStatusUnidad>(entity =>
            {
                entity.HasKey(e => e.IdClienteModeloCambioStatusUnidad);

                entity.ToTable("BD_CLIENTE_MODELO_CAMBIO_STATUS_UNIDAD");

                entity.Property(e => e.IdClienteModeloCambioStatusUnidad).HasColumnName("ID_CLIENTE_MODELO_CAMBIO_STATUS_UNIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdStatusUnidadFrom).HasColumnName("ID_STATUS_UNIDAD_FROM");

                entity.Property(e => e.IdStatusUnidadTo).HasColumnName("ID_STATUS_UNIDAD_TO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdClienteProductoStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdClienteProductoStatusAr);

                entity.ToTable("BD_CLIENTE_PRODUCTO_STATUS_AR");

                entity.Property(e => e.IdClienteProductoStatusAr).HasColumnName("ID_CLIENTE_PRODUCTO_STATUS_AR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProductoStatusAr).HasColumnName("ID_PRODUCTO_STATUS_AR");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdProductoStatusArNavigation)
                    .WithMany(p => p.BdClienteProductoStatusAr)
                    .HasForeignKey(d => d.IdProductoStatusAr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_CLIENTE_PRODUCTO_STATUS_AR_BD_PRODUCTO_STATUS_AR");
            });

            modelBuilder.Entity<BdClienteWeekhour>(entity =>
            {
                entity.HasKey(e => e.IdClienteWeekhour);

                entity.ToTable("BD_CLIENTE_WEEKHOUR");

                entity.Property(e => e.IdClienteWeekhour).HasColumnName("ID_CLIENTE_WEEKHOUR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdWeekhour).HasColumnName("ID_WEEKHOUR");
            });

            modelBuilder.Entity<BdComentarioAr>(entity =>
            {
                entity.HasKey(e => e.IdComentarioAr);

                entity.ToTable("BD_COMENTARIO_AR");

                entity.HasIndex(e => e.IdAr);

                entity.Property(e => e.IdComentarioAr).HasColumnName("ID_COMENTARIO_AR");

                entity.Property(e => e.DescComentarioAr)
                    .HasColumnName("DESC_COMENTARIO_AR")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdTarea).HasColumnName("ID_TAREA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioOki).HasColumnName("ID_USUARIO_OKI");

                entity.Property(e => e.NotifyBancomer)
                    .HasColumnName("NOTIFY_BANCOMER")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BdComprobacionSolicitudesViaticos>(entity =>
            {
                entity.HasKey(e => e.IdComprobacionSolicitudesViaticos);

                entity.ToTable("BD_COMPROBACION_SOLICITUDES_VIATICOS");

                entity.HasIndex(e => new { e.IdUsuarioSolicitado, e.Status, e.FecCorteSolicitudesViaticos })
                    .HasName("IX_MI_BD_COMPROBACION_SOLICITUDES_VIATICOS_1826_1825");

                entity.Property(e => e.IdComprobacionSolicitudesViaticos).HasColumnName("ID_COMPROBACION_SOLICITUDES_VIATICOS");

                entity.Property(e => e.FecCorteSolicitudesViaticos)
                    .HasColumnName("FEC_CORTE_SOLICITUDES_VIATICOS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioSolicitado).HasColumnName("ID_USUARIO_SOLICITADO");

                entity.Property(e => e.MontoComprobado)
                    .HasColumnName("MONTO_COMPROBADO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdComprobacionViaticos>(entity =>
            {
                entity.HasKey(e => e.IdComprobacionViaticos);

                entity.ToTable("BD_COMPROBACION_VIATICOS");

                entity.HasIndex(e => new { e.IdComprobacionViaticos, e.ArchivoPdf, e.Estatus, e.IdRazon, e.IdSolicitudViaticos, e.Status })
                    .HasName("IX_BD_COMPROBACION_VIATICOS");

                entity.Property(e => e.IdComprobacionViaticos).HasColumnName("ID_COMPROBACION_VIATICOS");

                entity.Property(e => e.ArchivoPdf)
                    .HasColumnName("ARCHIVO_PDF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivoXml)
                    .HasColumnName("ARCHIVO_XML")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.IdRazon).HasColumnName("ID_RAZON");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdTipoViatico).HasColumnName("ID_TIPO_VIATICO");

                entity.Property(e => e.MontoAprobado)
                    .HasColumnName("MONTO_APROBADO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoComprobado)
                    .HasColumnName("MONTO_COMPROBADO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<BdComprobacionViaticos2>(entity =>
            {
                entity.HasKey(e => e.IdComprobacionViaticos);

                entity.ToTable("BD_COMPROBACION_VIATICOS_2");

                entity.Property(e => e.IdComprobacionViaticos).HasColumnName("ID_COMPROBACION_VIATICOS");

                entity.Property(e => e.ArchivoPdf)
                    .HasColumnName("ARCHIVO_PDF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivoXml)
                    .HasColumnName("ARCHIVO_XML")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdRazon).HasColumnName("ID_RAZON");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdTipoViatico).HasColumnName("ID_TIPO_VIATICO");

                entity.Property(e => e.IdViatico).HasColumnName("ID_VIATICO");

                entity.Property(e => e.IsAprobado).HasColumnName("IS_APROBADO");

                entity.Property(e => e.IsValidadorXml).HasColumnName("IS_VALIDADOR_XML");

                entity.Property(e => e.MontoAprobado)
                    .HasColumnName("MONTO_APROBADO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoComprobado)
                    .HasColumnName("MONTO_COMPROBADO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<BdCompromisoBlog>(entity =>
            {
                entity.HasKey(e => e.IdCompromisosBlog);

                entity.ToTable("BD_COMPROMISO_BLOG");

                entity.Property(e => e.IdCompromisosBlog).HasColumnName("ID_COMPROMISOS_BLOG");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompromiso).HasColumnName("ID_COMPROMISO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdCompromisoResponsable>(entity =>
            {
                entity.HasKey(e => e.IdCompromisoResponsable);

                entity.ToTable("BD_COMPROMISO_RESPONSABLE");

                entity.Property(e => e.IdCompromisoResponsable).HasColumnName("ID_COMPROMISO_RESPONSABLE");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdCompromiso).HasColumnName("ID_COMPROMISO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");
            });

            modelBuilder.Entity<BdCompromisos>(entity =>
            {
                entity.HasKey(e => e.IdCompromiso);

                entity.ToTable("BD_COMPROMISOS");

                entity.Property(e => e.IdCompromiso).HasColumnName("ID_COMPROMISO");

                entity.Property(e => e.Calif).HasColumnName("CALIF");

                entity.Property(e => e.CodigoControl)
                    .HasColumnName("CODIGO_CONTROL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescCompromiso)
                    .HasColumnName("DESC_COMPROMISO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecFin)
                    .HasColumnName("FEC_FIN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIni)
                    .HasColumnName("FEC_INI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRealTermino)
                    .HasColumnName("FEC_REAL_TERMINO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdPrioridades).HasColumnName("ID_PRIORIDADES");

                entity.Property(e => e.IdUsuarioResponsable).HasColumnName("ID_USUARIO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioResponsableCompromiso).HasColumnName("ID_USUARIO_RESPONSABLE_COMPROMISO");

                entity.Property(e => e.NombreJunta).HasColumnName("NOMBRE_JUNTA");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.StatusCompromiso)
                    .HasColumnName("STATUS_COMPROMISO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCompromisosAcciones>(entity =>
            {
                entity.HasKey(e => e.IdCompromisosAcciones);

                entity.ToTable("BD_COMPROMISOS_ACCIONES");

                entity.Property(e => e.IdCompromisosAcciones).HasColumnName("ID_COMPROMISOS_ACCIONES");

                entity.Property(e => e.AccionConcluida).HasColumnName("ACCION_CONCLUIDA");

                entity.Property(e => e.DescAccion)
                    .HasColumnName("DESC_ACCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompromiso).HasColumnName("ID_COMPROMISO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Porcentaje).HasColumnName("PORCENTAJE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCompromisosCompromiso>(entity =>
            {
                entity.HasKey(e => e.IdCompromisosCompromiso);

                entity.ToTable("BD_COMPROMISOS_COMPROMISO");

                entity.Property(e => e.IdCompromisosCompromiso).HasColumnName("ID_COMPROMISOS_COMPROMISO");

                entity.Property(e => e.Compromiso)
                    .HasColumnName("COMPROMISO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompromiso).HasColumnName("ID_COMPROMISO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdConfiguracionMensajeria>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracion)
                    .HasName("PK__BD_CONFI__093CFA5F7A96450F");

                entity.ToTable("BD_CONFIGURACION_MENSAJERIA");

                entity.Property(e => e.IdConfiguracion).HasColumnName("ID_CONFIGURACION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiull)
                    .HasColumnName("FIULL")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Longitud).HasColumnName("LONGITUD");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdConfirmaciones>(entity =>
            {
                entity.HasKey(e => e.IdConfirmacion);

                entity.ToTable("BD_CONFIRMACIONES");

                entity.HasIndex(e => new { e.IdCargaConfirmaciones, e.Status })
                    .HasName("IX_BD_CONFIRMACIONES_ID_CARGA_CONFIRMACIONES, STATUS");

                entity.Property(e => e.IdConfirmacion).HasColumnName("ID_CONFIRMACION");

                entity.Property(e => e.IdCargaConfirmaciones).HasColumnName("ID_CARGA_CONFIRMACIONES");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.NumConfirmacion)
                    .HasColumnName("NUM_CONFIRMACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargaConfirmacionesNavigation)
                    .WithMany(p => p.BdConfirmaciones)
                    .HasForeignKey(d => d.IdCargaConfirmaciones)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_BD_CARGAS_CONFIRMACIONES");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdConfirmaciones)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdConfirmacionesIntermedia>(entity =>
            {
                entity.HasKey(e => e.IdConfirmacionIntermedia);

                entity.ToTable("BD_CONFIRMACIONES_INTERMEDIA");

                entity.HasIndex(e => e.IdCargaConfirmaciones);

                entity.Property(e => e.IdConfirmacionIntermedia).HasColumnName("ID_CONFIRMACION_INTERMEDIA");

                entity.Property(e => e.IdCargaConfirmaciones).HasColumnName("ID_CARGA_CONFIRMACIONES");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.NumConfirmacion)
                    .HasColumnName("NUM_CONFIRMACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargaConfirmacionesNavigation)
                    .WithMany(p => p.BdConfirmacionesIntermedia)
                    .HasForeignKey(d => d.IdCargaConfirmaciones)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_INTERMEDIA_BD_CARGAS_CONFIRMACIONES");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdConfirmacionesIntermedia)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_INTERMEDIA_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdConjuntoModeloConectividad>(entity =>
            {
                entity.HasKey(e => e.IdConjunto)
                    .HasName("PK__BD_CONJU__AFAEAB5FC394C4FA");

                entity.ToTable("BD_CONJUNTO_MODELO_CONECTIVIDAD");

                entity.Property(e => e.IdConjunto).HasColumnName("ID_CONJUNTO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdConectividadParent).HasColumnName("ID_CONECTIVIDAD_PARENT");

                entity.Property(e => e.IdModeloParent).HasColumnName("ID_MODELO_PARENT");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdConsumiblesUnidad>(entity =>
            {
                entity.HasKey(e => e.IdConsumibleUnidad);

                entity.ToTable("BD_CONSUMIBLES_UNIDAD");

                entity.HasIndex(e => new { e.IdUnidad, e.Autorizado })
                    .HasName("IX_BD_CONSUMIBLES_UNIDAD_ID_UNIDAD, AUTORIZADO");

                entity.Property(e => e.IdConsumibleUnidad).HasColumnName("ID_CONSUMIBLE_UNIDAD");

                entity.Property(e => e.Autorizado).HasColumnName("AUTORIZADO");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdConsumible).HasColumnName("ID_CONSUMIBLE");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoConsumiblesUtilizados).HasColumnName("NO_CONSUMIBLES_UTILIZADOS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotalConsumibles).HasColumnName("TOTAL_CONSUMIBLES");
            });

            modelBuilder.Entity<BdControlAlertasAr>(entity =>
            {
                entity.HasKey(e => e.IdControlAr)
                    .HasName("PK__BD_CONTR__AC29B6595032ECA8");

                entity.ToTable("BD_CONTROL_ALERTAS_AR");

                entity.Property(e => e.IdControlAr).HasColumnName("ID_CONTROL_AR");

                entity.Property(e => e.Avisado).HasColumnName("AVISADO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdControlInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBdControlInsumos)
                    .HasName("PK__BD_CONTR__A1BE29351BE96354");

                entity.ToTable("BD_CONTROL_INSUMOS");

                entity.Property(e => e.IdBdControlInsumos).HasColumnName("ID_BD_CONTROL_INSUMOS");

                entity.Property(e => e.Entrada).HasColumnName("ENTRADA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusInsumo).HasColumnName("ID_STATUS_INSUMO");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.NoTarima)
                    .HasColumnName("NO_TARIMA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionInventario)
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salida).HasColumnName("SALIDA");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasComputedColumnSql("([ENTRADA]-[SALIDA])");
            });

            modelBuilder.Entity<BdControlInsumosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdControlInsumosDetalle);

                entity.ToTable("BD_CONTROL_INSUMOS_DETALLE");

                entity.Property(e => e.IdControlInsumosDetalle).HasColumnName("ID_CONTROL_INSUMOS_DETALLE");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoReponsable).HasColumnName("ID_TIPO_REPONSABLE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.HasOne(d => d.IdTipoReponsableNavigation)
                    .WithMany(p => p.BdControlInsumosDetalle)
                    .HasForeignKey(d => d.IdTipoReponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_CONTROL_INSUMOS_DETALLE_C_TIPO_RESPONSABLE");
            });

            modelBuilder.Entity<BdControlInsumosEnvios>(entity =>
            {
                entity.HasKey(e => e.IdControlInsumoEnvio)
                    .HasName("PK__BD_CONTR__85880945AA658A7F");

                entity.ToTable("BD_CONTROL_INSUMOS_ENVIOS");

                entity.Property(e => e.IdControlInsumoEnvio).HasColumnName("ID_CONTROL_INSUMO_ENVIO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CantidadRetorno).HasColumnName("CANTIDAD_RETORNO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdStatusInsumo).HasColumnName("ID_STATUS_INSUMO");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IsReception).HasColumnName("IS_RECEPTION");
            });

            modelBuilder.Entity<BdControlKitTecnico>(entity =>
            {
                entity.HasKey(e => e.IdKitTecnico)
                    .HasName("PK__BD_CONTR__2C41134BD9207889");

                entity.ToTable("BD_CONTROL_KIT_TECNICO");

                entity.Property(e => e.IdKitTecnico).HasColumnName("ID_KIT_TECNICO");

                entity.Property(e => e.AproboCantidad).HasColumnName("APROBO_CANTIDAD");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.ControlInsumo).HasColumnName("CONTROL_INSUMO");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");
            });

            modelBuilder.Entity<BdControlMasivoDevoluciones>(entity =>
            {
                entity.HasKey(e => e.IdControlMasivoDevolucion)
                    .HasName("PK__BD_CONTR__B4CFAE3C725FCD24");

                entity.ToTable("BD_CONTROL_MASIVO_DEVOLUCIONES");

                entity.Property(e => e.IdControlMasivoDevolucion).HasColumnName("ID_CONTROL_MASIVO_DEVOLUCION");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCotizaciones3m>(entity =>
            {
                entity.HasKey(e => e.IdCotizacion);

                entity.ToTable("BD_COTIZACIONES_3M");

                entity.Property(e => e.IdCotizacion).HasColumnName("id_cotizacion");

                entity.Property(e => e.Atencion).HasMaxLength(60);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("fec_alta")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("id_ar");

                entity.Property(e => e.IdAutoriza).HasColumnName("id_autoriza");

                entity.Property(e => e.IdCondiciones).HasColumnName("id_condiciones");

                entity.Property(e => e.IdDiagnostica).HasColumnName("id_diagnostica");

                entity.Property(e => e.IdGenera).HasColumnName("id_genera");

                entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");

                entity.Property(e => e.IdNegocio).HasColumnName("id_negocio");

                entity.Property(e => e.IdReparacion).HasColumnName("id_reparacion");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");

                entity.Property(e => e.IsAutorizada).HasColumnName("is_autorizada");

                entity.Property(e => e.NoReporte)
                    .HasColumnName("no_reporte")
                    .HasMaxLength(20);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(250);

                entity.Property(e => e.Tc).HasColumnName("tc");

                entity.Property(e => e.Telefono).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<BdCotizaciones3mDet>(entity =>
            {
                entity.HasKey(e => e.IdDetCotizacion);

                entity.ToTable("BD_COTIZACIONES_3M_DET");

                entity.Property(e => e.IdDetCotizacion).HasColumnName("id_det_cotizacion");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.IdCotizacion).HasColumnName("id_cotizacion");

                entity.Property(e => e.IdInsumo).HasColumnName("id_insumo");

                entity.Property(e => e.IdUm).HasColumnName("id_um");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<BdCpAsignacionAutomatica>(entity =>
            {
                entity.HasKey(e => e.IdCpAsignacionAutomatica)
                    .HasName("PK__BD_CP_AS__0E6D66520FB31B61");

                entity.ToTable("BD_CP_ASIGNACION_AUTOMATICA");

                entity.Property(e => e.IdCpAsignacionAutomatica).HasColumnName("ID_CP_ASIGNACION_AUTOMATICA");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdReglaAsignacionAutomatica).HasColumnName("ID_REGLA_ASIGNACION_AUTOMATICA");
            });

            modelBuilder.Entity<BdCuentasBancarias>(entity =>
            {
                entity.HasKey(e => e.IdCuentaBancaria);

                entity.ToTable("BD_CUENTAS_BANCARIAS");

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("ID_CUENTA_BANCARIA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdBanco).HasColumnName("ID_BANCO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreBanco)
                    .IsRequired()
                    .HasColumnName("NOMBRE_BANCO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasColumnName("NUMERO_CUENTA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCursos>(entity =>
            {
                entity.HasKey(e => e.IdCursos);

                entity.ToTable("BD_CURSOS");

                entity.Property(e => e.IdCursos).HasColumnName("ID_CURSOS");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecFin)
                    .HasColumnName("FEC_FIN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("FEC_INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCapacitador).HasColumnName("ID_CAPACITADOR");

                entity.Property(e => e.IdNombreCurso).HasColumnName("ID_NOMBRE_CURSO");

                entity.Property(e => e.IdSedeCurso).HasColumnName("ID_SEDE_CURSO");

                entity.Property(e => e.IdStatusCurso).HasColumnName("ID_STATUS_CURSO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdCursosAsignados>(entity =>
            {
                entity.HasKey(e => e.IdCursoAsignado);

                entity.ToTable("BD_CURSOS_ASIGNADOS");

                entity.Property(e => e.IdCursoAsignado).HasColumnName("ID_CURSO_ASIGNADO");

                entity.Property(e => e.Calificacion)
                    .HasColumnName("CALIFICACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCursos).HasColumnName("ID_CURSOS");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdDbBackup>(entity =>
            {
                entity.HasKey(e => e.IdDbBackup);

                entity.ToTable("BD_DB_BACKUP");

                entity.Property(e => e.IdDbBackup).HasColumnName("ID_DB_BACKUP");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("FILE_PATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdDevoluciones>(entity =>
            {
                entity.HasKey(e => e.IdDevolucion);

                entity.ToTable("BD_DEVOLUCIONES");

                entity.Property(e => e.IdDevolucion).HasColumnName("ID_DEVOLUCION");

                entity.Property(e => e.DescEncargadoRecepcion)
                    .HasColumnName("DESC_ENCARGADO_RECEPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescLugarRecepcion)
                    .HasColumnName("DESC_LUGAR_RECEPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecDevolucion)
                    .HasColumnName("FEC_DEVOLUCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdRazonDevolucion).HasColumnName("ID_RAZON_DEVOLUCION");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdDevoluciones)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_BD_DEVOLUCIONES_C_CLIENTES");

                entity.HasOne(d => d.IdRazonDevolucionNavigation)
                    .WithMany(p => p.BdDevoluciones)
                    .HasForeignKey(d => d.IdRazonDevolucion)
                    .HasConstraintName("FK_BD_DEVOLUCIONES_C_RAZON_DEVOLUCION");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdDevoluciones)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_DEVOLUCIONES_BD_UNIDADES");
            });

            modelBuilder.Entity<BdDirecciones>(entity =>
            {
                entity.HasKey(e => e.IdDireccion);

                entity.ToTable("BD_DIRECCIONES");

                entity.Property(e => e.IdDireccion).HasColumnName("ID_DIRECCION");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnName("COLONIA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionAbreviada)
                    .HasColumnName("DIRECCION_ABREVIADA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.Latitud)
                    .HasColumnName("LATITUD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("LONGITUD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .IsRequired()
                    .HasColumnName("POBLACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdDireccionesRelaciones>(entity =>
            {
                entity.HasKey(e => e.IdDireccionRelacion);

                entity.ToTable("BD_DIRECCIONES_RELACIONES");

                entity.Property(e => e.IdDireccionRelacion).HasColumnName("ID_DIRECCION_RELACION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdDireccion).HasColumnName("ID_DIRECCION");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            });

            modelBuilder.Entity<BdElavonDispatches>(entity =>
            {
                entity.HasKey(e => e.IdElavonDispatches);

                entity.ToTable("BD_ELAVON_DISPATCHES");

                entity.Property(e => e.IdElavonDispatches).HasColumnName("ID_ELAVON_DISPATCHES");

                entity.Property(e => e.AccessoryAmt)
                    .HasColumnName("accessory_amt")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AccessoryType)
                    .HasColumnName("accessory_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumableAmt)
                    .HasColumnName("consumable_amt")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumableType)
                    .HasColumnName("consumable_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("device_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory)
                    .HasColumnName("device_type_category")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdElavonInbox).HasColumnName("ID_ELAVON_INBOX");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareName)
                    .HasColumnName("software_name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareVendor)
                    .HasColumnName("software_vendor")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareVersion)
                    .HasColumnName("software_version")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdElavonRecoveries>(entity =>
            {
                entity.HasKey(e => e.IdElavonRecoveries);

                entity.ToTable("BD_ELAVON_RECOVERIES");

                entity.Property(e => e.IdElavonRecoveries).HasColumnName("ID_ELAVON_RECOVERIES");

                entity.Property(e => e.AccessoryType)
                    .HasColumnName("accessory_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("device_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory)
                    .HasColumnName("device_type_category")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdElavonInbox).HasColumnName("ID_ELAVON_INBOX");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdEmails>(entity =>
            {
                entity.HasKey(e => e.IdEmail);

                entity.ToTable("BD_EMAILS");

                entity.HasIndex(e => new { e.IdEmail, e.Status })
                    .HasName("IX_BD_EMAILS_STATUS");

                entity.Property(e => e.IdEmail).HasColumnName("ID_EMAIL");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DescEmail)
                    .HasColumnName("DESC_EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBody)
                    .HasColumnName("EMAIL_BODY")
                    .IsUnicode(false);

                entity.Property(e => e.EmailBodytype)
                    .HasColumnName("EMAIL_BODYTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasColumnName("EMAIL_FROM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject)
                    .HasColumnName("EMAIL_SUBJECT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasColumnName("EMAIL_TO")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailToUser).HasColumnName("EMAIL_TO_USER");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta)
                    .HasColumnName("ID_USUARIO_ALTA")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdEmails2>(entity =>
            {
                entity.HasKey(e => e.IdEmail);

                entity.ToTable("BD_EMAILS_2");

                entity.Property(e => e.IdEmail).HasColumnName("ID_EMAIL");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DescEmail)
                    .HasColumnName("DESC_EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBody)
                    .HasColumnName("EMAIL_BODY")
                    .IsUnicode(false);

                entity.Property(e => e.EmailBodytype)
                    .HasColumnName("EMAIL_BODYTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasColumnName("EMAIL_FROM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject)
                    .HasColumnName("EMAIL_SUBJECT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasColumnName("EMAIL_TO")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailToUser).HasColumnName("EMAIL_TO_USER");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUsuarioAlta)
                    .HasColumnName("ID_USUARIO_ALTA")
                    .HasMaxLength(10);

                entity.Property(e => e.NoAr)
                    .IsRequired()
                    .HasColumnName("NO_AR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdEnvioDoctosDocto>(entity =>
            {
                entity.HasKey(e => e.IdEnvioDoctosDocto);

                entity.ToTable("BD_ENVIO_DOCTOS_DOCTO");

                entity.HasIndex(e => e.IdArPrefacturacion);

                entity.HasIndex(e => e.IdEnvioDoctos);

                entity.HasIndex(e => e.IsRecibido);

                entity.Property(e => e.IdEnvioDoctosDocto).HasColumnName("ID_ENVIO_DOCTOS_DOCTO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRecepcion)
                    .HasColumnName("FEC_RECEPCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdArPrefacturacion).HasColumnName("ID_AR_PREFACTURACION");

                entity.Property(e => e.IdEnvioDoctos).HasColumnName("ID_ENVIO_DOCTOS");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioRecepcion).HasColumnName("ID_USUARIO_RECEPCION");

                entity.Property(e => e.IsRecibido).HasColumnName("IS_RECIBIDO");
            });

            modelBuilder.Entity<BdEnvioElavon>(entity =>
            {
                entity.HasKey(e => e.IdEnvioElavon);

                entity.ToTable("BD_ENVIO_ELAVON");

                entity.Property(e => e.IdEnvioElavon).HasColumnName("ID_ENVIO_ELAVON");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.NombreArchivo)
                    .HasColumnName("NOMBRE_ARCHIVO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.XmlData)
                    .HasColumnName("XML_DATA")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<BdEnvioInsumos>(entity =>
            {
                entity.HasKey(e => e.IdEnvioInsumo);

                entity.ToTable("BD_ENVIO_INSUMOS");

                entity.HasIndex(e => e.IdEnvio)
                    .HasName("IDX1");

                entity.Property(e => e.IdEnvioInsumo).HasColumnName("ID_ENVIO_INSUMO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FecRecibida)
                    .HasColumnName("FEC_RECIBIDA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusUnidad2).HasColumnName("ID_STATUS_UNIDAD2");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioRecepcion).HasColumnName("ID_USUARIO_RECEPCION");

                entity.Property(e => e.IsRecibida).HasColumnName("IS_RECIBIDA");

                entity.HasOne(d => d.IdEnvioNavigation)
                    .WithMany(p => p.BdEnvioInsumos)
                    .HasForeignKey(d => d.IdEnvio)
                    .HasConstraintName("FK_BD_ENVIO_INSUMOS_BD_ENVIOS");
            });

            modelBuilder.Entity<BdEnvioSims>(entity =>
            {
                entity.HasKey(e => e.IdEnvioSim);

                entity.ToTable("BD_ENVIO_SIMS");

                entity.Property(e => e.IdEnvioSim).HasColumnName("ID_ENVIO_SIM");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRecibida)
                    .HasColumnName("FEC_RECIBIDA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.IdStatusUnidad2).HasColumnName("ID_STATUS_UNIDAD2");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioRecepcion).HasColumnName("ID_USUARIO_RECEPCION");

                entity.Property(e => e.IsRecibida).HasColumnName("IS_RECIBIDA");

                entity.HasOne(d => d.IdSimNavigation)
                    .WithMany(p => p.BdEnvioSims)
                    .HasForeignKey(d => d.IdSim)
                    .HasConstraintName("FK_BD_ENVIO_SIMS_BD_MC_SIMS");

                entity.HasOne(d => d.IdUsuarioRecepcionNavigation)
                    .WithMany(p => p.BdEnvioSims)
                    .HasForeignKey(d => d.IdUsuarioRecepcion)
                    .HasConstraintName("FK_BD_ENVIO_SIMS_C_USUARIOS");
            });

            modelBuilder.Entity<BdEnvioUnidad>(entity =>
            {
                entity.HasKey(e => e.IdEnvioUnidad);

                entity.ToTable("BD_ENVIO_UNIDAD");

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdUnidad, e.IdEnvio })
                    .HasName("IX_BD_ENVIO_UNIDAD_ID_ENVIO");

                entity.HasIndex(e => new { e.IdUnidad, e.IdEnvio, e.IsRecibida })
                    .HasName("IX_BD_ENVIO_UNIDAD_IS_RECIBIDA");

                entity.Property(e => e.IdEnvioUnidad).HasColumnName("ID_ENVIO_UNIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRecibida)
                    .HasColumnName("FEC_RECIBIDA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdStatusUnidad2).HasColumnName("ID_STATUS_UNIDAD2");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioRecepcion).HasColumnName("ID_USUARIO_RECEPCION");

                entity.Property(e => e.IsRecibida)
                    .HasColumnName("IS_RECIBIDA")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdEnvioNavigation)
                    .WithMany(p => p.BdEnvioUnidad)
                    .HasForeignKey(d => d.IdEnvio)
                    .HasConstraintName("FK_BD_ENVIO_UNIDAD_BD_ENVIOS");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdEnvioUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_ENVIO_UNIDAD_BD_UNIDADES");

                entity.HasOne(d => d.IdUsuarioRecepcionNavigation)
                    .WithMany(p => p.BdEnvioUnidad)
                    .HasForeignKey(d => d.IdUsuarioRecepcion)
                    .HasConstraintName("FK_BD_ENVIO_UNIDAD_C_USUARIOS");
            });

            modelBuilder.Entity<BdEnvios>(entity =>
            {
                entity.HasKey(e => e.IdEnvio);

                entity.ToTable("BD_ENVIOS");

                entity.HasIndex(e => e.NoGuia)
                    .HasName("NO_GUIA");

                entity.HasIndex(e => new { e.IdEnvio, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_1947_1946");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableDestino, e.IdResponsableDestino, e.IdStatusEnvio })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_DESTINO, ID_RESPONSABLE_DESTINO, ID_STATUS_ENVIO");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_ORIGEN, ID_RESPONSABLE_ORIGEN, ID_STATUS_ENVIO");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio, e.Status })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_ORIGEN, ID_RESPONSABLE_ORIGEN, ID_STATUS_ENVIO, STATUS");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdUrgenciaEnvio, e.FecEnvio, e.IdTipoResponsableDestino, e.IdStatusEnvio })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_DESTINO, ID_STATUS_ENVIO");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableOrigen, e.IdTipoResponsableOrigen, e.IdStatusEnvio, e.Status, e.FecEnvio })
                    .HasName("IX_MI_BD_ENVIOS_30334_30333");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio, e.Status, e.FecEnvio })
                    .HasName("IX_MI_BD_ENVIOS_30381_30380");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdUrgenciaEnvio, e.FecEnvio, e.IdTipoResponsableDestino, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_5596_5595");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdServicioMensajeriasPrecio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdTipoResponsableDestino, e.FecEnvio, e.IdStatusEnvio })
                    .HasName("INDX1");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdServicioMensajeria, e.NoGuia, e.IdUrgenciaEnvio, e.FecEnvio, e.FecRecepcion, e.IdTipoResponsableDestino, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_6182_6181");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdServicioMensajeria, e.NoGuia, e.Costo, e.IdUrgenciaEnvio, e.FecEnvio, e.FecRecepcion, e.IdTipoResponsableDestino, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_13806_13805");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRecepcion)
                    .HasColumnName("FEC_RECEPCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraEntrega)
                    .HasColumnName("HORA_ENTREGA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdChofer).HasColumnName("ID_CHOFER");

                entity.Property(e => e.IdClienteNuevo).HasColumnName("ID_CLIENTE_NUEVO");

                entity.Property(e => e.IdDireccionDestino).HasColumnName("ID_DIRECCION_DESTINO");

                entity.Property(e => e.IdProductoDhl).HasColumnName("ID_PRODUCTO_DHL");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdServicioMensajeriasPrecio).HasColumnName("ID_SERVICIO_MENSAJERIAS_PRECIO");

                entity.Property(e => e.IdStatusEnvio).HasColumnName("ID_STATUS_ENVIO");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdUrgenciaEnvio).HasColumnName("ID_URGENCIA_ENVIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAltaMasivaSimEspecial).HasColumnName("IS_ALTA_MASIVA_SIM_ESPECIAL");

                entity.Property(e => e.IsStock).HasColumnName("IS_STOCK");

                entity.Property(e => e.NoGuia)
                    .HasColumnName("NO_GUIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtraDireccionDestino)
                    .HasColumnName("OTRA_DIRECCION_DESTINO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Paquetes).HasColumnName("PAQUETES");

                entity.Property(e => e.Peso)
                    .HasColumnName("PESO")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdChoferNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdChofer)
                    .HasConstraintName("FK_BD_ENVIOS_C_USUARIOS");

                entity.HasOne(d => d.IdDireccionDestinoNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdDireccionDestino)
                    .HasConstraintName("FK_BD_ENVIOS_BD_DIRECCIONES");

                entity.HasOne(d => d.IdServicioMensajeriaNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdServicioMensajeria)
                    .HasConstraintName("FK_BD_ENVIOS_C_SERVICIO_MENSAJERIA");

                entity.HasOne(d => d.IdStatusEnvioNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdStatusEnvio)
                    .HasConstraintName("FK_BD_ENVIOS_C_STATUS_ENVIO");

                entity.HasOne(d => d.IdTipoResponsableDestinoNavigation)
                    .WithMany(p => p.BdEnviosIdTipoResponsableDestinoNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableDestino)
                    .HasConstraintName("FK_BD_ENVIOS_C_TIPO_RESPONSABLE1");

                entity.HasOne(d => d.IdTipoResponsableOrigenNavigation)
                    .WithMany(p => p.BdEnviosIdTipoResponsableOrigenNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableOrigen)
                    .HasConstraintName("FK_BD_ENVIOS_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdUrgenciaEnvioNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdUrgenciaEnvio)
                    .HasConstraintName("FK_BD_ENVIOS_C_URGENCIA_ENVIO");
            });

            modelBuilder.Entity<BdEnviosDoctos>(entity =>
            {
                entity.HasKey(e => e.IdEnvioDoctos);

                entity.ToTable("BD_ENVIOS_DOCTOS");

                entity.HasIndex(e => new { e.IdEnvioDoctos, e.IdUrgenciaEnvio, e.FecEnvio, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_DOCTOS_11883_11882");

                entity.HasIndex(e => new { e.IdEnvioDoctos, e.IdUrgenciaEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_DOCTOS_5459_5458");

                entity.Property(e => e.IdEnvioDoctos).HasColumnName("ID_ENVIO_DOCTOS");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRecepcion)
                    .HasColumnName("FEC_RECEPCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdStatusEnvio).HasColumnName("ID_STATUS_ENVIO");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdUrgenciaEnvio).HasColumnName("ID_URGENCIA_ENVIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoGuia)
                    .HasColumnName("NO_GUIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdEquivaleciasModelo>(entity =>
            {
                entity.HasKey(e => e.IdEquivaliencia)
                    .HasName("PK__BD_EQUIV__4C1C0899B71CD290");

                entity.ToTable("BD_EQUIVALECIAS_MODELO");

                entity.Property(e => e.IdEquivaliencia).HasColumnName("ID_EQUIVALIENCIA");

                entity.Property(e => e.DescNuevoModelo)
                    .HasColumnName("DESC_NUEVO_MODELO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");
            });

            modelBuilder.Entity<BdEquivalenciaEstado>(entity =>
            {
                entity.HasKey(e => e.IdEquivalenciaEstado)
                    .HasName("PK__BD_EQUIV__F01D840CE759F49E");

                entity.ToTable("BD_EQUIVALENCIA_ESTADO");

                entity.Property(e => e.IdEquivalenciaEstado).HasColumnName("ID_EQUIVALENCIA_ESTADO");

                entity.Property(e => e.DescEstado)
                    .HasColumnName("DESC_ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescEstadoEquivalencia)
                    .HasColumnName("DESC_ESTADO_EQUIVALENCIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdEspecificacionCausaRechazo>(entity =>
            {
                entity.HasKey(e => e.IdEspecificacionCausaRechazo);

                entity.ToTable("BD_ESPECIFICACION_CAUSA_RECHAZO");

                entity.Property(e => e.IdEspecificacionCausaRechazo).HasColumnName("ID_ESPECIFICACION_CAUSA_RECHAZO");

                entity.Property(e => e.DescEspecificacionCausaRechazo)
                    .HasColumnName("DESC_ESPECIFICACION_CAUSA_RECHAZO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCausaRechazoParent).HasColumnName("ID_CAUSA_RECHAZO_PARENT");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IsTirNeeded).HasColumnName("IS_TIR_NEEDED");

                entity.Property(e => e.NoValidacionNeeded).HasColumnName("NO_VALIDACION_NEEDED");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdEspecificacionTipoFalla>(entity =>
            {
                entity.HasKey(e => e.IdEspecifTipoFalla);

                entity.ToTable("BD_ESPECIFICACION_TIPO_FALLA");

                entity.Property(e => e.IdEspecifTipoFalla).HasColumnName("ID_ESPECIF_TIPO_FALLA");

                entity.Property(e => e.DescEspecificacionFalla)
                    .HasColumnName("DESC_ESPECIFICACION_FALLA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFallaParent).HasColumnName("ID_FALLA_PARENT");

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.IsTirNeeded).HasColumnName("IS_TIR_NEEDED");

                entity.Property(e => e.NoValidacionNeeded).HasColumnName("NO_VALIDACION_NEEDED");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdEtiquetaInformacionUnidadCliente>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaInformacionUnidadCliente);

                entity.ToTable("BD_ETIQUETA_INFORMACION_UNIDAD_CLIENTE");

                entity.Property(e => e.IdEtiquetaInformacionUnidadCliente).HasColumnName("ID_ETIQUETA_INFORMACION_UNIDAD_CLIENTE");

                entity.Property(e => e.DescEtiquetaInformacionUnidadCliente)
                    .HasColumnName("DESC_ETIQUETA_INFORMACION_UNIDAD_CLIENTE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEtiquetaInformacionUnidad).HasColumnName("ID_ETIQUETA_INFORMACION_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdExistenciasConsumiblesTecnicos>(entity =>
            {
                entity.HasKey(e => e.IdExistenciaConsumibleTecnico);

                entity.ToTable("BD_EXISTENCIAS_CONSUMIBLES_TECNICOS");

                entity.Property(e => e.IdExistenciaConsumibleTecnico).HasColumnName("ID_EXISTENCIA_CONSUMIBLE_TECNICO");

                entity.Property(e => e.ConsumiblesRecibidos).HasColumnName("CONSUMIBLES_RECIBIDOS");

                entity.Property(e => e.ConsumiblesReportados).HasColumnName("CONSUMIBLES_REPORTADOS");

                entity.Property(e => e.IdConsumible).HasColumnName("ID_CONSUMIBLE");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");
            });

            modelBuilder.Entity<BdExtravioPorMensajeriaCargaPdf>(entity =>
            {
                entity.HasKey(e => e.IdReparacionCargaPdf)
                    .HasName("PK__BD_EXTRA__CEE12DE554AC5FAC");

                entity.ToTable("BD_EXTRAVIO_POR_MENSAJERIA_CARGA_PDF");

                entity.Property(e => e.IdReparacionCargaPdf).HasColumnName("ID_REPARACION_CARGA_PDF");

                entity.Property(e => e.ArchivoSistema)
                    .HasColumnName("ARCHIVO_SISTEMA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivoUsuario)
                    .HasColumnName("ARCHIVO_USUARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdFallaConFallaEncontrada>(entity =>
            {
                entity.HasKey(e => e.IdFallaFallaEncontrada);

                entity.ToTable("BD_FALLA_CON_FALLA_ENCONTRADA");

                entity.Property(e => e.IdFallaFallaEncontrada).HasColumnName("ID_FALLA_FALLA_ENCONTRADA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFallaHijo).HasColumnName("ID_FALLA_HIJO");

                entity.Property(e => e.IdFallaPadre).HasColumnName("ID_FALLA_PADRE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdFallaEspecificaTipoFalla>(entity =>
            {
                entity.HasKey(e => e.IdFallaEspecificaTipoFalla);

                entity.ToTable("BD_FALLA_ESPECIFICA_TIPO_FALLA");

                entity.HasIndex(e => e.IdFalla)
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_4679_4678");

                entity.HasIndex(e => new { e.IdFalla, e.IdCliente })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_11848_11847");

                entity.HasIndex(e => new { e.IdFalla, e.IdEspecifTipoFalla })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_6167_6166");

                entity.HasIndex(e => new { e.IdEspecifTipoFalla, e.IdFalla, e.IdCliente })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_11852_11851");

                entity.HasIndex(e => new { e.IdFalla, e.IdCliente, e.IdTipoFalla })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_11850_11849");

                entity.Property(e => e.IdFallaEspecificaTipoFalla).HasColumnName("ID_FALLA_ESPECIFICA_TIPO_FALLA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEspecifTipoFalla).HasColumnName("ID_ESPECIF_TIPO_FALLA");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdTipoFalla).HasColumnName("ID_TIPO_FALLA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdFestivos>(entity =>
            {
                entity.HasKey(e => e.IdFestivos);

                entity.ToTable("BD_FESTIVOS");

                entity.HasIndex(e => e.IdFestivos)
                    .HasName("IX_BD_FESTIVOS")
                    .IsUnique();

                entity.Property(e => e.IdFestivos).HasColumnName("ID_FESTIVOS");

                entity.Property(e => e.Dia)
                    .HasColumnName("DIA")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<BdFotoAr>(entity =>
            {
                entity.HasKey(e => e.IdFotoAr);

                entity.ToTable("BD_FOTO_AR");

                entity.Property(e => e.IdFotoAr).HasColumnName("ID_FOTO_AR");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdAttach).HasColumnName("ID_ATTACH");

                entity.HasOne(d => d.IdAttachNavigation)
                    .WithMany(p => p.BdFotoAr)
                    .HasForeignKey(d => d.IdAttach)
                    .HasConstraintName("FK_BD_FOTO_AR_BD_ATTACH");
            });

            modelBuilder.Entity<BdGarantiaAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdGarantiaAlmacen);

                entity.ToTable("BD_GARANTIA_ALMACEN");

                entity.Property(e => e.IdGarantiaAlmacen).HasColumnName("ID_GARANTIA_ALMACEN");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Horas).HasColumnName("HORAS");

                entity.Property(e => e.HorasGarantia).HasColumnName("HORAS_GARANTIA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdWeekDays).HasColumnName("ID_WEEK_DAYS");

                entity.Property(e => e.Minutos).HasColumnName("MINUTOS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdGastosOperacion>(entity =>
            {
                entity.HasKey(e => e.IdGastosOp);

                entity.ToTable("BD_GASTOS_OPERACION");

                entity.Property(e => e.IdGastosOp).HasColumnName("ID_GASTOS_OP");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Importe)
                    .HasColumnName("IMPORTE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdGruposClientes>(entity =>
            {
                entity.HasKey(e => e.IdGrupoCliente);

                entity.ToTable("BD_GRUPOS_CLIENTES");

                entity.Property(e => e.IdGrupoCliente).HasColumnName("ID_GRUPO_CLIENTE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_GRUPO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdGruposClientes)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_BD_GRUPOS_CLIENTES_C_CLIENTES");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.BdGruposClientes)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_BD_GRUPOS_CLIENTES_C_GRUPOS");
            });

            modelBuilder.Entity<BdHistoricoPassword>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoPassword);

                entity.ToTable("BD_HISTORICO_PASSWORD");

                entity.Property(e => e.IdHistoricoPassword).HasColumnName("ID_HISTORICO_PASSWORD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("date");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdHorarioHorasMes>(entity =>
            {
                entity.HasKey(e => e.IdHorarioHorasMes);

                entity.ToTable("BD_HORARIO_HORAS_MES");

                entity.HasIndex(e => new { e.HorasMes, e.IdHorario, e.Mes, e.Anio })
                    .HasName("IX_MI_BD_HORARIO_HORAS_MES_6690_6689");

                entity.HasIndex(e => new { e.IdHorario, e.HorasMes, e.Mes, e.Anio })
                    .HasName("IX_MI_BD_HORARIO_HORAS_MES_6692_6691");

                entity.Property(e => e.IdHorarioHorasMes).HasColumnName("ID_HORARIO_HORAS_MES");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HorasMes).HasColumnName("HORAS_MES");

                entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.BdHorarioHorasMes)
                    .HasForeignKey(d => d.IdHorario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_HORARIO_HORAS_MES_C_HORARIOS");
            });

            modelBuilder.Entity<BdHorarioWeekhour>(entity =>
            {
                entity.HasKey(e => e.IdHorarioWeekhour)
                    .HasName("PK_BD_UPTIME_WEEKHOUR");

                entity.ToTable("BD_HORARIO_WEEKHOUR");

                entity.HasIndex(e => new { e.IdWeekhour, e.IdHorario })
                    .HasName("IX_BD_HORARIO_WEEKHOUR_ID_HORARIO");

                entity.Property(e => e.IdHorarioWeekhour).HasColumnName("ID_HORARIO_WEEKHOUR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdWeekhour).HasColumnName("ID_WEEKHOUR");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.BdHorarioWeekhour)
                    .HasForeignKey(d => d.IdHorario)
                    .HasConstraintName("FK_BD_HORARIO_WEEKHOUR_C_HORARIOS");

                entity.HasOne(d => d.IdWeekhourNavigation)
                    .WithMany(p => p.BdHorarioWeekhour)
                    .HasForeignKey(d => d.IdWeekhour)
                    .HasConstraintName("FK_BD_UPTIME_WEEKHOUR_C_WEEKHOURS");
            });

            modelBuilder.Entity<BdIgualas>(entity =>
            {
                entity.HasKey(e => e.IdIgualas);

                entity.ToTable("BD_IGUALAS");

                entity.HasIndex(e => new { e.Year, e.Month, e.NoAfiliacion })
                    .HasName("IX_BD_IGUALAS");

                entity.Property(e => e.IdIgualas).HasColumnName("ID_IGUALAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IsDolar).HasColumnName("IS_DOLAR");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioDolar)
                    .HasColumnName("PRECIO_DOLAR")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeCambio)
                    .HasColumnName("TIPO_DE_CAMBIO")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdIgualasAlta>(entity =>
            {
                entity.HasKey(e => e.IdIgualaAlta);

                entity.ToTable("BD_IGUALAS_ALTA");

                entity.Property(e => e.IdIgualaAlta).HasColumnName("ID_IGUALA_ALTA");

                entity.Property(e => e.HavePriceProblem).HasColumnName("HAVE_PRICE_PROBLEM");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAfiliacionNoValido).HasColumnName("IS_AFILIACION_NO_VALIDO");

                entity.Property(e => e.IsClienteNoConfigurado).HasColumnName("IS_CLIENTE_NO_CONFIGURADO");

                entity.Property(e => e.IsDolar).HasColumnName("IS_DOLAR");

                entity.Property(e => e.IsDuplicadoExcel).HasColumnName("IS_DUPLICADO_EXCEL");

                entity.Property(e => e.IsIgualaRepetida).HasColumnName("IS_IGUALA_REPETIDA");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioDolar)
                    .HasColumnName("PRECIO_DOLAR")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TipoDeCambio)
                    .HasColumnName("TIPO_DE_CAMBIO")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdInformacionUnidadAr>(entity =>
            {
                entity.HasKey(e => e.IdInformacionUnidadAr);

                entity.ToTable("BD_INFORMACION_UNIDAD_AR");

                entity.HasIndex(e => e.IdAr);

                entity.Property(e => e.IdInformacionUnidadAr).HasColumnName("ID_INFORMACION_UNIDAD_AR");

                entity.Property(e => e.Aplicacion)
                    .HasColumnName("APLICACION")
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadDiscoDuro)
                    .HasColumnName("CAPACIDAD_DISCO_DURO")
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.InstalacionLlaves)
                    .HasColumnName("INSTALACION_LLAVES")
                    .IsUnicode(false);

                entity.Property(e => e.LectorTarjeta)
                    .HasColumnName("LECTOR_TARJETA")
                    .IsUnicode(false);

                entity.Property(e => e.Memoria)
                    .HasColumnName("MEMORIA")
                    .IsUnicode(false);

                entity.Property(e => e.Monitor)
                    .HasColumnName("MONITOR")
                    .IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesA)
                    .HasColumnName("NOMBRE_PERSONA_LLAVES_A")
                    .IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesB)
                    .HasColumnName("NOMBRE_PERSONA_LLAVES_B")
                    .IsUnicode(false);

                entity.Property(e => e.Procesador)
                    .HasColumnName("PROCESADOR")
                    .IsUnicode(false);

                entity.Property(e => e.StatusInstalacionLlaves)
                    .HasColumnName("STATUS_INSTALACION_LLAVES")
                    .IsUnicode(false);

                entity.Property(e => e.TipoLlave)
                    .HasColumnName("TIPO_LLAVE")
                    .IsUnicode(false);

                entity.Property(e => e.TipoPw)
                    .HasColumnName("TIPO_PW")
                    .IsUnicode(false);

                entity.Property(e => e.TipoTeclado)
                    .HasColumnName("TIPO_TECLADO")
                    .IsUnicode(false);

                entity.Property(e => e.VelocidadProcesador)
                    .HasColumnName("VELOCIDAD_PROCESADOR")
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .IsUnicode(false);

                entity.Property(e => e.VersionTecladoEpp)
                    .HasColumnName("VERSION_TECLADO_EPP")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivoInsumos>(entity =>
            {
                entity.HasKey(e => e.IdIngresoArchivoInsumo)
                    .HasName("PK__BD_INGRE__A2E7631D1449BC23");

                entity.ToTable("BD_INGRESO_ARCHIVO_INSUMOS");

                entity.Property(e => e.IdIngresoArchivoInsumo).HasColumnName("ID_INGRESO_ARCHIVO_INSUMO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArchivo).HasColumnName("ID_ARCHIVO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusInsumo).HasColumnName("ID_STATUS_INSUMO");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusArchivo)
                    .HasColumnName("STATUS_ARCHIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdArchivoAlmacen);

                entity.ToTable("BD_INGRESO_ARCHIVOS_ALMACEN");

                entity.Property(e => e.IdArchivoAlmacen).HasColumnName("ID_ARCHIVO_ALMACEN");

                entity.Property(e => e.Categoria).HasColumnName("CATEGORIA");

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAltaArchivo)
                    .HasColumnName("FECHA_ALTA_ARCHIVO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("FECHA_COMPRA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVencimientoKernel)
                    .HasColumnName("FECHA_VENCIMIENTO_KERNEL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdArchivo).HasColumnName("ID_ARCHIVO");

                entity.Property(e => e.IdCarrier).HasColumnName("ID_CARRIER");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdFabricante).HasColumnName("ID_FABRICANTE");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoConexion).HasColumnName("ID_TIPO_CONEXION");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoTerminal).HasColumnName("ID_TIPO_TERMINAL");

                entity.Property(e => e.IdUsuarioAltaArchivo).HasColumnName("ID_USUARIO_ALTA_ARCHIVO");

                entity.Property(e => e.IsSim).HasColumnName("IS_SIM");

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasColumnName("SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusArchivo)
                    .HasColumnName("STATUS_ARCHIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionAplicativo)
                    .HasColumnName("VERSION_APLICATIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionKernel)
                    .HasColumnName("VERSION_KERNEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosAsignacion>(entity =>
            {
                entity.HasKey(e => e.IdArchivoMasivo);

                entity.ToTable("BD_INGRESO_ARCHIVOS_ASIGNACION");

                entity.HasIndex(e => new { e.IdArchivoMasivo, e.IdAr, e.IdArchivo, e.StatusArchivo })
                    .HasName("IX_MI_BD_INGRESO_ARCHIVOS_ASIGNACION_8589_8588");

                entity.Property(e => e.IdArchivoMasivo).HasColumnName("ID_ARCHIVO_MASIVO");

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAtencion)
                    .HasColumnName("FEC_ATENCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAltaArchivo)
                    .HasColumnName("FECHA_ALTA_ARCHIVO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraAtencion)
                    .HasColumnName("HORA_ATENCION")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdArchivo).HasColumnName("ID_ARCHIVO");

                entity.Property(e => e.IdDispatcher).HasColumnName("ID_DISPATCHER");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUsuarioAltaArchivo).HasColumnName("ID_USUARIO_ALTA_ARCHIVO");

                entity.Property(e => e.StatusArchivo)
                    .HasColumnName("STATUS_ARCHIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosExito>(entity =>
            {
                entity.HasKey(e => e.IdArchivoMasivo)
                    .HasName("PK_BD_INGRESO_ARCHIVOS");

                entity.ToTable("BD_INGRESO_ARCHIVOS_EXITO");

                entity.HasIndex(e => e.IdArchivo);

                entity.Property(e => e.IdArchivoMasivo).HasColumnName("ID_ARCHIVO_MASIVO");

                entity.Property(e => e.Aplicacion)
                    .HasColumnName("APLICACION")
                    .IsUnicode(false);

                entity.Property(e => e.Atiende)
                    .HasColumnName("ATIENDE")
                    .IsUnicode(false);

                entity.Property(e => e.CadenaCierreEscrita)
                    .HasColumnName("CADENA_CIERRE_ESCRITA")
                    .IsUnicode(false);

                entity.Property(e => e.Caja)
                    .HasColumnName("CAJA")
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadDiscoDuro)
                    .HasColumnName("CAPACIDAD_DISCO_DURO")
                    .IsUnicode(false);

                entity.Property(e => e.CodigoIntervencion)
                    .HasColumnName("CODIGO_INTERVENCION")
                    .IsUnicode(false);

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.DescErrorMov)
                    .HasColumnName("DESC_ERROR_MOV")
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo)
                    .HasColumnName("DESCRIPCION_TRABAJO")
                    .IsUnicode(false);

                entity.Property(e => e.DigitoVerificador)
                    .HasColumnName("DIGITO_VERIFICADOR")
                    .IsUnicode(false);

                entity.Property(e => e.FallaEncontrada)
                    .HasColumnName("FALLA_ENCONTRADA")
                    .IsUnicode(false);

                entity.Property(e => e.FecCierre)
                    .HasColumnName("FEC_CIERRE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecFinIngeniero)
                    .HasColumnName("FEC_FIN_INGENIERO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIniIngeniero)
                    .HasColumnName("FEC_INI_INGENIERO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecLlegada)
                    .HasColumnName("FEC_LLEGADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecLlegadaTerceros)
                    .HasColumnName("FEC_LLEGADA_TERCEROS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAltaArchivo)
                    .HasColumnName("FECHA_ALTA_ARCHIVO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FolioServicio)
                    .HasColumnName("FOLIO_SERVICIO")
                    .IsUnicode(false);

                entity.Property(e => e.FolioTas)
                    .HasColumnName("FOLIO_TAS")
                    .IsUnicode(false);

                entity.Property(e => e.FolioTir)
                    .HasColumnName("FOLIO_TIR")
                    .IsUnicode(false);

                entity.Property(e => e.FolioValidacion)
                    .HasColumnName("FOLIO_VALIDACION")
                    .IsUnicode(false);

                entity.Property(e => e.HoraCierre)
                    .HasColumnName("HORA_CIERRE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HoraFinIngeniero)
                    .HasColumnName("HORA_FIN_INGENIERO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HoraIniIngeniero)
                    .HasColumnName("HORA_INI_INGENIERO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HoraLlegada)
                    .HasColumnName("HORA_LLEGADA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HoraLlegadaTerceros)
                    .HasColumnName("HORA_LLEGADA_TERCEROS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdArchivo).HasColumnName("ID_ARCHIVO");

                entity.Property(e => e.IdCausa).HasColumnName("ID_CAUSA");

                entity.Property(e => e.IdEspecifTipoFalla).HasColumnName("ID_ESPECIF_TIPO_FALLA");

                entity.Property(e => e.IdModeloFalla).HasColumnName("ID_MODELO_FALLA");

                entity.Property(e => e.IdSolucion).HasColumnName("ID_SOLUCION");

                entity.Property(e => e.IdTipoFallaEncontrada).HasColumnName("ID_TIPO_FALLA_ENCONTRADA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAltaArchivo).HasColumnName("ID_USUARIO_ALTA_ARCHIVO");

                entity.Property(e => e.InstalacionLlaves)
                    .HasColumnName("INSTALACION_LLAVES")
                    .IsUnicode(false);

                entity.Property(e => e.IntensidadSenial)
                    .HasColumnName("INTENSIDAD_SENIAL")
                    .IsUnicode(false);

                entity.Property(e => e.IsBoletin).HasColumnName("IS_BOLETIN");

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsMov).HasColumnName("IS_MOV");

                entity.Property(e => e.IsSimRemplazada).HasColumnName("IS_SIM_REMPLAZADA");

                entity.Property(e => e.IsSoporteCliente).HasColumnName("IS_SOPORTE_CLIENTE");

                entity.Property(e => e.LectorTarjeta)
                    .HasColumnName("LECTOR_TARJETA")
                    .IsUnicode(false);

                entity.Property(e => e.Memoria)
                    .HasColumnName("MEMORIA")
                    .IsUnicode(false);

                entity.Property(e => e.MinutoCierre)
                    .HasColumnName("MINUTO_CIERRE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MinutoFinIngeniero)
                    .HasColumnName("MINUTO_FIN_INGENIERO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MinutoIniIngeniero)
                    .HasColumnName("MINUTO_INI_INGENIERO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MinutoLlegada)
                    .HasColumnName("MINUTO_LLEGADA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MinutoLlegadaTercero)
                    .HasColumnName("MINUTO_LLEGADA_TERCERO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Monitor)
                    .HasColumnName("MONITOR")
                    .IsUnicode(false);

                entity.Property(e => e.MotivoCobro)
                    .HasColumnName("MOTIVO_COBRO")
                    .IsUnicode(false);

                entity.Property(e => e.NoEquipo)
                    .HasColumnName("NO_EQUIPO")
                    .IsUnicode(false);

                entity.Property(e => e.NoEquipoMov)
                    .HasColumnName("NO_EQUIPO_MOV")
                    .IsUnicode(false);

                entity.Property(e => e.NoInventarioFalla)
                    .HasColumnName("NO_INVENTARIO_FALLA")
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieEntrada)
                    .HasColumnName("NO_SERIE_ENTRADA")
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieFalla)
                    .HasColumnName("NO_SERIE_FALLA")
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieSalida)
                    .HasColumnName("NO_SERIE_SALIDA")
                    .IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesA)
                    .HasColumnName("NOMBRE_PERSONA_LLAVES_A")
                    .IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesB)
                    .HasColumnName("NOMBRE_PERSONA_LLAVES_B")
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteSoporteCliente)
                    .HasColumnName("OTORGANTE_SOPORTE_CLIENTE")
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteTas)
                    .HasColumnName("OTORGANTE_TAS")
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVobo)
                    .HasColumnName("OTORGANTE_VOBO")
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVoboCliente)
                    .HasColumnName("OTORGANTE_VOBO_CLIENTE")
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVoboTerceros)
                    .HasColumnName("OTORGANTE_VOBO_TERCEROS")
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Procesador)
                    .HasColumnName("PROCESADOR")
                    .IsUnicode(false);

                entity.Property(e => e.StatusArchivo)
                    .HasColumnName("STATUS_ARCHIVO")
                    .IsUnicode(false);

                entity.Property(e => e.StatusInstalacionLlaves)
                    .HasColumnName("STATUS_INSTALACION_LLAVES")
                    .IsUnicode(false);

                entity.Property(e => e.StatusMov)
                    .HasColumnName("STATUS_MOV")
                    .IsUnicode(false);

                entity.Property(e => e.TipoLlave)
                    .HasColumnName("TIPO_LLAVE")
                    .IsUnicode(false);

                entity.Property(e => e.TipoPw)
                    .HasColumnName("TIPO_PW")
                    .IsUnicode(false);

                entity.Property(e => e.TipoTeclado)
                    .HasColumnName("TIPO_TECLADO")
                    .IsUnicode(false);

                entity.Property(e => e.VelocidadProcesador)
                    .HasColumnName("VELOCIDAD_PROCESADOR")
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .IsUnicode(false);

                entity.Property(e => e.VersionTecladoEpp)
                    .HasColumnName("VERSION_TECLADO_EPP")
                    .IsUnicode(false);

                entity.Property(e => e.VoltajeNeutro)
                    .HasColumnName("VOLTAJE_NEUTRO")
                    .IsUnicode(false);

                entity.Property(e => e.VoltajeTierra)
                    .HasColumnName("VOLTAJE_TIERRA")
                    .IsUnicode(false);

                entity.Property(e => e.VoltajeTierraNeutro)
                    .HasColumnName("VOLTAJE_TIERRA_NEUTRO")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosRechazo>(entity =>
            {
                entity.HasKey(e => e.IdArchivoMasivo);

                entity.ToTable("BD_INGRESO_ARCHIVOS_RECHAZO");

                entity.Property(e => e.IdArchivoMasivo).HasColumnName("ID_ARCHIVO_MASIVO");

                entity.Property(e => e.AutorizacionRechazo)
                    .HasColumnName("AUTORIZACION_RECHAZO")
                    .IsUnicode(false);

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.DescErrorMov)
                    .HasColumnName("DESC_ERROR_MOV")
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo)
                    .HasColumnName("DESCRIPCION_TRABAJO")
                    .IsUnicode(false);

                entity.Property(e => e.FecCierre)
                    .HasColumnName("FEC_CIERRE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAltaArchivo)
                    .HasColumnName("FECHA_ALTA_ARCHIVO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FolioServicio)
                    .HasColumnName("FOLIO_SERVICIO")
                    .IsUnicode(false);

                entity.Property(e => e.HoraCierre)
                    .HasColumnName("HORA_CIERRE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdArchivo).HasColumnName("ID_ARCHIVO");

                entity.Property(e => e.IdCausa).HasColumnName("ID_CAUSA");

                entity.Property(e => e.IdCausaRechazo).HasColumnName("ID_CAUSA_RECHAZO");

                entity.Property(e => e.IdEspecificaCausaRechazo).HasColumnName("ID_ESPECIFICA_CAUSA_RECHAZO");

                entity.Property(e => e.IdSolucion).HasColumnName("ID_SOLUCION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAltaArchivo).HasColumnName("ID_USUARIO_ALTA_ARCHIVO");

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsMov).HasColumnName("IS_MOV");

                entity.Property(e => e.MinutoCierre)
                    .HasColumnName("MINUTO_CIERRE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NoEquipoMov)
                    .HasColumnName("NO_EQUIPO_MOV")
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieEntrada)
                    .HasColumnName("NO_SERIE_ENTRADA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieSalida)
                    .HasColumnName("NO_SERIE_SALIDA")
                    .IsUnicode(false);

                entity.Property(e => e.OtorganteVobo)
                    .HasColumnName("OTORGANTE_VOBO")
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StatusArchivo)
                    .HasColumnName("STATUS_ARCHIVO")
                    .IsUnicode(false);

                entity.Property(e => e.StatusMov)
                    .HasColumnName("STATUS_MOV")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdInstalaciones>(entity =>
            {
                entity.HasKey(e => e.IdInstalacion);

                entity.ToTable("BD_INSTALACIONES");

                entity.Property(e => e.IdInstalacion).HasColumnName("ID_INSTALACION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdClienteIni).HasColumnName("ID_CLIENTE_INI");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.HasOne(d => d.IdClienteIniNavigation)
                    .WithMany(p => p.BdInstalaciones)
                    .HasForeignKey(d => d.IdClienteIni)
                    .HasConstraintName("FK_BD_INSTALACIONES_C_CLIENTES");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdInstalaciones)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_INSTALACIONES_BD_NEGOCIOS");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.BdInstalacionesIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK_BD_INSTALACIONES_BD_UNIDADES1");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.BdInstalaciones)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("FK_BD_INSTALACIONES_C_USUARIOS");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdInstalacionesIdUnidadNavigation)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_INSTALACIONES_BD_UNIDADES");
            });

            modelBuilder.Entity<BdInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBdInsumo)
                    .HasName("PK__BD_INSUM__F768FC8BF5E6F90A");

                entity.ToTable("BD_INSUMOS");

                entity.Property(e => e.IdBdInsumo).HasColumnName("ID_BD_INSUMO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdItemsSolicitudAlmacen).HasColumnName("ID_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusInsumo).HasColumnName("ID_STATUS_INSUMO");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoTarima)
                    .HasColumnName("NO_TARIMA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionInventario)
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdInsumosAlta>(entity =>
            {
                entity.HasKey(e => e.IdInsumosAlta)
                    .HasName("PK__BD_INSUM__FF7E81862DE23FD8");

                entity.ToTable("BD_INSUMOS_ALTA");

                entity.Property(e => e.IdInsumosAlta).HasColumnName("ID_INSUMOS_ALTA");

                entity.Property(e => e.Cantidades).HasColumnName("CANTIDADES");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsNullCliente).HasColumnName("IS_NULL_CLIENTE");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.NoTarima)
                    .HasColumnName("NO_TARIMA")
                    .HasMaxLength(50);

                entity.Property(e => e.PosicionInventario)
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdItemsSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdItemsSolicitudAlmacen);

                entity.ToTable("BD_ITEMS_SOLICITUD_ALMACEN");

                entity.HasIndex(e => e.IdSolicitudAlmacen);

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdCliente })
                    .HasName("IX_MI_BD_ITEMS_SOLICITUD_ALMACEN_254_253");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdStatusItemsSolicitudAlmacen })
                    .HasName("IX_BD_ITEMS_SOLICITUD_ALMACEN_ID_STATUS_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdItemsSolicitudAlmacen).HasColumnName("ID_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.CantidadItems).HasColumnName("CANTIDAD_ITEMS");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdKitInsumo).HasColumnName("ID_KIT_INSUMO");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdParentInsumo).HasColumnName("ID_PARENT_INSUMO");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdStatusItemsSolicitudAlmacen).HasColumnName("ID_STATUS_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoItemSolicitudAlmacen).HasColumnName("ID_TIPO_ITEM_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsEmbarque).HasColumnName("IS_EMBARQUE");

                entity.Property(e => e.IsSurtido)
                    .HasColumnName("IS_SURTIDO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notas)
                    .HasColumnName("NOTAS")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdKitInsumos>(entity =>
            {
                entity.HasKey(e => e.IdKitInsumo)
                    .HasName("PK__BD_KIT_I__E3DEE2B0FF55C6D9");

                entity.ToTable("BD_KIT_INSUMOS");

                entity.Property(e => e.IdKitInsumo).HasColumnName("ID_KIT_INSUMO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdInsumoParent).HasColumnName("ID_INSUMO_PARENT");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdLoadFilterDhl>(entity =>
            {
                entity.HasKey(e => e.IdLoadFilterDhl)
                    .HasName("PK__BD_LOAD___34823661904E8C4E");

                entity.ToTable("BD_LOAD_FILTER_DHL");

                entity.Property(e => e.IdLoadFilterDhl).HasColumnName("ID_LOAD_FILTER_DHL");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CostoSgs)
                    .HasColumnName("COSTO_SGS")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdCargaEnvioDhl).HasColumnName("ID_CARGA_ENVIO_DHL");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdServicioMensajeriaPrecio).HasColumnName("ID_SERVICIO_MENSAJERIA_PRECIO");

                entity.Property(e => e.NoGuia)
                    .HasColumnName("NO_GUIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdLoadFilterEstafeta>(entity =>
            {
                entity.HasKey(e => e.IdLoadFilterEstafeta)
                    .HasName("PK__BD_LOAD___BFBA0BB9A829BB6E");

                entity.ToTable("BD_LOAD_FILTER_ESTAFETA");

                entity.Property(e => e.IdLoadFilterEstafeta).HasColumnName("ID_LOAD_FILTER_ESTAFETA");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CostoSgs)
                    .HasColumnName("COSTO_SGS")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdCargaEnvioEstafeta).HasColumnName("ID_CARGA_ENVIO_ESTAFETA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdServicioMensajeriaPrecio).HasColumnName("ID_SERVICIO_MENSAJERIA_PRECIO");

                entity.Property(e => e.NoGuia)
                    .HasColumnName("NO_GUIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdLogErroresEmailSolicitudes>(entity =>
            {
                entity.HasKey(e => e.IdLogErrorEmail)
                    .HasName("PK_BD_LOG_ERROR_EMAIL_SOLICITUDES");

                entity.ToTable("BD_LOG_ERRORES_EMAIL_SOLICITUDES");

                entity.Property(e => e.IdLogErrorEmail).HasColumnName("ID_LOG_ERROR_EMAIL");

                entity.Property(e => e.DescripcionError)
                    .HasColumnName("DESCRIPCION_ERROR")
                    .HasMaxLength(1500);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Modulo)
                    .HasColumnName("MODULO")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BdLoginUsers>(entity =>
            {
                entity.ToTable("BD_LOGIN_USERS");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IpMachine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdLogroBlog>(entity =>
            {
                entity.HasKey(e => e.IdLogroBlog);

                entity.ToTable("BD_LOGRO_BLOG");

                entity.Property(e => e.IdLogroBlog).HasColumnName("ID_LOGRO_BLOG");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdLogro).HasColumnName("ID_LOGRO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdLogros>(entity =>
            {
                entity.HasKey(e => e.IdLogro);

                entity.ToTable("BD_LOGROS");

                entity.Property(e => e.IdLogro).HasColumnName("ID_LOGRO");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cuantificacion)
                    .HasColumnName("CUANTIFICACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescLogro)
                    .HasColumnName("DESC_LOGRO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAuditable)
                    .HasColumnName("FEC_AUDITABLE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRealCierre)
                    .HasColumnName("FEC_REAL_CIERRE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdGerente).HasColumnName("ID_GERENTE");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoLogro).HasColumnName("ID_TIPO_LOGRO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdLogrosResponsables>(entity =>
            {
                entity.HasKey(e => e.IdLogrosResponsables);

                entity.ToTable("BD_LOGROS_RESPONSABLES");

                entity.Property(e => e.IdLogrosResponsables).HasColumnName("ID_LOGROS_RESPONSABLES");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdLogro).HasColumnName("ID_LOGRO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");
            });

            modelBuilder.Entity<BdMcSims>(entity =>
            {
                entity.HasKey(e => e.IdSim);

                entity.ToTable("BD_MC_SIMS");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCarrier).HasColumnName("ID_CARRIER");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdItemsSolicitudAlmacen).HasColumnName("ID_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusSim).HasColumnName("ID_STATUS_SIM");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsDisponible).HasColumnName("IS_DISPONIBLE");

                entity.Property(e => e.IsNuevo).HasColumnName("IS_NUEVO");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.NoSim)
                    .IsRequired()
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdMcSims)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_MC_SIMS_BD_UNIDADES");
            });

            modelBuilder.Entity<BdMcViaGeozonaCoordenadas>(entity =>
            {
                entity.HasKey(e => e.IdGeozonaCoordenadas);

                entity.ToTable("BD_MC_VIA_GEOZONA_COORDENADAS");

                entity.Property(e => e.IdGeozonaCoordenadas).HasColumnName("ID_GEOZONA_COORDENADAS");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.Latitud)
                    .HasColumnName("LATITUD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("LONGITUD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<BdMcViaGeozonaCoordenadasZona>(entity =>
            {
                entity.HasKey(e => e.IdGeozonaCoordenadasPlaza)
                    .HasName("PK_BD_MC_VIA_GEOZONA_COORDENADAS_PLAZA");

                entity.ToTable("BD_MC_VIA_GEOZONA_COORDENADAS_ZONA");

                entity.Property(e => e.IdGeozonaCoordenadasPlaza).HasColumnName("ID_GEOZONA_COORDENADAS_PLAZA");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.Latitud)
                    .HasColumnName("LATITUD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("LONGITUD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<BdMcViaGeozonaTecnico>(entity =>
            {
                entity.HasKey(e => e.IdGeozona);

                entity.ToTable("BD_MC_VIA_GEOZONA_TECNICO");

                entity.Property(e => e.IdGeozona).HasColumnName("ID_GEOZONA");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");
            });

            modelBuilder.Entity<BdMenu>(entity =>
            {
                entity.ToTable("BD_MENU");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("missing_index_4077_4076");

                entity.HasIndex(e => new { e.IdMenu0, e.IdUsuario })
                    .HasName("IX_BD_MENU_ID_MENU0, ID_USUARIO");

                entity.HasIndex(e => new { e.IdMenu1, e.IdUsuario })
                    .HasName("IX_BD_MENU_ID_MENU1, ID_USUARIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdMenu0).HasColumnName("ID_MENU0");

                entity.Property(e => e.IdMenu1).HasColumnName("ID_MENU1");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdMenuTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdMenuTipoUsuario);

                entity.ToTable("BD_MENU_TIPO_USUARIO");

                entity.Property(e => e.IdMenuTipoUsuario).HasColumnName("ID_MENU_TIPO_USUARIO");

                entity.Property(e => e.IdPestanasBitacoraAr).HasColumnName("ID_PESTANAS_BITACORA_AR");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");
            });

            modelBuilder.Entity<BdModeloAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdModeloAccesorio);

                entity.ToTable("BD_MODELO_ACCESORIO");

                entity.Property(e => e.IdModeloAccesorio).HasColumnName("ID_MODELO_ACCESORIO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAccesorio).HasColumnName("ID_ACCESORIO");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdAccesorioNavigation)
                    .WithMany(p => p.BdModeloAccesorio)
                    .HasForeignKey(d => d.IdAccesorio)
                    .HasConstraintName("FK_BD_MODELO_ACCESORIO_C_ACCESORIOS");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloAccesorio)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_ACCESORIO_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloCategoria>(entity =>
            {
                entity.HasKey(e => e.IdModeloCategoria)
                    .HasName("PK__BD_MODEL__E265EAC3F621A77B");

                entity.ToTable("BD_MODELO_CATEGORIA");

                entity.Property(e => e.IdModeloCategoria).HasColumnName("ID_MODELO_CATEGORIA");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");
            });

            modelBuilder.Entity<BdModeloCelular>(entity =>
            {
                entity.HasKey(e => e.IdModeloCelular);

                entity.ToTable("BD_MODELO_CELULAR");

                entity.Property(e => e.IdModeloCelular).HasColumnName("ID_MODELO_CELULAR");

                entity.Property(e => e.DescModeloCelular)
                    .HasColumnName("DESC_MODELO_CELULAR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdModeloConectividad>(entity =>
            {
                entity.HasKey(e => e.IdModeloConectividad)
                    .HasName("PK__BD_MODEL__5B7BD33529C43DAE");

                entity.ToTable("BD_MODELO_CONECTIVIDAD");

                entity.Property(e => e.IdModeloConectividad).HasColumnName("ID_MODELO_CONECTIVIDAD");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdModeloInsumo>(entity =>
            {
                entity.HasKey(e => e.IdModeloInsumo);

                entity.ToTable("BD_MODELO_INSUMO");

                entity.Property(e => e.IdModeloInsumo).HasColumnName("ID_MODELO_INSUMO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.BdModeloInsumo)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_BD_MODELO_INSUMO_C_INSUMOS");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloInsumo)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_INSUMO_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloLlave>(entity =>
            {
                entity.HasKey(e => e.IdModeloLlave);

                entity.ToTable("BD_MODELO_LLAVE");

                entity.Property(e => e.IdModeloLlave).HasColumnName("ID_MODELO_LLAVE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdLlaveNavigation)
                    .WithMany(p => p.BdModeloLlave)
                    .HasForeignKey(d => d.IdLlave)
                    .HasConstraintName("FK_BD_MODELO_LLAVE_C_LLAVES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloLlave)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_LLAVE_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloModulo>(entity =>
            {
                entity.ToTable("BD_MODELO_MODULO");

                entity.HasIndex(e => e.IdModeloModulo)
                    .HasName("IX_MI_BD_MODELO_MODULO_353_352");

                entity.HasIndex(e => new { e.IdModeloModulo, e.IdModelo })
                    .HasName("IX_MI_BD_MODELO_MODULO_269_268");

                entity.HasIndex(e => new { e.IdProductoModulo, e.IdModelo })
                    .HasName("IX_MI_BD_MODELO_MODULO_273_272");

                entity.HasIndex(e => new { e.IdProductoModulo, e.IdMarcaModulo, e.IdModeloModulo, e.IdModelo })
                    .HasName("IX_MI_BD_MODELO_MODULO_169_168");

                entity.HasIndex(e => new { e.Id, e.IdMarcaModulo, e.IdModeloModulo, e.IdUsuarioAlta, e.IdModelo, e.IdProductoModulo })
                    .HasName("IX_MI_BD_MODELO_MODULO_275_274");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdMarcaModulo).HasColumnName("ID_MARCA_MODULO");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdModeloModulo).HasColumnName("ID_MODELO_MODULO");

                entity.Property(e => e.IdProductoModulo).HasColumnName("ID_PRODUCTO_MODULO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdMarcaModuloNavigation)
                    .WithMany(p => p.BdModeloModulo)
                    .HasForeignKey(d => d.IdMarcaModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_MARCAS");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloModuloIdModeloNavigation)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_MODELOS");

                entity.HasOne(d => d.IdModeloModuloNavigation)
                    .WithMany(p => p.BdModeloModuloIdModeloModuloNavigation)
                    .HasForeignKey(d => d.IdModeloModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_MODELOS1");

                entity.HasOne(d => d.IdProductoModuloNavigation)
                    .WithMany(p => p.BdModeloModulo)
                    .HasForeignKey(d => d.IdProductoModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_PRODUCTOS");
            });

            modelBuilder.Entity<BdModeloPrecio>(entity =>
            {
                entity.HasKey(e => e.IdModeloPrecio);

                entity.ToTable("BD_MODELO_PRECIO");

                entity.Property(e => e.IdModeloPrecio).HasColumnName("ID_MODELO_PRECIO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdModeloPrecio)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_PRECIO_C_CLIENTES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloPrecio)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_PRECIO_C_MODELOS");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.BdModeloPrecio)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_BD_MODELO_PRECIO_C_MONEDAS");
            });

            modelBuilder.Entity<BdModeloServicio>(entity =>
            {
                entity.HasKey(e => e.IdModeloServicio)
                    .HasName("PK__BD_MODEL__AFB1861684E18BC2");

                entity.ToTable("BD_MODELO_SERVICIO");

                entity.Property(e => e.IdModeloServicio).HasColumnName("ID_MODELO_SERVICIO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IsChecked)
                    .HasColumnName("IS_CHECKED")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsInstalacion).HasColumnName("IS_INSTALACION");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.IsSustitucion).HasColumnName("IS_SUSTITUCION");
            });

            modelBuilder.Entity<BdModeloSku>(entity =>
            {
                entity.HasKey(e => e.IdModeloSku);

                entity.ToTable("BD_MODELO_SKU");

                entity.Property(e => e.IdModeloSku).HasColumnName("ID_MODELO_SKU");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdModeloSku)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_SKU_C_CLIENTES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloSku)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_SKU_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloSoftware>(entity =>
            {
                entity.HasKey(e => e.IdModeloSoftware);

                entity.ToTable("BD_MODELO_SOFTWARE");

                entity.Property(e => e.IdModeloSoftware).HasColumnName("ID_MODELO_SOFTWARE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdModeloSparePart>(entity =>
            {
                entity.ToTable("BD_MODELO_SPARE_PART");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdMarcaSparePart).HasColumnName("ID_MARCA_SPARE_PART");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdProductoSparePart).HasColumnName("ID_PRODUCTO_SPARE_PART");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdModeloSustituto>(entity =>
            {
                entity.ToTable("BD_MODELO_SUSTITUTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdModeloSustituto).HasColumnName("ID_MODELO_SUSTITUTO");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloSustitutoIdModeloNavigation)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_SUSTITUTO_C_MODELOS");

                entity.HasOne(d => d.IdModeloSustitutoNavigation)
                    .WithMany(p => p.BdModeloSustitutoIdModeloSustitutoNavigation)
                    .HasForeignKey(d => d.IdModeloSustituto)
                    .HasConstraintName("FK_BD_MODELO_SUSTITUTO_C_MODELOS1");

                entity.HasOne(d => d.IdSoftwareNavigation)
                    .WithMany(p => p.BdModeloSustituto)
                    .HasForeignKey(d => d.IdSoftware)
                    .HasConstraintName("FK_BD_MODELO_SUSTITUTO_C_SOFTWARE");
            });

            modelBuilder.Entity<BdNegocioHorasMes>(entity =>
            {
                entity.HasKey(e => e.IdNegocioHorasMes)
                    .HasName("PK_BD_UNIDAD_HORAS_MES");

                entity.ToTable("BD_NEGOCIO_HORAS_MES");

                entity.HasIndex(e => new { e.IdNegocio, e.Mes, e.Anio })
                    .HasName("IX_BD_NEGOCIO_HORAS_MES_ID_NEGOCIO, MES, ANIO");

                entity.HasIndex(e => new { e.IdNegocioHorasMes, e.IdNegocio, e.Mes, e.Anio })
                    .HasName("IX_BD_NEGOCIO_HORAS_MES_MES, ANIO");

                entity.Property(e => e.IdNegocioHorasMes).HasColumnName("ID_NEGOCIO_HORAS_MES");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HorasMes).HasColumnName("HORAS_MES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IsContract)
                    .HasColumnName("IS_CONTRACT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdNegocioHorasMes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_HORAS_MES_C_CLIENTES1");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdNegocioHorasMes)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_HORAS_MES_BD_NEGOCIOS");
            });

            modelBuilder.Entity<BdNegocios>(entity =>
            {
                entity.HasKey(e => e.IdNegocio);

                entity.ToTable("BD_NEGOCIOS");

                entity.HasIndex(e => e.Cp)
                    .HasName("missing_index_3671_3670");

                entity.HasIndex(e => e.DescNegocio)
                    .HasName("missing_index_2853_2852");

                entity.HasIndex(e => e.IdCargaAlta);

                entity.HasIndex(e => e.IdEstado);

                entity.HasIndex(e => e.IdRegion);

                entity.HasIndex(e => e.IdSegmento);

                entity.HasIndex(e => e.IdZona);

                entity.HasIndex(e => e.NoAfiliacion);

                entity.HasIndex(e => new { e.IdCliente, e.NoAfiliacion })
                    .HasName("IX_BD_NEGOCIOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.NoAfiliacion, e.IdCliente, e.Status })
                    .HasName("missing_index_2739_2738");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Status, e.IdCliente })
                    .HasName("missing_index_2737_2736");

                entity.HasIndex(e => new { e.IdNegocio, e.DescNegocio, e.IdCliente, e.Status })
                    .HasName("missing_index_2851_2850");

                entity.HasIndex(e => new { e.IdZona, e.IdEstado, e.IdNegocio, e.IdRegion, e.IdCliente, e.Status })
                    .HasName("missing_index_3872_3871");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.Cp, e.DescNegocio, e.IdCliente, e.Status })
                    .HasName("missing_index_1226_1225");

                entity.HasIndex(e => new { e.Cp, e.Latitud, e.Longitud, e.IdNegocio, e.IdRegion, e.IdZona, e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.IdEstado, e.IdCliente, e.Status })
                    .HasName("missing_index_1231_1230");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.Aproximado).HasColumnName("APROXIMADO");

                entity.Property(e => e.CalleNumFiscal)
                    .HasColumnName("CALLE_NUM_FISCAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaFiscal)
                    .HasColumnName("COLONIA_FISCAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEjecutivo)
                    .HasColumnName("CORREO_EJECUTIVO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CpFiscal)
                    .HasColumnName("CP_FISCAL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAltaIguala)
                    .HasColumnName("FEC_ALTA_IGUALA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecBajaIguala)
                    .HasColumnName("FEC_BAJA_IGUALA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecUpdate)
                    .HasColumnName("FEC_UPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.GradoError)
                    .HasColumnName("GRADO_ERROR")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.IdCargaAlta).HasColumnName("ID_CARGA_ALTA");

                entity.Property(e => e.IdCargaStatus).HasColumnName("ID_CARGA_STATUS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdEstadoFiscal)
                    .HasColumnName("ID_ESTADO_FISCAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdTipoCobroNegocio).HasColumnName("ID_TIPO_COBRO_NEGOCIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioUpdate).HasColumnName("ID_USUARIO_UPDATE");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.Latitud)
                    .HasColumnName("LATITUD")
                    .HasColumnType("numeric(20, 15)");

                entity.Property(e => e.Longitud)
                    .HasColumnName("LONGITUD")
                    .HasColumnType("numeric(20, 15)");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFiscal)
                    .HasColumnName("NOMBRE_FISCAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PoblacionFiscal)
                    .HasColumnName("POBLACION_FISCAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RfcFiscal)
                    .HasColumnName("RFC_FISCAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargaAltaNavigation)
                    .WithMany(p => p.BdNegociosIdCargaAltaNavigation)
                    .HasForeignKey(d => d.IdCargaAlta)
                    .HasConstraintName("FK_BD_NEGOCIOS_BD_CARGAS");

                entity.HasOne(d => d.IdCargaStatusNavigation)
                    .WithMany(p => p.BdNegociosIdCargaStatusNavigation)
                    .HasForeignKey(d => d.IdCargaStatus)
                    .HasConstraintName("FK_BD_NEGOCIOS_BD_CARGAS1");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.BdNegocios)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_BD_NEGOCIOS_SEPOMEX_ESTADOS");

                entity.HasOne(d => d.IdHorarioAccesoNavigation)
                    .WithMany(p => p.BdNegociosIdHorarioAccesoNavigation)
                    .HasForeignKey(d => d.IdHorarioAcceso)
                    .HasConstraintName("FK_BD_NEGOCIOS_C_HORARIOS1");

                entity.HasOne(d => d.IdHorarioUptimeNavigation)
                    .WithMany(p => p.BdNegociosIdHorarioUptimeNavigation)
                    .HasForeignKey(d => d.IdHorarioUptime)
                    .HasConstraintName("FK_BD_NEGOCIOS_C_HORARIOS");
            });

            modelBuilder.Entity<BdNegociosAlta>(entity =>
            {
                entity.HasKey(e => e.IdNegocioAlta);

                entity.ToTable("BD_NEGOCIOS_ALTA");

                entity.Property(e => e.IdNegocioAlta).HasColumnName("ID_NEGOCIO_ALTA");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsCpIncorrecto).HasColumnName("IS_CP_INCORRECTO");

                entity.Property(e => e.IsIdEstadoIncorrecto).HasColumnName("IS_ID_ESTADO_INCORRECTO");

                entity.Property(e => e.IsNoAfiliacionDuplicado).HasColumnName("IS_NO_AFILIACION_DUPLICADO");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.IsRegionIncorrecto).HasColumnName("IS_REGION_INCORRECTO");

                entity.Property(e => e.IsZonaIncorrecto).HasColumnName("IS_ZONA_INCORRECTO");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdNegociosAlta)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_BD_NEGOCIOS_ALTA_C_CLIENTES");
            });

            modelBuilder.Entity<BdNegociosServiciosDobles>(entity =>
            {
                entity.HasKey(e => e.IdNegocioServicioDoble)
                    .HasName("PK__BD_NEGOC__DD8FA290BCCE31A1");

                entity.ToTable("BD_NEGOCIOS_SERVICIOS_DOBLES");

                entity.Property(e => e.IdNegocioServicioDoble).HasColumnName("ID_NEGOCIO_SERVICIO_DOBLE");

                entity.Property(e => e.DescripcionServicioDoble)
                    .HasColumnName("DESCRIPCION_SERVICIO_DOBLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdServicioDoble).HasColumnName("ID_SERVICIO_DOBLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsExito).HasColumnName("IS_EXITO");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .IsUnicode(false);

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdOnbaseInbox>(entity =>
            {
                entity.HasKey(e => e.IdOnbaseInbox)
                    .HasName("PK__BD_ONBAS__610C6D1059B23E38");

                entity.ToTable("BD_ONBASE_INBOX");

                entity.Property(e => e.IdOnbaseInbox).HasColumnName("ID_ONBASE_INBOX");

                entity.Property(e => e.Afilamex)
                    .HasColumnName("AFILAMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Afiliacion)
                    .HasColumnName("AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Arodt)
                    .HasColumnName("ARODT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Carga)
                    .HasColumnName("CARGA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Codigoproducto)
                    .HasColumnName("CODIGOPRODUCTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Comercio)
                    .HasColumnName("COMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Conectividad)
                    .HasColumnName("CONECTIVIDAD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto1)
                    .HasColumnName("CONTACTO1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto2)
                    .HasColumnName("CONTACTO2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Contactocomercio)
                    .HasColumnName("CONTACTOCOMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.Diasatencion)
                    .HasColumnName("DIASATENCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasColumnName("DOMICILIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivoka)
                    .HasColumnName("EJECUTIVOKA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivosucursal)
                    .HasColumnName("EJECUTIVOSUCURSAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailejecutivo)
                    .HasColumnName("EMAILEJECUTIVO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailejecutivoka)
                    .HasColumnName("EMAILEJECUTIVOKA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailrespuesta)
                    .HasColumnName("EMAILRESPUESTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailserv)
                    .HasColumnName("EMAILSERV")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fechaenvio)
                    .HasColumnName("FECHAENVIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Foliotelecarga)
                    .HasColumnName("FOLIOTELECARGA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Horarioatencion)
                    .HasColumnName("HORARIOATENCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idamex)
                    .HasColumnName("IDAMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcaja)
                    .HasColumnName("IDCAJA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mcc)
                    .HasColumnName("MCC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modelotpv)
                    .HasColumnName("MODELOTPV")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numrollos)
                    .HasColumnName("NUMROLLOS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Preodt)
                    .HasColumnName("PREODT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .HasColumnName("PROYECTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Razonsocial)
                    .HasColumnName("RAZONSOCIAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referenciaubicacion)
                    .HasColumnName("REFERENCIAUBICACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtiposervicio)
                    .HasColumnName("SUBTIPOSERVICIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telejecutivo)
                    .HasColumnName("TELEJECUTIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telsucursal)
                    .HasColumnName("TELSUCURSAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiposervicio)
                    .HasColumnName("TIPOSERVICIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdOnbaseInboxConfirmacion>(entity =>
            {
                entity.HasKey(e => e.IdOnbaseInboxConfirmacion)
                    .HasName("PK__BD_ONBAS__58AB64DCF8551C15");

                entity.ToTable("BD_ONBASE_INBOX_CONFIRMACION");

                entity.Property(e => e.IdOnbaseInboxConfirmacion).HasColumnName("ID_ONBASE_INBOX_CONFIRMACION");

                entity.Property(e => e.Afiliacion)
                    .HasColumnName("AFILIACION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Conectividad)
                    .HasColumnName("CONECTIVIDAD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto1)
                    .HasColumnName("CONTACTO1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto2)
                    .HasColumnName("CONTACTO2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contactocomercio)
                    .HasColumnName("CONTACTOCOMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.Diasatencion)
                    .HasColumnName("DIASATENCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivoka)
                    .HasColumnName("EJECUTIVOKA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivosucursal)
                    .HasColumnName("EJECUTIVOSUCURSAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emailejecutivoka)
                    .HasColumnName("EMAILEJECUTIVOKA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emailserv)
                    .HasColumnName("EMAILSERV")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Foliotelecarga)
                    .HasColumnName("FOLIOTELECARGA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Horarioatencion)
                    .HasColumnName("HORARIOATENCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idcaja)
                    .HasColumnName("IDCAJA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mcc)
                    .HasColumnName("MCC")
                    .HasColumnType("text");

                entity.Property(e => e.Modelotpv)
                    .HasColumnName("MODELOTPV")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Preodt)
                    .HasColumnName("PREODT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .HasColumnName("PROYECTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referenciaubicacion)
                    .HasColumnName("REFERENCIAUBICACION")
                    .IsUnicode(false);

                entity.Property(e => e.Sintoma)
                    .HasColumnName("SINTOMA")
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telejecutivo)
                    .HasColumnName("TELEJECUTIVO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telsucursal)
                    .HasColumnName("TELSUCURSAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompra)
                    .HasName("PK__BD_ORDEN__6C6555B88AAE0349");

                entity.ToTable("BD_ORDEN_COMPRA");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecOrdenCompra)
                    .HasColumnName("FEC_ORDEN_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdStatusOrdenCompra).HasColumnName("ID_STATUS_ORDEN_COMPRA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdOrdenCompraInsumos>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraInsumo)
                    .HasName("PK__BD_ORDEN__83776C9344C8B686");

                entity.ToTable("BD_ORDEN_COMPRA_INSUMOS");

                entity.Property(e => e.IdOrdenCompraInsumo).HasColumnName("ID_ORDEN_COMPRA_INSUMO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Costo).HasColumnName("COSTO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IsRecibido).HasColumnName("IS_RECIBIDO");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasComputedColumnSql("([CANTIDAD]*[COSTO])");
            });

            modelBuilder.Entity<BdOrdenCompraNoFactura>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraNoFactura)
                    .HasName("PK__BD_ORDEN__050DFE803E90B59E");

                entity.ToTable("BD_ORDEN_COMPRA_NO_FACTURA");

                entity.Property(e => e.IdOrdenCompraNoFactura).HasColumnName("ID_ORDEN_COMPRA_NO_FACTURA");

                entity.Property(e => e.FecFactura)
                    .HasColumnName("FEC_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoFactura)
                    .HasColumnName("NO_FACTURA")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdOrdenCompraUnidades>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraUnidad)
                    .HasName("PK__BD_ORDEN__CA8BA0FD21EDC624");

                entity.ToTable("BD_ORDEN_COMPRA_UNIDADES");

                entity.Property(e => e.IdOrdenCompraUnidad).HasColumnName("ID_ORDEN_COMPRA_UNIDAD");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Costo).HasColumnName("COSTO");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IsRecibido).HasColumnName("IS_RECIBIDO");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasComputedColumnSql("([CANTIDAD]*[COSTO])");

                entity.HasOne(d => d.IdOrdenCompraNavigation)
                    .WithMany(p => p.BdOrdenCompraUnidades)
                    .HasForeignKey(d => d.IdOrdenCompra)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORDENCOMPRAUNIDADES_ORDEN_COMPRA");
            });

            modelBuilder.Entity<BdOrdenCompraVendedor>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraVendedor)
                    .HasName("PK__BD_ORDEN__BFD995CEE26E874D");

                entity.ToTable("BD_ORDEN_COMPRA_VENDEDOR");

                entity.Property(e => e.IdOrdenCompraVendedor).HasColumnName("ID_ORDEN_COMPRA_VENDEDOR");

                entity.Property(e => e.ArcherVendorId).HasColumnName("ARCHER_VENDOR_ID");

                entity.Property(e => e.CentroCosto)
                    .HasColumnName("CENTRO_COSTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdTipoItemOrdenCompra).HasColumnName("ID_TIPO_ITEM_ORDEN_COMPRA");

                entity.Property(e => e.IdVendedor).HasColumnName("ID_VENDEDOR");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoOrdenCompra)
                    .HasColumnName("NO_ORDEN_COMPRA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TerminoPago)
                    .HasColumnName("TERMINO_PAGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPaseListaTecnico>(entity =>
            {
                entity.HasKey(e => e.IdPaseListaTecnico);

                entity.ToTable("BD_PASE_LISTA_TECNICO");

                entity.Property(e => e.IdPaseListaTecnico).HasColumnName("ID_PASE_LISTA_TECNICO");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("FECHA_HORA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPasoArNumber>(entity =>
            {
                entity.HasKey(e => e.IdPaso)
                    .HasName("PK__BD_PASO___B68ACC884D109FDE");

                entity.ToTable("BD_PASO_AR_NUMBER");

                entity.Property(e => e.IdPaso).HasColumnName("ID_PASO");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");

                entity.Property(e => e.Number).HasColumnName("NUMBER");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPasoCambioStatusUnidadMasivo>(entity =>
            {
                entity.HasKey(e => e.IdPasoCambioStatusUnidadMasivo)
                    .HasName("PK__BD_PASO___EE8C715F2D788351");

                entity.ToTable("BD_PASO_CAMBIO_STATUS_UNIDAD_MASIVO");

                entity.Property(e => e.IdPasoCambioStatusUnidadMasivo).HasColumnName("ID_PASO_CAMBIO_STATUS_UNIDAD_MASIVO");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.FecCarga)
                    .HasColumnName("FEC_CARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioCarga).HasColumnName("ID_USUARIO_CARGA");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .IsUnicode(false);

                entity.Property(e => e.Validacion)
                    .HasColumnName("VALIDACION")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPeriodoUsuarioInactivo>(entity =>
            {
                entity.HasKey(e => e.IdPeriodoUsuarioInactivo);

                entity.ToTable("BD_PERIODO_USUARIO_INACTIVO");

                entity.Property(e => e.IdPeriodoUsuarioInactivo).HasColumnName("ID_PERIODO_USUARIO_INACTIVO");

                entity.Property(e => e.FecCambio)
                    .HasColumnName("FEC_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecFin)
                    .HasColumnName("FEC_FIN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("FEC_INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioCambio).HasColumnName("ID_USUARIO_CAMBIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusUsuario)
                    .HasColumnName("STATUS_USUARIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPestanasBitacoraAr>(entity =>
            {
                entity.HasKey(e => e.IdPestanasBitacoraAr);

                entity.ToTable("BD_PESTANAS_BITACORA_AR");

                entity.Property(e => e.IdPestanasBitacoraAr).HasColumnName("ID_PESTANAS_BITACORA_AR");

                entity.Property(e => e.NombrePestana)
                    .HasColumnName("NOMBRE_PESTANA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPlazaCp>(entity =>
            {
                entity.HasKey(e => e.IdPlazaCp);

                entity.ToTable("BD_PLAZA_CP");

                entity.HasIndex(e => e.Cp);

                entity.Property(e => e.IdPlazaCp).HasColumnName("ID_PLAZA_CP");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdPlaza).HasColumnName("ID_PLAZA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.BdPlazaCp)
                    .HasForeignKey(d => d.IdPlaza)
                    .HasConstraintName("FK_BD_PLAZA_CP_C_PLAZAS");
            });

            modelBuilder.Entity<BdPreciosLicenciaAndroid>(entity =>
            {
                entity.HasKey(e => e.IdPrecioLicencia)
                    .HasName("PK__BD_PRECI__AD3F36D1CCA1633C");

                entity.ToTable("BD_PRECIOS_LICENCIA_ANDROID");

                entity.Property(e => e.IdPrecioLicencia).HasColumnName("ID_PRECIO_LICENCIA");

                entity.Property(e => e.CostoMensual)
                    .HasColumnName("COSTO_MENSUAL")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RangoLicencia)
                    .HasColumnName("RANGO_LICENCIA")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPreciosLicenciaWeb>(entity =>
            {
                entity.HasKey(e => e.IdPrecioLicencia)
                    .HasName("PK__BD_PRECI__AD3F36D1E8047AD2");

                entity.ToTable("BD_PRECIOS_LICENCIA_WEB");

                entity.Property(e => e.IdPrecioLicencia).HasColumnName("ID_PRECIO_LICENCIA");

                entity.Property(e => e.CostoMensual)
                    .HasColumnName("COSTO_MENSUAL")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RangoLicencia)
                    .HasColumnName("RANGO_LICENCIA")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdPresupuestos>(entity =>
            {
                entity.HasKey(e => e.IdPresupuesto);

                entity.ToTable("BD_PRESUPUESTOS");

                entity.HasIndex(e => new { e.IdRegion, e.IdCliente, e.IdConcepto, e.Year })
                    .HasName("IX_BD_PRESUPUESTOS")
                    .IsUnique();

                entity.Property(e => e.IdPresupuesto).HasColumnName("ID_PRESUPUESTO");

                entity.Property(e => e.Abril)
                    .HasColumnName("ABRIL")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Agosto)
                    .HasColumnName("AGOSTO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Diciembre)
                    .HasColumnName("DICIEMBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Enero)
                    .HasColumnName("ENERO")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Febrero)
                    .HasColumnName("FEBRERO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConcepto).HasColumnName("ID_CONCEPTO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Julio)
                    .HasColumnName("JULIO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Junio)
                    .HasColumnName("JUNIO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Marzo)
                    .HasColumnName("MARZO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Mayo)
                    .HasColumnName("MAYO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Noviembre)
                    .HasColumnName("NOVIEMBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Octubre)
                    .HasColumnName("OCTUBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Septiembre)
                    .HasColumnName("SEPTIEMBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdPresupuestosEjercido>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoEjercido);

                entity.ToTable("BD_PRESUPUESTOS_EJERCIDO");

                entity.HasIndex(e => new { e.Year, e.Mes, e.IdCliente })
                    .HasName("IX_BD_PRESUPUESTOS_EJERCIDO_1");

                entity.HasIndex(e => new { e.IdConcepto, e.IdCliente, e.IdRegion, e.Mes, e.Semana, e.Importe })
                    .HasName("IX_BD_PRESUPUESTOS_EJERCIDO")
                    .IsUnique();

                entity.Property(e => e.IdPresupuestoEjercido).HasColumnName("ID_PRESUPUESTO_EJERCIDO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConcepto).HasColumnName("ID_CONCEPTO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Importe)
                    .HasColumnName("IMPORTE")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasMaxLength(15);

                entity.Property(e => e.Semana).HasColumnName("SEMANA");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdPresupuestosRegional>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoRegional);

                entity.ToTable("BD_PRESUPUESTOS_REGIONAL");

                entity.HasIndex(e => new { e.IdRegion, e.IdConcepto, e.Year })
                    .HasName("IX_BD_PRESUPUESTOS_REGIONAL")
                    .IsUnique();

                entity.Property(e => e.IdPresupuestoRegional).HasColumnName("ID_PRESUPUESTO_REGIONAL");

                entity.Property(e => e.Abril)
                    .HasColumnName("ABRIL")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Agosto)
                    .HasColumnName("AGOSTO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Diciembre)
                    .HasColumnName("DICIEMBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Enero)
                    .HasColumnName("ENERO")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Febrero)
                    .HasColumnName("FEBRERO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdConcepto).HasColumnName("ID_CONCEPTO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Julio)
                    .HasColumnName("JULIO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Junio)
                    .HasColumnName("JUNIO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Marzo)
                    .HasColumnName("MARZO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Mayo)
                    .HasColumnName("MAYO")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Noviembre)
                    .HasColumnName("NOVIEMBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Octubre)
                    .HasColumnName("OCTUBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Septiembre)
                    .HasColumnName("SEPTIEMBRE")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdProductoStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdProductoStatusAr);

                entity.ToTable("BD_PRODUCTO_STATUS_AR");

                entity.Property(e => e.IdProductoStatusAr).HasColumnName("ID_PRODUCTO_STATUS_AR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.StatusBb)
                    .HasColumnName("STATUS_BB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusWeb)
                    .HasColumnName("STATUS_WEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStatusArNavigation)
                    .WithMany(p => p.BdProductoStatusAr)
                    .HasForeignKey(d => d.IdStatusAr)
                    .HasConstraintName("FK_BD_PRODUCTO_STATUS_AR_C_STATUS_AR");
            });

            modelBuilder.Entity<BdPruebasUnitarias>(entity =>
            {
                entity.HasKey(e => e.IdPruebas)
                    .HasName("PK__BD_PRUEB__9927CC8E9E6934B7");

                entity.ToTable("BD_PRUEBAS_UNITARIAS");

                entity.Property(e => e.IdPruebas).HasColumnName("ID_PRUEBAS");

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdRecepcionElavon>(entity =>
            {
                entity.HasKey(e => e.IdRecepcionElavon);

                entity.ToTable("BD_RECEPCION_ELAVON");

                entity.Property(e => e.IdRecepcionElavon).HasColumnName("ID_RECEPCION_ELAVON");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.NombreArchivo)
                    .HasColumnName("NOMBRE_ARCHIVO")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.XmlData)
                    .HasColumnName("XML_DATA")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<BdRecepcionInsumos>(entity =>
            {
                entity.HasKey(e => e.IdRecepcionInsumo)
                    .HasName("PK__BD_RECEP__3F8A213BECF1FD0F");

                entity.ToTable("BD_RECEPCION_INSUMOS");

                entity.Property(e => e.IdRecepcionInsumo).HasColumnName("ID_RECEPCION_INSUMO");

                entity.Property(e => e.CantidadRecepcionada).HasColumnName("CANTIDAD_RECEPCIONADA");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");
            });

            modelBuilder.Entity<BdRecoverPassword>(entity =>
            {
                entity.HasKey(e => e.IdRecoveryPassword)
                    .HasName("PK__BD_RECOV__B61A99475620F5CF");

                entity.ToTable("BD_RECOVER_PASSWORD");

                entity.Property(e => e.IdRecoveryPassword).HasColumnName("ID_RECOVERY_PASSWORD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.TemporaryPassword)
                    .HasColumnName("TEMPORARY_PASSWORD")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdReglasAsignacionAutomatica>(entity =>
            {
                entity.HasKey(e => e.IdReglaAsignacionAutomatica)
                    .HasName("PK__BD_REGLA__0DCA118C14576F0B");

                entity.ToTable("BD_REGLAS_ASIGNACION_AUTOMATICA");

                entity.Property(e => e.IdReglaAsignacionAutomatica).HasColumnName("ID_REGLA_ASIGNACION_AUTOMATICA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");
            });

            modelBuilder.Entity<BdReglasModelos>(entity =>
            {
                entity.HasKey(e => e.IdReglas)
                    .HasName("PK__BD_REGLA__DC4295B8DEBA1CB0");

                entity.ToTable("BD_REGLAS_MODELOS");

                entity.Property(e => e.IdReglas).HasColumnName("ID_REGLAS");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.LetrasMax).HasColumnName("LETRAS_MAX");

                entity.Property(e => e.LetrasMin).HasColumnName("LETRAS_MIN");

                entity.Property(e => e.LongMax).HasColumnName("LONG_MAX");

                entity.Property(e => e.LongMin).HasColumnName("LONG_MIN");

                entity.Property(e => e.NumeroMax).HasColumnName("NUMERO_MAX");

                entity.Property(e => e.NumeroMin).HasColumnName("NUMERO_MIN");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdReglasStatusAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdReglasStatusAlmacen);

                entity.ToTable("BD_REGLAS_STATUS_ALMACEN");

                entity.Property(e => e.IdReglasStatusAlmacen).HasColumnName("ID_REGLAS_STATUS_ALMACEN");

                entity.Property(e => e.ColorRgb)
                    .HasColumnName("COLOR_RGB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdOperador).HasColumnName("ID_OPERADOR");

                entity.Property(e => e.IdStatusSolicitudAlmacen).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Minutos).HasColumnName("MINUTOS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdReglasStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdReglaStatusAr);

                entity.ToTable("BD_REGLAS_STATUS_AR");

                entity.Property(e => e.IdReglaStatusAr).HasColumnName("ID_REGLA_STATUS_AR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdClienteProductoStatusAr).HasColumnName("ID_CLIENTE_PRODUCTO_STATUS_AR");

                entity.Property(e => e.IdOperador).HasColumnName("ID_OPERADOR");

                entity.Property(e => e.IdTiempoMedicion).HasColumnName("ID_TIEMPO_MEDICION");

                entity.Property(e => e.IdTiempoReferencia).HasColumnName("ID_TIEMPO_REFERENCIA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Minutos).HasColumnName("MINUTOS");

                entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteProductoStatusArNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdClienteProductoStatusAr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_BD_CLIENTE_PRODUCTO_STATUS_AR");

                entity.HasOne(d => d.IdOperadorNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdOperador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_C_OPERADORES");

                entity.HasOne(d => d.IdTiempoMedicionNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdTiempoMedicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_C_TIEMPO_MEDICION");

                entity.HasOne(d => d.IdTiempoReferenciaNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdTiempoReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_C_TIEMPO_REFERENCIA");
            });

            modelBuilder.Entity<BdReingresoSim>(entity =>
            {
                entity.HasKey(e => e.IdReingresoSim);

                entity.ToTable("BD_REINGRESO_SIM");

                entity.Property(e => e.IdReingresoSim).HasColumnName("ID_REINGRESO_SIM");

                entity.Property(e => e.FecReingreso)
                    .HasColumnName("FEC_REINGRESO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.IdSolicitudRecoleccionAnterior).HasColumnName("ID_SOLICITUD_RECOLECCION_ANTERIOR");

                entity.Property(e => e.IdSolicitudRecoleccionReingreso).HasColumnName("ID_SOLICITUD_RECOLECCION_REINGRESO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioReingreso).HasColumnName("ID_USUARIO_REINGRESO");

                entity.HasOne(d => d.IdSolicitudRecoleccionAnteriorNavigation)
                    .WithMany(p => p.BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_SIM_BD_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdSolicitudRecoleccionReingresoNavigation)
                    .WithMany(p => p.BdReingresoSimIdSolicitudRecoleccionReingresoNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_SIM_BD_SOLICITUD_RECOLECCION1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdReingresoSim)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_REINGRESO_SIM_BD_UNIDADES");
            });

            modelBuilder.Entity<BdReingresoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdReingresoUnidad);

                entity.ToTable("BD_REINGRESO_UNIDAD");

                entity.HasIndex(e => e.IdUnidad);

                entity.Property(e => e.IdReingresoUnidad).HasColumnName("ID_REINGRESO_UNIDAD");

                entity.Property(e => e.FecReingreso)
                    .HasColumnName("FEC_REINGRESO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdClienteAnterior).HasColumnName("ID_CLIENTE_ANTERIOR");

                entity.Property(e => e.IdClienteReingreso).HasColumnName("ID_CLIENTE_REINGRESO");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdResponsableAnterior).HasColumnName("ID_RESPONSABLE_ANTERIOR");

                entity.Property(e => e.IdResponsableReingreso).HasColumnName("ID_RESPONSABLE_REINGRESO");

                entity.Property(e => e.IdSolicitudRecoleccionAnterior).HasColumnName("ID_SOLICITUD_RECOLECCION_ANTERIOR");

                entity.Property(e => e.IdSolicitudRecoleccionReingreso).HasColumnName("ID_SOLICITUD_RECOLECCION_REINGRESO");

                entity.Property(e => e.IdStatusUnidadAnterior).HasColumnName("ID_STATUS_UNIDAD_ANTERIOR");

                entity.Property(e => e.IdStatusUnidadReingreso).HasColumnName("ID_STATUS_UNIDAD_REINGRESO");

                entity.Property(e => e.IdTipoResponsableAnterior).HasColumnName("ID_TIPO_RESPONSABLE_ANTERIOR");

                entity.Property(e => e.IdTipoResponsableReingreso).HasColumnName("ID_TIPO_RESPONSABLE_REINGRESO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioReingreso).HasColumnName("ID_USUARIO_REINGRESO");

                entity.Property(e => e.IsDaniadaAnterior).HasColumnName("IS_DANIADA_ANTERIOR");

                entity.Property(e => e.IsDaniadaReingreso).HasColumnName("IS_DANIADA_REINGRESO");

                entity.Property(e => e.IsNuevaAnterior).HasColumnName("IS_NUEVA_ANTERIOR");

                entity.Property(e => e.IsNuevaReingreso).HasColumnName("IS_NUEVA_REINGRESO");

                entity.Property(e => e.NoImeiAnterior)
                    .HasColumnName("NO_IMEI_ANTERIOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoImeiReingreso)
                    .HasColumnName("NO_IMEI_REINGRESO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventarioAnterior)
                    .HasColumnName("NO_INVENTARIO_ANTERIOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventarioReingreso)
                    .HasColumnName("NO_INVENTARIO_REINGRESO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieAnterior)
                    .HasColumnName("NO_SERIE_ANTERIOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieReingreso)
                    .HasColumnName("NO_SERIE_REINGRESO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSimAnterior)
                    .HasColumnName("NO_SIM_ANTERIOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSimReingreso)
                    .HasColumnName("NO_SIM_REINGRESO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudRecoleccionAnteriorNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_BD_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdSolicitudRecoleccionReingresoNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_BD_SOLICITUD_RECOLECCION1");

                entity.HasOne(d => d.IdStatusUnidadAnteriorNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdStatusUnidadAnteriorNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_STATUS_UNIDAD");

                entity.HasOne(d => d.IdStatusUnidadReingresoNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdStatusUnidadReingresoNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_STATUS_UNIDAD1");

                entity.HasOne(d => d.IdTipoResponsableAnteriorNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdTipoResponsableAnteriorNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdTipoResponsableReingresoNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdTipoResponsableReingresoNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_TIPO_RESPONSABLE1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdReingresoUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_BD_UNIDADES");
            });

            modelBuilder.Entity<BdRelacionFacturaEnvio>(entity =>
            {
                entity.HasKey(e => e.IdRelacionFacturaEnvio)
                    .HasName("PK__BD_RELAC__9A00745F38B1DE48");

                entity.ToTable("BD_RELACION_FACTURA_ENVIO");

                entity.Property(e => e.IdRelacionFacturaEnvio).HasColumnName("ID_RELACION_FACTURA_ENVIO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.NoFactura)
                    .HasColumnName("NO_FACTURA")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdReparacionUnidad>(entity =>
            {
                entity.HasKey(e => e.IdReparacionUnidad);

                entity.ToTable("BD_REPARACION_UNIDAD");

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdReparacionUnidad, e.IdUnidad, e.IdTecnico, e.IdStatusReparacion })
                    .HasName("IX_MI_BD_REPARACION_UNIDAD_6108_6107");

                entity.HasIndex(e => new { e.IdUnidad, e.IdTecnico, e.IdStatusReparacion, e.IdUsuarioAlta })
                    .HasName("IX_MI_BD_REPARACION_UNIDAD_195_194");

                entity.Property(e => e.IdReparacionUnidad).HasColumnName("ID_REPARACION_UNIDAD");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescReparacion)
                    .HasColumnName("DESC_REPARACION")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecReparacion)
                    .HasColumnName("FEC_REPARACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.IdNivelReparacion).HasColumnName("ID_NIVEL_REPARACION");

                entity.Property(e => e.IdReparacion).HasColumnName("ID_REPARACION");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdStatusReparacion).HasColumnName("ID_STATUS_REPARACION");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdTipoReparacion).HasColumnName("ID_TIPO_REPARACION");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioReparacion).HasColumnName("ID_USUARIO_REPARACION");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");
            });

            modelBuilder.Entity<BdReparecionesCargaPdf>(entity =>
            {
                entity.HasKey(e => e.IdReparacionCargaPdf)
                    .HasName("PK__BD_REPAR__CEE12DE5E1221796");

                entity.ToTable("BD_REPARECIONES_CARGA_PDF");

                entity.Property(e => e.IdReparacionCargaPdf).HasColumnName("ID_REPARACION_CARGA_PDF");

                entity.Property(e => e.ArchivoSistema)
                    .HasColumnName("ARCHIVO_SISTEMA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivoUsuario)
                    .HasColumnName("ARCHIVO_USUARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdReporteCierre>(entity =>
            {
                entity.HasKey(e => e.IdReporteCierre)
                    .HasName("PK_C_REPORTES_CIERRE");

                entity.ToTable("BD_REPORTE_CIERRE");

                entity.HasIndex(e => new { e.IdReporteCierre, e.IdCliente })
                    .HasName("IX_BD_REPORTE_CIERRE_ID_CLIENTE");

                entity.HasIndex(e => new { e.IdCliente, e.FecAlta, e.IdUsuarioAlta, e.IdReporteCierre, e.Status, e.IdStatusReporteCierre })
                    .HasName("IX_MI_BD_REPORTE_CIERRE_21_20");

                entity.HasIndex(e => new { e.IdReporteCierre, e.FecAlta, e.IdUsuarioAlta, e.IdCliente, e.Status, e.IdStatusReporteCierre })
                    .HasName("IX_MI_BD_REPORTE_CIERRE_19_18");

                entity.Property(e => e.IdReporteCierre).HasColumnName("ID_REPORTE_CIERRE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdStatusReporteCierre).HasColumnName("ID_STATUS_REPORTE_CIERRE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NumArs).HasColumnName("NUM_ARS");

                entity.Property(e => e.Report)
                    .HasColumnName("REPORT")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdReporteCierre)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C_REPORTES_CIERRE_C_CLIENTES");

                entity.HasOne(d => d.IdStatusReporteCierreNavigation)
                    .WithMany(p => p.BdReporteCierre)
                    .HasForeignKey(d => d.IdStatusReporteCierre)
                    .HasConstraintName("FK_BD_REPORTE_CIERRE_C_STATUS_REPORTE_CIERRE");
            });

            modelBuilder.Entity<BdReporteCierreAr>(entity =>
            {
                entity.HasKey(e => e.IdReporteCierreAr);

                entity.ToTable("BD_REPORTE_CIERRE_AR");

                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdReporteCierre);

                entity.Property(e => e.IdReporteCierreAr).HasColumnName("ID_REPORTE_CIERRE_AR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdReporteCierre).HasColumnName("ID_REPORTE_CIERRE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdReporteCierreAr)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REPORTE_CIERRE_AR_C_CLIENTES");

                entity.HasOne(d => d.IdReporteCierreNavigation)
                    .WithMany(p => p.BdReporteCierreAr)
                    .HasForeignKey(d => d.IdReporteCierre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REPORTE_CIERRE_AR_C_REPORTES_CIERRE");
            });

            modelBuilder.Entity<BdReporteMovInventario>(entity =>
            {
                entity.HasKey(e => e.IdBdReporteMovInventario);

                entity.ToTable("BD_REPORTE_MOV_INVENTARIO");

                entity.Property(e => e.IdBdReporteMovInventario).HasColumnName("ID_BD_REPORTE_MOV_INVENTARIO");

                entity.Property(e => e.DiaSemana)
                    .HasColumnName("DIA_SEMANA")
                    .HasMaxLength(10);

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdReporteMovInventario).HasColumnName("ID_REPORTE_MOV_INVENTARIO");

                entity.Property(e => e.UDispInicioDia).HasColumnName("U_DISP_INICIO_DIA");

                entity.Property(e => e.UEntradasDia).HasColumnName("U_ENTRADAS_DIA");

                entity.Property(e => e.UEntradasLab).HasColumnName("U_ENTRADAS_LAB");

                entity.Property(e => e.UInvLab).HasColumnName("U_INV_LAB");

                entity.Property(e => e.USalInst).HasColumnName("U_SAL_INST");

                entity.Property(e => e.USalLab).HasColumnName("U_SAL_LAB");

                entity.Property(e => e.USalManto).HasColumnName("U_SAL_MANTO");

                entity.HasOne(d => d.IdReporteMovInventarioNavigation)
                    .WithMany(p => p.BdReporteMovInventario)
                    .HasForeignKey(d => d.IdReporteMovInventario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REPORTE_MOV_INVENTARIO_C_REPORTE_MOV_INVENTARIO");
            });

            modelBuilder.Entity<BdRetiros>(entity =>
            {
                entity.HasKey(e => e.IdRetiro);

                entity.ToTable("BD_RETIROS");

                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdNegocio);

                entity.HasIndex(e => new { e.IdAr, e.FecAlta, e.IdUnidad })
                    .HasName("IX_BD_RETIROS_ID_UNIDAD");

                entity.Property(e => e.IdRetiro).HasColumnName("ID_RETIRO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdRetiros)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_RETIROS_BD_NEGOCIOS");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.BdRetirosIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK_BD_RETIROS_BD_UNIDADES1");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.BdRetiros)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("FK_BD_RETIROS_C_USUARIOS");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdRetirosIdUnidadNavigation)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_RETIROS_BD_UNIDADES");
            });

            modelBuilder.Entity<BdServicioCausa>(entity =>
            {
                entity.HasKey(e => e.IdServicioCausa);

                entity.ToTable("BD_SERVICIO_CAUSA");

                entity.Property(e => e.IdServicioCausa).HasColumnName("ID_SERVICIO_CAUSA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCausa).HasColumnName("ID_CAUSA");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdCausaNavigation)
                    .WithMany(p => p.BdServicioCausa)
                    .HasForeignKey(d => d.IdCausa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_CAUSA_C_CAUSAS");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.BdServicioCausa)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_CAUSA_C_SERVICIOS");
            });

            modelBuilder.Entity<BdServicioCausaRechazoPrecio>(entity =>
            {
                entity.HasKey(e => e.IdServicioCausaRechazoPrecio);

                entity.ToTable("BD_SERVICIO_CAUSA_RECHAZO_PRECIO");

                entity.HasIndex(e => e.IdServicio)
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_149568_149567");

                entity.HasIndex(e => new { e.IdCliente, e.IdServicio, e.IdEspecificacionCausaRechazo })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10243_10242");

                entity.HasIndex(e => new { e.IdServicio, e.IdEspecificacionCausaRechazo, e.IdCliente })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10233_10232");

                entity.HasIndex(e => new { e.IdServicioCausaRechazoPrecio, e.IdServicio, e.IdEspecificacionCausaRechazo })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_149573_149572");

                entity.HasIndex(e => new { e.IdCliente, e.IdServicio, e.IdEspecificacionCausaRechazo, e.Precio })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10229_10228");

                entity.HasIndex(e => new { e.IdServicio, e.IdEspecificacionCausaRechazo, e.IdCliente, e.Precio })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10231_10230");

                entity.HasIndex(e => new { e.IdServicio, e.IdEspecificacionCausaRechazo, e.Precio, e.IdCliente })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10248_10247");

                entity.HasIndex(e => new { e.Precio, e.IdCliente, e.IdServicio, e.IdEspecificacionCausaRechazo })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10246_10245");

                entity.Property(e => e.IdServicioCausaRechazoPrecio).HasColumnName("ID_SERVICIO_CAUSA_RECHAZO_PRECIO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEspecificacionCausaRechazo).HasColumnName("ID_ESPECIFICACION_CAUSA_RECHAZO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<BdServicioMovInv>(entity =>
            {
                entity.HasKey(e => e.IdServicioMovInv)
                    .HasName("PK_BD_SERVICIO_MOV_INT");

                entity.ToTable("BD_SERVICIO_MOV_INV");

                entity.Property(e => e.IdServicioMovInv).HasColumnName("ID_SERVICIO_MOV_INV");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdMovInv).HasColumnName("ID_MOV_INV");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsRequired).HasColumnName("IS_REQUIRED");

                entity.HasOne(d => d.IdMovInvNavigation)
                    .WithMany(p => p.BdServicioMovInv)
                    .HasForeignKey(d => d.IdMovInv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_MOV_INT_C_MOV_INV");
            });

            modelBuilder.Entity<BdServicioSegmento>(entity =>
            {
                entity.HasKey(e => e.IdServicioSegmento);

                entity.ToTable("BD_SERVICIO_SEGMENTO");

                entity.HasIndex(e => new { e.IdServicio, e.IdSegmento, e.IdTipoPlaza })
                    .HasName("IX_BD_SERVICIO_SEGMENTO_ID_SERVICIO, ID_SEGMENTO, ID_TIPO_PLAZA");

                entity.Property(e => e.IdServicioSegmento).HasColumnName("ID_SERVICIO_SEGMENTO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HorasGarantia).HasColumnName("HORAS_GARANTIA");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("ID_TIPO_PLAZA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.PrecioExito)
                    .HasColumnName("PRECIO_EXITO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Ta).HasColumnName("TA");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.Ts).HasColumnName("TS");
            });

            modelBuilder.Entity<BdServicioSolucion>(entity =>
            {
                entity.HasKey(e => e.IdServicioSolucion);

                entity.ToTable("BD_SERVICIO_SOLUCION");

                entity.Property(e => e.IdServicioSolucion).HasColumnName("ID_SERVICIO_SOLUCION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdSolucion).HasColumnName("ID_SOLUCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.BdServicioSolucion)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_SOLUCION_C_SERVICIOS");

                entity.HasOne(d => d.IdSolucionNavigation)
                    .WithMany(p => p.BdServicioSolucion)
                    .HasForeignKey(d => d.IdSolucion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_SOLUCION_C_SOLUCIONES");
            });

            modelBuilder.Entity<BdServicioSolucionPrecio>(entity =>
            {
                entity.HasKey(e => e.IdServicioSolucionPrecio);

                entity.ToTable("BD_SERVICIO_SOLUCION_PRECIO");

                entity.Property(e => e.IdServicioSolucionPrecio).HasColumnName("ID_SERVICIO_SOLUCION_PRECIO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEspecifTipoFalla).HasColumnName("ID_ESPECIF_TIPO_FALLA");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<BdServicioTipoFalla>(entity =>
            {
                entity.HasKey(e => e.IdServicioTipoFalla);

                entity.ToTable("BD_SERVICIO_TIPO_FALLA");

                entity.Property(e => e.IdServicioTipoFalla).HasColumnName("ID_SERVICIO_TIPO_FALLA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdTipoFalla).HasColumnName("ID_TIPO_FALLA");
            });

            modelBuilder.Entity<BdServicioWeekhour>(entity =>
            {
                entity.HasKey(e => e.IdServicioWeekhour);

                entity.ToTable("BD_SERVICIO_WEEKHOUR");

                entity.HasIndex(e => new { e.IdWeekhour, e.IdServicio })
                    .HasName("IX_BD_SERVICIO_WEEKHOUR_ID_SERVICIO");

                entity.Property(e => e.IdServicioWeekhour).HasColumnName("ID_SERVICIO_WEEKHOUR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdWeekhour).HasColumnName("ID_WEEKHOUR");
            });

            modelBuilder.Entity<BdServiciosFallas>(entity =>
            {
                entity.HasKey(e => e.IdServicioFalla);

                entity.ToTable("BD_SERVICIOS_FALLAS");

                entity.Property(e => e.IdServicioFalla).HasColumnName("ID_SERVICIO_FALLA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdSims>(entity =>
            {
                entity.HasKey(e => e.IdSim);

                entity.ToTable("BD_SIMS");

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => e.NoSim)
                    .HasName("IX_MI_BD_SIMS_4794_4793");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.Status })
                    .HasName("IX_BD_SIMS_ID_SOLICITUD_RECOLECCION, STATUS");

                entity.HasIndex(e => new { e.NoSim, e.Status })
                    .HasName("IX_MI_BD_SIMS_4796_4795");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCarrier).HasColumnName("ID_CARRIER");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusSim).HasColumnName("ID_STATUS_SIM");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.IsDisponible).HasColumnName("IS_DISPONIBLE");

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .IsRequired()
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdSimsAlta>(entity =>
            {
                entity.HasKey(e => e.IdSimAlta);

                entity.ToTable("BD_SIMS_ALTA");

                entity.Property(e => e.IdSimAlta).HasColumnName("ID_SIM_ALTA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCarrier).HasColumnName("ID_CARRIER");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAsignado).HasColumnName("IS_ASIGNADO");

                entity.Property(e => e.IsNullCarrier).HasColumnName("IS_NULL_CARRIER");

                entity.Property(e => e.IsNullSim).HasColumnName("IS_NULL_SIM");

                entity.Property(e => e.IsNumeric).HasColumnName("IS_NUMERIC");

                entity.Property(e => e.IsOtroCliente).HasColumnName("IS_OTRO_CLIENTE");

                entity.Property(e => e.IsProcesado).HasColumnName("IS_PROCESADO");

                entity.Property(e => e.IsReingreso).HasColumnName("IS_REINGRESO");

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Validacion).HasColumnName("VALIDACION");
            });

            modelBuilder.Entity<BdSoftelPaso>(entity =>
            {
                entity.HasKey(e => e.IdSoftelPaso)
                    .HasName("PK__BD_SOFTE__2BA7B6E7D84AB152");

                entity.ToTable("BD_SOFTEL_PASO");

                entity.Property(e => e.IdSoftelPaso).HasColumnName("ID_SOFTEL_PASO");

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.From)
                    .HasColumnName("FROM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumberMsg).HasColumnName("NUMBER_MSG");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdSolicitudAlmacenComentario>(entity =>
            {
                entity.HasKey(e => e.IdComentarioSolicitudAlmacen)
                    .HasName("PK_BD_COMENTARIO_SOLICITUD_ALMACEN");

                entity.ToTable("BD_SOLICITUD_ALMACEN_COMENTARIO");

                entity.Property(e => e.IdComentarioSolicitudAlmacen).HasColumnName("ID_COMENTARIO_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescComentarioSolicitudAlmacen)
                    .HasColumnName("DESC_COMENTARIO_SOLICITUD_ALMACEN")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdStatusSolicitudAlmacen).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdSolicitudCorreo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCorreo)
                    .HasName("PK_BD_SOLICITUDES_CORREO");

                entity.ToTable("BD_SOLICITUD_CORREO");

                entity.Property(e => e.IdSolicitudCorreo).HasColumnName("ID_SOLICITUD_CORREO");

                entity.Property(e => e.Estatus).HasColumnName("ESTATUS");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCorreo)
                    .HasColumnName("FECHA_CORREO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCorreo)
                    .HasColumnName("ID_CORREO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(50);

                entity.Property(e => e.Nemonico)
                    .HasColumnName("NEMONICO")
                    .HasMaxLength(150);

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(100);

                entity.Property(e => e.NoSerieEquipo)
                    .HasColumnName("NO_SERIE_EQUIPO")
                    .HasMaxLength(200);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasMaxLength(3000);
            });

            modelBuilder.Entity<BdSolicitudCorreoLog>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCorreoLog)
                    .HasName("PK_BD_SOLICITUD_CORREOLOG");

                entity.ToTable("BD_SOLICITUD_CORREO_LOG");

                entity.Property(e => e.IdSolicitudCorreoLog).HasColumnName("ID_SOLICITUD_CORREO_LOG");

                entity.Property(e => e.ContenidoEmail).HasColumnName("CONTENIDO_EMAIL");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCorreo)
                    .HasColumnName("FECHA_CORREO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCorreo)
                    .HasColumnName("ID_CORREO")
                    .HasMaxLength(100);

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<BdSolicitudCorreoOki>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCorreoOki)
                    .HasName("PK_BD_SOLICITUDES_CORREO_OKI");

                entity.ToTable("BD_SOLICITUD_CORREO_OKI");

                entity.Property(e => e.IdSolicitudCorreoOki).HasColumnName("ID_SOLICITUD_CORREO_OKI");

                entity.Property(e => e.Estatus).HasColumnName("ESTATUS");

                entity.Property(e => e.Falla)
                    .HasColumnName("FALLA")
                    .HasMaxLength(500);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCorreo)
                    .HasColumnName("FECHA_CORREO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCorreo)
                    .HasColumnName("ID_CORREO")
                    .HasMaxLength(100);

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Nemonico)
                    .HasColumnName("NEMONICO")
                    .HasMaxLength(150);

                entity.Property(e => e.NoAr)
                    .HasColumnName("NO_AR")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreCajero)
                    .HasColumnName("NOMBRE_CAJERO")
                    .HasMaxLength(200);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasMaxLength(3000);

                entity.Property(e => e.Ticket)
                    .HasColumnName("TICKET")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BdSolicitudRecoleccion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudRecoleccion)
                    .HasName("PK_BD_SOLICITUDES_RECOLECCION");

                entity.ToTable("BD_SOLICITUD_RECOLECCION");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.IdStatusSolicitudRecoleccion })
                    .HasName("IX_MI_BD_SOLICITUD_RECOLECCION_4785_4784");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.IdCliente, e.IdAlmacenDestino, e.IdServicioMensajeria, e.IdStatusSolicitudRecoleccion })
                    .HasName("IX_MI_BD_SOLICITUD_RECOLECCION_4787_4786");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.CalleNum)
                    .HasColumnName("CALLE_NUM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidades).HasColumnName("CANTIDADES");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Delegacion)
                    .HasColumnName("DELEGACION")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Distribuidor)
                    .HasColumnName("DISTRIBUIDOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecRecoleccion)
                    .HasColumnName("FEC_RECOLECCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraRecoleccion)
                    .HasColumnName("HORA_RECOLECCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAlmacenDestino).HasColumnName("ID_ALMACEN_DESTINO");

                entity.Property(e => e.IdAttachSolicitud).HasColumnName("ID_ATTACH_SOLICITUD");

                entity.Property(e => e.IdChofer).HasColumnName("ID_CHOFER");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdStatusSolicitudRecoleccion).HasColumnName("ID_STATUS_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("ID_TIPO_SOLICITUD");

                entity.Property(e => e.IdUnidadMensajeria).HasColumnName("ID_UNIDAD_MENSAJERIA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoUnidades).HasColumnName("NO_UNIDADES");

                entity.HasOne(d => d.IdChoferNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdChofer)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_C_CHOFERES");

                entity.HasOne(d => d.IdStatusSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdStatusSolicitudRecoleccion)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_C_STATUS_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdUnidadMensajeriaNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdUnidadMensajeria)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_C_UNIDAD_MENSAJERIA");
            });

            modelBuilder.Entity<BdSolicitudRecoleccionInsumos>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudRecoleccionInsumos);

                entity.ToTable("BD_SOLICITUD_RECOLECCION_INSUMOS");

                entity.Property(e => e.IdSolicitudRecoleccionInsumos).HasColumnName("ID_SOLICITUD_RECOLECCION_INSUMOS");

                entity.Property(e => e.Cantidades).HasColumnName("CANTIDADES");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccionInsumos)
                    .HasForeignKey(d => d.IdSolicitudRecoleccion)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_INSUMOS_BD_SOLICITUD_RECOLECCION");
            });

            modelBuilder.Entity<BdSolicitudRecoleccionModelo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudRecoleccionModelo);

                entity.ToTable("BD_SOLICITUD_RECOLECCION_MODELO");

                entity.Property(e => e.IdSolicitudRecoleccionModelo).HasColumnName("ID_SOLICITUD_RECOLECCION_MODELO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoUnidades).HasColumnName("NO_UNIDADES");

                entity.HasOne(d => d.IdSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccionModelo)
                    .HasForeignKey(d => d.IdSolicitudRecoleccion)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_MODELO_BD_SOLICITUD_RECOLECCION");
            });

            modelBuilder.Entity<BdSolicitudesAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudAlmacen);

                entity.ToTable("BD_SOLICITUDES_ALMACEN");

                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdEnvio);

                entity.HasIndex(e => new { e.IdStatusSolicitudAlmacen, e.IdEnvio })
                    .HasName("IX_BD_SOLICITUDES_ALMACEN_ID_STATUS_SOLICITUD_ALMACEN, ID_ENVIO");

                entity.HasIndex(e => new { e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.IdSolicitudAlmacen, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_21326_21325");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdAlmacen, e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_4_3");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.FecAlta, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_22_21");

                entity.HasIndex(e => new { e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.IdSolicitudAlmacen, e.IdAlmacen, e.IdTipoSolicitudAlmacen, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_12_11");

                entity.HasIndex(e => new { e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.FecCompromiso, e.IdUsuarioAlta, e.FecAlta, e.IdSolicitudAlmacen, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_BD_SOLICITUDES_ALMACEN_ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.CantidadSparePart).HasColumnName("CANTIDAD_SPARE_PART");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCompromiso)
                    .HasColumnName("FEC_COMPROMISO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecConfirm)
                    .HasColumnName("FEC_CONFIRM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdDireccion).HasColumnName("ID_DIRECCION");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdStatusSolicitudAlmacen).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TIPO_SERVICIO");

                entity.Property(e => e.IdTipoSolicitudAlmacen).HasColumnName("ID_TIPO_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUrgenciaSolicitudAlmacen).HasColumnName("ID_URGENCIA_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioConfirm).HasColumnName("ID_USUARIO_CONFIRM");

                entity.Property(e => e.IsEntregasParciales).HasColumnName("IS_ENTREGAS_PARCIALES");

                entity.Property(e => e.Notas)
                    .HasColumnName("NOTAS")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.OtraDireccion)
                    .HasColumnName("OTRA_DIRECCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDireccionNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdDireccion)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_BD_DIRECCIONES");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdSparePart)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_SPARE_PARTS");

                entity.HasOne(d => d.IdTipoResponsableDestinoNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdTipoResponsableDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_TIPO_SERVICIO_SOLICITUD_ALMACEN2");

                entity.HasOne(d => d.IdTipoSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdTipoSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_TIPO_SOLICITUD_ALMACEN");

                entity.HasOne(d => d.IdUrgenciaSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdUrgenciaSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_URGENCIA_SOLICITUD_ALMACEN");
            });

            modelBuilder.Entity<BdSolicitudesAlmacenOld>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudAlmacen);

                entity.ToTable("BD_SOLICITUDES_ALMACEN_OLD");

                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_BD_SOLICITUDES_ALMACEN_ID_AR");

                entity.Property(e => e.IdSolicitudAlmacen).HasColumnName("ID_SOLICITUD_ALMACEN");

                entity.Property(e => e.CantidadSparePart).HasColumnName("CANTIDAD_SPARE_PART");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecConfirm)
                    .HasColumnName("FEC_CONFIRM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdStatusSolicitudAlmacen).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoSolicitudAlmacen).HasColumnName("ID_TIPO_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUrgenciaSolicitudAlmacen).HasColumnName("ID_URGENCIA_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioConfirm).HasColumnName("ID_USUARIO_CONFIRM");

                entity.Property(e => e.Notas)
                    .HasColumnName("NOTAS")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_ALMACENES");

                entity.HasOne(d => d.IdResponsableDestinoNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOldIdResponsableDestinoNavigation)
                    .HasForeignKey(d => d.IdResponsableDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_USUARIOS");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdSparePart)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_SPARE_PARTS");

                entity.HasOne(d => d.IdTipoResponsableDestinoNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdTipoResponsableDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdTipoSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdTipoSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_TIPO_SOLICITUD_ALMACEN");

                entity.HasOne(d => d.IdUrgenciaSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdUrgenciaSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_URGENCIA_SOLICITUD_ALMACEN");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOldIdUsuarioAltaNavigation)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_USUARIOS1");

                entity.HasOne(d => d.IdUsuarioConfirmNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOldIdUsuarioConfirmNavigation)
                    .HasForeignKey(d => d.IdUsuarioConfirm)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_USUARIOS2");
            });

            modelBuilder.Entity<BdSolicitudesDevolucion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDevolucion);

                entity.ToTable("BD_SOLICITUDES_DEVOLUCION");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.Accesorios).HasColumnName("ACCESORIOS");

                entity.Property(e => e.CalleNum)
                    .HasColumnName("CALLE_NUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Delegacion)
                    .HasColumnName("DELEGACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecDevolucion)
                    .HasColumnName("FEC_DEVOLUCION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraDevolucion)
                    .HasColumnName("HORA_DEVOLUCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdChofer).HasColumnName("ID_CHOFER");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdSolicitante).HasColumnName("ID_SOLICITANTE");

                entity.Property(e => e.IdStatusSolicitudDevolucion).HasColumnName("ID_STATUS_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdStatusValidacionDevolucion).HasColumnName("ID_STATUS_VALIDACION_DEVOLUCION");

                entity.Property(e => e.IdUnidadMensajeria).HasColumnName("ID_UNIDAD_MENSAJERIA");

                entity.Property(e => e.Insumos).HasColumnName("INSUMOS");

                entity.Property(e => e.NoSims).HasColumnName("NO_SIMS");

                entity.Property(e => e.NoUnidades).HasColumnName("NO_UNIDADES");

                entity.Property(e => e.Notas)
                    .HasColumnName("NOTAS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Refacciones).HasColumnName("REFACCIONES");

                entity.Property(e => e.SpareParts).HasColumnName("SPARE_PARTS");
            });

            modelBuilder.Entity<BdSolicitudesDevolucionInsumos>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDevolucionInsumo);

                entity.ToTable("BD_SOLICITUDES_DEVOLUCION_INSUMOS");

                entity.Property(e => e.IdSolicitudDevolucionInsumo).HasColumnName("ID_SOLICITUD_DEVOLUCION_INSUMO");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdStatusInsumoIni).HasColumnName("ID_STATUS_INSUMO_INI");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsRecibidoRetorno).HasColumnName("IS_RECIBIDO_RETORNO");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionInsumos)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_INSUMO_C_USUARIOS");
            });

            modelBuilder.Entity<BdSolicitudesDevolucionItems>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDevolucionItem)
                    .HasName("PK_BD_SOLICITUDES_DEVOLUCION_INSUMO");

                entity.ToTable("BD_SOLICITUDES_DEVOLUCION_ITEMS");

                entity.Property(e => e.IdSolicitudDevolucionItem).HasColumnName("ID_SOLICITUD_DEVOLUCION_ITEM");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAccesorio).HasColumnName("ID_ACCESORIO");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.IdRefaccion).HasColumnName("ID_REFACCION");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdStatusInsumoIni).HasColumnName("ID_STATUS_INSUMO_INI");

                entity.Property(e => e.IdTipoItemSolicitudAlmacen).HasColumnName("ID_TIPO_ITEM_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsRecibidoRetorno).HasColumnName("IS_RECIBIDO_RETORNO");
            });

            modelBuilder.Entity<BdSolicitudesDevolucionModelo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDevolucionModelo);

                entity.ToTable("BD_SOLICITUDES_DEVOLUCION_MODELO");

                entity.Property(e => e.IdSolicitudDevolucionModelo).HasColumnName("ID_SOLICITUD_DEVOLUCION_MODELO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoUnidades).HasColumnName("NO_UNIDADES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionModelo)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_MODELO_C_MODELOS");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionModelo)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_MODELO_C_USUARIOS");
            });

            modelBuilder.Entity<BdSolicitudesDevolucionUnidad>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDevolucionUnidad);

                entity.ToTable("BD_SOLICITUDES_DEVOLUCION_UNIDAD");

                entity.HasIndex(e => e.NoSerie)
                    .HasName("IX_MI_BD_SOLICITUDES_DEVOLUCION_UNIDAD_34302_34301");

                entity.HasIndex(e => new { e.IdSolicitudDevolucionUnidad, e.IdUnidad, e.IdSolicitudDevolucion, e.IsRecibidoRetorno })
                    .HasName("IX_BD_SOLICITUDES_DEVOLUCION_UNIDAD_ID_SOLICITUD_DEVOLUCION, IS_RECIBIDO_RETORNO");

                entity.Property(e => e.IdSolicitudDevolucionUnidad).HasColumnName("ID_SOLICITUD_DEVOLUCION_UNIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudDevolucion).HasColumnName("ID_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdStatusUnidadIni).HasColumnName("ID_STATUS_UNIDAD_INI");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsRecibidoRetorno).HasColumnName("IS_RECIBIDO_RETORNO");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_UNIDAD_BD_UNIDADES");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionUnidad)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_UNIDAD_C_USUARIOS");
            });

            modelBuilder.Entity<BdSolicitudesViaticos>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudViaticos)
                    .HasName("PK_C_SOLICITUD_VIATICO");

                entity.ToTable("BD_SOLICITUDES_VIATICOS");

                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdComprobacionSolicitudesViaticos)
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_120168_120167");

                entity.HasIndex(e => new { e.IdUsuarioSolicitado, e.IdStatusSolicitudViaticos, e.FecConfirmacion })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_97642_97641");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.IdStatusSolicitudViaticos, e.IdUsuarioSolicitado, e.FecConfirmacion })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_97748_97747");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdStatusSolicitudViaticos })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_8692_8691");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.Destino, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdStatusSolicitudViaticos })
                    .HasName("IX_BD_SOLICITUDES_VIATICOS_ID_STATUS_SOLICITUD_VIATICOS");

                entity.HasIndex(e => new { e.IdAr, e.Destino, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdSolicitudViaticos, e.IdStatusSolicitudViaticos, e.FecAlta })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_27346_27345");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.Destino, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdStatusSolicitudViaticos, e.FecAlta })
                    .HasName("IX_BD_SOLICITUDES_VIATICOS_ID_STATUS_SOLICITUD_VIATICOS, FEC_ALTA");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.ComentarioAutorizador)
                    .HasColumnName("COMENTARIO_AUTORIZADOR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioConfirmador)
                    .HasColumnName("COMENTARIO_CONFIRMADOR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioSolicitante)
                    .HasColumnName("COMENTARIO_SOLICITANTE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasColumnName("DESTINO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecConfirmacion)
                    .HasColumnName("FEC_CONFIRMACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FromAutomatizacion).HasColumnName("FROM_AUTOMATIZACION");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdComprobacionSolicitudesViaticos).HasColumnName("ID_COMPROBACION_SOLICITUDES_VIATICOS");

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("ID_CUENTA_BANCARIA");

                entity.Property(e => e.IdStatusSolicitudViaticos).HasColumnName("ID_STATUS_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioSolicitado).HasColumnName("ID_USUARIO_SOLICITADO");

                entity.Property(e => e.NumConfirmacion)
                    .HasColumnName("NUM_CONFIRMACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStatusSolicitudViaticosNavigation)
                    .WithMany(p => p.BdSolicitudesViaticos)
                    .HasForeignKey(d => d.IdStatusSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C_SOLICITUD_VIATICO_C_STATUS_SOLICITUD_VIATICOS");
            });

            modelBuilder.Entity<BdSolicitudesViaticosConceptos>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudViaticosConcepto)
                    .HasName("PK_BD_SOLICITUDES_VIATICOS_CONCEPTO");

                entity.ToTable("BD_SOLICITUDES_VIATICOS_CONCEPTOS");

                entity.HasIndex(e => e.IdSolicitudViaticos);

                entity.Property(e => e.IdSolicitudViaticosConcepto).HasColumnName("ID_SOLICITUD_VIATICOS_CONCEPTO");

                entity.Property(e => e.Adeudo)
                    .HasColumnName("ADEUDO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadAutorizada)
                    .HasColumnName("CANTIDAD_AUTORIZADA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadComprobada)
                    .HasColumnName("CANTIDAD_COMPROBADA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadSolicitada)
                    .HasColumnName("CANTIDAD_SOLICITADA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadSolicitadaReal)
                    .HasColumnName("CANTIDAD_SOLICITADA_REAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FromAutomatizacion).HasColumnName("FROM_AUTOMATIZACION");

                entity.Property(e => e.IdSolicitudViaticos).HasColumnName("ID_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdViatico).HasColumnName("ID_VIATICO");

                entity.Property(e => e.Kilometros)
                    .HasColumnName("KILOMETROS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdSolicitudesViaticosConceptos)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_VIATICOS_CONCEPTO_BD_SOLICITUDES_VIATICOS");

                entity.HasOne(d => d.IdViaticoNavigation)
                    .WithMany(p => p.BdSolicitudesViaticosConceptos)
                    .HasForeignKey(d => d.IdViatico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_VIATICOS_CONCEPTO_C_VIATICOS");
            });

            modelBuilder.Entity<BdSoporteTecnico>(entity =>
            {
                entity.HasKey(e => e.IdSoporteTecnico);

                entity.ToTable("BD_SOPORTE_TECNICO");

                entity.HasIndex(e => new { e.IdSoporteTecnico, e.IdAr, e.IdUsuarioSoporte, e.Status })
                    .HasName("IX_BD_SOPORTE_TECNICO_STATUS");

                entity.HasIndex(e => new { e.IdSoporteTecnico, e.IdUsuarioSoporte, e.IdAr, e.Status })
                    .HasName("IX_BD_SOPORTE_TECNICO_ID_AR, STATUS");

                entity.Property(e => e.IdSoporteTecnico).HasColumnName("ID_SOPORTE_TECNICO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecConfirm)
                    .HasColumnName("FEC_CONFIRM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdStatusArAnt).HasColumnName("ID_STATUS_AR_ANT");

                entity.Property(e => e.IdTipoSoporteTecnico).HasColumnName("ID_TIPO_SOPORTE_TECNICO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioConfirm).HasColumnName("ID_USUARIO_CONFIRM");

                entity.Property(e => e.IdUsuarioSoporte).HasColumnName("ID_USUARIO_SOPORTE");

                entity.Property(e => e.IsChecked).HasColumnName("IS_CHECKED");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoSoporteTecnicoNavigation)
                    .WithMany(p => p.BdSoporteTecnico)
                    .HasForeignKey(d => d.IdTipoSoporteTecnico)
                    .HasConstraintName("FK_BD_SOPORTE_TECNICO_C_TIPO_SOPORTE_TECNICO");
            });

            modelBuilder.Entity<BdSparePartPrecio>(entity =>
            {
                entity.HasKey(e => e.IdSparePartPrecio);

                entity.ToTable("BD_SPARE_PART_PRECIO");

                entity.Property(e => e.IdSparePartPrecio).HasColumnName("ID_SPARE_PART_PRECIO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdSparePartPrecio)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SPARE_PART_PRECIO_C_CLIENTES");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.BdSparePartPrecio)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_BD_SPARE_PART_PRECIO_C_MONEDAS");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdSparePartPrecio)
                    .HasForeignKey(d => d.IdSparePart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SPARE_PART_PRECIO_C_SPARE_PARTS");
            });

            modelBuilder.Entity<BdStatusDoctoTipoResponsablePrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusDoctoTipoResponsablePrefacturacion)
                    .HasName("PK_BD_MOV_DOCTOS_PREFACTURACION");

                entity.ToTable("BD_STATUS_DOCTO_TIPO_RESPONSABLE_PREFACTURACION");

                entity.Property(e => e.IdStatusDoctoTipoResponsablePrefacturacion).HasColumnName("ID_STATUS_DOCTO_TIPO_RESPONSABLE_PREFACTURACION");

                entity.Property(e => e.IdStatusDoctoPrefacturacion).HasColumnName("ID_STATUS_DOCTO_PREFACTURACION");

                entity.Property(e => e.IdTipoDoctoPrefacturacion).HasColumnName("ID_TIPO_DOCTO_PREFACTURACION");

                entity.Property(e => e.IdTipoResponsablePrefacturacion).HasColumnName("ID_TIPO_RESPONSABLE_PREFACTURACION");

                entity.Property(e => e.IsClienteAssign).HasColumnName("IS_CLIENTE_ASSIGN");

                entity.Property(e => e.IsPartnerAssign).HasColumnName("IS_PARTNER_ASSIGN");

                entity.Property(e => e.IsPrefacturacionAssign).HasColumnName("IS_PREFACTURACION_ASSIGN");
            });

            modelBuilder.Entity<BdStatusTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdStatusTipoUsuario);

                entity.ToTable("BD_STATUS_TIPO_USUARIO");

                entity.Property(e => e.IdStatusTipoUsuario).HasColumnName("ID_STATUS_TIPO_USUARIO");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");
            });

            modelBuilder.Entity<BdSustituciones>(entity =>
            {
                entity.HasKey(e => e.IdSustitucion);

                entity.ToTable("BD_SUSTITUCIONES");

                entity.Property(e => e.IdSustitucion).HasColumnName("ID_SUSTITUCION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUnidadEntrada).HasColumnName("ID_UNIDAD_ENTRADA");

                entity.Property(e => e.IdUnidadSalida).HasColumnName("ID_UNIDAD_SALIDA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NoEquipoEntrada)
                    .HasColumnName("NO_EQUIPO_ENTRADA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoEquipoSalida)
                    .HasColumnName("NO_EQUIPO_SALIDA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdSustituciones)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_BD_NEGOCIOS");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.BdSustituciones)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_C_USUARIOS");

                entity.HasOne(d => d.IdUnidadEntradaNavigation)
                    .WithMany(p => p.BdSustitucionesIdUnidadEntradaNavigation)
                    .HasForeignKey(d => d.IdUnidadEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_BD_UNIDADES");

                entity.HasOne(d => d.IdUnidadSalidaNavigation)
                    .WithMany(p => p.BdSustitucionesIdUnidadSalidaNavigation)
                    .HasForeignKey(d => d.IdUnidadSalida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_BD_UNIDADES1");
            });

            modelBuilder.Entity<BdTempActualizaTipoPlazaCliente>(entity =>
            {
                entity.ToTable("BD_TEMP_ACTUALIZA_TIPO_PLAZA_CLIENTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("ID_TIPO_PLAZA");

                entity.Property(e => e.IdTipoPlazaCliente).HasColumnName("ID_TIPO_PLAZA_CLIENTE");
            });

            modelBuilder.Entity<BdTempCorreccion>(entity =>
            {
                entity.HasKey(e => e.IdTempCorreccion);

                entity.ToTable("BD_TEMP_CORRECCION");

                entity.Property(e => e.IdTempCorreccion).HasColumnName("ID_TEMP_CORRECCION");

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieMal)
                    .HasColumnName("NO_SERIE_MAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieOk)
                    .HasColumnName("NO_SERIE_OK")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdTempServicioCierrePda>(entity =>
            {
                entity.HasKey(e => e.IdTempServicioCierrePda);

                entity.ToTable("BD_TEMP_SERVICIO_CIERRE_PDA");

                entity.Property(e => e.IdTempServicioCierrePda).HasColumnName("ID_TEMP_SERVICIO_CIERRE_PDA");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IsCierrePda).HasColumnName("IS_CIERRE_PDA");
            });

            modelBuilder.Entity<BdTerminales>(entity =>
            {
                entity.HasKey(e => e.IdTerminal)
                    .HasName("PK__BD_TERMINALES__403C232B");

                entity.ToTable("BD_TERMINALES");

                entity.HasIndex(e => e.IdTerminal)
                    .HasName("PK_BD_TERMINALES")
                    .IsUnique();

                entity.Property(e => e.IdTerminal).HasColumnName("ID_TERMINAL");

                entity.Property(e => e.AppRoute)
                    .HasColumnName("APP_ROUTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescTerminal)
                    .HasColumnName("DESC_TERMINAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocRoute)
                    .HasColumnName("DOC_ROUTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebRoute)
                    .HasColumnName("WEB_ROUTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdTipoPlan>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlan);

                entity.ToTable("BD_TIPO_PLAN");

                entity.Property(e => e.IdTipoPlan).HasColumnName("ID_TIPO_PLAN");

                entity.Property(e => e.DescTipoPlan)
                    .HasColumnName("DESC_TIPO_PLAN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdTipoPlazaClienteCp>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlazaClienteCp);

                entity.ToTable("BD_TIPO_PLAZA_CLIENTE_CP");

                entity.HasIndex(e => e.Cp);

                entity.HasIndex(e => new { e.IdTipoPlazaClienteCp, e.Cp, e.IdTipoPlazaCliente })
                    .HasName("missing_index_3665_3664");

                entity.Property(e => e.IdTipoPlazaClienteCp).HasColumnName("ID_TIPO_PLAZA_CLIENTE_CP");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTipoPlazaCliente).HasColumnName("ID_TIPO_PLAZA_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdTipoServicioProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicioProducto);

                entity.ToTable("BD_TIPO_SERVICIO_PRODUCTO");

                entity.Property(e => e.IdTipoServicioProducto).HasColumnName("ID_TIPO_SERVICIO_PRODUCTO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdTipoCobro).HasColumnName("ID_TIPO_COBRO");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TIPO_SERVICIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.HasOne(d => d.IdTipoCobroNavigation)
                    .WithMany(p => p.BdTipoServicioProducto)
                    .HasForeignKey(d => d.IdTipoCobro)
                    .HasConstraintName("FK_BD_TIPO_SERVICIO_PRODUCTO_C_TIPO_COBRO");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.BdTipoServicioProducto)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_TIPO_SERVICIO_PRODUCTO_C_TIPO_SERVICIO");
            });

            modelBuilder.Entity<BdTpvsAlta>(entity =>
            {
                entity.HasKey(e => e.IdTpvAlta);

                entity.ToTable("BD_TPVS_ALTA");

                entity.HasIndex(e => e.NoSerie)
                    .HasName("IX_MI_BD_TPVS_ALTA_27385_27384");

                entity.HasIndex(e => new { e.IdTpvAlta, e.IdModelo, e.IdSolicitudRecoleccion })
                    .HasName("IX_MI_BD_TPVS_ALTA_27400_27399");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.NoSerie, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27389_27388");

                entity.HasIndex(e => new { e.NoSerie, e.IsReingreso, e.IsProcesada, e.IsCambioModelo })
                    .HasName("IX_MI_BD_TPVS_ALTA_27383_27382");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.NoImei, e.NoSim, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27398_27397");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.NoSerie, e.NoSim, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27419_27418");

                entity.HasIndex(e => new { e.IdModelo, e.NoSerie, e.IdModeloAnt, e.IsReingreso, e.IsProcesada, e.IsCambioModelo })
                    .HasName("IX_MI_BD_TPVS_ALTA_27387_27386");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.IdResponsable, e.NoSerie, e.IdUsuarioAlta, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27391_27390");

                entity.Property(e => e.IdTpvAlta).HasColumnName("ID_TPV_ALTA");

                entity.Property(e => e.ExistsModelo).HasColumnName("EXISTS_MODELO");

                entity.Property(e => e.ExistsSim).HasColumnName("EXISTS_SIM");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdModeloAnt).HasColumnName("ID_MODELO_ANT");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAsignada).HasColumnName("IS_ASIGNADA");

                entity.Property(e => e.IsCambioModelo).HasColumnName("IS_CAMBIO_MODELO");

                entity.Property(e => e.IsErrorSerie).HasColumnName("IS_ERROR_SERIE");

                entity.Property(e => e.IsGprs).HasColumnName("IS_GPRS");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.Property(e => e.IsNullAplicativo).HasColumnName("IS_NULL_APLICATIVO");

                entity.Property(e => e.IsNullCliente).HasColumnName("IS_NULL_CLIENTE");

                entity.Property(e => e.IsNullConectividad).HasColumnName("IS_NULL_CONECTIVIDAD");

                entity.Property(e => e.IsNullNoImei).HasColumnName("IS_NULL_NO_IMEI");

                entity.Property(e => e.IsNullNoSerie).HasColumnName("IS_NULL_NO_SERIE");

                entity.Property(e => e.IsNullNoSim).HasColumnName("IS_NULL_NO_SIM");

                entity.Property(e => e.IsNullNueva).HasColumnName("IS_NULL_NUEVA");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.IsReingreso).HasColumnName("IS_REINGRESO");

                entity.Property(e => e.MsgErrorSerie)
                    .HasColumnName("MSG_ERROR_SERIE")
                    .IsUnicode(false);

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdTransacciones>(entity =>
            {
                entity.HasKey(e => e.IdTransacciones);

                entity.ToTable("BD_TRANSACCIONES");

                entity.HasIndex(e => e.NoFiliacion)
                    .HasName("IX_BD_TRANSACCIONES_2");

                entity.HasIndex(e => new { e.Month, e.Year, e.NoFiliacion })
                    .HasName("IX_BD_TRANSACCIONES_1")
                    .IsUnique();

                entity.Property(e => e.IdTransacciones).HasColumnName("ID_TRANSACCIONES");

                entity.Property(e => e.ApprovedcCount).HasColumnName("APPROVEDC_COUNT");

                entity.Property(e => e.Declinedcount).HasColumnName("DECLINEDCOUNT");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NoFiliacion).HasColumnName("NO_FILIACION");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdTransaccionesPaso>(entity =>
            {
                entity.HasKey(e => e.IdTransaccionesPaso);

                entity.ToTable("BD_TRANSACCIONES_PASO");

                entity.Property(e => e.IdTransaccionesPaso).HasColumnName("ID_TRANSACCIONES_PASO");

                entity.Property(e => e.ApprovedcCount).HasColumnName("APPROVEDC_COUNT");

                entity.Property(e => e.Declinedcount).HasColumnName("DECLINEDCOUNT");

                entity.Property(e => e.DescError)
                    .HasColumnName("DESC_ERROR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IsError).HasColumnName("IS_ERROR");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NoAfiliacion).HasColumnName("NO_AFILIACION");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<BdTransferencias>(entity =>
            {
                entity.HasKey(e => e.IdTransferencia)
                    .HasName("PK__BD_TRANS__20A04596E971E01A");

                entity.ToTable("BD_TRANSFERENCIAS");

                entity.Property(e => e.IdTransferencia).HasColumnName("ID_TRANSFERENCIA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdStatusTransferencia).HasColumnName("ID_STATUS_TRANSFERENCIA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemFilename)
                    .HasColumnName("SYSTEM_FILENAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserFilename)
                    .HasColumnName("USER_FILENAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdTransferenciasPaso>(entity =>
            {
                entity.HasKey(e => e.IdTransferenciaPaso)
                    .HasName("PK__BD_TRANS__BEB61D8067319EBB");

                entity.ToTable("BD_TRANSFERENCIAS_PASO");

                entity.HasIndex(e => new { e.IdTransferenciaPaso, e.NoSerie, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdTipoResponsableDestino, e.IdResponsableDestino, e.IdUsuario, e.IdTransferencia })
                    .HasName("missing_index_278_277");

                entity.Property(e => e.IdTransferenciaPaso).HasColumnName("ID_TRANSFERENCIA_PASO");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdTransferencia).HasColumnName("ID_TRANSFERENCIA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdTransferenciasUnidad>(entity =>
            {
                entity.HasKey(e => e.IdTransferenciaUnidad)
                    .HasName("PK__BD_TRANS__27E50C086838334E");

                entity.ToTable("BD_TRANSFERENCIAS_UNIDAD");

                entity.HasIndex(e => new { e.IdTransferencia, e.IdUnidad })
                    .HasName("missing_index_3682_3681");

                entity.HasIndex(e => new { e.IdTransferencia, e.IdUnidad, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdResponsableDestino, e.IsRecibido, e.IdTipoResponsableDestino })
                    .HasName("missing_index_280_279");

                entity.Property(e => e.IdTransferenciaUnidad).HasColumnName("ID_TRANSFERENCIA_UNIDAD");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecibido)
                    .HasColumnName("FEC_RECIBIDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdResponsableDestino).HasColumnName("ID_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdResponsableOrigen).HasColumnName("ID_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdTipoResponsableDestino).HasColumnName("ID_TIPO_RESPONSABLE_DESTINO");

                entity.Property(e => e.IdTipoResponsableOrigen).HasColumnName("ID_TIPO_RESPONSABLE_ORIGEN");

                entity.Property(e => e.IdTransferencia).HasColumnName("ID_TRANSFERENCIA");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IsRecibido).HasColumnName("IS_RECIBIDO");
            });

            modelBuilder.Entity<BdUnidadAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdUnidadAccesorio);

                entity.ToTable("BD_UNIDAD_ACCESORIO");

                entity.HasIndex(e => e.IdUnidad);

                entity.Property(e => e.IdUnidadAccesorio).HasColumnName("ID_UNIDAD_ACCESORIO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAccesorio).HasColumnName("ID_ACCESORIO");

                entity.Property(e => e.IdStatusAccesorio).HasColumnName("ID_STATUS_ACCESORIO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAccesorioNavigation)
                    .WithMany(p => p.BdUnidadAccesorio)
                    .HasForeignKey(d => d.IdAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_ACCESORIO_C_ACCESORIOS");

                entity.HasOne(d => d.IdStatusAccesorioNavigation)
                    .WithMany(p => p.BdUnidadAccesorio)
                    .HasForeignKey(d => d.IdStatusAccesorio)
                    .HasConstraintName("FK_BD_UNIDAD_ACCESORIO_C_STATUS_ACCESORIO");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdUnidadAccesorio)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_ACCESORIO_BD_UNIDADES");
            });

            modelBuilder.Entity<BdUnidades>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.ToTable("BD_UNIDADES");

                entity.HasIndex(e => e.IdItemsSolicitudAlmacen)
                    .HasName("IX_MI_BD_UNIDADES_3420_3419");

                entity.HasIndex(e => e.IdModelo);

                entity.HasIndex(e => e.IdParent);

                entity.HasIndex(e => e.IdProducto);

                entity.HasIndex(e => e.IdResponsable);

                entity.HasIndex(e => e.IdStatusUnidad);

                entity.HasIndex(e => e.IdTipoResponsable);

                entity.HasIndex(e => e.NoInventario);

                entity.HasIndex(e => e.NoSerie)
                    .IsUnique();

                entity.HasIndex(e => e.NoSim)
                    .HasName("IX_MI_BD_UNIDADES_36101_36100");

                entity.HasIndex(e => new { e.IdProducto, e.IdMarca })
                    .HasName("IX_MI_BD_UNIDADES_1945_1944");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.Status })
                    .HasName("IX_BD_UNIDADES_ID_SOLICITUD_RECOLECCION, STATUS");

                entity.HasIndex(e => new { e.IdStatusUnidad, e.Status })
                    .HasName("IX_BD_UNIDADES_ID_STATUS_UNIDAD, STATUS");

                entity.HasIndex(e => new { e.IdTipoResponsable, e.IdResponsable })
                    .HasName("IX_MI_BD_UNIDADES_8869_8868");

                entity.HasIndex(e => new { e.IdTipoResponsable, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_BD_UNIDADES_ID_TIPO_RESPONSABLE, ID_RESPONSABLE, ID_STATUS_UNIDAD");

                entity.HasIndex(e => new { e.IdMarca, e.IdModelo, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_BD_UNIDADES_ID_MARCA, ID_MODELO, ID_RESPONSABLE, ID_STATUS_UNIDAD");

                entity.HasIndex(e => new { e.IdTipoResponsable, e.IdResponsable, e.IdStatusUnidad, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_6_5");

                entity.HasIndex(e => new { e.IdCliente, e.IdMarca, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada })
                    .HasName("IX_BD_UNIDADES_ID_CLIENTE, ID_MARCA, ID_TIPO_RESPONSABLE, ID_RESPONSABLE, IS_DANIADA");

                entity.HasIndex(e => new { e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_30715_30714");

                entity.HasIndex(e => new { e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.IsRetiro, e.IdStatusUnidad, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_4166_4165");

                entity.HasIndex(e => new { e.IdMarca, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada, e.Status, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_22355_22354");

                entity.HasIndex(e => new { e.IdCliente, e.IdMarca, e.IdModelo, e.IdTipoResponsable, e.IsDaniada, e.IdStatusUnidad, e.IdResponsable })
                    .HasName("IX_MI_BD_UNIDADES_3434_3433");

                entity.HasIndex(e => new { e.IdCliente, e.IdProducto, e.IdResponsable, e.IsDaniada, e.IdStatusUnidad, e.IdUnidad, e.IdTipoResponsable, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_413_412");

                entity.HasIndex(e => new { e.IdStatusUnidad, e.IdUnidad, e.IdCliente, e.IdProducto, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_415_414");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.IsDaniada, e.IdStatusUnidad, e.IsRetiro, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_64248_64247");

                entity.HasIndex(e => new { e.NoImei, e.IsDaniada, e.IdStatusUnidad, e.IdUnidad, e.IdCliente, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdProducto, e.IsRetiro, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_64246_64245");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.Status })
                    .HasName("IX_BD_UNIDADES_STATUS");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.NoSerie, e.NoInventario, e.NoImei, e.PosicionInventario, e.FecAlta, e.IdCliente, e.IdMarca, e.IdModelo, e.IdTipoResponsable, e.IsDaniada, e.Status, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_82332_82331");

                entity.HasIndex(e => new { e.NoSerie, e.NoInventario, e.NoImei, e.PosicionInventario, e.FecAlta, e.IdUnidad, e.IdProducto, e.IdModelo, e.IdCliente, e.IdMarca, e.IdTipoResponsable, e.IsDaniada, e.Status, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_187660_187659");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.PosicionInventario, e.IsDaniada, e.FecAlta, e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.IsRetiro, e.IdStatusUnidad, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_4171_4170");

                entity.HasIndex(e => new { e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdSim, e.NoImei, e.NoSim, e.IdResponsable, e.IdCliente, e.Status })
                    .HasName("IX_BD_UNIDADES_ID_CLIENTE, STATUS");

                entity.HasIndex(e => new { e.IdUnidad, e.FecAlta, e.IdNivelDiagnostico, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdSim, e.IdCliente, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_81_80");

                entity.HasIndex(e => new { e.IdUnidad, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IdStatusUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdCliente, e.Status, e.IdAplicativo, e.IdConectividad, e.IdTipoResponsable })
                    .HasName("missing_index_3944_3943");

                entity.HasIndex(e => new { e.NoInventario, e.IdSim, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IdUnidad, e.IdCliente, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdNivelDiagnostico, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_83_82");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IsNueva, e.PosicionInventario, e.IsRetiro, e.IsDaniada, e.FecAlta, e.IdAplicativo, e.IdConectividad, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.IdResponsable, e.IdTipoResponsable, e.IdStatusUnidad, e.Status })
                    .HasName("missing_index_2282_2281");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.Caja)
                    .HasColumnName("CAJA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Comentarios)
                    .HasColumnName("COMENTARIOS")
                    .IsUnicode(false);

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("FEC_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVencimientoKernel)
                    .HasColumnName("FECHA_VENCIMIENTO_KERNEL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FolioTelmex)
                    .HasColumnName("FOLIO_TELMEX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdFabricante).HasColumnName("ID_FABRICANTE");

                entity.Property(e => e.IdItemsSolicitudAlmacen).HasColumnName("ID_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdNivelDiagnostico).HasColumnName("ID_NIVEL_DIAGNOSTICO");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.IdTecnicoEnviadaScrap).HasColumnName("ID_TECNICO_ENVIADA_SCRAP");

                entity.Property(e => e.IdTipoConexion).HasColumnName("ID_TIPO_CONEXION");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdTipoTerminal).HasColumnName("ID_TIPO_TERMINAL");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsDato).HasColumnName("IS_DATO");

                entity.Property(e => e.IsDiagnosticada).HasColumnName("IS_DIAGNOSTICADA");

                entity.Property(e => e.IsFacturable).HasColumnName("IS_FACTURABLE");

                entity.Property(e => e.IsGarantia).HasColumnName("IS_GARANTIA");

                entity.Property(e => e.IsInternacional).HasColumnName("IS_INTERNACIONAL");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.Property(e => e.IsPropiedadCliente).HasColumnName("IS_PROPIEDAD_CLIENTE");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.IsVenta).HasColumnName("IS_VENTA");

                entity.Property(e => e.MotivoEnviadaScrap)
                    .HasColumnName("MOTIVO_ENVIADA_SCRAP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoEquipo)
                    .HasColumnName("NO_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerie)
                    .IsRequired()
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoTarima)
                    .HasColumnName("NO_TARIMA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionInventario)
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo)
                    .HasColumnName("purchase_order_no")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VersionKernel)
                    .HasColumnName("VERSION_KERNEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vigencia)
                    .HasColumnName("VIGENCIA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BdUnidadesNoReportadas>(entity =>
            {
                entity.HasKey(e => e.IdUnidadNoReportada);

                entity.ToTable("BD_UNIDADES_NO_REPORTADAS");

                entity.Property(e => e.IdUnidadNoReportada).HasColumnName("ID_UNIDAD_NO_REPORTADA");

                entity.Property(e => e.IdAuditoriaReporte).HasColumnName("ID_AUDITORIA_REPORTE");

                entity.Property(e => e.IdStatusSerie).HasColumnName("ID_STATUS_SERIE");

                entity.Property(e => e.NoSerieNoReportado)
                    .HasColumnName("NO_SERIE_NO_REPORTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAuditoriaReporteNavigation)
                    .WithMany(p => p.BdUnidadesNoReportadas)
                    .HasForeignKey(d => d.IdAuditoriaReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDADES_NO_REPORTADAS_BD_AUDITORIA_REPORTE");
            });

            modelBuilder.Entity<BdUnidadesPasoTest>(entity =>
            {
                entity.HasKey(e => e.IdUnidadPasoTest)
                    .HasName("PK__BD_UNIDA__33C276C900238AC8");

                entity.ToTable("BD_UNIDADES_PASO_TEST");

                entity.Property(e => e.IdUnidadPasoTest).HasColumnName("ID_UNIDAD_PASO_TEST");

                entity.Property(e => e.IdAplicativo).HasColumnName("ID_APLICATIVO");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesPorRecibirAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdRecepcion);

                entity.ToTable("BD_UNIDADES_POR_RECIBIR_ALMACEN");

                entity.HasIndex(e => new { e.NoSerie, e.IdJefeAlmacen })
                    .HasName("IX_MI_BD_UNIDADES_POR_RECIBIR_ALMACEN_7196_7195");

                entity.HasIndex(e => new { e.IdRecepcion, e.NoSerie, e.IdJefeAlmacen, e.IsProcesada })
                    .HasName("IX_BD_UNIDADES_POR_RECIBIR_ALMACEN_ID_JEFE_ALMACEN, IS_PROCESADA");

                entity.Property(e => e.IdRecepcion).HasColumnName("ID_RECEPCION");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdJefeAlmacen).HasColumnName("ID_JEFE_ALMACEN");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.NoSerie)
                    .IsRequired()
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionInventario)
                    .IsRequired()
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesProcesadasAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdUnidadProcesadaAlmacen)
                    .HasName("PK__BD_UNIDA__8006DB168CAAACE5");

                entity.ToTable("BD_UNIDADES_PROCESADAS_ALMACEN");

                entity.Property(e => e.IdUnidadProcesadaAlmacen).HasColumnName("ID_UNIDAD_PROCESADA_ALMACEN");

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Success)
                    .HasColumnName("SUCCESS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesRefaccionesAlta>(entity =>
            {
                entity.HasKey(e => e.IdUnidadRefaccionAlta)
                    .HasName("PK_BD_REFACCIONES_ALTA");

                entity.ToTable("BD_UNIDADES_REFACCIONES_ALTA");

                entity.Property(e => e.IdUnidadRefaccionAlta).HasColumnName("ID_UNIDAD_REFACCION_ALTA");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsDatoNulo)
                    .HasColumnName("IS_DATO_NULO")
                    .HasMaxLength(10);

                entity.Property(e => e.IsListaNoSerieDuplicada).HasColumnName("IS_LISTA_NO_SERIE_DUPLICADA");

                entity.Property(e => e.IsNoSerieDuplicada).HasColumnName("IS_NO_SERIE_DUPLICADA");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.IsPropiedadCliente).HasColumnName("IS_PROPIEDAD_CLIENTE");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.NecesitaCostoOIdMoneda).HasColumnName("NECESITA_COSTO_O_ID_MONEDA");

                entity.Property(e => e.NoEquipo)
                    .HasColumnName("NO_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerie)
                    .IsRequired()
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionInventario)
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesReportadas>(entity =>
            {
                entity.HasKey(e => e.IdUnidadReportada);

                entity.ToTable("BD_UNIDADES_REPORTADAS");

                entity.Property(e => e.IdUnidadReportada).HasColumnName("ID_UNIDAD_REPORTADA");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DestinoEnvio)
                    .HasColumnName("DESTINO_ENVIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Existe).HasColumnName("EXISTE");

                entity.Property(e => e.FecEnvio)
                    .HasColumnName("FEC_ENVIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecUltimoStatus)
                    .HasColumnName("FEC_ULTIMO_STATUS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guia)
                    .HasColumnName("GUIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdAuditoriaReporte).HasColumnName("ID_AUDITORIA_REPORTE");

                entity.Property(e => e.IdEnvio).HasColumnName("ID_ENVIO");

                entity.Property(e => e.IdStatusSerie).HasColumnName("ID_STATUS_SERIE");

                entity.Property(e => e.IsDuplicada).HasColumnName("IS_DUPLICADA");

                entity.Property(e => e.NoDiasTransito).HasColumnName("NO_DIAS_TRANSITO");

                entity.Property(e => e.NoSerieReportado)
                    .HasColumnName("NO_SERIE_REPORTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pertenece).HasColumnName("PERTENECE");

                entity.Property(e => e.Responsable)
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAuditoriaReporteNavigation)
                    .WithMany(p => p.BdUnidadesReportadas)
                    .HasForeignKey(d => d.IdAuditoriaReporte)
                    .HasConstraintName("FK_BD_UNIDADES_REPORTADAS_BD_UNIDADES_REPORTADAS");
            });

            modelBuilder.Entity<BdUpdateIsContractNegocios>(entity =>
            {
                entity.HasKey(e => e.IdUpdateIsContractNegocios);

                entity.ToTable("BD_UPDATE_IS_CONTRACT_NEGOCIOS");

                entity.Property(e => e.IdUpdateIsContractNegocios).HasColumnName("ID_UPDATE_IS_CONTRACT_NEGOCIOS");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_NEGOCIO");
            });

            modelBuilder.Entity<BdUploadDhl>(entity =>
            {
                entity.HasKey(e => e.IdUploadDhl)
                    .HasName("PK__BD_UPLOA__7B20E2120FAE9EDF");

                entity.ToTable("BD_UPLOAD_DHL");

                entity.Property(e => e.IdUploadDhl).HasColumnName("ID_UPLOAD_DHL");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdUploadEstafeta>(entity =>
            {
                entity.HasKey(e => e.IdUploadEstafeta)
                    .HasName("PK__BD_UPLOA__536D36A397F27C8A");

                entity.ToTable("BD_UPLOAD_ESTAFETA");

                entity.Property(e => e.IdUploadEstafeta).HasColumnName("ID_UPLOAD_ESTAFETA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            });

            modelBuilder.Entity<BdUsuarioAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioAlmacen);

                entity.ToTable("BD_USUARIO_ALMACEN");

                entity.HasIndex(e => e.IdAlmacen);

                entity.HasIndex(e => e.IdUsuario);

                entity.Property(e => e.IdUsuarioAlmacen).HasColumnName("ID_USUARIO_ALMACEN");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdUsuarioArchivosVarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioArchivosVarios);

                entity.ToTable("BD_USUARIO_ARCHIVOS_VARIOS");

                entity.Property(e => e.IdUsuarioArchivosVarios).HasColumnName("ID_USUARIO_ARCHIVOS_VARIOS");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaStatus)
                    .HasColumnName("FECHA_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTipoArchivo).HasColumnName("ID_TIPO_ARCHIVO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreArchivoSistema)
                    .HasColumnName("NOMBRE_ARCHIVO_SISTEMA")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoUsuario)
                    .HasColumnName("NOMBRE_ARCHIVO_USUARIO")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdUsuarioCelular>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioCelular);

                entity.ToTable("BD_USUARIO_CELULAR");

                entity.Property(e => e.IdUsuarioCelular).HasColumnName("ID_USUARIO_CELULAR");

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecFinPlan)
                    .HasColumnName("FEC_FIN_PLAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIniPlan)
                    .HasColumnName("FEC_INI_PLAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModeloCelular).HasColumnName("ID_MODELO_CELULAR");

                entity.Property(e => e.IdTipoPlan).HasColumnName("ID_TIPO_PLAN");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdUsuarioCliente>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioCliente);

                entity.ToTable("BD_USUARIO_CLIENTE");

                entity.HasIndex(e => e.IdCliente);

                entity.HasIndex(e => e.IdUsuario);

                entity.HasIndex(e => new { e.IdUsuario, e.IdCliente })
                    .HasName("IX_MI_BD_USUARIO_CLIENTE_1922_1921");

                entity.Property(e => e.IdUsuarioCliente).HasColumnName("ID_USUARIO_CLIENTE");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdUsuarioProducto>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioProducto);

                entity.ToTable("BD_USUARIO_PRODUCTO");

                entity.HasIndex(e => e.IdProducto);

                entity.HasIndex(e => e.IdUsuario);

                entity.Property(e => e.IdUsuarioProducto).HasColumnName("ID_USUARIO_PRODUCTO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdUsuarioStatusUnidad>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioStatusUnidad)
                    .HasName("PK__BD_USUAR__D713569DB6312571");

                entity.ToTable("BD_USUARIO_STATUS_UNIDAD");

                entity.Property(e => e.IdUsuarioStatusUnidad).HasColumnName("ID_USUARIO_STATUS_UNIDAD");

                entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IsChecked).HasColumnName("IS_CHECKED");
            });

            modelBuilder.Entity<BdUsuarioTecnico>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioTecnico);

                entity.ToTable("BD_USUARIO_TECNICO");

                entity.Property(e => e.IdUsuarioTecnico).HasColumnName("ID_USUARIO_TECNICO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");
            });

            modelBuilder.Entity<BdUsuarioVistaEscalamiento>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioVistaEscalamiento);

                entity.ToTable("BD_USUARIO_VISTA_ESCALAMIENTO");

                entity.HasIndex(e => e.IdUsuario);

                entity.HasIndex(e => e.IdVistaEscalamiento);

                entity.Property(e => e.IdUsuarioVistaEscalamiento).HasColumnName("ID_USUARIO_VISTA_ESCALAMIENTO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdVistaEscalamiento).HasColumnName("ID_VISTA_ESCALAMIENTO");

                entity.HasOne(d => d.IdVistaEscalamientoNavigation)
                    .WithMany(p => p.BdUsuarioVistaEscalamiento)
                    .HasForeignKey(d => d.IdVistaEscalamiento)
                    .HasConstraintName("FK_BD_USUARIO_VISTA_ESCALAMIENTO_C_VISTAS_ESCALAMIENTO");
            });

            modelBuilder.Entity<BdUsuarioZona>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioZona);

                entity.ToTable("BD_USUARIO_ZONA");

                entity.HasIndex(e => e.IdRegion);

                entity.HasIndex(e => e.IdUsuario);

                entity.HasIndex(e => e.IdZona);

                entity.HasIndex(e => new { e.IdUsuario, e.IdZona })
                    .HasName("IX_MI_BD_USUARIO_ZONA_30337_30336");

                entity.HasIndex(e => new { e.IdUsuario, e.IdRegion, e.IdZona })
                    .HasName("IX_BD_USUARIO_ZONA_ID_REGION, ID_ZONA");

                entity.Property(e => e.IdUsuarioZona).HasColumnName("ID_USUARIO_ZONA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");
            });

            modelBuilder.Entity<BdVacaciones>(entity =>
            {
                entity.HasKey(e => e.IdVacaciones);

                entity.ToTable("BD_VACACIONES");

                entity.Property(e => e.IdVacaciones).HasColumnName("ID_VACACIONES");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("FEC_INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecSolicitud)
                    .HasColumnName("FEC_SOLICITUD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecTermina)
                    .HasColumnName("FEC_TERMINA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Periodo).HasColumnName("PERIODO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdVistaEscalamientoStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdVistaEscalamientoStatusAr)
                    .HasName("PK_BD_VISTA_ECALAMIENTO_STATUS_AR");

                entity.ToTable("BD_VISTA_ESCALAMIENTO_STATUS_AR");

                entity.Property(e => e.IdVistaEscalamientoStatusAr).HasColumnName("ID_VISTA_ESCALAMIENTO_STATUS_AR");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdVistaEscalamiento).HasColumnName("ID_VISTA_ESCALAMIENTO");

                entity.HasOne(d => d.IdVistaEscalamientoNavigation)
                    .WithMany(p => p.BdVistaEscalamientoStatusAr)
                    .HasForeignKey(d => d.IdVistaEscalamiento)
                    .HasConstraintName("FK_BD_VISTA_ESCALAMIENTO_STATUS_AR_C_STATUS_AR");
            });

            modelBuilder.Entity<BdWincorClientes>(entity =>
            {
                entity.HasKey(e => e.IdClienteWincor);

                entity.ToTable("BD_WINCOR_CLIENTES");

                entity.Property(e => e.IdClienteWincor).HasColumnName("ID_CLIENTE_WINCOR");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdWincorClientesServicios>(entity =>
            {
                entity.HasKey(e => e.IdClienteServicioWincor)
                    .HasName("PK_BD_WINCOR_CLIENTE_SERVICIO");

                entity.ToTable("BD_WINCOR_CLIENTES_SERVICIOS");

                entity.Property(e => e.IdClienteServicioWincor).HasColumnName("ID_CLIENTE_SERVICIO_WINCOR");

                entity.Property(e => e.IdClienteWincor).HasColumnName("ID_CLIENTE_WINCOR");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IdServicioWincor).HasColumnName("ID_SERVICIO_WINCOR");
            });

            modelBuilder.Entity<BdWincorServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicioWincor)
                    .HasName("PK_BD_WINCOR_PROYECTOS");

                entity.ToTable("BD_WINCOR_SERVICIOS");

                entity.Property(e => e.IdServicioWincor).HasColumnName("ID_SERVICIO_WINCOR");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdWorkload>(entity =>
            {
                entity.HasKey(e => e.IdWorkload);

                entity.ToTable("BD_WORKLOAD");

                entity.HasIndex(e => e.FecAlta);

                entity.Property(e => e.IdWorkload).HasColumnName("ID_WORKLOAD");

                entity.Property(e => e.BlkBy).IsUnicode(false);

                entity.Property(e => e.Command).IsUnicode(false);

                entity.Property(e => e.Cputime)
                    .HasColumnName("CPUTime")
                    .IsUnicode(false);

                entity.Property(e => e.Dbname)
                    .HasColumnName("DBName")
                    .IsUnicode(false);

                entity.Property(e => e.DiskIo)
                    .HasColumnName("DiskIO")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HostName).IsUnicode(false);

                entity.Property(e => e.LastBatch).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.ProgramName).IsUnicode(false);

                entity.Property(e => e.Requestid)
                    .HasColumnName("REQUESTID")
                    .IsUnicode(false);

                entity.Property(e => e.Spid)
                    .HasColumnName("SPID")
                    .IsUnicode(false);

                entity.Property(e => e.SpidUno)
                    .HasColumnName("SPID_UNO")
                    .IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdWsBancomer>(entity =>
            {
                entity.HasKey(e => e.IdTareaBancomer);

                entity.ToTable("BD_WS_BANCOMER");

                entity.HasIndex(e => e.TaskId);

                entity.HasIndex(e => new { e.IdTareaBancomer, e.TaskId, e.CreateDate, e.BbvaCrtDireccion, e.BbvaTsitio, e.BbvaCiAutoserv, e.Importado, e.Automatico, e.BbvaCtrAutoservicio, e.Summary, e.TaskType, e.TaskName, e.Priority, e.Urgency, e.BbvaCrtClaseAtm, e.Status })
                    .HasName("IX_BD_WS_BANCOMER_Status");

                entity.Property(e => e.IdTareaBancomer).HasColumnName("id_tarea_bancomer");

                entity.Property(e => e.AssigneeId)
                    .HasColumnName("Assignee_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Automatico).HasColumnName("automatico");

                entity.Property(e => e.BbvaCiAutoserv)
                    .HasColumnName("BBVA_CI_Autoserv")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BbvaCrtClaseAtm)
                    .HasColumnName("BBVA_CRT_Clase_ATM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BbvaCrtDireccion)
                    .HasColumnName("BBVA_CRT_Direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BbvaCtrAutoservicio)
                    .HasColumnName("BBVA_CTR_Autoservicio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BbvaNdc)
                    .HasColumnName("BBVA_NDC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BbvaNoSerie)
                    .HasColumnName("BBVA_No_Serie")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BbvaTsitio)
                    .HasColumnName("BBVA_Tsitio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Completion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecCarga)
                    .HasColumnName("FEC_CARGA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaEta)
                    .HasColumnName("Fecha_ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFinalizacion)
                    .HasColumnName("Fecha_Finalizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolioResolutor)
                    .HasColumnName("Folio_Resolutor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Importado).HasColumnName("importado");

                entity.Property(e => e.InstancedId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Justificacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("Last_Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaskId)
                    .HasColumnName("Task_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskNotes)
                    .HasColumnName("Task_Notes")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Urgency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Z1DStatusReasonDisplay)
                    .HasColumnName("z1D_StatusReasonDisplay")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdZonaCp>(entity =>
            {
                entity.HasKey(e => e.IdZonaCp);

                entity.ToTable("BD_ZONA_CP");

                entity.HasIndex(e => e.Cp)
                    .HasName("IX_BD_ZONA_CP");

                entity.HasIndex(e => e.IdZona);

                entity.Property(e => e.IdZonaCp).HasColumnName("ID_ZONA_CP");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");
            });

            modelBuilder.Entity<CAccesorios>(entity =>
            {
                entity.HasKey(e => e.IdAccesorio);

                entity.ToTable("C_ACCESORIOS");

                entity.Property(e => e.IdAccesorio).HasColumnName("ID_ACCESORIO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescAccesorio)
                    .HasColumnName("DESC_ACCESORIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CActasAdmin>(entity =>
            {
                entity.HasKey(e => e.IdTipoActaAdmin);

                entity.ToTable("C_ACTAS_ADMIN");

                entity.Property(e => e.IdTipoActaAdmin).HasColumnName("ID_TIPO_ACTA_ADMIN");

                entity.Property(e => e.DescActaAdmin)
                    .HasColumnName("DESC_ACTA_ADMIN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CAlmacenes>(entity =>
            {
                entity.HasKey(e => e.IdAlmacen);

                entity.ToTable("C_ALMACENES");

                entity.Property(e => e.IdAlmacen).HasColumnName("ID_ALMACEN");

                entity.Property(e => e.AutoNotif).HasColumnName("AUTO_NOTIF");

                entity.Property(e => e.DescAlmacen)
                    .HasColumnName("DESC_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250);

                entity.Property(e => e.EnvioEmail).HasColumnName("ENVIO_EMAIL");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsLab).HasColumnName("IS_LAB");

                entity.Property(e => e.IsPropiedadCliente).HasColumnName("IS_PROPIEDAD_CLIENTE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CArchivos>(entity =>
            {
                entity.HasKey(e => e.IdArchivo);

                entity.ToTable("C_ARCHIVOS");

                entity.Property(e => e.IdArchivo).HasColumnName("ID_ARCHIVO");

                entity.Property(e => e.DescArchivo)
                    .HasColumnName("DESC_ARCHIVO")
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsAlmacenMasivo).HasColumnName("IS_ALMACEN_MASIVO");

                entity.Property(e => e.IsCerradoExito).HasColumnName("IS_CERRADO_EXITO");

                entity.Property(e => e.IsEnvio).HasColumnName("IS_ENVIO");

                entity.Property(e => e.IsRecepcion).HasColumnName("IS_RECEPCION");

                entity.Property(e => e.NombreArchivo)
                    .HasColumnName("NOMBRE_ARCHIVO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CAreas>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.ToTable("C_AREAS");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.DescArea)
                    .HasColumnName("DESC_AREA")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdJefeArea).HasColumnName("ID_JEFE_AREA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CBbvaMicroformasServicios>(entity =>
            {
                entity.HasKey(e => e.IdBbva)
                    .HasName("PK__C_BBVA_M__705754273FA11A03");

                entity.ToTable("C_BBVA_MICROFORMAS_SERVICIOS");

                entity.Property(e => e.IdBbva).HasColumnName("ID_BBVA");

                entity.Property(e => e.DesservBbva)
                    .HasColumnName("DESSERV_BBVA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.TipoServicio)
                    .HasColumnName("TIPO_SERVICIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vim)
                    .HasColumnName("VIM")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CBitacoraAgendadosComentarios>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraAgendadosComentarios);

                entity.ToTable("C_BITACORA_AGENDADOS_COMENTARIOS");

                entity.Property(e => e.IdBitacoraAgendadosComentarios).HasColumnName("ID_BITACORA_AGENDADOS_COMENTARIOS");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCalifJunta>(entity =>
            {
                entity.HasKey(e => e.IdCalifJunta);

                entity.ToTable("C_CALIF_JUNTA");

                entity.Property(e => e.IdCalifJunta).HasColumnName("ID_CALIF_JUNTA");

                entity.Property(e => e.CalifJunta)
                    .HasColumnName("CALIF_JUNTA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdStatusJunta).HasColumnName("ID_STATUS_JUNTA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCarrier>(entity =>
            {
                entity.HasKey(e => e.IdCarrier);

                entity.ToTable("C_CARRIER");

                entity.Property(e => e.IdCarrier).HasColumnName("ID_CARRIER");

                entity.Property(e => e.Caracter)
                    .HasColumnName("CARACTER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaracterObligatorio).HasColumnName("CARACTER_OBLIGATORIO");

                entity.Property(e => e.DescCarrier)
                    .IsRequired()
                    .HasColumnName("DESC_CARRIER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DigitoVerificador).HasColumnName("DIGITO_VERIFICADOR");

                entity.Property(e => e.LetraMax).HasColumnName("LETRA_MAX");

                entity.Property(e => e.LetraMin).HasColumnName("LETRA_MIN");

                entity.Property(e => e.LongMax).HasColumnName("LONG_MAX");

                entity.Property(e => e.LongMin).HasColumnName("LONG_MIN");

                entity.Property(e => e.NumMax).HasColumnName("NUM_MAX");

                entity.Property(e => e.NumMin).HasColumnName("NUM_MIN");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__C_CATEGO__4BD51FA5239B33CE");

                entity.ToTable("C_CATEGORIA");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.DescCategoria)
                    .HasColumnName("DESC_CATEGORIA")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCategoriaValidaDispositivos>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaValidaDispositivos);

                entity.ToTable("C_CATEGORIA_VALIDA_DISPOSITIVOS");

                entity.Property(e => e.IdCategoriaValidaDispositivos).HasColumnName("ID_CATEGORIA_VALIDA_DISPOSITIVOS");

                entity.Property(e => e.DescIdentificador)
                    .HasColumnName("DESC_IDENTIFICADOR")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Identificador)
                    .HasColumnName("IDENTIFICADOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausaCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdCausaCancelacion)
                    .HasName("PK__C_CAUSA___D74935B60C901E7D");

                entity.ToTable("C_CAUSA_CANCELACION");

                entity.Property(e => e.IdCausaCancelacion).HasColumnName("ID_CAUSA_CANCELACION");

                entity.Property(e => e.DescCausaCancelacion)
                    .HasColumnName("DESC_CAUSA_CANCELACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausaCancelacionSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdCausaCancelacionSolicitudAlmacen);

                entity.ToTable("C_CAUSA_CANCELACION_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdCausaCancelacionSolicitudAlmacen).HasColumnName("ID_CAUSA_CANCELACION_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescCausaCancelacionSolicitudAlmacen)
                    .HasColumnName("DESC_CAUSA_CANCELACION_SOLICITUD_ALMACEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausaRetiro>(entity =>
            {
                entity.HasKey(e => e.IdCausaRetiro)
                    .HasName("PK__C_CAUSA___A118E7CB20DB452D");

                entity.ToTable("C_CAUSA_RETIRO");

                entity.Property(e => e.IdCausaRetiro).HasColumnName("ID_CAUSA_RETIRO");

                entity.Property(e => e.CausaRetiro)
                    .HasColumnName("CAUSA_RETIRO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausas>(entity =>
            {
                entity.HasKey(e => e.IdCausa);

                entity.ToTable("C_CAUSAS");

                entity.Property(e => e.IdCausa).HasColumnName("ID_CAUSA");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescCausa)
                    .HasColumnName("DESC_CAUSA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausasRechazo>(entity =>
            {
                entity.HasKey(e => e.IdCausaRechazo);

                entity.ToTable("C_CAUSAS_RECHAZO");

                entity.Property(e => e.IdCausaRechazo).HasColumnName("ID_CAUSA_RECHAZO");

                entity.Property(e => e.DescCausaRechazo)
                    .HasColumnName("DESC_CAUSA_RECHAZO")
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusReasonCode)
                    .HasColumnName("status_reason_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausasRechazoDefinitivoDoctoPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdCausaRechazoDefinitivoDoctoPrefacturacion);

                entity.ToTable("C_CAUSAS_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION");

                entity.Property(e => e.IdCausaRechazoDefinitivoDoctoPrefacturacion).HasColumnName("ID_CAUSA_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION");

                entity.Property(e => e.DescCausaRechazoDefinitivoDoctoPrefacturacion)
                    .HasColumnName("DESC_CAUSA_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCausasRechazoSegmento>(entity =>
            {
                entity.HasKey(e => e.IdCausaRechazoSegmento);

                entity.ToTable("C_CAUSAS_RECHAZO_SEGMENTO");

                entity.Property(e => e.IdCausaRechazoSegmento).HasColumnName("ID_CAUSA_RECHAZO_SEGMENTO");

                entity.Property(e => e.IdCausaRechazo).HasColumnName("ID_CAUSA_RECHAZO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");
            });

            modelBuilder.Entity<CChoferes>(entity =>
            {
                entity.HasKey(e => e.IdChofer);

                entity.ToTable("C_CHOFERES");

                entity.Property(e => e.IdChofer).HasColumnName("ID_CHOFER");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnName("MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnName("PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CClientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_BD_CLIENTES");

                entity.ToTable("C_CLIENTES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.CadenaWincor)
                    .HasColumnName("CADENA_WINCOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CentroCostos)
                    .HasColumnName("CENTRO_COSTOS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CharCodigoIntervencion)
                    .HasColumnName("CHAR_CODIGO_INTERVENCION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescCliente)
                    .HasColumnName("DESC_CLIENTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocTir)
                    .HasColumnName("DOC_TIR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAccess).HasColumnName("ID_ACCESS");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdTipoCalculoUptime)
                    .HasColumnName("ID_TIPO_CALCULO_UPTIME")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Is3X1).HasColumnName("IS_3_X_1");

                entity.Property(e => e.IsAddReplicate).HasColumnName("IS_ADD_REPLICATE");

                entity.Property(e => e.IsArUnico).HasColumnName("IS_AR_UNICO");

                entity.Property(e => e.IsArUpdatesNegocio)
                    .HasColumnName("IS_AR_UPDATES_NEGOCIO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAsignacionAuto).HasColumnName("IS_ASIGNACION_AUTO");

                entity.Property(e => e.IsAsignacionMasiva).HasColumnName("IS_ASIGNACION_MASIVA");

                entity.Property(e => e.IsCierreMasivo).HasColumnName("IS_CIERRE_MASIVO");

                entity.Property(e => e.IsElavon).HasColumnName("IS_ELAVON");

                entity.Property(e => e.IsEmailServiceCharge).HasColumnName("IS_EMAIL_SERVICE_CHARGE");

                entity.Property(e => e.IsFacturacionAutomatica).HasColumnName("IS_FACTURACION_AUTOMATICA");

                entity.Property(e => e.IsFacturacionIguala).HasColumnName("IS_FACTURACION_IGUALA");

                entity.Property(e => e.IsFecGarantiaChange).HasColumnName("IS_FEC_GARANTIA_CHANGE");

                entity.Property(e => e.IsFecInicioDefault).HasColumnName("IS_FEC_INICIO_DEFAULT");

                entity.Property(e => e.IsIdReq)
                    .HasColumnName("IS_ID_REQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsInterfazSantander).HasColumnName("IS_INTERFAZ_SANTANDER");

                entity.Property(e => e.IsLab)
                    .HasColumnName("IS_LAB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsModFecCita).HasColumnName("is_mod_fec_cita");

                entity.Property(e => e.IsModifiedAr).HasColumnName("IS_MODIFIED_AR");

                entity.Property(e => e.IsNumericNoAfiliacion)
                    .HasColumnName("IS_NUMERIC_NO_AFILIACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNumericNoAr)
                    .HasColumnName("IS_NUMERIC_NO_AR")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOneUnidad).HasColumnName("IS_ONE_UNIDAD");

                entity.Property(e => e.IsPagoEvento).HasColumnName("IS_PAGO_EVENTO");

                entity.Property(e => e.IsPagoIguala).HasColumnName("IS_PAGO_IGUALA");

                entity.Property(e => e.IsPendienteParte).HasColumnName("IS_PENDIENTE_PARTE");

                entity.Property(e => e.IsPrecioDoble).HasColumnName("IS_PRECIO_DOBLE");

                entity.Property(e => e.IsPrefacturacion)
                    .HasColumnName("IS_PREFACTURACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReparaciones)
                    .HasColumnName("IS_REPARACIONES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReporteAr)
                    .HasColumnName("IS_REPORTE_AR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRetipificados)
                    .HasColumnName("IS_RETIPIFICADOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRetornoAccesorios).HasColumnName("IS_RETORNO_ACCESORIOS");

                entity.Property(e => e.IsSegmentoDelimitador).HasColumnName("IS_SEGMENTO_DELIMITADOR");

                entity.Property(e => e.IsSendHistory).HasColumnName("IS_SEND_HISTORY");

                entity.Property(e => e.IsSingleMovInv)
                    .HasColumnName("IS_SINGLE_MOV_INV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSustitucionNoNeeded).HasColumnName("IS_SUSTITUCION_NO_NEEDED");

                entity.Property(e => e.IsTimeNeeded).HasColumnName("IS_TIME_NEEDED");

                entity.Property(e => e.IsUnidadAtendidaRequired)
                    .HasColumnName("IS_UNIDAD_ATENDIDA_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUptime)
                    .HasColumnName("IS_UPTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsValidaTir).HasColumnName("IS_VALIDA_TIR");

                entity.Property(e => e.IsVisitaCobrable)
                    .HasColumnName("IS_VISITA_COBRABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWincor)
                    .HasColumnName("IS_WINCOR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWincorTiempo).HasColumnName("IS_WINCOR_TIEMPO");

                entity.Property(e => e.NoPoliticaViaticos).HasColumnName("NO_POLITICA_VIATICOS");

                entity.Property(e => e.PorRechazo)
                    .HasColumnName("POR_RECHAZO")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorUptime)
                    .HasColumnName("POR_UPTIME")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((99.7))");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoCalculoUptimeNavigation)
                    .WithMany(p => p.CClientes)
                    .HasForeignKey(d => d.IdTipoCalculoUptime)
                    .HasConstraintName("FK_C_CLIENTES_C_TIPO_CALCULO_UPTIME");
            });

            modelBuilder.Entity<CClientesPmo>(entity =>
            {
                entity.HasKey(e => e.IdClienteProducto);

                entity.ToTable("C_CLIENTES_PMO");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IX_C_CLIENTES_PMO")
                    .IsUnique();

                entity.HasIndex(e => e.IdProducto)
                    .HasName("IX_C_CLIENTES_PMO_2");

                entity.HasIndex(e => new { e.IdCliente, e.IdProducto })
                    .HasName("IX_C_CLIENTES_PMO_1");

                entity.Property(e => e.IdClienteProducto).HasColumnName("ID_CLIENTE_PRODUCTO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CCodigosIntervencionNivel0>(entity =>
            {
                entity.HasKey(e => e.IdCodigoNivel0);

                entity.ToTable("C_CODIGOS_INTERVENCION_NIVEL0");

                entity.Property(e => e.IdCodigoNivel0).HasColumnName("ID_CODIGO_NIVEL0");

                entity.Property(e => e.ClaveCodigo)
                    .HasColumnName("CLAVE_CODIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescCodigo)
                    .HasColumnName("DESC_CODIGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoMedida).HasColumnName("ID_TIPO_MEDIDA");

                entity.Property(e => e.ReportaInstalacion).HasColumnName("REPORTA_INSTALACION");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCodigosIntervencionNivel1>(entity =>
            {
                entity.HasKey(e => e.IdCodigoNivel1);

                entity.ToTable("C_CODIGOS_INTERVENCION_NIVEL1");

                entity.Property(e => e.IdCodigoNivel1).HasColumnName("ID_CODIGO_NIVEL1");

                entity.Property(e => e.ClaveCodigo)
                    .HasColumnName("CLAVE_CODIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescCodigo)
                    .HasColumnName("DESC_CODIGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdParentNivel0).HasColumnName("ID_PARENT_NIVEL0");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdParentNivel0Navigation)
                    .WithMany(p => p.CCodigosIntervencionNivel1)
                    .HasForeignKey(d => d.IdParentNivel0)
                    .HasConstraintName("FK_C_CODIGOS_INTERVENCION_NIVEL1_C_CODIGOS_INTERVENCION_NIVEL0");
            });

            modelBuilder.Entity<CCodigosIntervencionNivel2>(entity =>
            {
                entity.HasKey(e => e.IdCodigoNivel2);

                entity.ToTable("C_CODIGOS_INTERVENCION_NIVEL2");

                entity.Property(e => e.IdCodigoNivel2).HasColumnName("ID_CODIGO_NIVEL2");

                entity.Property(e => e.ClaveCodigo)
                    .HasColumnName("CLAVE_CODIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescCodigo)
                    .HasColumnName("DESC_CODIGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdParentNivel0).HasColumnName("ID_PARENT_NIVEL0");

                entity.Property(e => e.IdParentNivel1).HasColumnName("ID_PARENT_NIVEL1");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CConceptoAr>(entity =>
            {
                entity.HasKey(e => e.IdConcepto);

                entity.ToTable("C_CONCEPTO_AR");

                entity.Property(e => e.IdConcepto).HasColumnName("ID_CONCEPTO");

                entity.Property(e => e.DescripcionConceptoAr)
                    .HasColumnName("DESCRIPCION_CONCEPTO_AR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CConceptosPmo>(entity =>
            {
                entity.HasKey(e => e.IdConceptosPmo);

                entity.ToTable("C_CONCEPTOS_PMO");

                entity.HasIndex(e => new { e.DescConcepto, e.IdTipoConcepto, e.IdAplica })
                    .HasName("IX_C_CONCEPTOS_PMO")
                    .IsUnique();

                entity.Property(e => e.IdConceptosPmo).HasColumnName("ID_CONCEPTOS_PMO");

                entity.Property(e => e.DescConcepto)
                    .HasColumnName("DESC_CONCEPTO")
                    .HasMaxLength(40);

                entity.Property(e => e.IdAplica).HasColumnName("ID_APLICA");

                entity.Property(e => e.IdTipoConcepto).HasColumnName("ID_TIPO_CONCEPTO");
            });

            modelBuilder.Entity<CConectividad>(entity =>
            {
                entity.HasKey(e => e.IdConectividad)
                    .HasName("PK__C_CONECT__890C867F684A2BA3");

                entity.ToTable("C_CONECTIVIDAD");

                entity.Property(e => e.IdConectividad).HasColumnName("ID_CONECTIVIDAD");

                entity.Property(e => e.DescConectividad)
                    .HasColumnName("DESC_CONECTIVIDAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsConjunto).HasColumnName("IS_CONJUNTO");

                entity.Property(e => e.IsGprs).HasColumnName("IS_GPRS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CConsumibles>(entity =>
            {
                entity.HasKey(e => e.IdConsumible);

                entity.ToTable("C_CONSUMIBLES");

                entity.Property(e => e.IdConsumible).HasColumnName("ID_CONSUMIBLE");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescConsumible)
                    .IsRequired()
                    .HasColumnName("DESC_CONSUMIBLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaStatus)
                    .HasColumnName("FECHA_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modulo)
                    .HasColumnName("MODULO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoParte)
                    .HasColumnName("NO_PARTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCpDarBbva94>(entity =>
            {
                entity.HasKey(e => e.IdCp)
                    .HasName("PK__C_CP_DAR__8B622F9B96D5D183");

                entity.ToTable("C_CP_DAR_BBVA_94");

                entity.Property(e => e.IdCp).HasColumnName("ID_CP");

                entity.Property(e => e.DAsenta)
                    .HasColumnName("D_ASENTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DCiudad)
                    .HasColumnName("D_CIUDAD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DCodigo).HasColumnName("D_CODIGO");

                entity.Property(e => e.DCodigoNum).HasColumnName("D_CODIGO_NUM");

                entity.Property(e => e.DEstado)
                    .HasColumnName("D_ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DMunicipio)
                    .HasColumnName("D_MUNICIPIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DTipoAsenta)
                    .HasColumnName("D_TIPO_ASENTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DarOrigen)
                    .HasColumnName("DAR_ORIGEN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Div)
                    .HasColumnName("DIV")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Respaldo)
                    .HasColumnName("RESPALDO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CCpProsa>(entity =>
            {
                entity.HasKey(e => e.IdCpProsa);

                entity.ToTable("C_CP_PROSA");

                entity.Property(e => e.IdCpProsa).HasColumnName("ID_CP_PROSA");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(100);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(30);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.FechaCarga)
                    .HasColumnName("FECHA_CARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(60);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(60);

                entity.Property(e => e.Zona).HasColumnName("ZONA");
            });

            modelBuilder.Entity<CDescripcionTrabajo>(entity =>
            {
                entity.HasKey(e => e.IdDescripcionTrabajo);

                entity.ToTable("C_DESCRIPCION_TRABAJO");

                entity.Property(e => e.IdDescripcionTrabajo).HasColumnName("ID_DESCRIPCION_TRABAJO");

                entity.Property(e => e.DescTrabajo)
                    .HasColumnName("DESC_TRABAJO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdEspecifTipoFalla).HasColumnName("ID_ESPECIF_TIPO_FALLA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CDesviaciones>(entity =>
            {
                entity.HasKey(e => e.IdDesviacion);

                entity.ToTable("C_DESVIACIONES");

                entity.HasIndex(e => new { e.IdDesviacion, e.IdCliente, e.IdResponsable, e.Status, e.IsAdministradorLogistico })
                    .HasName("IX_MI_C_DESVIACIONES_61_60");

                entity.HasIndex(e => new { e.IdDesviacion, e.IdResponsable, e.IdCliente, e.Status, e.IsAdministradorLogistico })
                    .HasName("IX_MI_C_DESVIACIONES_59_58");

                entity.Property(e => e.IdDesviacion).HasColumnName("ID_DESVIACION");

                entity.Property(e => e.DescDesviacion)
                    .HasColumnName("DESC_DESVIACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAdministradorLogistico).HasColumnName("IS_ADMINISTRADOR_LOGISTICO");

                entity.Property(e => e.IsDesviacionTemp).HasColumnName("IS_DESVIACION_TEMP");

                entity.Property(e => e.IsLaboratorio).HasColumnName("IS_LABORATORIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CDirecciones>(entity =>
            {
                entity.HasKey(e => e.IdDirecciones);

                entity.ToTable("C_DIRECCIONES");

                entity.Property(e => e.IdDirecciones).HasColumnName("ID_DIRECCIONES");

                entity.Property(e => e.DescDireccion)
                    .HasColumnName("DESC_DIRECCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdDireccionesJefe).HasColumnName("ID_DIRECCIONES_JEFE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CDocsTir>(entity =>
            {
                entity.HasKey(e => e.IdDocsTir);

                entity.ToTable("C_DOCS_TIR");

                entity.Property(e => e.IdDocsTir).HasColumnName("ID_DOCS_TIR");

                entity.Property(e => e.DescDoc)
                    .HasColumnName("DESC_DOC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocTir)
                    .HasColumnName("DOC_TIR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CDominiosEmail>(entity =>
            {
                entity.HasKey(e => e.IdDominioEmail);

                entity.ToTable("C_DOMINIOS_EMAIL");

                entity.Property(e => e.IdDominioEmail).HasColumnName("ID_DOMINIO_EMAIL");

                entity.Property(e => e.DescDominioEmail)
                    .HasColumnName("DESC_DOMINIO_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CElavonSantanderServicios>(entity =>
            {
                entity.HasKey(e => e.IdElavon)
                    .HasName("PK__C_ELAVON__5597FC3F896F8739");

                entity.ToTable("C_ELAVON_SANTANDER_SERVICIOS");

                entity.Property(e => e.IdElavon).HasColumnName("ID_ELAVON");

                entity.Property(e => e.DescServicioElavon)
                    .HasColumnName("DESC_SERVICIO_ELAVON")
                    .IsUnicode(false);

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IsReparado).HasColumnName("IS_REPARADO");

                entity.Property(e => e.ServiciosSgs)
                    .HasColumnName("SERVICIOS_SGS")
                    .IsUnicode(false);

                entity.Property(e => e.SubtipoServicio)
                    .HasColumnName("SUBTIPO_SERVICIO")
                    .IsUnicode(false);

                entity.Property(e => e.Vip)
                    .HasColumnName("VIP")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CEquipoCliente>(entity =>
            {
                entity.HasKey(e => e.IdEquipoCliente);

                entity.ToTable("C_EQUIPO_CLIENTE");

                entity.Property(e => e.IdEquipoCliente).HasColumnName("ID_EQUIPO_CLIENTE");

                entity.Property(e => e.DescripcionEquipo)
                    .HasColumnName("DESCRIPCION_EQUIPO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CEstadosDarBbva94>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__C_ESTADO__241E2E01900C67EE");

                entity.ToTable("C_ESTADOS_DAR_BBVA_94");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.Dar)
                    .HasColumnName("DAR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CEtiquetaInformacionCierre>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaInformacionCierre)
                    .HasName("PK__C_ETIQUE__A8E02856BFD281CE");

                entity.ToTable("C_ETIQUETA_INFORMACION_CIERRE");

                entity.Property(e => e.IdEtiquetaInformacionCierre).HasColumnName("ID_ETIQUETA_INFORMACION_CIERRE");

                entity.Property(e => e.CampoServicio)
                    .HasColumnName("CAMPO_SERVICIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescEtiquetaInformacionCierre)
                    .HasColumnName("DESC_ETIQUETA_INFORMACION_CIERRE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CEtiquetaInformacionRechazo>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaInformacionRechazo)
                    .HasName("PK__C_ETIQUE__4D80EA389BCF967B");

                entity.ToTable("C_ETIQUETA_INFORMACION_RECHAZO");

                entity.Property(e => e.IdEtiquetaInformacionRechazo).HasColumnName("ID_ETIQUETA_INFORMACION_RECHAZO");

                entity.Property(e => e.CampoServicio)
                    .HasColumnName("CAMPO_SERVICIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescEtiquetaInformacionRechazo)
                    .HasColumnName("DESC_ETIQUETA_INFORMACION_RECHAZO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CEtiquetaInformacionUnidad>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaInformacionUnidad);

                entity.ToTable("C_ETIQUETA_INFORMACION_UNIDAD");

                entity.Property(e => e.IdEtiquetaInformacionUnidad).HasColumnName("ID_ETIQUETA_INFORMACION_UNIDAD");

                entity.Property(e => e.DescEtiquetaInformacionUnidad)
                    .HasColumnName("DESC_ETIQUETA_INFORMACION_UNIDAD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFallas>(entity =>
            {
                entity.HasKey(e => e.IdFalla)
                    .HasName("PK_BD_FALLAS");

                entity.ToTable("C_FALLAS");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescFalla)
                    .HasColumnName("DESC_FALLA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoFalla).HasColumnName("ID_TIPO_FALLA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDowntime)
                    .HasColumnName("IS_DOWNTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFallasEncontradas>(entity =>
            {
                entity.HasKey(e => e.IdFalla);

                entity.ToTable("C_FALLAS_ENCONTRADAS");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.DescFalla)
                    .HasColumnName("DESC_FALLA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("date");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CGrupos>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("C_GRUPOS");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_GRUPO");

                entity.Property(e => e.DescGrupo)
                    .HasColumnName("DESC_GRUPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdDocsTir).HasColumnName("ID_DOCS_TIR");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CHorarios>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("PK_C_UPTIME");

                entity.ToTable("C_HORARIOS");

                entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");

                entity.Property(e => e.DescHorario)
                    .HasColumnName("DESC_HORARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CHoras>(entity =>
            {
                entity.HasKey(e => e.IdHora);

                entity.ToTable("C_HORAS");

                entity.Property(e => e.IdHora).HasColumnName("ID_HORA");

                entity.Property(e => e.NoHora)
                    .IsRequired()
                    .HasColumnName("NO_HORA")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CInsumos>(entity =>
            {
                entity.HasKey(e => e.IdInsumo)
                    .HasName("PK_C_INSUMOS_1");

                entity.ToTable("C_INSUMOS");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescInsumo)
                    .HasColumnName("DESC_INSUMO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoInsumo).HasColumnName("ID_TIPO_INSUMO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAgrupacion).HasColumnName("IS_AGRUPACION");

                entity.Property(e => e.IsControlInsumos).HasColumnName("IS_CONTROL_INSUMOS");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CInsumosAlta>(entity =>
            {
                entity.HasKey(e => e.IdInsumo);

                entity.ToTable("C_INSUMOS_ALTA");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescInsumo)
                    .HasColumnName("DESC_INSUMO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoInsumo).HasColumnName("ID_TIPO_INSUMO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CInsumosOld>(entity =>
            {
                entity.HasKey(e => e.IdInsumo)
                    .HasName("PK_C_INSUMOS");

                entity.ToTable("C_INSUMOS_OLD");

                entity.HasIndex(e => new { e.IdInsumo, e.DescInsumo, e.IdCliente, e.Status })
                    .HasName("IX_C_INSUMOS_ID_CLIENTE_STATUS");

                entity.Property(e => e.IdInsumo).HasColumnName("ID_INSUMO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescInsumo)
                    .HasColumnName("DESC_INSUMO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoInsumo).HasColumnName("ID_TIPO_INSUMO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoInsumoNavigation)
                    .WithMany(p => p.CInsumosOld)
                    .HasForeignKey(d => d.IdTipoInsumo)
                    .HasConstraintName("FK_C_INSUMOS_C_TIPO_INSUMO");
            });

            modelBuilder.Entity<CLlaves>(entity =>
            {
                entity.HasKey(e => e.IdLlave)
                    .HasName("PK_BD_LLAVES");

                entity.ToTable("C_LLAVES");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.DescLlave)
                    .HasColumnName("DESC_LLAVE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CLogros>(entity =>
            {
                entity.HasKey(e => e.IdTipoLogro);

                entity.ToTable("C_LOGROS");

                entity.Property(e => e.IdTipoLogro).HasColumnName("ID_TIPO_LOGRO");

                entity.Property(e => e.DescLogro)
                    .HasColumnName("DESC_LOGRO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMarcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("C_MARCAS");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.DescMarca)
                    .HasColumnName("DESC_MARCA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdAccess).HasColumnName("ID_ACCESS");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CMarcas)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_C_MARCAS_C_PRODUCTOS");
            });

            modelBuilder.Entity<CMcAutomoviles>(entity =>
            {
                entity.HasKey(e => e.IdAutomovil)
                    .HasName("PK_BD_MC_AUTOMOVILES");

                entity.ToTable("C_MC_AUTOMOVILES");

                entity.Property(e => e.IdAutomovil).HasColumnName("ID_AUTOMOVIL");

                entity.Property(e => e.DescMarca)
                    .HasColumnName("DESC_MARCA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DescModelo)
                    .HasColumnName("DESC_MODELO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdMedioTransporte).HasColumnName("ID_MEDIO_TRANSPORTE");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.Niv)
                    .HasColumnName("NIV")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Placas)
                    .HasColumnName("PLACAS")
                    .HasMaxLength(10);

                entity.Property(e => e.RendimientoPorLitro).HasColumnName("RENDIMIENTO_POR_LITRO");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcBoletos>(entity =>
            {
                entity.HasKey(e => e.IdBoleto)
                    .HasName("PK_BD_MC_BOLETOS");

                entity.ToTable("C_MC_BOLETOS");

                entity.Property(e => e.IdBoleto).HasColumnName("ID_BOLETO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasMaxLength(10);

                entity.Property(e => e.DescNombre)
                    .HasColumnName("DESC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcCasetas>(entity =>
            {
                entity.HasKey(e => e.IdCaseta)
                    .HasName("PK_BD_MC_CASETAS");

                entity.ToTable("C_MC_CASETAS");

                entity.Property(e => e.IdCaseta).HasColumnName("ID_CASETA");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasMaxLength(10);

                entity.Property(e => e.DescCaseta)
                    .HasColumnName("DESC_CASETA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcEstacionEvaluar>(entity =>
            {
                entity.HasKey(e => e.IdEstacionEvaluar)
                    .HasName("PK__C_MC_EST__F5C80A3C6FBA24D6");

                entity.ToTable("C_MC_ESTACION_EVALUAR");

                entity.Property(e => e.IdEstacionEvaluar).HasColumnName("ID_ESTACION_EVALUAR");

                entity.Property(e => e.DescripcionEstacion)
                    .HasColumnName("DESCRIPCION_ESTACION")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcEstacionEvaluarReglas>(entity =>
            {
                entity.HasKey(e => e.IdEstacionEvaluarReglas)
                    .HasName("PK__C_MC_EST__0BA40FA67B2BD782");

                entity.ToTable("C_MC_ESTACION_EVALUAR_REGLAS");

                entity.Property(e => e.IdEstacionEvaluarReglas).HasColumnName("ID_ESTACION_EVALUAR_REGLAS");

                entity.Property(e => e.DanadoMaxTiempo).HasColumnName("DANADO_MAX_TIEMPO");

                entity.Property(e => e.DanadoMinTiempo).HasColumnName("DANADO_MIN_TIEMPO");

                entity.Property(e => e.DescripcionEstacionReglas)
                    .HasColumnName("DESCRIPCION_ESTACION_REGLAS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstacionEvaluar).HasColumnName("ID_ESTACION_EVALUAR");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.MaxTiempo).HasColumnName("MAX_TIEMPO");

                entity.Property(e => e.MinTiempo).HasColumnName("MIN_TIEMPO");

                entity.Property(e => e.Regla)
                    .HasColumnName("REGLA")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcMedioTransporte>(entity =>
            {
                entity.HasKey(e => e.IdMedioTransporte)
                    .HasName("PK_BD_MC_MEDIO_TRANSPORTE");

                entity.ToTable("C_MC_MEDIO_TRANSPORTE");

                entity.Property(e => e.IdMedioTransporte).HasColumnName("ID_MEDIO_TRANSPORTE");

                entity.Property(e => e.CostoPorCaseta)
                    .HasColumnName("COSTO_POR_CASETA")
                    .HasMaxLength(20);

                entity.Property(e => e.CostoPorKm)
                    .IsRequired()
                    .HasColumnName("COSTO_POR_KM")
                    .HasMaxLength(10);

                entity.Property(e => e.CostoPorMantenimiento)
                    .HasColumnName("COSTO_POR_MANTENIMIENTO")
                    .HasMaxLength(10);

                entity.Property(e => e.DescNombre)
                    .HasColumnName("DESC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAutobus).HasColumnName("IS_AUTOBUS");

                entity.Property(e => e.IsCasetas).HasColumnName("IS_CASETAS");

                entity.Property(e => e.IsMantenimiento).HasColumnName("IS_MANTENIMIENTO");
            });

            modelBuilder.Entity<CMcRutas>(entity =>
            {
                entity.HasKey(e => e.IdRuta)
                    .HasName("PK_BD_MC_RUTAS");

                entity.ToTable("C_MC_RUTAS");

                entity.Property(e => e.IdRuta).HasColumnName("ID_RUTA");

                entity.Property(e => e.DescNombre)
                    .HasColumnName("DESC_NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoDestino)
                    .HasColumnName("ESTADO_DESTINO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoOrigen)
                    .HasColumnName("ESTADO_ORIGEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.PoblacionDestino)
                    .HasColumnName("POBLACION_DESTINO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoblacionOrigen)
                    .HasColumnName("POBLACION_ORIGEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcTopesMaximos>(entity =>
            {
                entity.HasKey(e => e.IdTopeMaximo);

                entity.ToTable("C_MC_TOPES_MAXIMOS");

                entity.Property(e => e.IdTopeMaximo).HasColumnName("ID_TOPE_MAXIMO");

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdViatico).HasColumnName("ID_VIATICO");

                entity.Property(e => e.PrecioMaximo)
                    .HasColumnName("PRECIO_MAXIMO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CMcViaticosMotivos>(entity =>
            {
                entity.HasKey(e => e.IdMotivo)
                    .HasName("PK__C_MC_VIA__007C6C354A3E8764");

                entity.ToTable("C_MC_VIATICOS_MOTIVOS");

                entity.Property(e => e.IdMotivo).HasColumnName("ID_MOTIVO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("MOTIVO")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(19)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMcViaticosRazonesCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdRazon)
                    .HasName("PK__C_MC_VIA__E5BA9BD16B156B4A");

                entity.ToTable("C_MC_VIATICOS_RAZONES_CANCELACION");

                entity.Property(e => e.IdRazon).HasColumnName("ID_RAZON");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(19)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMenu>(entity =>
            {
                entity.HasKey(e => e.IdMenu);

                entity.ToTable("C_MENU");

                entity.Property(e => e.IdMenu).HasColumnName("ID_MENU");

                entity.Property(e => e.DesMenu)
                    .HasColumnName("DES_MENU")
                    .HasMaxLength(50);

                entity.Property(e => e.DesName)
                    .HasColumnName("DES_NAME")
                    .HasMaxLength(75);

                entity.Property(e => e.Href)
                    .HasColumnName("HREF")
                    .IsUnicode(false);

                entity.Property(e => e.HrefV3)
                    .HasColumnName("HREF_V3")
                    .IsUnicode(false);

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdParentV3).HasColumnName("ID_PARENT_V3");

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.IsV2).HasColumnName("IS_V2");

                entity.Property(e => e.IsV3).HasColumnName("IS_V3");

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.NivelV3).HasColumnName("NIVEL_V3");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenV3).HasColumnName("ORDEN_V3");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Target)
                    .HasColumnName("TARGET")
                    .HasMaxLength(50);

                entity.Property(e => e.TargetV3)
                    .HasColumnName("TARGET_V3")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMenuCopia>(entity =>
            {
                entity.HasKey(e => e.IdMenu);

                entity.ToTable("C_MENU_COPIA");

                entity.Property(e => e.IdMenu)
                    .HasColumnName("ID_MENU")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesMenu)
                    .HasColumnName("DES_MENU")
                    .HasMaxLength(50);

                entity.Property(e => e.DesName)
                    .HasColumnName("DES_NAME")
                    .HasMaxLength(75);

                entity.Property(e => e.Href)
                    .HasColumnName("HREF")
                    .IsUnicode(false);

                entity.Property(e => e.HrefV3)
                    .HasColumnName("HREF_V3")
                    .IsUnicode(false);

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdParentV3).HasColumnName("ID_PARENT_V3");

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.IsV2).HasColumnName("IS_V2");

                entity.Property(e => e.IsV3).HasColumnName("IS_V3");

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.NivelV3).HasColumnName("NIVEL_V3");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenV3).HasColumnName("ORDEN_V3");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Target)
                    .HasColumnName("TARGET")
                    .HasMaxLength(50);

                entity.Property(e => e.TargetV3)
                    .HasColumnName("TARGET_V3")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMinutos>(entity =>
            {
                entity.HasKey(e => e.IdMinuto);

                entity.ToTable("C_MINUTOS");

                entity.Property(e => e.IdMinuto).HasColumnName("ID_MINUTO");

                entity.Property(e => e.NoMinuto)
                    .IsRequired()
                    .HasColumnName("NO_MINUTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CModelos>(entity =>
            {
                entity.HasKey(e => e.IdModelo);

                entity.ToTable("C_MODELOS");

                entity.HasIndex(e => new { e.IdMarca, e.Status })
                    .HasName("IX_MI_C_MODELOS_35_34");

                entity.HasIndex(e => new { e.IdModelo, e.Status })
                    .HasName("IX_MI_C_MODELOS_118_117");

                entity.HasIndex(e => new { e.IdModelo, e.IdMarca, e.Status })
                    .HasName("IX_MI_C_MODELOS_124_123");

                entity.HasIndex(e => new { e.IdModelo, e.Status, e.IdMarca })
                    .HasName("IX_MI_C_MODELOS_261_260");

                entity.HasIndex(e => new { e.Sku, e.IdModelo, e.Status })
                    .HasName("IX_C_MODELOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdModelo, e.DescModelo, e.IdMarca, e.Status })
                    .HasName("IX_MI_C_MODELOS_53_52");

                entity.HasIndex(e => new { e.IdModelo, e.DescModelo, e.Status, e.Sku })
                    .HasName("IX_MI_C_MODELOS_171_170");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescModelo)
                    .HasColumnName("DESC_MODELO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("device_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory)
                    .HasColumnName("device_type_category")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdAccess).HasColumnName("ID_ACCESS");

                entity.Property(e => e.IdAttachImagenModelo).HasColumnName("ID_ATTACH_IMAGEN_MODELO");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdMonedaCosto).HasColumnName("ID_MONEDA_COSTO");

                entity.Property(e => e.IdStatusModelo).HasColumnName("ID_STATUS_MODELO");

                entity.Property(e => e.IsConectividad).HasColumnName("IS_CONECTIVIDAD");

                entity.Property(e => e.IsConjunto).HasColumnName("IS_CONJUNTO");

                entity.Property(e => e.IsContacless).HasColumnName("IS_CONTACLESS");

                entity.Property(e => e.IsGprs).HasColumnName("IS_GPRS");

                entity.Property(e => e.IsItems).HasColumnName("IS_ITEMS");

                entity.Property(e => e.IsMulticonectividad).HasColumnName("IS_MULTICONECTIVIDAD");

                entity.Property(e => e.IsReporteSims).HasColumnName("IS_REPORTE_SIMS");

                entity.Property(e => e.MultiConectividad).HasColumnName("MULTI_CONECTIVIDAD");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMonedaCostoNavigation)
                    .WithMany(p => p.CModelos)
                    .HasForeignKey(d => d.IdMonedaCosto)
                    .HasConstraintName("FK_C_MODELOS_C_MONEDAS");
            });

            modelBuilder.Entity<CMonedas>(entity =>
            {
                entity.HasKey(e => e.IdMoneda);

                entity.ToTable("C_MONEDAS");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.DescMoneda)
                    .HasColumnName("DESC_MONEDA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CMovInv>(entity =>
            {
                entity.HasKey(e => e.IdMovInv);

                entity.ToTable("C_MOV_INV");

                entity.Property(e => e.IdMovInv).HasColumnName("ID_MOV_INV");

                entity.Property(e => e.Corto)
                    .HasColumnName("CORTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescMovInv)
                    .HasColumnName("DESC_MOV_INV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href)
                    .HasColumnName("HREF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsObligatorio).HasColumnName("IS_OBLIGATORIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CNivelReparacion>(entity =>
            {
                entity.HasKey(e => e.IdNivelReparacion);

                entity.ToTable("C_NIVEL_REPARACION");

                entity.HasIndex(e => e.IdNivelReparacion)
                    .HasName("IX_C_NIVEL_REPARACION")
                    .IsUnique();

                entity.Property(e => e.IdNivelReparacion).HasColumnName("ID_NIVEL_REPARACION");

                entity.Property(e => e.DescNivelReparacion)
                    .HasColumnName("DESC_NIVEL_REPARACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CNombreCurso>(entity =>
            {
                entity.HasKey(e => e.IdNombreCurso)
                    .HasName("PK_C_CURSO");

                entity.ToTable("C_NOMBRE_CURSO");

                entity.Property(e => e.IdNombreCurso).HasColumnName("ID_NOMBRE_CURSO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NombreCurso)
                    .HasColumnName("NOMBRE_CURSO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CNombreJunta>(entity =>
            {
                entity.HasKey(e => e.IdNombreJunta);

                entity.ToTable("C_NOMBRE_JUNTA");

                entity.Property(e => e.IdNombreJunta).HasColumnName("ID_NOMBRE_JUNTA");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.NeedArea).HasColumnName("NEED_AREA");

                entity.Property(e => e.NombreJunta)
                    .HasColumnName("NOMBRE_JUNTA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<COperadores>(entity =>
            {
                entity.HasKey(e => e.IdOperador);

                entity.ToTable("C_OPERADORES");

                entity.Property(e => e.IdOperador).HasColumnName("ID_OPERADOR");

                entity.Property(e => e.DescOperador)
                    .IsRequired()
                    .HasColumnName("DESC_OPERADOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CPlazas>(entity =>
            {
                entity.HasKey(e => e.IdPlaza);

                entity.ToTable("C_PLAZAS");

                entity.Property(e => e.IdPlaza).HasColumnName("ID_PLAZA");

                entity.Property(e => e.DescPlaza)
                    .HasColumnName("DESC_PLAZA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("ID_TIPO_PLAZA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdTipoPlazaNavigation)
                    .WithMany(p => p.CPlazas)
                    .HasForeignKey(d => d.IdTipoPlaza)
                    .HasConstraintName("FK_C_PLAZAS_C_TIPO_PLAZA");
            });

            modelBuilder.Entity<CPrioridades>(entity =>
            {
                entity.HasKey(e => e.IdPrioridades);

                entity.ToTable("C_PRIORIDADES");

                entity.Property(e => e.IdPrioridades).HasColumnName("ID_PRIORIDADES");

                entity.Property(e => e.DescPrioridades)
                    .HasColumnName("DESC_PRIORIDADES")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CProductoDhl>(entity =>
            {
                entity.HasKey(e => e.IdProductoDhl)
                    .HasName("PK__c_producto_dhl__7D102741");

                entity.ToTable("c_producto_dhl");

                entity.Property(e => e.IdProductoDhl)
                    .HasColumnName("id_producto_dhl")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescProductoDhl)
                    .HasColumnName("desc_producto_dhl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomProductoDhl)
                    .HasColumnName("nom_producto_dhl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CProductos>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("C_PRODUCTOS");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Class)
                    .HasColumnName("CLASS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassEdit)
                    .HasColumnName("CLASS_EDIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescProducto)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdTipoProducto).HasColumnName("ID_TIPO_PRODUCTO");

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageEdit)
                    .HasColumnName("IMAGE_EDIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageInactive)
                    .HasColumnName("IMAGE_INACTIVE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAccesorios).HasColumnName("IS_ACCESORIOS");

                entity.Property(e => e.IsBom).HasColumnName("IS_BOM");

                entity.Property(e => e.IsGprs).HasColumnName("IS_GPRS");

                entity.Property(e => e.IsInsumos).HasColumnName("IS_INSUMOS");

                entity.Property(e => e.IsKey).HasColumnName("IS_KEY");

                entity.Property(e => e.IsSoftware).HasColumnName("IS_SOFTWARE");

                entity.Property(e => e.IsSpareParts).HasColumnName("IS_SPARE_PARTS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.CProductos)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .HasConstraintName("FK_C_PRODUCTOS_C_TIPO_PRODUCTO");
            });

            modelBuilder.Entity<CProductosNegocios>(entity =>
            {
                entity.HasKey(e => e.IdProductoNegocio)
                    .HasName("PK__C_PRODUC__14F134FAE99D68E4");

                entity.ToTable("C_PRODUCTOS_NEGOCIOS");

                entity.Property(e => e.IdProductoNegocio).HasColumnName("ID_PRODUCTO_NEGOCIO");

                entity.Property(e => e.DescProductoNegocio)
                    .HasColumnName("DESC_PRODUCTO_NEGOCIO")
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CProveedoresUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdProveedorUsuario)
                    .HasName("PK__C_PROVEE__EBE413EEBA61EF7D");

                entity.ToTable("C_PROVEEDORES_USUARIOS");

                entity.Property(e => e.IdProveedorUsuario).HasColumnName("ID_PROVEEDOR_USUARIO");

                entity.Property(e => e.DescProveedorUsuario)
                    .HasColumnName("DESC_PROVEEDOR_USUARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CProyectos>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK_BD_PROYECTOS");

                entity.ToTable("C_PROYECTOS");

                entity.Property(e => e.IdProyecto).HasColumnName("ID_PROYECTO");

                entity.Property(e => e.DescProyecto)
                    .HasColumnName("DESC_PROYECTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FecGarantia)
                    .HasColumnName("FEC_GARANTIA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("FEC_INICIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.NumUnidades).HasColumnName("NUM_UNIDADES");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CProyectosPmo>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPmo);

                entity.ToTable("C_PROYECTOS_PMO");

                entity.HasIndex(e => new { e.IdCliente, e.IdUsuario })
                    .HasName("IX_C_PROYECTOS_PMO")
                    .IsUnique();

                entity.Property(e => e.IdProyectoPmo).HasColumnName("ID_PROYECTO_PMO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Perfil)
                    .HasColumnName("PERFIL")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CPuestos>(entity =>
            {
                entity.HasKey(e => e.IdPuesto);

                entity.ToTable("C_PUESTOS");

                entity.Property(e => e.IdPuesto).HasColumnName("ID_PUESTO");

                entity.Property(e => e.DescPuesto)
                    .HasColumnName("DESC_PUESTO")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsResponsable).HasColumnName("IS_RESPONSABLE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CRazonDevolucion>(entity =>
            {
                entity.HasKey(e => e.IdRazonDevolucion);

                entity.ToTable("C_RAZON_DEVOLUCION");

                entity.Property(e => e.IdRazonDevolucion).HasColumnName("ID_RAZON_DEVOLUCION");

                entity.Property(e => e.DescRazonDevolucion)
                    .HasColumnName("DESC_RAZON_DEVOLUCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CRegiones>(entity =>
            {
                entity.HasKey(e => e.IdRegion)
                    .HasName("PK_C_ZONAS");

                entity.ToTable("C_REGIONES");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DescRegion)
                    .HasColumnName("DESC_REGION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CReparaciones>(entity =>
            {
                entity.HasKey(e => e.IdReparacion);

                entity.ToTable("C_REPARACIONES");

                entity.Property(e => e.IdReparacion).HasColumnName("ID_REPARACION");

                entity.Property(e => e.DescReparacion)
                    .HasColumnName("DESC_REPARACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CReporteMovInventario>(entity =>
            {
                entity.HasKey(e => e.IdReporteMovInventario);

                entity.ToTable("C_REPORTE_MOV_INVENTARIO");

                entity.Property(e => e.IdReporteMovInventario).HasColumnName("ID_REPORTE_MOV_INVENTARIO");

                entity.Property(e => e.FecFin)
                    .HasColumnName("FEC_FIN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIni)
                    .HasColumnName("FEC_INI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CReportesRetipificados>(entity =>
            {
                entity.HasKey(e => e.IdReporteRetipificados);

                entity.ToTable("C_REPORTES_RETIPIFICADOS");

                entity.Property(e => e.IdReporteRetipificados).HasColumnName("ID_REPORTE_RETIPIFICADOS");

                entity.Property(e => e.DescReporteRetipificados)
                    .HasColumnName("DESC_REPORTE_RETIPIFICADOS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CResponsables>(entity =>
            {
                entity.HasKey(e => e.IdResponsables)
                    .HasName("PK_C_RESPONSABLES_1");

                entity.ToTable("C_RESPONSABLES");

                entity.Property(e => e.IdResponsables).HasColumnName("ID_RESPONSABLES");

                entity.Property(e => e.DescResponsable)
                    .HasColumnName("DESC_RESPONSABLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAlmacen).HasColumnName("IS_ALMACEN");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CResponsablesAgendados>(entity =>
            {
                entity.HasKey(e => e.IdResponsableAgendado)
                    .HasName("PK_C_RESPONSABLES");

                entity.ToTable("C_RESPONSABLES_AGENDADOS");

                entity.Property(e => e.IdResponsableAgendado).HasColumnName("ID_RESPONSABLE_AGENDADO");

                entity.Property(e => e.DescResponsableAgendado)
                    .HasColumnName("DESC_RESPONSABLE_AGENDADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CSedeCurso>(entity =>
            {
                entity.HasKey(e => e.IdSedeCurso);

                entity.ToTable("C_SEDE_CURSO");

                entity.Property(e => e.IdSedeCurso).HasColumnName("ID_SEDE_CURSO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.SedeCurso)
                    .HasColumnName("SEDE_CURSO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CSegmentos>(entity =>
            {
                entity.HasKey(e => e.IdSegmento);

                entity.ToTable("C_SEGMENTOS");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.DescSegmento)
                    .HasColumnName("DESC_SEGMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsKeyAccount).HasColumnName("IS_KEY_ACCOUNT");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CServicioMensajeria>(entity =>
            {
                entity.HasKey(e => e.IdServicioMensajeria);

                entity.ToTable("C_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.DescServicioMensajeria)
                    .HasColumnName("DESC_SERVICIO_MENSAJERIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsCamion).HasColumnName("IS_CAMION");

                entity.Property(e => e.IsInterno).HasColumnName("IS_INTERNO");

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("PAGINA_WEB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK_BD_SERVICIOS");

                entity.ToTable("C_SERVICIOS");

                entity.HasIndex(e => new { e.IdCliente, e.Status })
                    .HasName("IX_MI_C_SERVICIOS_124_123");

                entity.HasIndex(e => new { e.IdServicio, e.Status })
                    .HasName("IX_MI_C_SERVICIOS_2_1");

                entity.HasIndex(e => new { e.IdServicio, e.DescServicio, e.Status })
                    .HasName("IX_MI_C_SERVICIOS_88_87");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescServicio)
                    .HasColumnName("DESC_SERVICIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdArneedFile).HasColumnName("IdARNeedFile");

                entity.Property(e => e.IdArneedNocheckup).HasColumnName("IdARNeedNOcheckup");

                entity.Property(e => e.IdArreopen).HasColumnName("IdARReopen");

                entity.Property(e => e.IdCategoriaValidaDispositivos)
                    .HasColumnName("ID_CATEGORIA_VALIDA_DISPOSITIVOS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdMoneda).HasColumnName("ID_MONEDA");

                entity.Property(e => e.IdTipoPrecio).HasColumnName("ID_TIPO_PRECIO");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TIPO_SERVICIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAlertReincidente).HasColumnName("IS_ALERT_REINCIDENTE");

                entity.Property(e => e.IsAplicacionRequired).HasColumnName("IS_APLICACION_REQUIRED");

                entity.Property(e => e.IsAsignacionAuto).HasColumnName("IS_ASIGNACION_AUTO");

                entity.Property(e => e.IsCadenaCierreEscritaRequired).HasColumnName("IS_CADENA_CIERRE_ESCRITA_REQUIRED");

                entity.Property(e => e.IsCajaRequired).HasColumnName("IS_CAJA_REQUIRED");

                entity.Property(e => e.IsCapacidadDiscoDuroRequired).HasColumnName("IS_CAPACIDAD_DISCO_DURO_REQUIRED");

                entity.Property(e => e.IsCausaRequired).HasColumnName("IS_CAUSA_REQUIRED");

                entity.Property(e => e.IsCausaSolucionRequired)
                    .HasColumnName("IS_CAUSA_SOLUCION_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCierrePda)
                    .HasColumnName("IS_CIERRE_PDA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCodigoIntervencionRequired).HasColumnName("IS_CODIGO_INTERVENCION_REQUIRED");

                entity.Property(e => e.IsCourtSchedule).HasColumnName("isCourtSchedule");

                entity.Property(e => e.IsDescTrabajoCatalogoRequired).HasColumnName("IS_DESC_TRABAJO_CATALOGO_REQUIRED");

                entity.Property(e => e.IsDescTrabajoRequired).HasColumnName("IS_DESC_TRABAJO_REQUIRED");

                entity.Property(e => e.IsDescripcionTrabajoRechazoRequired).HasColumnName("IS_DESCRIPCION_TRABAJO_RECHAZO_REQUIRED");

                entity.Property(e => e.IsDowntime)
                    .HasColumnName("IS_DOWNTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDvRequired).HasColumnName("IS_DV_REQUIRED");

                entity.Property(e => e.IsEmailServiceCharge).HasColumnName("IS_EMAIL_SERVICE_CHARGE");

                entity.Property(e => e.IsEspecificaCausaRechazoRequired).HasColumnName("IS_ESPECIFICA_CAUSA_RECHAZO_REQUIRED");

                entity.Property(e => e.IsEspecificaTipoFalla).HasColumnName("IS_ESPECIFICA_TIPO_FALLA");

                entity.Property(e => e.IsFallaEncontradaCatalogoRequired).HasColumnName("IS_FALLA_ENCONTRADA_CATALOGO_REQUIRED");

                entity.Property(e => e.IsFallaEncontradaRequired)
                    .HasColumnName("IS_FALLA_ENCONTRADA_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecFinIngenieroRequired)
                    .HasColumnName("IS_FEC_FIN_INGENIERO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecIniIngenieroRequired)
                    .HasColumnName("IS_FEC_INI_INGENIERO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecLlegadaIngPartnerRequired).HasColumnName("IS_FEC_LLEGADA_ING_PARTNER_REQUIRED");

                entity.Property(e => e.IsFecLlegadaRequired)
                    .HasColumnName("IS_FEC_LLEGADA_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecLlegadaTercerosRequired)
                    .HasColumnName("IS_FEC_LLEGADA_TERCEROS_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFolioServicioRechazoRequired).HasColumnName("IS_FOLIO_SERVICIO_RECHAZO_REQUIRED");

                entity.Property(e => e.IsFolioServicioRequired)
                    .HasColumnName("IS_FOLIO_SERVICIO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFolioTirRequired).HasColumnName("IS_FOLIO_TIR_REQUIRED");

                entity.Property(e => e.IsFolioValidacionRequired).HasColumnName("IS_FOLIO_VALIDACION_REQUIRED");

                entity.Property(e => e.IsHorarioGarantia).HasColumnName("IS_HORARIO_GARANTIA");

                entity.Property(e => e.IsIdCausaRechazoRequired).HasColumnName("IS_ID_CAUSA_RECHAZO_REQUIRED");

                entity.Property(e => e.IsIdModeloRequired)
                    .HasColumnName("IS_ID_MODELO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIdTipoFallaEncontradaRequired).HasColumnName("IS_ID_TIPO_FALLA_ENCONTRADA_REQUIRED");

                entity.Property(e => e.IsIdentificaAgendadosRequired).HasColumnName("IS_IDENTIFICA_AGENDADOS_REQUIRED");

                entity.Property(e => e.IsInstalacionLlavesRequired).HasColumnName("IS_INSTALACION_LLAVES_REQUIRED");

                entity.Property(e => e.IsInsumosRequired)
                    .HasColumnName("IS_INSUMOS_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIntensidadSenialRequired)
                    .HasColumnName("IS_INTENSIDAD_SENIAL_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIs2TaquetesAdicionalesRequired).HasColumnName("IS_IS_2_TAQUETES_ADICIONALES_REQUIRED");

                entity.Property(e => e.IsIsBlindajeTuercaSeguridadRequired).HasColumnName("IS_IS_BLINDAJE_TUERCA_SEGURIDAD_REQUIRED");

                entity.Property(e => e.IsIsBoletinRequired)
                    .HasColumnName("IS_IS_BOLETIN_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIsFotografiasRequired).HasColumnName("IS_IS_FOTOGRAFIAS_REQUIRED");

                entity.Property(e => e.IsIsInstalacionPlacaFrontalRequired).HasColumnName("IS_IS_INSTALACION_PLACA_FRONTAL_REQUIRED");

                entity.Property(e => e.IsIsInstalacionPlacaLateralRequired).HasColumnName("IS_IS_INSTALACION_PLACA_LATERAL_REQUIRED");

                entity.Property(e => e.IsIsSimRemplazadaRequired)
                    .HasColumnName("IS_IS_SIM_REMPLAZADA_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIsSoporteClienteRequired)
                    .HasColumnName("IS_IS_SOPORTE_CLIENTE_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIsSustitucion4TuercasRequired).HasColumnName("IS_IS_SUSTITUCION_4_TUERCAS_REQUIRED");

                entity.Property(e => e.IsIsValidacionAlarmasRequired).HasColumnName("IS_IS_VALIDACION_ALARMAS_REQUIRED");

                entity.Property(e => e.IsLectorTarjetaRequired).HasColumnName("IS_LECTOR_TARJETA_REQUIRED");

                entity.Property(e => e.IsLecturaVoltajeRequired).HasColumnName("IS_LECTURA_VOLTAJE_REQUIRED");

                entity.Property(e => e.IsMemoriaRequired).HasColumnName("IS_MEMORIA_REQUIRED");

                entity.Property(e => e.IsMinutosGarantia).HasColumnName("IS_MINUTOS_GARANTIA");

                entity.Property(e => e.IsMonitorRequired).HasColumnName("IS_MONITOR_REQUIRED");

                entity.Property(e => e.IsMotivoCobroRequired)
                    .HasColumnName("IS_MOTIVO_COBRO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMultipleTask).HasColumnName("IS_MULTIPLE_TASK");

                entity.Property(e => e.IsNoEquipoRequired)
                    .HasColumnName("IS_NO_EQUIPO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNoInventarioRequired)
                    .HasColumnName("IS_NO_INVENTARIO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNoSerieRequired)
                    .HasColumnName("IS_NO_SERIE_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNombrePersonaLlavesARequired).HasColumnName("IS_NOMBRE_PERSONA_LLAVES_A_REQUIRED");

                entity.Property(e => e.IsNombrePersonaLlavesBRequired).HasColumnName("IS_NOMBRE_PERSONA_LLAVES_B_REQUIRED");

                entity.Property(e => e.IsOtorganteSoporteClienteRequired)
                    .HasColumnName("IS_OTORGANTE_SOPORTE_CLIENTE_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteTasRequired)
                    .HasColumnName("IS_OTORGANTE_TAS_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboClienteRequired)
                    .HasColumnName("IS_OTORGANTE_VOBO_CLIENTE_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboIngPartnerRequired).HasColumnName("IS_OTORGANTE_VOBO_ING_PARTNER_REQUIRED");

                entity.Property(e => e.IsOtorganteVoboRechazoRequired)
                    .HasColumnName("IS_OTORGANTE_VOBO_RECHAZO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboRequired)
                    .HasColumnName("IS_OTORGANTE_VOBO_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboTercerosRequired)
                    .HasColumnName("IS_OTORGANTE_VOBO_TERCEROS_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrefacturacionAgendado)
                    .HasColumnName("IS_PREFACTURACION_AGENDADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrefacturacionIsCobrable)
                    .HasColumnName("IS_PREFACTURACION_IS_COBRABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrefacturacionIsRetipificado)
                    .HasColumnName("IS_PREFACTURACION_IS_RETIPIFICADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsProcesadorRequired).HasColumnName("IS_PROCESADOR_REQUIRED");

                entity.Property(e => e.IsProyecto).HasColumnName("IS_PROYECTO");

                entity.Property(e => e.IsReglaDuplicado).HasColumnName("IS_REGLA_DUPLICADO");

                entity.Property(e => e.IsReportReincidente).HasColumnName("IS_REPORT_REINCIDENTE");

                entity.Property(e => e.IsReporteServicioPartnerRequired).HasColumnName("IS_REPORTE_SERVICIO_PARTNER_REQUIRED");

                entity.Property(e => e.IsSolucionRequired).HasColumnName("IS_SOLUCION_REQUIRED");

                entity.Property(e => e.IsStatusInstalacionLlavesRequired).HasColumnName("IS_STATUS_INSTALACION_LLAVES_REQUIRED");

                entity.Property(e => e.IsTasRequired)
                    .HasColumnName("IS_TAS_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTipoLlaveRequired).HasColumnName("IS_TIPO_LLAVE_REQUIRED");

                entity.Property(e => e.IsTipoPwRequired).HasColumnName("IS_TIPO_PW_REQUIRED");

                entity.Property(e => e.IsTipoTecladoRequired).HasColumnName("IS_TIPO_TECLADO_REQUIRED");

                entity.Property(e => e.IsVelocidadProcesadorRequired).HasColumnName("IS_VELOCIDAD_PROCESADOR_REQUIRED");

                entity.Property(e => e.IsVersionRequired).HasColumnName("IS_VERSION_REQUIRED");

                entity.Property(e => e.IsVersionTecladoEppRequired).HasColumnName("IS_VERSION_TECLADO_EPP_REQUIRED");

                entity.Property(e => e.IsWarrantyDays).HasColumnName("isWarrantyDays");

                entity.Property(e => e.IsXmlElavon).HasColumnName("IS_XML_ELAVON");

                entity.Property(e => e.KitInsumo).HasColumnName("KIT_INSUMO");

                entity.Property(e => e.LengthCodigoIntervencion).HasColumnName("LENGTH_CODIGO_INTERVENCION");

                entity.Property(e => e.MinPromedio).HasColumnName("MIN_PROMEDIO");

                entity.Property(e => e.MinTablero).HasColumnName("MIN_TABLERO");

                entity.Property(e => e.NeedClaveRechazo).HasColumnName("needClaveRechazo");

                entity.Property(e => e.NeedKit).HasColumnName("NEED_KIT");

                entity.Property(e => e.NeedNoSim).HasColumnName("needNoSim");

                entity.Property(e => e.NoDias).HasColumnName("NO_DIAS");

                entity.Property(e => e.RequestType)
                    .HasColumnName("request_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitosServicio)
                    .HasColumnName("REQUISITOS_SERVICIO")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.CServicios)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_C_SERVICIOS_C_MONEDAS");

                entity.HasOne(d => d.IdTipoPrecioNavigation)
                    .WithMany(p => p.CServicios)
                    .HasForeignKey(d => d.IdTipoPrecio)
                    .HasConstraintName("FK_C_SERVICIOS_C_TIPO_PRECIO");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.CServicios)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIOS_C_TIPO_SERVICIO");
            });

            modelBuilder.Entity<CServiciosBancomer>(entity =>
            {
                entity.HasKey(e => new { e.IdServicio, e.Mov });

                entity.ToTable("C_SERVICIOS_BANCOMER");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Mov)
                    .HasColumnName("MOV")
                    .HasMaxLength(1);

                entity.Property(e => e.DescServicio)
                    .HasColumnName("DESC_SERVICIO")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CServiciosDobles>(entity =>
            {
                entity.HasKey(e => e.IdServicioDoble)
                    .HasName("PK__C_SERVIC__7E4206DD08E3A941");

                entity.ToTable("C_SERVICIOS_DOBLES");

                entity.Property(e => e.IdServicioDoble).HasColumnName("ID_SERVICIO_DOBLE");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Outblue).HasColumnName("OUTBLUE");

                entity.Property(e => e.RollosProductivo).HasColumnName("ROLLOS_PRODUCTIVO");
            });

            modelBuilder.Entity<CSoftware>(entity =>
            {
                entity.HasKey(e => e.IdSoftware)
                    .HasName("PK_BD_SOFTWARE");

                entity.ToTable("C_SOFTWARE");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.DescSoftware)
                    .HasColumnName("DESC_SOFTWARE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CSoluciones>(entity =>
            {
                entity.HasKey(e => e.IdSolucion);

                entity.ToTable("C_SOLUCIONES");

                entity.Property(e => e.IdSolucion).HasColumnName("ID_SOLUCION");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescSolucion)
                    .HasColumnName("DESC_SOLUCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsExito).HasColumnName("IS_EXITO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CSpareParts>(entity =>
            {
                entity.HasKey(e => e.IdSparePart);

                entity.ToTable("C_SPARE_PARTS");

                entity.Property(e => e.IdSparePart).HasColumnName("ID_SPARE_PART");

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescSparePart)
                    .HasColumnName("DESC_SPARE_PART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdAttachImagenSparePart).HasColumnName("ID_ATTACH_IMAGEN_SPARE_PART");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdTipoSparePart).HasColumnName("ID_TIPO_SPARE_PART");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoSparePartNavigation)
                    .WithMany(p => p.CSpareParts)
                    .HasForeignKey(d => d.IdTipoSparePart)
                    .HasConstraintName("FK_C_SPARE_PARTS_C_TIPO_SPARE_PART");
            });

            modelBuilder.Entity<CStatusAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdStatusAccesorio);

                entity.ToTable("C_STATUS_ACCESORIO");

                entity.Property(e => e.IdStatusAccesorio).HasColumnName("ID_STATUS_ACCESORIO");

                entity.Property(e => e.DescStatusAccesorio)
                    .HasColumnName("DESC_STATUS_ACCESORIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdStatusAr);

                entity.ToTable("C_STATUS_AR");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.DescStatusAr)
                    .HasColumnName("DESC_STATUS_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDowntimeTrigger).HasColumnName("ID_TIPO_DOWNTIME_TRIGGER");

                entity.Property(e => e.IsAbierta).HasColumnName("IS_ABIERTA");

                entity.Property(e => e.IsAbiertaFreeze).HasColumnName("IS_ABIERTA_FREEZE");

                entity.Property(e => e.IsAbiertaModule).HasColumnName("IS_ABIERTA_MODULE");

                entity.Property(e => e.IsAsignacionTemporal).HasColumnName("IS_ASIGNACION_TEMPORAL");

                entity.Property(e => e.IsBbAbiertas).HasColumnName("IS_BB_ABIERTAS");

                entity.Property(e => e.IsBbCerradas).HasColumnName("IS_BB_CERRADAS");

                entity.Property(e => e.IsBbNuevas).HasColumnName("IS_BB_NUEVAS");

                entity.Property(e => e.IsBbPendientes).HasColumnName("IS_BB_PENDIENTES");

                entity.Property(e => e.IsCargaTrabajoTecnico).HasColumnName("IS_CARGA_TRABAJO_TECNICO");

                entity.Property(e => e.IsCerrada).HasColumnName("IS_CERRADA");

                entity.Property(e => e.IsCierreMasivo).HasColumnName("IS_CIERRE_MASIVO");

                entity.Property(e => e.IsControlModule).HasColumnName("IS_CONTROL_MODULE");

                entity.Property(e => e.IsDesviacion).HasColumnName("IS_DESVIACION");

                entity.Property(e => e.IsDesviacionDefault).HasColumnName("IS_DESVIACION_DEFAULT");

                entity.Property(e => e.IsDesviacionNeeded).HasColumnName("IS_DESVIACION_NEEDED");

                entity.Property(e => e.IsDesviacionTemporal).HasColumnName("IS_DESVIACION_TEMPORAL");

                entity.Property(e => e.IsFecGarantiaChange).HasColumnName("IS_FEC_GARANTIA_CHANGE");

                entity.Property(e => e.IsMovInvAllowed).HasColumnName("IS_MOV_INV_ALLOWED");

                entity.Property(e => e.IsPendiente).HasColumnName("IS_PENDIENTE");

                entity.Property(e => e.IsReasignacionTecnicoHorario).HasColumnName("IS_REASIGNACION_TECNICO_HORARIO");

                entity.Property(e => e.IsSearchModule).HasColumnName("IS_SEARCH_MODULE");

                entity.Property(e => e.IsSearchModuleChecked).HasColumnName("IS_SEARCH_MODULE_CHECKED");

                entity.Property(e => e.IsSolicitudAgendado).HasColumnName("IS_SOLICITUD_AGENDADO");

                entity.Property(e => e.IsSolicitudAlmacen).HasColumnName("IS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IsSolicitudViaticos).HasColumnName("IS_SOLICITUD_VIATICOS");

                entity.Property(e => e.IsSoporteTecnico).HasColumnName("IS_SOPORTE_TECNICO");

                entity.Property(e => e.IsTableroAniejos).HasColumnName("IS_TABLERO_ANIEJOS");

                entity.Property(e => e.IsVisitaAgendado).HasColumnName("IS_VISITA_AGENDADO");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("request_status")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoDowntimeTriggerNavigation)
                    .WithMany(p => p.CStatusAr)
                    .HasForeignKey(d => d.IdTipoDowntimeTrigger)
                    .HasConstraintName("FK_C_STATUS_AR_C_TIPO_DOWNTIME_TRIGGER");
            });

            modelBuilder.Entity<CStatusArEq>(entity =>
            {
                entity.HasKey(e => e.IdStatusArEq);

                entity.ToTable("C_STATUS_AR_EQ");

                entity.Property(e => e.IdStatusArEq).HasColumnName("ID_STATUS_AR_EQ");

                entity.Property(e => e.DescStatusArEq)
                    .HasColumnName("DESC_STATUS_AR_EQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.HasOne(d => d.IdStatusArNavigation)
                    .WithMany(p => p.CStatusArEq)
                    .HasForeignKey(d => d.IdStatusAr)
                    .HasConstraintName("FK_C_STATUS_AR_EQ_C_STATUS_AR");
            });

            modelBuilder.Entity<CStatusCarga>(entity =>
            {
                entity.HasKey(e => e.IdStatusCarga)
                    .HasName("PK_C_STATUS_ARCHIVO");

                entity.ToTable("C_STATUS_CARGA");

                entity.Property(e => e.IdStatusCarga).HasColumnName("ID_STATUS_CARGA");

                entity.Property(e => e.DescStatusCarga)
                    .HasColumnName("DESC_STATUS_CARGA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusCot3m>(entity =>
            {
                entity.HasKey(e => e.IdStatusCot);

                entity.ToTable("C_STATUS_COT_3M");

                entity.Property(e => e.IdStatusCot).HasColumnName("id_status_cot");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CStatusCurso>(entity =>
            {
                entity.HasKey(e => e.IdStatusCurso);

                entity.ToTable("C_STATUS_CURSO");

                entity.Property(e => e.IdStatusCurso).HasColumnName("ID_STATUS_CURSO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCurso)
                    .HasColumnName("STATUS_CURSO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusDoctosPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusDoctoPrefacturacion)
                    .HasName("PK_C_STATUS_DOCTOS_PREFACTURACION_OLD2");

                entity.ToTable("C_STATUS_DOCTOS_PREFACTURACION");

                entity.Property(e => e.IdStatusDoctoPrefacturacion).HasColumnName("ID_STATUS_DOCTO_PREFACTURACION");

                entity.Property(e => e.DescStatusDoctoPrefacturacion)
                    .HasColumnName("DESC_STATUS_DOCTO_PREFACTURACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsClienteAssign).HasColumnName("IS_CLIENTE_ASSIGN");

                entity.Property(e => e.IsDoctoDigital).HasColumnName("IS_DOCTO_DIGITAL");

                entity.Property(e => e.IsDoctoFisico).HasColumnName("IS_DOCTO_FISICO");

                entity.Property(e => e.IsIngenieroAssign).HasColumnName("IS_INGENIERO_ASSIGN");

                entity.Property(e => e.IsModuleBusqueda).HasColumnName("IS_MODULE_BUSQUEDA");

                entity.Property(e => e.IsModulePrefacturacion).HasColumnName("IS_MODULE_PREFACTURACION");

                entity.Property(e => e.IsModuleReporte).HasColumnName("IS_MODULE_REPORTE");

                entity.Property(e => e.IsPartnerAssign).HasColumnName("IS_PARTNER_ASSIGN");

                entity.Property(e => e.IsPrefacturacionAssign).HasColumnName("IS_PREFACTURACION_ASSIGN");

                entity.Property(e => e.IsSupervisorAssign).HasColumnName("IS_SUPERVISOR_ASSIGN");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusEnvio>(entity =>
            {
                entity.HasKey(e => e.IdStatusEnvio);

                entity.ToTable("C_STATUS_ENVIO");

                entity.Property(e => e.IdStatusEnvio).HasColumnName("ID_STATUS_ENVIO");

                entity.Property(e => e.DescStatusEnvio)
                    .HasColumnName("DESC_STATUS_ENVIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusInsumos>(entity =>
            {
                entity.HasKey(e => e.IdStatusInsumo);

                entity.ToTable("C_STATUS_INSUMOS");

                entity.Property(e => e.IdStatusInsumo).HasColumnName("ID_STATUS_INSUMO");

                entity.Property(e => e.DescStatusInsumo)
                    .HasColumnName("DESC_STATUS_INSUMO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusItemsSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdStatusItemsSolicitudAlmacen)
                    .HasName("PK_C_STATUS_ITEM_SOLICITUD_ALMACEN");

                entity.ToTable("C_STATUS_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdStatusItemsSolicitudAlmacen).HasColumnName("ID_STATUS_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescStatusItemsSolicitudAlmacen)
                    .HasColumnName("DESC_STATUS_ITEMS_SOLICITUD_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusJunta>(entity =>
            {
                entity.HasKey(e => e.IdStatusJunta);

                entity.ToTable("C_STATUS_JUNTA");

                entity.Property(e => e.IdStatusJunta).HasColumnName("ID_STATUS_JUNTA");

                entity.Property(e => e.ColorRgb)
                    .HasColumnName("COLOR_RGB")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAuto).HasColumnName("IS_AUTO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusJunta)
                    .HasColumnName("STATUS_JUNTA")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdStatusOrdenCompra)
                    .HasName("PK__C_STATUS__72B86E1FAA32BA12");

                entity.ToTable("C_STATUS_ORDEN_COMPRA");

                entity.Property(e => e.IdStatusOrdenCompra).HasColumnName("ID_STATUS_ORDEN_COMPRA");

                entity.Property(e => e.DescStatus)
                    .HasColumnName("DESC_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusReasonCodes>(entity =>
            {
                entity.HasKey(e => e.IdStatusReasonCodes);

                entity.ToTable("C_STATUS_REASON_CODES");

                entity.Property(e => e.IdStatusReasonCodes).HasColumnName("ID_STATUS_REASON_CODES");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusElavon)
                    .HasColumnName("status_elavon")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusReason)
                    .HasColumnName("status_reason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusReasonCode)
                    .HasColumnName("status_reason_code")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusReparacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusReparacion);

                entity.ToTable("C_STATUS_REPARACION");

                entity.Property(e => e.IdStatusReparacion).HasColumnName("ID_STATUS_REPARACION");

                entity.Property(e => e.DescStatusReparacion)
                    .HasColumnName("DESC_STATUS_REPARACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusReporteCierre>(entity =>
            {
                entity.HasKey(e => e.IdStatusReporteCierre);

                entity.ToTable("C_STATUS_REPORTE_CIERRE");

                entity.Property(e => e.IdStatusReporteCierre).HasColumnName("ID_STATUS_REPORTE_CIERRE");

                entity.Property(e => e.DescStatusReporteCierre)
                    .HasColumnName("DESC_STATUS_REPORTE_CIERRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdStatusSolicitudAlmacen);

                entity.ToTable("C_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdStatusSolicitudAlmacen).HasColumnName("ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescStatusSolicitudAlmacen)
                    .IsRequired()
                    .HasColumnName("DESC_STATUS_SOLICITUD_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCancelado).HasColumnName("IS_CANCELADO");

                entity.Property(e => e.IsConfirmarEntrega).HasColumnName("IS_CONFIRMAR_ENTREGA");

                entity.Property(e => e.IsFlujoAlmacen)
                    .HasColumnName("IS_FLUJO_ALMACEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsHabilitaConfirmar).HasColumnName("IS_HABILITA_CONFIRMAR");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudDevolucion>(entity =>
            {
                entity.HasKey(e => e.IdStatusSolicitudDevolucion);

                entity.ToTable("C_STATUS_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.IdStatusSolicitudDevolucion).HasColumnName("ID_STATUS_SOLICITUD_DEVOLUCION");

                entity.Property(e => e.DescStatusSolicitudDevolucion)
                    .HasColumnName("DESC_STATUS_SOLICITUD_DEVOLUCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudRecoleccion>(entity =>
            {
                entity.HasKey(e => e.IdStatusSolicitudRecoleccion);

                entity.ToTable("C_STATUS_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusSolicitudRecoleccion).HasColumnName("ID_STATUS_SOLICITUD_RECOLECCION");

                entity.Property(e => e.DescStatusSolicitudRecoleccion)
                    .HasColumnName("DESC_STATUS_SOLICITUD_RECOLECCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudViaticos>(entity =>
            {
                entity.HasKey(e => e.IdStatusSolicitudViaticos);

                entity.ToTable("C_STATUS_SOLICITUD_VIATICOS");

                entity.Property(e => e.IdStatusSolicitudViaticos).HasColumnName("ID_STATUS_SOLICITUD_VIATICOS");

                entity.Property(e => e.DescStatusSolicitudViaticos)
                    .HasColumnName("DESC_STATUS_SOLICITUD_VIATICOS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCancelarSolicitudViaticosAllowed).HasColumnName("IS_CANCELAR_SOLICITUD_VIATICOS_ALLOWED");

                entity.Property(e => e.IsCerrarSolicitudViaticos).HasColumnName("IS_CERRAR_SOLICITUD_VIATICOS");

                entity.Property(e => e.IsHabilitaAr).HasColumnName("IS_HABILITA_AR");

                entity.Property(e => e.IsModuleMisSolicitudes).HasColumnName("IS_MODULE_MIS_SOLICITUDES");

                entity.Property(e => e.IsSearchModuleChecked).HasColumnName("IS_SEARCH_MODULE_CHECKED");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusUnidad>(entity =>
            {
                entity.HasKey(e => e.IdStatusUnidad);

                entity.ToTable("C_STATUS_UNIDAD");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.AssignmentNo)
                    .HasColumnName("assignment_no")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentNoDanada)
                    .HasColumnName("assignment_no_danada")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescStatusUnidad)
                    .HasColumnName("DESC_STATUS_UNIDAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsLab).HasColumnName("IS_LAB");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CStatusUsuario>(entity =>
            {
                entity.HasKey(e => e.IdStatusUsuario);

                entity.ToTable("C_STATUS_USUARIO");

                entity.Property(e => e.IdStatusUsuario).HasColumnName("ID_STATUS_USUARIO");

                entity.Property(e => e.DescStatusUsuario)
                    .HasColumnName("DESC_STATUS_USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Envios).HasColumnName("ENVIOS");

                entity.Property(e => e.RequierePeriodo).HasColumnName("REQUIERE_PERIODO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Viaticos).HasColumnName("VIATICOS");
            });

            modelBuilder.Entity<CStatusValidacionPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusValidacionPrefacturacion);

                entity.ToTable("C_STATUS_VALIDACION_PREFACTURACION");

                entity.Property(e => e.IdStatusValidacionPrefacturacion).HasColumnName("ID_STATUS_VALIDACION_PREFACTURACION");

                entity.Property(e => e.DescStatusValidacionPrefacturacion)
                    .HasColumnName("DESC_STATUS_VALIDACION_PREFACTURACION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsAutomatica).HasColumnName("IS_AUTOMATICA");

                entity.Property(e => e.NextIdStatusAr).HasColumnName("NEXT_ID_STATUS_AR");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CSubAlmacenes>(entity =>
            {
                entity.HasKey(e => e.IdCSubAlmacenes)
                    .HasName("PK__C_SUB_AL__10991DCE9D2AC00E");

                entity.ToTable("C_SUB_ALMACENES");

                entity.Property(e => e.IdCSubAlmacenes).HasColumnName("ID_C_SUB_ALMACENES");

                entity.Property(e => e.DescSubAlmacen)
                    .HasColumnName("DESC_SUB_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentAlmacen).HasColumnName("ID_PARENT_ALMACEN");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdParentAlmacenNavigation)
                    .WithMany(p => p.CSubAlmacenes)
                    .HasForeignKey(d => d.IdParentAlmacen)
                    .HasConstraintName("FK__C_SUB_ALM__ID_PA__29B0ECBB");
            });

            modelBuilder.Entity<CTecnicos>(entity =>
            {
                entity.HasKey(e => e.IdTecnico);

                entity.ToTable("C_TECNICOS");

                entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Materno)
                    .HasColumnName("MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paterno)
                    .HasColumnName("PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTiempoMedicion>(entity =>
            {
                entity.HasKey(e => e.IdTiempoMedicion);

                entity.ToTable("C_TIEMPO_MEDICION");

                entity.Property(e => e.IdTiempoMedicion).HasColumnName("ID_TIEMPO_MEDICION");

                entity.Property(e => e.DescTiempoMedicion)
                    .HasColumnName("DESC_TIEMPO_MEDICION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTiempoReferencia>(entity =>
            {
                entity.HasKey(e => e.IdTiempoReferencia);

                entity.ToTable("C_TIEMPO_REFERENCIA");

                entity.Property(e => e.IdTiempoReferencia).HasColumnName("ID_TIEMPO_REFERENCIA");

                entity.Property(e => e.DescTiempoReferencia)
                    .IsRequired()
                    .HasColumnName("DESC_TIEMPO_REFERENCIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Factor).HasColumnName("FACTOR");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTiempos>(entity =>
            {
                entity.HasKey(e => e.IdTiempos);

                entity.ToTable("C_TIEMPOS");

                entity.Property(e => e.IdTiempos).HasColumnName("ID_TIEMPOS");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Horas).HasColumnName("HORAS");

                entity.Property(e => e.MinTotales).HasColumnName("MIN_TOTALES");

                entity.Property(e => e.Minutos).HasColumnName("MINUTOS");

                entity.Property(e => e.Servicio).HasColumnName("SERVICIO");

                entity.Property(e => e.Traslado).HasColumnName("TRASLADO");
            });

            modelBuilder.Entity<CTimestamp>(entity =>
            {
                entity.HasKey(e => e.IdTimestamp);

                entity.ToTable("C_TIMESTAMP");

                entity.Property(e => e.IdTimestamp).HasColumnName("ID_TIMESTAMP");

                entity.Property(e => e.DescTimestamp)
                    .HasColumnName("DESC_TIMESTAMP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoAB>(entity =>
            {
                entity.HasKey(e => e.IdTipoAB)
                    .HasName("PK__C_TIPO_A__4B00D75F71A1E58A");

                entity.ToTable("C_TIPO_A_B");

                entity.Property(e => e.IdTipoAB).HasColumnName("ID_TIPO_A_B");

                entity.Property(e => e.DescTipoAB)
                    .HasColumnName("DESC_TIPO_A_B")
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoArchivo>(entity =>
            {
                entity.HasKey(e => e.IdTipoArchivo);

                entity.ToTable("C_TIPO_ARCHIVO");

                entity.Property(e => e.IdTipoArchivo).HasColumnName("ID_TIPO_ARCHIVO");

                entity.Property(e => e.DescTipoArchivo)
                    .HasColumnName("DESC_TIPO_ARCHIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("EXTENSION")
                    .HasMaxLength(4);

                entity.Property(e => e.Imagen)
                    .HasColumnName("IMAGEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoAuditoria>(entity =>
            {
                entity.HasKey(e => e.IdTipoAuditoria);

                entity.ToTable("C_TIPO_AUDITORIA");

                entity.Property(e => e.IdTipoAuditoria).HasColumnName("ID_TIPO_AUDITORIA");

                entity.Property(e => e.DescTipoAuditoria)
                    .HasColumnName("DESC_TIPO_AUDITORIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoCalculoUptime>(entity =>
            {
                entity.HasKey(e => e.IdTipoCalculoUptime)
                    .HasName("PK_C_TIPO_CALCULO_DOWNTME");

                entity.ToTable("C_TIPO_CALCULO_UPTIME");

                entity.Property(e => e.IdTipoCalculoUptime).HasColumnName("ID_TIPO_CALCULO_UPTIME");

                entity.Property(e => e.DescTipoCalculoUptime)
                    .HasColumnName("DESC_TIPO_CALCULO_UPTIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoCobro>(entity =>
            {
                entity.HasKey(e => e.IdTipoCobro);

                entity.ToTable("C_TIPO_COBRO");

                entity.Property(e => e.IdTipoCobro).HasColumnName("ID_TIPO_COBRO");

                entity.Property(e => e.DescTipoCobro)
                    .HasColumnName("DESC_TIPO_COBRO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoCobroNegocio>(entity =>
            {
                entity.HasKey(e => e.IdTipoCobroNegocio);

                entity.ToTable("C_TIPO_COBRO_NEGOCIO");

                entity.Property(e => e.IdTipoCobroNegocio).HasColumnName("ID_TIPO_COBRO_NEGOCIO");

                entity.Property(e => e.DescTipoCobroNegocio)
                    .HasColumnName("DESC_TIPO_COBRO_NEGOCIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoDowntimeTrigger>(entity =>
            {
                entity.HasKey(e => e.IdTipoDowntimeTrigger);

                entity.ToTable("C_TIPO_DOWNTIME_TRIGGER");

                entity.Property(e => e.IdTipoDowntimeTrigger).HasColumnName("ID_TIPO_DOWNTIME_TRIGGER");

                entity.Property(e => e.DescTipoDowntimeTrigger)
                    .HasColumnName("DESC_TIPO_DOWNTIME_TRIGGER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoFalla>(entity =>
            {
                entity.HasKey(e => e.IdTipoFalla);

                entity.ToTable("C_TIPO_FALLA");

                entity.Property(e => e.IdTipoFalla).HasColumnName("ID_TIPO_FALLA");

                entity.Property(e => e.DescTipoFalla)
                    .HasColumnName("DESC_TIPO_FALLA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IsCobrable).HasColumnName("IS_COBRABLE");

                entity.Property(e => e.IsEspecial).HasColumnName("IS_ESPECIAL");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoFallaSegmento>(entity =>
            {
                entity.HasKey(e => e.IdTipoFallaSegmento);

                entity.ToTable("C_TIPO_FALLA_SEGMENTO");

                entity.Property(e => e.IdTipoFallaSegmento).HasColumnName("ID_TIPO_FALLA_SEGMENTO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdTipoFalla).HasColumnName("ID_TIPO_FALLA");
            });

            modelBuilder.Entity<CTipoInsumo>(entity =>
            {
                entity.HasKey(e => e.IdTipoInsumo);

                entity.ToTable("C_TIPO_INSUMO");

                entity.Property(e => e.IdTipoInsumo).HasColumnName("ID_TIPO_INSUMO");

                entity.Property(e => e.DescTipoInsumo)
                    .HasColumnName("DESC_TIPO_INSUMO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoInventario>(entity =>
            {
                entity.HasKey(e => e.IdTipoInventario);

                entity.ToTable("C_TIPO_INVENTARIO");

                entity.Property(e => e.IdTipoInventario).HasColumnName("ID_TIPO_INVENTARIO");

                entity.Property(e => e.DescTipoInventario)
                    .HasColumnName("DESC_TIPO_INVENTARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoItemOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdTipoItemOrdenCompra)
                    .HasName("PK__C_TIPO_I__EB726181FB5A492B");

                entity.ToTable("C_TIPO_ITEM_ORDEN_COMPRA");

                entity.Property(e => e.IdTipoItemOrdenCompra).HasColumnName("ID_TIPO_ITEM_ORDEN_COMPRA");

                entity.Property(e => e.DescTipoItemOrdenCompra)
                    .HasColumnName("DESC_TIPO_ITEM_ORDEN_COMPRA")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoItemSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdTipoItemSolicitudAlmacen);

                entity.ToTable("C_TIPO_ITEM_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoItemSolicitudAlmacen).HasColumnName("ID_TIPO_ITEM_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescTipoItemSolicitudAlmacen)
                    .HasColumnName("DESC_TIPO_ITEM_SOLICITUD_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdStatusArNew).HasColumnName("ID_STATUS_AR_NEW");

                entity.Property(e => e.IdTipoProducto).HasColumnName("ID_TIPO_PRODUCTO");

                entity.Property(e => e.IsIndividuallyControlled).HasColumnName("IS_INDIVIDUALLY_CONTROLLED");

                entity.Property(e => e.IsUnidadGrupoClientes)
                    .HasColumnName("IS_UNIDAD_GRUPO_CLIENTES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoLocalidad>(entity =>
            {
                entity.HasKey(e => e.IdTipoLocalidad)
                    .HasName("PK_C_LOCALIDAD");

                entity.ToTable("C_TIPO_LOCALIDAD");

                entity.Property(e => e.IdTipoLocalidad).HasColumnName("ID_TIPO_LOCALIDAD");

                entity.Property(e => e.DescLocalidad)
                    .HasColumnName("DESC_LOCALIDAD")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPart>(entity =>
            {
                entity.HasKey(e => e.IdTipoPart);

                entity.ToTable("C_TIPO_PART");

                entity.Property(e => e.IdTipoPart).HasColumnName("ID_TIPO_PART");

                entity.Property(e => e.DescTipoPart)
                    .HasColumnName("DESC_TIPO_PART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPlaza>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlaza);

                entity.ToTable("C_TIPO_PLAZA");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("ID_TIPO_PLAZA");

                entity.Property(e => e.DescTipoPlaza)
                    .HasColumnName("DESC_TIPO_PLAZA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPlazaCliente>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlazaCliente);

                entity.ToTable("C_TIPO_PLAZA_CLIENTE");

                entity.Property(e => e.IdTipoPlazaCliente).HasColumnName("ID_TIPO_PLAZA_CLIENTE");

                entity.Property(e => e.DescTipoPlazaCliente)
                    .HasColumnName("DESC_TIPO_PLAZA_CLIENTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPlazaNegocio>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlazaNegocio);

                entity.ToTable("C_TIPO_PLAZA_NEGOCIO");

                entity.Property(e => e.IdTipoPlazaNegocio).HasColumnName("ID_TIPO_PLAZA_NEGOCIO");

                entity.Property(e => e.DescTipoPlazaNegocio)
                    .HasColumnName("DESC_TIPO_PLAZA_NEGOCIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPrecio>(entity =>
            {
                entity.HasKey(e => e.IdTipoPrecio);

                entity.ToTable("C_TIPO_PRECIO");

                entity.Property(e => e.IdTipoPrecio).HasColumnName("ID_TIPO_PRECIO");

                entity.Property(e => e.DescTipoPrecio)
                    .HasColumnName("DESC_TIPO_PRECIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProducto);

                entity.ToTable("C_TIPO_PRODUCTO");

                entity.Property(e => e.IdTipoProducto).HasColumnName("ID_TIPO_PRODUCTO");

                entity.Property(e => e.DescTipoProducto)
                    .HasColumnName("DESC_TIPO_PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoResponsable>(entity =>
            {
                entity.HasKey(e => e.IdTipoResponsable)
                    .HasName("PK_C_TIPO_RESP");

                entity.ToTable("C_TIPO_RESPONSABLE");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.DescTipoResponsable)
                    .HasColumnName("DESC_TIPO_RESPONSABLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoResponsablePrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoResponsablePrefacturacion)
                    .HasName("PK_C_RESPONSABLES_PREFACTURACION");

                entity.ToTable("C_TIPO_RESPONSABLE_PREFACTURACION");

                entity.Property(e => e.IdTipoResponsablePrefacturacion).HasColumnName("ID_TIPO_RESPONSABLE_PREFACTURACION");

                entity.Property(e => e.DescTipoResponsablePrefacturacion)
                    .HasColumnName("DESC_TIPO_RESPONSABLE_PREFACTURACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio);

                entity.ToTable("C_TIPO_SERVICIO");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TIPO_SERVICIO");

                entity.Property(e => e.DescTipoServicio)
                    .IsRequired()
                    .HasColumnName("DESC_TIPO_SERVICIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoServicioSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicioSolicitudAlmacen);

                entity.ToTable("C_TIPO_SERVICIO_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoServicioSolicitudAlmacen).HasColumnName("ID_TIPO_SERVICIO_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescTipoServicioSolicitudAlmacen)
                    .HasColumnName("DESC_TIPO_SERVICIO_SOLICITUD_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdTipoSolicitudAlmacen);

                entity.ToTable("C_TIPO_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdTipoSolicitudAlmacen).HasColumnName("ID_TIPO_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescTipoSolicitudAlmacen)
                    .HasColumnName("DESC_TIPO_SOLICITUD_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoSoporteTecnico>(entity =>
            {
                entity.HasKey(e => e.IdTipoSoporteTecnico);

                entity.ToTable("C_TIPO_SOPORTE_TECNICO");

                entity.Property(e => e.IdTipoSoporteTecnico).HasColumnName("ID_TIPO_SOPORTE_TECNICO");

                entity.Property(e => e.DescTipoSoporteTecnico)
                    .HasColumnName("DESC_TIPO_SOPORTE_TECNICO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoSparePart>(entity =>
            {
                entity.HasKey(e => e.IdTipoSparePart);

                entity.ToTable("C_TIPO_SPARE_PART");

                entity.Property(e => e.IdTipoSparePart).HasColumnName("ID_TIPO_SPARE_PART");

                entity.Property(e => e.DescTipoSparePart)
                    .HasColumnName("DESC_TIPO_SPARE_PART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.ToTable("C_TIPO_USUARIO");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");

                entity.Property(e => e.DescTipoUsuario)
                    .HasColumnName("DESC_TIPO_USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAutoAssignTechnicians).HasColumnName("IS_AUTO_ASSIGN_TECHNICIANS");

                entity.Property(e => e.IsChangeUnitStock).HasColumnName("IS_CHANGE_UNIT_STOCK");

                entity.Property(e => e.IsEditFiscal).HasColumnName("IS_EDIT_FISCAL");

                entity.Property(e => e.IsSoporte).HasColumnName("IS_SOPORTE");

                entity.Property(e => e.IsSysAdmin).HasColumnName("IS_SYS_ADMIN");

                entity.Property(e => e.IsTargetChangeSent).HasColumnName("IS_TARGET_CHANGE_SENT");

                entity.Property(e => e.IsTechniciansAssignedOnly).HasColumnName("IS_TECHNICIANS_ASSIGNED_ONLY");

                entity.Property(e => e.IsTecnico).HasColumnName("IS_TECNICO");

                entity.Property(e => e.IsViewAllServicios).HasColumnName("IS_VIEW_ALL_SERVICIOS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CTipoZonaOld>(entity =>
            {
                entity.HasKey(e => e.IdTipoZona)
                    .HasName("PK_C_TIPO_ZONA");

                entity.ToTable("C_TIPO_ZONA_OLD");

                entity.Property(e => e.IdTipoZona).HasColumnName("ID_TIPO_ZONA");

                entity.Property(e => e.DescTipoZona)
                    .HasColumnName("DESC_TIPO_ZONA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CUnidadMensajeria>(entity =>
            {
                entity.HasKey(e => e.IdUnidadMensajeria);

                entity.ToTable("C_UNIDAD_MENSAJERIA");

                entity.Property(e => e.IdUnidadMensajeria).HasColumnName("ID_UNIDAD_MENSAJERIA");

                entity.Property(e => e.DescUnidadMensajeria)
                    .HasColumnName("DESC_UNIDAD_MENSAJERIA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdServicioMensajeria).HasColumnName("ID_SERVICIO_MENSAJERIA");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CUpdateTablasBb>(entity =>
            {
                entity.HasKey(e => e.IdUpdateTablasBb);

                entity.ToTable("C_UPDATE_TABLAS_BB");

                entity.Property(e => e.IdUpdateTablasBb).HasColumnName("ID_UPDATE_TABLAS_BB");

                entity.Property(e => e.DescTablaUpdate)
                    .HasColumnName("DESC_TABLA_UPDATE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecUpdate)
                    .HasColumnName("FEC_UPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioUpdate).HasColumnName("ID_USUARIO_UPDATE");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TablaUpdate)
                    .IsRequired()
                    .HasColumnName("TABLA_UPDATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CUrgenciaEnvio>(entity =>
            {
                entity.HasKey(e => e.IdUrgenciaEnvio);

                entity.ToTable("C_URGENCIA_ENVIO");

                entity.Property(e => e.IdUrgenciaEnvio).HasColumnName("ID_URGENCIA_ENVIO");

                entity.Property(e => e.DescUrgenciaEnvio)
                    .HasColumnName("DESC_URGENCIA_ENVIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CUrgenciaSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdUrgenciaSolicitudAlmacen);

                entity.ToTable("C_URGENCIA_SOLICITUD_ALMACEN");

                entity.Property(e => e.IdUrgenciaSolicitudAlmacen).HasColumnName("ID_URGENCIA_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescUrgenciaSolicitudAlmacen)
                    .HasColumnName("DESC_URGENCIA_SOLICITUD_ALMACEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("C_USUARIOS");

                entity.HasIndex(e => e.Credencial)
                    .HasName("IX_MI_C_USUARIOS_3464_3463");

                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_MI_C_USUARIOS_15_14");

                entity.HasIndex(e => e.Username)
                    .HasName("IX_MI_C_USUARIOS_46_45");

                entity.HasIndex(e => new { e.IdUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_28400_28399");

                entity.HasIndex(e => new { e.IdZona, e.Status })
                    .HasName("IX_MI_C_USUARIOS_10616_10615");

                entity.HasIndex(e => new { e.Username, e.Status })
                    .HasName("IX_MI_C_USUARIOS_75_74");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.FecAccesoPda, e.IsPda })
                    .HasName("IX_MI_C_USUARIOS_2_1");

                entity.HasIndex(e => new { e.IdUsuario, e.Email, e.Status })
                    .HasName("IX_MI_C_USUARIOS_57_56");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_83_82");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Status })
                    .HasName("IX_MI_C_USUARIOS_5108_5107");

                entity.HasIndex(e => new { e.IdZona, e.Status, e.IdPuesto })
                    .HasName("IX_MI_C_USUARIOS_10677_10676");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.Nombre, e.IdUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_12087_12086");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Email, e.Status })
                    .HasName("IX_MI_C_USUARIOS_1924_1923");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IdTipoUsuario })
                    .HasName("IX_C_USUARIOS_ID_TIPO_USUARIO");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.Status, e.IdUsuario })
                    .HasName("IX_MI_C_USUARIOS_8782_8781");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.Status })
                    .HasName("IX_MI_C_USUARIOS_5114_5113");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_634_633");

                entity.HasIndex(e => new { e.Materno, e.IdUsuario, e.Nombre, e.Paterno, e.IdTipoUsuario, e.Status })
                    .HasName("IX_C_USUARIOS_ID_TIPO_USUARIO_STATUS");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.FecAccesoPda, e.IdUsuario, e.IsPda })
                    .HasName("IX_MI_C_USUARIOS_12072_12071");

                entity.HasIndex(e => new { e.Materno, e.IdUsuario, e.Nombre, e.Paterno, e.IdTipoUsuario, e.Status, e.IsFollowerDispatch })
                    .HasName("IX_C_USUARIOS_ID_TIPO_USUARIO, STATUS, IS_FOLLOWER_DISPATCH");

                entity.HasIndex(e => new { e.Nombre, e.Paterno, e.Materno, e.IdZona, e.IdUsuario, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_10556_10555");

                entity.HasIndex(e => new { e.Nombre, e.Paterno, e.Materno, e.Username, e.Email, e.Curp, e.Status })
                    .HasName("IX_MI_C_USUARIOS_8109_8108");

                entity.HasIndex(e => new { e.Curp, e.Nombre, e.Paterno, e.Materno, e.Username, e.Email, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_153999_153998");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.IdZona, e.Status, e.IdPuesto })
                    .HasName("IX_MI_C_USUARIOS_25194_25193");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.IsEligeVacaciones, e.IsAutorizaVacaciones, e.DiasVacaciones, e.IsElavon, e.FecBaja, e.FecReingreso, e.IdArea, e.IdHorario, e.HrefFoto, e.Frase, e.TelefonoCasa, e.Celular, e.IdPuesto, e.FecIngreso, e.IdEdoNac, e.FecNac, e.FecExp, e.Credencial, e.IsFollowerDispatch, e.IsDispatchProgramados, e.TelefonoOficina, e.TelefonoOficinaExt, e.IdJefe, e.IdZona, e.IdUsuarioAlta, e.FecAlta, e.IdUsuarioStatus, e.FecStatus, e.NoIdNextel, e.NoTelNextel, e.IdAlmacenOld, e.IsPda, e.FecAccesoPda, e.Curp, e.Materno, e.Username, e.Password, e.Email, e.Sexo, e.Telefono, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_154001_154000");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosOki).HasColumnName("COMENTARIOS_OKI");

                entity.Property(e => e.Credencial)
                    .HasColumnName("CREDENCIAL")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.DiasVacaciones).HasColumnName("DIAS_VACACIONES");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailServiceClose).HasColumnName("EMAIL_SERVICE_CLOSE");

                entity.Property(e => e.ExcelUltimoMov).HasColumnName("EXCEL_ULTIMO_MOV");

                entity.Property(e => e.ExcelUsuarioCierre).HasColumnName("EXCEL_USUARIO_CIERRE");

                entity.Property(e => e.FecAccesoPda)
                    .HasColumnName("FEC_ACCESO_PDA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecBaja)
                    .HasColumnName("FEC_BAJA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecExp)
                    .HasColumnName("FEC_EXP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecIngreso)
                    .HasColumnName("FEC_INGRESO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecNac)
                    .HasColumnName("FEC_NAC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecReingreso)
                    .HasColumnName("FEC_REINGRESO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecStatus)
                    .HasColumnName("FEC_STATUS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Frase)
                    .HasColumnName("FRASE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrefFoto)
                    .HasColumnName("HREF_FOTO")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.IdAlmacenOld).HasColumnName("ID_ALMACEN_OLD");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdDatosFiscales).HasColumnName("ID_DATOS_FISCALES");

                entity.Property(e => e.IdDirecciones).HasColumnName("ID_DIRECCIONES");

                entity.Property(e => e.IdEdoNac).HasColumnName("ID_EDO_NAC");

                entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");

                entity.Property(e => e.IdJefe).HasColumnName("ID_JEFE");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_PROVEEDOR");

                entity.Property(e => e.IdPuesto).HasColumnName("ID_PUESTO");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IdUsuarioStatus).HasColumnName("ID_USUARIO_STATUS");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsActualizacionMasivaCoordenadasNegocio).HasColumnName("IS_ACTUALIZACION_MASIVA_COORDENADAS_NEGOCIO");

                entity.Property(e => e.IsAddReplicate).HasColumnName("IS_ADD_REPLICATE");

                entity.Property(e => e.IsAdiministrarUsuarios).HasColumnName("IS_ADIMINISTRAR_USUARIOS");

                entity.Property(e => e.IsAllCliente).HasColumnName("IS_ALL_CLIENTE");

                entity.Property(e => e.IsAltaMasivaNegocios).HasColumnName("IS_ALTA_MASIVA_NEGOCIOS");

                entity.Property(e => e.IsAltaMasivaViaticos).HasColumnName("IS_ALTA_MASIVA_VIATICOS");

                entity.Property(e => e.IsAutorizaVacaciones).HasColumnName("IS_AUTORIZA_VACACIONES");

                entity.Property(e => e.IsCache).HasColumnName("IS_CACHE");

                entity.Property(e => e.IsConsultaUnidad).HasColumnName("IS_CONSULTA_UNIDAD");

                entity.Property(e => e.IsDaniadaUsuario).HasColumnName("IS_DANIADA_USUARIO");

                entity.Property(e => e.IsDeleteDrive).HasColumnName("IS_DELETE_DRIVE");

                entity.Property(e => e.IsDispatchProgramados).HasColumnName("IS_DISPATCH_PROGRAMADOS");

                entity.Property(e => e.IsEditaNegocios).HasColumnName("IS_EDITA_NEGOCIOS");

                entity.Property(e => e.IsEditarAlmacen).HasColumnName("IS_EDITAR_ALMACEN");

                entity.Property(e => e.IsEditarEspecificacionesServicio).HasColumnName("IS_EDITAR_ESPECIFICACIONES_SERVICIO");

                entity.Property(e => e.IsElavon).HasColumnName("IS_ELAVON");

                entity.Property(e => e.IsEligeVacaciones).HasColumnName("IS_ELIGE_VACACIONES");

                entity.Property(e => e.IsEmailServiceCharge).HasColumnName("IS_EMAIL_SERVICE_CHARGE");

                entity.Property(e => e.IsExlsNegocios).HasColumnName("IS_EXLS_NEGOCIOS");

                entity.Property(e => e.IsFecGarantiaChange).HasColumnName("IS_FEC_GARANTIA_CHANGE");

                entity.Property(e => e.IsFollowerDispatch).HasColumnName("IS_FOLLOWER_DISPATCH");

                entity.Property(e => e.IsModCUsuarios).HasColumnName("is_mod_c_usuarios");

                entity.Property(e => e.IsModificaMensajeria).HasColumnName("IS_MODIFICA_MENSAJERIA");

                entity.Property(e => e.IsModifiedAr).HasColumnName("IS_MODIFIED_AR");

                entity.Property(e => e.IsPadronIngenieros).HasColumnName("IS_PADRON_INGENIEROS");

                entity.Property(e => e.IsPda).HasColumnName("IS_PDA");

                entity.Property(e => e.IsReabrirAuditoria).HasColumnName("IS_REABRIR_AUDITORIA");

                entity.Property(e => e.IsRecoverPassword).HasColumnName("IS_RECOVER_PASSWORD");

                entity.Property(e => e.IsRedireccionEnvio).HasColumnName("IS_REDIRECCION_ENVIO");

                entity.Property(e => e.IsReporteDesviacion).HasColumnName("IS_REPORTE_DESVIACION");

                entity.Property(e => e.IsReporteLicenciasDhl).HasColumnName("IS_REPORTE_LICENCIAS_DHL");

                entity.Property(e => e.IsStatusCambioAbiertas).HasColumnName("is_status_cambio_abiertas");

                entity.Property(e => e.IsStolenUnit).HasColumnName("IS_STOLEN_UNIT");

                entity.Property(e => e.IsUpdatePosicionInventario).HasColumnName("IS_UPDATE_POSICION_INVENTARIO");

                entity.Property(e => e.Materno)
                    .HasColumnName("MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModificaMUnidad).HasColumnName("MODIFICA_M_UNIDAD");

                entity.Property(e => e.NoIdNextel)
                    .HasColumnName("NO_ID_NEXTEL")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NoTelNextel)
                    .HasColumnName("NO_TEL_NEXTEL")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Paterno)
                    .HasColumnName("PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCasa)
                    .HasColumnName("TELEFONO_CASA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoOficina)
                    .HasColumnName("TELEFONO_OFICINA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoOficinaExt)
                    .HasColumnName("TELEFONO_OFICINA_EXT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.CUsuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK_C_USUARIOS_C_TIPO_USUARIO");
            });

            modelBuilder.Entity<CUsuariosCorporativo>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioCorp);

                entity.ToTable("C_USUARIOS_CORPORATIVO");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_C_USUARIOS_CORPORATIVO");

                entity.Property(e => e.IdUsuarioCorp).HasColumnName("ID_USUARIO_CORP");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CVendedores>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PK__C_VENDED__4E11DBE6D6FA9F54");

                entity.ToTable("C_VENDEDORES");

                entity.Property(e => e.IdVendedor).HasColumnName("ID_VENDEDOR");

                entity.Property(e => e.ArcherVendorId).HasColumnName("ARCHER_VENDOR_ID");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescVendedor)
                    .HasColumnName("DESC_VENDEDOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CViaticos>(entity =>
            {
                entity.HasKey(e => e.IdViatico);

                entity.ToTable("C_VIATICOS");

                entity.Property(e => e.IdViatico).HasColumnName("ID_VIATICO");

                entity.Property(e => e.DescViatico)
                    .HasColumnName("DESC_VIATICO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAr).HasColumnName("IS_AR");

                entity.Property(e => e.IsNotAr).HasColumnName("IS_NOT_AR");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CVistasEscalamiento>(entity =>
            {
                entity.HasKey(e => e.IdVistaEscalamiento);

                entity.ToTable("C_VISTAS_ESCALAMIENTO");

                entity.Property(e => e.IdVistaEscalamiento).HasColumnName("ID_VISTA_ESCALAMIENTO");

                entity.Property(e => e.DescVistaEscalamiento)
                    .HasColumnName("DESC_VISTA_ESCALAMIENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CWeekDays>(entity =>
            {
                entity.HasKey(e => e.IdWeekDays);

                entity.ToTable("C_WEEK_DAYS");

                entity.Property(e => e.IdWeekDays).HasColumnName("ID_WEEK_DAYS");

                entity.Property(e => e.WeekDay)
                    .HasColumnName("WEEK_DAY")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CWeekhours>(entity =>
            {
                entity.HasKey(e => e.IdWeekhour);

                entity.ToTable("C_WEEKHOURS");

                entity.Property(e => e.IdWeekhour).HasColumnName("ID_WEEKHOUR");

                entity.Property(e => e.DescWeekhour)
                    .HasColumnName("DESC_WEEKHOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weekday).HasColumnName("WEEKDAY");
            });

            modelBuilder.Entity<CWincorEquivalenciasSgs>(entity =>
            {
                entity.HasKey(e => e.IdEquivalencia)
                    .HasName("PK__C_WINCOR__6AEAAC0100658DEB");

                entity.ToTable("C_WINCOR_EQUIVALENCIAS_SGS");

                entity.Property(e => e.IdEquivalencia).HasColumnName("ID_EQUIVALENCIA");

                entity.Property(e => e.DescStatusWincor)
                    .HasColumnName("DESC_STATUS_WINCOR")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdStatusAr).HasColumnName("ID_STATUS_AR");

                entity.Property(e => e.IdStatusWincor).HasColumnName("ID_STATUS_WINCOR");

                entity.HasOne(d => d.IdStatusArNavigation)
                    .WithMany(p => p.CWincorEquivalenciasSgs)
                    .HasForeignKey(d => d.IdStatusAr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_AR_WINCOR_EQUIV");
            });

            modelBuilder.Entity<CZonaAtencionSantander>(entity =>
            {
                entity.HasKey(e => e.IdZonaAtencion);

                entity.ToTable("C_ZONA_ATENCION_SANTANDER");

                entity.Property(e => e.IdZonaAtencion).HasColumnName("ID_ZONA_ATENCION");

                entity.Property(e => e.CentroServicio)
                    .HasColumnName("CENTRO_SERVICIO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaMf).HasColumnName("ZONA_MF");
            });

            modelBuilder.Entity<CZonas>(entity =>
            {
                entity.HasKey(e => e.IdZona)
                    .HasName("PK_C_OFICINAS");

                entity.ToTable("C_ZONAS");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.CadenaF11)
                    .HasColumnName("CADENA_F11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescZona)
                    .HasColumnName("DESC_ZONA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Frontera).HasColumnName("FRONTERA");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsAsignacionAuto).HasColumnName("IS_ASIGNACION_AUTO");

                entity.Property(e => e.OrdenF11).HasColumnName("ORDEN_F11");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.CZonas)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_C_OFICINAS_C_REGIONES");
            });

            modelBuilder.Entity<CZonasAgenteCallCenter>(entity =>
            {
                entity.HasKey(e => e.IdZonaAgenteCallcenter);

                entity.ToTable("C_ZONAS_AGENTE_CALL_CENTER");

                entity.Property(e => e.IdZonaAgenteCallcenter).HasColumnName("ID_ZONA_AGENTE_CALLCENTER");

                entity.Property(e => e.IdAgente).HasColumnName("ID_AGENTE");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ElavonInbox>(entity =>
            {
                entity.HasKey(e => e.IdElavonInbox);

                entity.ToTable("ELAVON_INBOX");

                entity.Property(e => e.IdElavonInbox).HasColumnName("ID_ELAVON_INBOX");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AttentionWindow)
                    .HasColumnName("attention_window")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Colony)
                    .HasColumnName("colony")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionType)
                    .HasColumnName("connection_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CountyDistrict)
                    .HasColumnName("county_district")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("device_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory)
                    .HasColumnName("device_type_category")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DueBy)
                    .HasColumnName("due_by")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalTid)
                    .HasColumnName("external_tid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFalla).HasColumnName("ID_FALLA");

                entity.Property(e => e.IdProyecto).HasColumnName("ID_PROYECTO");

                entity.Property(e => e.IdRecepcionElavon).HasColumnName("ID_RECEPCION_ELAVON");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.IsFollowDispatch).HasColumnName("IS_FOLLOW_DISPATCH");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .HasColumnName("purchase_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType)
                    .HasColumnName("request_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SimCardCarrier)
                    .HasColumnName("sim_card_carrier")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvince)
                    .HasColumnName("state_province")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Terminal3DigitNumber)
                    .HasColumnName("terminal_3_digit_number")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("tid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElavonOutbox>(entity =>
            {
                entity.HasKey(e => e.IdElavonOutbox);

                entity.ToTable("ELAVON_OUTBOX");

                entity.Property(e => e.IdElavonOutbox).HasColumnName("ID_ELAVON_OUTBOX");

                entity.Property(e => e.AssignmentNo)
                    .HasColumnName("assignment_no")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentNoFrom)
                    .HasColumnName("assignment_no_from")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BookingDt)
                    .HasColumnName("booking_dt")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cabecera)
                    .HasColumnName("CABECERA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("device_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory)
                    .HasColumnName("device_type_category")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdEnvioElavon).HasColumnName("ID_ENVIO_ELAVON");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Profile)
                    .HasColumnName("profile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo)
                    .HasColumnName("purchase_order_no")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("request_status")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceReceivedBy)
                    .HasColumnName("service_received_by")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusReason)
                    .HasColumnName("status_reason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusReasonCode)
                    .HasColumnName("status_reason_code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("tid")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Equipos>(entity =>
            {
                entity.HasKey(e => e.IdEquipo);

                entity.ToTable("EQUIPOS");

                entity.Property(e => e.IdEquipo).HasColumnName("ID_EQUIPO");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Afiliacion).HasMaxLength(255);

                entity.Property(e => e.Ar).HasColumnName("AR");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactName).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Desc).HasMaxLength(255);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Id).HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdResponsable)
                    .HasColumnName("ID_RESPONSABLE")
                    .HasMaxLength(10);

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuario).HasMaxLength(255);

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.Idequipo1).HasColumnName("IDEquipo");

                entity.Property(e => e.Idregional)
                    .HasColumnName("IDRegional")
                    .HasMaxLength(255);

                entity.Property(e => e.Idzona).HasColumnName("IDZona");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(255);

                entity.Property(e => e.Inventario).HasMaxLength(255);

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.Property(e => e.IsProcessed).HasColumnName("IS_PROCESSED");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.MakeId)
                    .HasColumnName("MakeID")
                    .HasMaxLength(255);

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasMaxLength(255);

                entity.Property(e => e.NoEquipo)
                    .HasColumnName("NO_EQUIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PosicionInventario)
                    .HasColumnName("POSICION_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode).HasMaxLength(255);

                entity.Property(e => e.ReceivingLocId)
                    .HasColumnName("ReceivingLocID")
                    .HasMaxLength(255);

                entity.Property(e => e.SerialNumber).HasMaxLength(255);

                entity.Property(e => e.Simm)
                    .HasColumnName("SIMM")
                    .HasMaxLength(255);

                entity.Property(e => e.StateProv).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErroresArPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdArError)
                    .HasName("PK__ERRORES___CB458F4DBA59FB62");

                entity.ToTable("ERRORES_AR_PREFACTURACION");

                entity.Property(e => e.IdArError).HasColumnName("ID_AR_ERROR");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdArPrefacturacion).HasColumnName("ID_AR_PREFACTURACION");
            });

            modelBuilder.Entity<HistoricoElavon>(entity =>
            {
                entity.HasKey(e => e.IdHistorico)
                    .HasName("PK_HOSTORICO_ELAVON");

                entity.ToTable("HISTORICO_ELAVON");

                entity.Property(e => e.IdHistorico).HasColumnName("ID_HISTORICO");

                entity.Property(e => e.ActReferencias)
                    .HasColumnName("ACT_REFERENCIAS")
                    .HasMaxLength(100);

                entity.Property(e => e.Afiliacion)
                    .HasColumnName("AFILIACION")
                    .HasMaxLength(20);

                entity.Property(e => e.AfiliacionAmex)
                    .HasColumnName("AFILIACION_AMEX")
                    .HasMaxLength(50);

                entity.Property(e => e.AfiliacionCierreAmex)
                    .HasColumnName("AFILIACION_CIERRE_AMEX")
                    .HasMaxLength(50);

                entity.Property(e => e.AtiendeComercio)
                    .HasColumnName("ATIENDE_COMERCIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Base)
                    .HasColumnName("BASE")
                    .HasMaxLength(10);

                entity.Property(e => e.CableCorriente)
                    .HasColumnName("CABLE_CORRIENTE")
                    .HasMaxLength(10);

                entity.Property(e => e.Cargador)
                    .HasColumnName("CARGADOR")
                    .HasMaxLength(10);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(100);

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(50);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(150);

                entity.Property(e => e.Comercio)
                    .HasColumnName("COMERCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Conclusiones)
                    .HasColumnName("CONCLUSIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Conectividad)
                    .HasColumnName("CONECTIVIDAD")
                    .HasMaxLength(30);

                entity.Property(e => e.Contacto1)
                    .HasColumnName("CONTACTO_1")
                    .HasMaxLength(100);

                entity.Property(e => e.CorreoEjecutio)
                    .HasColumnName("CORREO_EJECUTIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.CriterioCambio)
                    .HasColumnName("CRITERIO_CAMBIO")
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("text");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(150);

                entity.Property(e => e.Discover)
                    .HasColumnName("DISCOVER")
                    .HasMaxLength(10);

                entity.Property(e => e.DomicilioAlterno)
                    .HasColumnName("DOMICILIO_ALTERNO")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(50);

                entity.Property(e => e.EstatusServicio)
                    .HasColumnName("ESTATUS_SERVICIO")
                    .HasMaxLength(20);

                entity.Property(e => e.FechaAlta)
                    .IsRequired()
                    .HasColumnName("FECHA_ALTA")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaAltaSistema)
                    .HasColumnName("FECHA_ALTA_SISTEMA")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaAtencionProveedor)
                    .HasColumnName("FECHA_ATENCION_PROVEEDOR")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaCierreSistema)
                    .HasColumnName("FECHA_CIERRE_SISTEMA")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("FECHA_VENCIMIENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.HorasEncidas)
                    .HasColumnName("HORAS_ENCIDAS")
                    .HasMaxLength(10);

                entity.Property(e => e.IdAmex)
                    .HasColumnName("ID_AMEX")
                    .HasMaxLength(50);

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_CAJA")
                    .HasMaxLength(100);

                entity.Property(e => e.IdEquipo)
                    .HasColumnName("ID_EQUIPO")
                    .HasMaxLength(15);

                entity.Property(e => e.Modelo)
                    .HasColumnName("MODELO")
                    .HasMaxLength(50);

                entity.Property(e => e.ModeloInstalado)
                    .HasColumnName("MODELO_INSTALADO")
                    .HasMaxLength(100);

                entity.Property(e => e.ModeloTerminalSale)
                    .HasColumnName("MODELO_TERMINAL_SALE")
                    .HasMaxLength(100);

                entity.Property(e => e.MotivoCancelacion)
                    .HasColumnName("MOTIVO_CANCELACION")
                    .HasMaxLength(100);

                entity.Property(e => e.MotivoRechazo)
                    .HasColumnName("MOTIVO_RECHAZO")
                    .HasMaxLength(150);

                entity.Property(e => e.Nivel)
                    .HasColumnName("NIVEL")
                    .HasMaxLength(30);

                entity.Property(e => e.NoSerieEntra)
                    .HasColumnName("NO_SERIE_ENTRA")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSerieMantto)
                    .HasColumnName("NO_SERIE_MANTTO")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSerieSale)
                    .HasColumnName("NO_SERIE_SALE")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSimEntra)
                    .HasColumnName("NO_SIM_ENTRA")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSimSale)
                    .HasColumnName("NO_SIM_SALE")
                    .HasMaxLength(50);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Odt)
                    .IsRequired()
                    .HasColumnName("ODT")
                    .HasMaxLength(100);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(30);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(155);

                entity.Property(e => e.Rechazo)
                    .HasColumnName("RECHAZO")
                    .HasMaxLength(100);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.RolloInstalar).HasColumnName("ROLLO_INSTALAR");

                entity.Property(e => e.RollosEntregados)
                    .HasColumnName("ROLLOS_ENTREGADOS")
                    .HasMaxLength(10);

                entity.Property(e => e.SlaFijo).HasColumnName("SLA_FIJO");

                entity.Property(e => e.SubTipoServicio)
                    .HasColumnName("SUB_TIPO_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Tecnico)
                    .HasColumnName("TECNICO")
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(20);

                entity.Property(e => e.TelefonosCampo)
                    .HasColumnName("TELEFONOS_CAMPO")
                    .HasMaxLength(60);

                entity.Property(e => e.TidAmexCierre)
                    .HasColumnName("TID_AMEX_CIERRE")
                    .HasMaxLength(50);

                entity.Property(e => e.TiempoAtencion)
                    .HasColumnName("TIEMPO_ATENCION")
                    .HasMaxLength(10);

                entity.Property(e => e.TieneAmex)
                    .HasColumnName("TIENE_AMEX")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoAB)
                    .HasColumnName("TIPO_A_B")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoComercio)
                    .HasColumnName("TIPO_COMERCIO")
                    .HasMaxLength(30);

                entity.Property(e => e.TipoServicio)
                    .HasColumnName("TIPO_SERVICIO")
                    .HasMaxLength(100);

                entity.Property(e => e.VersionSw)
                    .HasColumnName("VERSION_SW")
                    .HasMaxLength(80);

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<HistoricoElavonPaso>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoElavonPaso)
                    .HasName("PK__HISTORIC__C29EF394B9908975");

                entity.ToTable("HISTORICO_ELAVON_PASO");

                entity.HasIndex(e => e.Afiliacion)
                    .HasName("missing_index_3915_3914");

                entity.HasIndex(e => e.Odt)
                    .HasName("missing_index_3917_3916");

                entity.Property(e => e.IdHistoricoElavonPaso).HasColumnName("ID_HISTORICO_ELAVON_PASO");

                entity.Property(e => e.ActReferencias)
                    .HasColumnName("ACT_REFERENCIAS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Afiliacion)
                    .HasColumnName("AFILIACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AfiliacionAmex)
                    .HasColumnName("AFILIACION_AMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AfiliacionCierreAmex)
                    .HasColumnName("AFILIACION_CIERRE_AMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AtiendeComercio)
                    .HasColumnName("ATIENDE_COMERCIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Base)
                    .HasColumnName("BASE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CableCorriente)
                    .HasColumnName("CABLE_CORRIENTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cargador)
                    .HasColumnName("CARGADOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Comercio)
                    .HasColumnName("COMERCIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusiones)
                    .HasColumnName("CONCLUSIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Conectividad)
                    .HasColumnName("CONECTIVIDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto1)
                    .HasColumnName("CONTACTO_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEjecutio)
                    .HasColumnName("CORREO_EJECUTIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CriterioCambio)
                    .HasColumnName("CRITERIO_CAMBIO")
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("text");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Discover)
                    .HasColumnName("DISCOVER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioAlterno)
                    .HasColumnName("DOMICILIO_ALTERNO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusServicio)
                    .HasColumnName("ESTATUS_SERVICIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAltaSistema)
                    .HasColumnName("FECHA_ALTA_SISTEMA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAtencionProveedor)
                    .HasColumnName("FECHA_ATENCION_PROVEEDOR")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierreSistema)
                    .HasColumnName("FECHA_CIERRE_SISTEMA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("FECHA_VENCIMIENTO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HorasEncidas)
                    .HasColumnName("HORAS_ENCIDAS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdAmex)
                    .HasColumnName("ID_AMEX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_CAJA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCarga).HasColumnName("ID_CARGA");

                entity.Property(e => e.IdEquipo)
                    .HasColumnName("ID_EQUIPO")
                    .IsUnicode(false);

                entity.Property(e => e.IsError).HasColumnName("IS_ERROR");

                entity.Property(e => e.Modelo)
                    .HasColumnName("MODELO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloInstalado)
                    .HasColumnName("MODELO_INSTALADO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloTerminalSale)
                    .HasColumnName("MODELO_TERMINAL_SALE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoCancelacion)
                    .HasColumnName("MOTIVO_CANCELACION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoRechazo)
                    .HasColumnName("MOTIVO_RECHAZO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel)
                    .HasColumnName("NIVEL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieEntra)
                    .HasColumnName("NO_SERIE_ENTRA")
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieMantto)
                    .HasColumnName("NO_SERIE_MANTTO")
                    .IsUnicode(false);

                entity.Property(e => e.NoSerieSale)
                    .HasColumnName("NO_SERIE_SALE")
                    .IsUnicode(false);

                entity.Property(e => e.NoSimEntra)
                    .HasColumnName("NO_SIM_ENTRA")
                    .IsUnicode(false);

                entity.Property(e => e.NoSimSale)
                    .HasColumnName("NO_SIM_SALE")
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Odt)
                    .IsRequired()
                    .HasColumnName("ODT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.Rechazo)
                    .HasColumnName("RECHAZO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RolloInstalar).HasColumnName("ROLLO_INSTALAR");

                entity.Property(e => e.RollosEntregados)
                    .HasColumnName("ROLLOS_ENTREGADOS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SlaFijo).HasColumnName("SLA_FIJO");

                entity.Property(e => e.SubTipoServicio)
                    .HasColumnName("SUB_TIPO_SERVICIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tecnico)
                    .HasColumnName("TECNICO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .IsUnicode(false);

                entity.Property(e => e.TelefonosCampo)
                    .HasColumnName("TELEFONOS_CAMPO")
                    .IsUnicode(false);

                entity.Property(e => e.TidAmexCierre)
                    .HasColumnName("TID_AMEX_CIERRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoAtencion)
                    .HasColumnName("TIEMPO_ATENCION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TieneAmex)
                    .HasColumnName("TIENE_AMEX")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAB)
                    .HasColumnName("TIPO_A_B")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComercio)
                    .HasColumnName("TIPO_COMERCIO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServicio)
                    .HasColumnName("TIPO_SERVICIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VersionSw)
                    .HasColumnName("VERSION_SW")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBanamex>(entity =>
            {
                entity.ToTable("NEGOCIOS_BANAMEX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion).HasColumnName("NO_AFILIACION");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<NegociosBansefi>(entity =>
            {
                entity.ToTable("NEGOCIOS_BANSEFI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.IsSystemDuplicated).HasColumnName("IS_SYSTEM_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBbva>(entity =>
            {
                entity.ToTable("NEGOCIOS_BBVA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBbvaWincor>(entity =>
            {
                entity.ToTable("NEGOCIOS_BBVA_WINCOR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBmxAtm>(entity =>
            {
                entity.ToTable("NEGOCIOS_BMX_ATM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.IsSystemDuplicated).HasColumnName("IS_SYSTEM_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBmxpl>(entity =>
            {
                entity.ToTable("NEGOCIOS_BMXPL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBmxtnm>(entity =>
            {
                entity.ToTable("NEGOCIOS_BMXTNM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<NegociosFujitsuBajio>(entity =>
            {
                entity.ToTable("NEGOCIOS_FUJITSU_BAJIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuBanjercito>(entity =>
            {
                entity.ToTable("NEGOCIOS_FUJITSU_BANJERCITO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuHsbc>(entity =>
            {
                entity.ToTable("NEGOCIOS_FUJITSU_HSBC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuInd>(entity =>
            {
                entity.ToTable("NEGOCIOS_FUJITSU_IND");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosGnp>(entity =>
            {
                entity.ToTable("NEGOCIOS_GNP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<NegociosHsbc>(entity =>
            {
                entity.ToTable("NEGOCIOS_HSBC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion).HasColumnName("NO_AFILIACION");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vip)
                    .HasColumnName("VIP")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NegociosHsbcFujitsu>(entity =>
            {
                entity.ToTable("NEGOCIOS_HSBC_FUJITSU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.IsSystemDuplicated).HasColumnName("IS_SYSTEM_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosHsbcWincor>(entity =>
            {
                entity.ToTable("NEGOCIOS_HSBC_WINCOR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosMontepio>(entity =>
            {
                entity.ToTable("NEGOCIOS_MONTEPIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<NegociosSantander>(entity =>
            {
                entity.ToTable("NEGOCIOS_SANTANDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSantanderWincor>(entity =>
            {
                entity.ToTable("NEGOCIOS_SANTANDER_WINCOR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSat>(entity =>
            {
                entity.ToTable("NEGOCIOS_SAT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSoftel>(entity =>
            {
                entity.ToTable("NEGOCIOS_SOFTEL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.IsProcesada).HasColumnName("IS_PROCESADA");

                entity.Property(e => e.IsSystemDuplicated).HasColumnName("IS_SYSTEM_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<NegociosTelefonica>(entity =>
            {
                entity.ToTable("NEGOCIOS_TELEFONICA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.IsHorarioAcceso).HasColumnName("IS_HORARIO_ACCESO");

                entity.Property(e => e.IsHorarioUptime).HasColumnName("IS_HORARIO_UPTIME");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReporteHojaServicios>(entity =>
            {
                entity.HasKey(e => e.IdReporteHojaServicio)
                    .HasName("PK__REPORTE___938FB86D46B8DA9A");

                entity.ToTable("REPORTE_HOJA_SERVICIOS");

                entity.Property(e => e.IdReporteHojaServicio).HasColumnName("ID_REPORTE_HOJA_SERVICIO");

                entity.Property(e => e.AbrevTecnico)
                    .HasColumnName("ABREV_TECNICO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Accesorios)
                    .HasColumnName("ACCESORIOS")
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasColumnName("EMPRESA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoPor)
                    .HasColumnName("ENVIADO_POR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FallaReport)
                    .HasColumnName("FALLA_REPORT")
                    .IsUnicode(false);

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnName("FECHA_RECEPCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolioTelmex)
                    .HasColumnName("FOLIO_TELMEX")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.NoReporte)
                    .HasColumnName("NO_REPORTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Svc).HasColumnName("SVC");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.ReporteHojaServicios)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_UNIDADES");
            });

            modelBuilder.Entity<SantanderOutbox>(entity =>
            {
                entity.HasKey(e => e.IdSantanderOutbox);

                entity.ToTable("SANTANDER_OUTBOX");

                entity.Property(e => e.IdSantanderOutbox).HasColumnName("ID_SANTANDER_OUTBOX");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("FECHA_ENVIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdTipoOutboxSantander).HasColumnName("ID_TIPO_OUTBOX_SANTANDER");

                entity.Property(e => e.NameFile)
                    .HasColumnName("NAME_FILE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SantanderOutboxCierre>(entity =>
            {
                entity.HasKey(e => e.IdSantanderOutboxCierre);

                entity.ToTable("SANTANDER_OUTBOX_CIERRE");

                entity.Property(e => e.IdSantanderOutboxCierre).HasColumnName("ID_SANTANDER_OUTBOX_CIERRE");

                entity.Property(e => e.Afiliacion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Aplicacion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Atendio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Caja)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosSolucion)
                    .HasColumnName("Comentarios Solucion")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdAr).HasColumnName("ID_AR");

                entity.Property(e => e.IdResultado)
                    .HasColumnName("id_resultado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InsumosEntregados)
                    .HasColumnName("insumos entregados")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Odt)
                    .HasColumnName("ODT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerieBaseInstalada)
                    .HasColumnName("Serie Base instalada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerieBaseRetirada)
                    .HasColumnName("serie base retirada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerieInstalada)
                    .HasColumnName("serie instalada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerieRetirada)
                    .HasColumnName("serie retirada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SimInstalado)
                    .HasColumnName("Sim instalado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SimRetirado)
                    .HasColumnName("sim retirado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SepomexEstados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("SEPOMEX_ESTADOS");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SepomexOld>(entity =>
            {
                entity.ToTable("SEPOMEX_old");

                entity.HasIndex(e => e.DCp)
                    .HasName("IX_SEPOMEX_d_CP");

                entity.HasIndex(e => new { e.Id, e.DAsenta, e.DMnpio, e.DCiudad, e.DCp, e.DEstado })
                    .HasName("IX_SEPOMEX_d_estado");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DAsenta)
                    .HasColumnName("d_asenta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DCiudad)
                    .HasColumnName("d_ciudad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DCp)
                    .HasColumnName("d_CP")
                    .HasMaxLength(10);

                entity.Property(e => e.DEstado).HasColumnName("d_estado");

                entity.Property(e => e.DMnpio)
                    .HasColumnName("d_mnpio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoLocalidad).HasColumnName("ID_TIPO_LOCALIDAD");
            });

            modelBuilder.Entity<SiBdLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("SI_BD_LOG");

                entity.Property(e => e.IdLog).HasColumnName("ID_LOG");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250);

                entity.Property(e => e.EstadoServicio)
                    .HasColumnName("ESTADO_SERVICIO")
                    .HasMaxLength(60);

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.Responsable)
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<SiCServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.ToTable("SI_C_SERVICIOS");

                entity.Property(e => e.IdServicio).HasColumnName("ID_SERVICIO");

                entity.Property(e => e.DescServicio)
                    .HasColumnName("DESC_SERVICIO")
                    .HasMaxLength(60);

                entity.Property(e => e.IdResponsableTecnico).HasColumnName("ID_RESPONSABLE_TECNICO");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TIPO_SERVICIO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TempAfiliaciones>(entity =>
            {
                entity.HasKey(e => e.IdTempAfilacion);

                entity.ToTable("TEMP_AFILIACIONES");

                entity.Property(e => e.IdTempAfilacion).HasColumnName("ID_TEMP_AFILACION");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdResponsable)
                    .HasColumnName("ID_RESPONSABLE")
                    .HasMaxLength(10);

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempHorarios>(entity =>
            {
                entity.HasKey(e => e.IdHorarios);

                entity.ToTable("TEMP_HORARIOS");

                entity.Property(e => e.IdHorarios).HasColumnName("ID_HORARIOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdHorarioAcceso).HasColumnName("ID_HORARIO_ACCESO");

                entity.Property(e => e.IdHorarioUptime).HasColumnName("ID_HORARIO_UPTIME");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempNegocios>(entity =>
            {
                entity.ToTable("TEMP_NEGOCIOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colonia)
                    .HasColumnName("COLONIA")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5);

                entity.Property(e => e.DescNegocio)
                    .HasColumnName("DESC_NEGOCIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.IdSegmento).HasColumnName("ID_SEGMENTO");

                entity.Property(e => e.IdZona).HasColumnName("ID_ZONA");

                entity.Property(e => e.IsDuplicated).HasColumnName("IS_DUPLICATED");

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("POBLACION")
                    .HasMaxLength(255);

                entity.Property(e => e.Segmento)
                    .HasColumnName("SEGMENTO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TempUpdateNoInventario>(entity =>
            {
                entity.HasKey(e => e.IdTempUpdateNoInventario);

                entity.ToTable("TEMP_UPDATE_NO_INVENTARIO");

                entity.Property(e => e.IdTempUpdateNoInventario).HasColumnName("ID_TEMP_UPDATE_NO_INVENTARIO");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");

                entity.Property(e => e.NoInventario)
                    .IsRequired()
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnidadesBnmAtm>(entity =>
            {
                entity.ToTable("UNIDADES_BNM_ATM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FecAlta)
                    .HasColumnName("FEC_ALTA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdLlave).HasColumnName("ID_LLAVE");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdResponsable).HasColumnName("ID_RESPONSABLE");

                entity.Property(e => e.IdSim).HasColumnName("ID_SIM");

                entity.Property(e => e.IdSoftware).HasColumnName("ID_SOFTWARE");

                entity.Property(e => e.IdSolicitudRecoleccion).HasColumnName("ID_SOLICITUD_RECOLECCION");

                entity.Property(e => e.IdStatusUnidad).HasColumnName("ID_STATUS_UNIDAD");

                entity.Property(e => e.IdTipoResponsable).HasColumnName("ID_TIPO_RESPONSABLE");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("ID_USUARIO_ALTA");

                entity.Property(e => e.IsDaniada).HasColumnName("IS_DANIADA");

                entity.Property(e => e.IsDuplicadoLista).HasColumnName("IS_DUPLICADO_LISTA");

                entity.Property(e => e.IsErrorAfiliacion).HasColumnName("IS_ERROR_AFILIACION");

                entity.Property(e => e.IsNueva).HasColumnName("IS_NUEVA");

                entity.Property(e => e.IsRetiro).HasColumnName("IS_RETIRO");

                entity.Property(e => e.IsSystema).HasColumnName("IS_SYSTEMA");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoAfiliacion)
                    .HasColumnName("NO_AFILIACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoEquipo)
                    .HasColumnName("NO_EQUIPO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoImei)
                    .HasColumnName("NO_IMEI")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .HasColumnName("NO_INVENTARIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoSerie)
                    .HasColumnName("NO_SERIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoSim)
                    .HasColumnName("NO_SIM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionInv)
                    .HasColumnName("POSICION_INV")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
