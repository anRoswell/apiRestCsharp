using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqLog
    {
        public int RlogIdReqLog { get; set; }
        public string RlogVista { get; set; }
        public string RlogControlador { get; set; }
        public bool? RlogEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }
    }
}
