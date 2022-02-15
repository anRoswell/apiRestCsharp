using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class FormasPago
    {
        public FormasPago()
        {
            Contratos = new HashSet<Contrato>();
        }

        public int FpagIdFormasPago { get; set; }
        public string FpagDescripcion { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
