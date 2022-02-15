using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class PrvCondicionesPago
    {
        public PrvCondicionesPago()
        {
            Proveedores = new HashSet<Proveedore>();
        }

        public int CondPagoIdPrvCondicionesPago { get; set; }
        public bool? CondPagoEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
