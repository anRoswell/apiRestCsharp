using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Periodo
    {
        public Periodo()
        {
            CertificadosEspeciales = new HashSet<CertificadosEspeciale>();
        }

        public int PerIdPeriodo { get; set; }
        public string PerDescripcion { get; set; }
        public bool? PerEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<CertificadosEspeciale> CertificadosEspeciales { get; set; }
    }
}
