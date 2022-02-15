using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class PrvSocio
    {
        public int SocIdPrvSocios { get; set; }
        public string SocIdentificacion { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }
    }
}
