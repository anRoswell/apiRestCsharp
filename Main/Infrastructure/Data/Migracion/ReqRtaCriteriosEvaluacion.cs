using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqRtaCriteriosEvaluacion
    {
        public int RcriIdReqRtaCriteriosEvaluacion { get; set; }
        public int RcriCodRequerimiento { get; set; }
        public int RcriCodCriterio { get; set; }
        public string RcriRtaCriterio { get; set; }
        public bool? RcriEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ReqCriterio RcriCodCriterioNavigation { get; set; }
        public virtual Requerimiento RcriCodRequerimientoNavigation { get; set; }
    }
}
