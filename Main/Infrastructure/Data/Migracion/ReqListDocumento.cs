using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqListDocumento
    {
        public int RldocIdReqListDocumentos { get; set; }
        public int RlCodRequerimiento { get; set; }
        public int RldocCodDocument { get; set; }
        public int RldocCodUser { get; set; }
        public bool? RldocFechaRegistro { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Requerimiento RlCodRequerimientoNavigation { get; set; }
    }
}
