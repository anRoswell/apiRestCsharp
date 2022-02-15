using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class HashRecoveryAccount
    {
        public int IdHashRecoveryAccount { get; set; }
        public string CodUsuario { get; set; }
        public string CodigoHash { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
