using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class PrvDocumento
    {
        public int PrvdIdPrvDocumentos { get; set; }
        public string PrvdCodProveedor { get; set; }
        public int PrvdCodDocumento { get; set; }
        public string PrvdNameDocument { get; set; }
        public string PrvdExtDocument { get; set; }
        public int PrvdSizeDocument { get; set; }
        public string PrvdUrlDocument { get; set; }
        public string PrvdOriginalNameDocument { get; set; }
        public int PrvdEstadoDocumento { get; set; }
        public DateTime? PrvdExpedicion { get; set; }
        public bool PrvdValidationDocument { get; set; }
        public bool PrvdSendNotification { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Proveedore PrvdCodProveedorNavigation { get; set; }
    }
}
