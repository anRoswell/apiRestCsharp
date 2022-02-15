using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Contrato
    {
        public Contrato()
        {
            Cdocumentacions = new HashSet<Cdocumentacion>();
        }

        public int ContIdContratos { get; set; }
        public int ContCodRequerimiento { get; set; }
        public string ContContratante { get; set; }
        public string ContNitCtante { get; set; }
        public string ContRteLegalCtante { get; set; }
        public string ContCcrepresentanteCtante { get; set; }
        public string ContDireccionNotificacionCtante { get; set; }
        public string ContTelefonoCtante { get; set; }
        public int ContCodGestorContratoCtante { get; set; }
        public int ContCodCoordinaroContratoCtante { get; set; }
        public string ContContratista { get; set; }
        public string ContNitCtista { get; set; }
        public string ContRteLegalCtista { get; set; }
        public string ContCcrepresentanteCtista { get; set; }
        public string ContDireccionNotificacionCtista { get; set; }
        public string ContTelefonoCtista { get; set; }
        public int ContCodGestorContratoCtista { get; set; }
        public int ContCodCoordinaroContratoCtista { get; set; }
        public string ContUnidadNegocio { get; set; }
        public string ContClaseContrato { get; set; }
        public string ContObjetoContrato { get; set; }
        public string ContObligacionesEspecificas { get; set; }
        public int ContDuracionContrato { get; set; }
        public DateTime ContVigenciaDesde { get; set; }
        public DateTime ContVigenciaHasta { get; set; }
        public decimal ContValorContrato { get; set; }
        public int ContCodFormaPago { get; set; }
        public bool ContRequiereIngresoPersonal { get; set; }
        public bool ContProrrogaAutomatica { get; set; }
        public int? ContDiasNotificacionNoRenovacionAutomatica { get; set; }
        public bool ContPreavisoProrrogaMeses { get; set; }
        public bool ContRequiereActaInicio { get; set; }
        public bool ContRequiereActaLiquidacion { get; set; }
        public DateTime? ContFechaLiquidacionEsperada { get; set; }
        public DateTime? ContFechaLiquidacionReal { get; set; }
        public int ContTipoDocumento { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual FormasPago ContCodFormaPagoNavigation { get; set; }
        public virtual Requerimiento ContCodRequerimientoNavigation { get; set; }
        public virtual ICollection<Cdocumentacion> Cdocumentacions { get; set; }
    }
}
