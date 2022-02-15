using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Documento
    {
        public int CocIdDocumentos { get; set; }
        public string CocNombreDocumento { get; set; }
        public string CocDescripcion { get; set; }
        public bool? CocEstado { get; set; }
        public bool Cocrequiered { get; set; }
        public int CoclimitLoad { get; set; }
        public bool CocVigencia { get; set; }
        public int CocVigenciaMaxima { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }
    }
}
