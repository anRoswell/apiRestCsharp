using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class TipoProveedor
    {
        public TipoProveedor()
        {
            Proveedores = new HashSet<Proveedore>();
        }

        public int TipPrvIdTipoProveedor { get; set; }
        public string TipPrvNombreTipoProveedor { get; set; }
        public bool? TipPrvEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
