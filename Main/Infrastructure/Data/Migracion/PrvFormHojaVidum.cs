using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class PrvFormHojaVidum
    {
        public int PrvFrmIdPrvFormHojaVida { get; set; }
        public string PrvFrmCodProveedor { get; set; }
        public string PrvFrmpathPdfHojaVida { get; set; }
        public int PrvFrmEstado { get; set; }
        public bool PrvFrmFirmado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Proveedore PrvFrmCodProveedorNavigation { get; set; }
    }
}
