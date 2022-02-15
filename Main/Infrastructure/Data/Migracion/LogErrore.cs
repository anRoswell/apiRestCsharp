using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class LogErrore
    {
        public int Id { get; set; }
        public string Origen { get; set; }
        public string Controlador { get; set; }
        public string Funcion { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public bool Estado { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
