using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class DocumentsType
    {
        public DocumentsType()
        {
            Cdocumentacions = new HashSet<Cdocumentacion>();
        }

        public int TipDidDocumentsType { get; set; }
        public string TipDnombreDocumentType { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Cdocumentacion> Cdocumentacions { get; set; }
    }
}
