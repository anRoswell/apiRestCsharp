using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqCriterio
    {
        public ReqCriterio()
        {
            ReqCriterosEvaluacions = new HashSet<ReqCriterosEvaluacion>();
            ReqRtaCriteriosEvaluacions = new HashSet<ReqRtaCriteriosEvaluacion>();
        }

        public int RcriIdReqCriterios { get; set; }
        public string RcriCriterio { get; set; }
        public string RcriCodTypeQuestion { get; set; }
        public bool? RcriEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<ReqCriterosEvaluacion> ReqCriterosEvaluacions { get; set; }
        public virtual ICollection<ReqRtaCriteriosEvaluacion> ReqRtaCriteriosEvaluacions { get; set; }
    }
}
