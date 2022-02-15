using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqOfertado
    {
        public int RoferIdReqOfertados { get; set; }
        public int RoferCodRequerimiento { get; set; }
        public DateTime RoferfechaFinOfertaPresentada { get; set; }
        public int RoferEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Requerimiento RoferCodRequerimientoNavigation { get; set; }
    }
}
