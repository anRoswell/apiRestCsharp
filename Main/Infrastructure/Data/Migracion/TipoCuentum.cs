using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class TipoCuentum
    {
        public TipoCuentum()
        {
            Proveedores = new HashSet<Proveedore>();
        }

        public int TipCtaIdTipoCuenta { get; set; }
        public string TipCtaNombreTipoCuenta { get; set; }
        public bool? TipCtaEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
