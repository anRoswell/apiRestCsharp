using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqArtSerRequerido
    {
        public int RasrIdReqArtSerRequeridos { get; set; }
        public int RasrCodRequerimiento { get; set; }
        public int RasrItem { get; set; }
        public string RasrDescripcion { get; set; }
        public int RasrCantidad { get; set; }
        public int RasrCodUnidadMedida { get; set; }
        public string RasrFichaTecnica { get; set; }
        public bool? RasrObligatorio { get; set; }
        public string RasrItemEquivalente { get; set; }
        public int RasrCodCategoria { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Categoria RasrCodCategoriaNavigation { get; set; }
        public virtual Requerimiento RasrCodRequerimientoNavigation { get; set; }
    }
}
