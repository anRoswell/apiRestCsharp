using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Ciudade
    {
        //public Ciudade()
        //{
        //    Proveedores = new HashSet<Proveedore>();
        //}

        public string CodigoCiudad { get; set; }
        public string CodDepartamento { get; set; }
        public string Ciudad { get; set; }
        public bool Habilitado { get; set; }

        //public virtual Departamento CodDepartamentoNavigation { get; set; }
        //public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
