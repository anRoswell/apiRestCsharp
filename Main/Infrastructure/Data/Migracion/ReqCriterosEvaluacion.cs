using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqCriterosEvaluacion
    {
        public int RcevIdReqCriterosEvaluacion { get; set; }
        public int RcevCodRequerimiento { get; set; }
        public int RcevCodCriterio { get; set; }
        public bool? RcevEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ReqCriterio RcevCodCriterioNavigation { get; set; }
        public virtual Requerimiento RcevCodRequerimientoNavigation { get; set; }
    }
}
