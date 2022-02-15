using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Agencium
    {
        public int AgnIdAgencia { get; set; }
        public int AgnEmpCodEmpresa { get; set; }
        public string AgnNombreAgencia { get; set; }
        public string AgnDireccion { get; set; }
        public string AgnTelefono { get; set; }
        public string AgnAbreviatura { get; set; }
        public int AgnCiuCodCiudad { get; set; }
        public bool? AgnEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Empresa AgnEmpCodEmpresaNavigation { get; set; }
    }
}
