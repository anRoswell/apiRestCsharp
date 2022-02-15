using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ModulosXaplicacion
    {
        public int IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public int CodAplicacion { get; set; }
        public bool Captura { get; set; }
        public bool Listador { get; set; }
        public bool Consulta { get; set; }
        public string Descripcion { get; set; }
        public string Link { get; set; }
    }
}
