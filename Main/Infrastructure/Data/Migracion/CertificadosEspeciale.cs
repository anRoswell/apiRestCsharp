using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class CertificadosEspeciale
    {
        public int CerIdCertificadosEspeciales { get; set; }
        public string CerDescripcion { get; set; }
        public int CerCodPeriodo { get; set; }
        public string CerDestinatario { get; set; }
        public bool CerIncluirGarantia { get; set; }
        public string CerAlcanceTerritorial { get; set; }
        public int CerCodTipoCertificado { get; set; }
        public int CerEstadoCertificado { get; set; }
        public bool? CerEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Periodo CerCodPeriodoNavigation { get; set; }
        public virtual TipoCertificado CerCodTipoCertificadoNavigation { get; set; }
    }
}
