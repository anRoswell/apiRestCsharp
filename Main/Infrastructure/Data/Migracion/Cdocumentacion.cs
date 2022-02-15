using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Cdocumentacion
    {
        public int CdocIdCdocumentacion { get; set; }
        public int CdocCodContrato { get; set; }
        public int CdocTipoDocumento { get; set; }
        public int CdocEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Contrato CdocCodContratoNavigation { get; set; }
        public virtual DocumentsType CdocTipoDocumentoNavigation { get; set; }
    }
}
