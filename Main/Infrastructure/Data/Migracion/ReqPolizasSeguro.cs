using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqPolizasSeguro
    {
        public int RpsIdReqPolizasSeguro { get; set; }
        public int RpsCodRequirimiento { get; set; }
        public string RpsCobertura { get; set; }
        public string RpsTermino { get; set; }
        public bool? RpsEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Requerimiento RpsCodRequirimientoNavigation { get; set; }
    }
}
