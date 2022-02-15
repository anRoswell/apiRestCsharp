using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class TipoCertificado
    {
        public TipoCertificado()
        {
            CertificadosEspeciales = new HashSet<CertificadosEspeciale>();
        }

        public int TicIdTipoCertificado { get; set; }
        public string TicDescripcion { get; set; }
        public bool? TicEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<CertificadosEspeciale> CertificadosEspeciales { get; set; }
    }
}
