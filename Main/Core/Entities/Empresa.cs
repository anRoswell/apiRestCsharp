using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Empresa : BaseEntity
    {
        public Empresa()
        {
            //Agencia = new HashSet<Agencium>();
            PermisosEmpresasxUsuarios = new HashSet<PermisosEmpresasxUsuario>();
            //Proveedores = new HashSet<Proveedore>();
        }

        public string EmpNit { get; set; }
        public string EmpNombreEmpresa { get; set; }
        public string EmpDireccion { get; set; }
        public string EmpTelefono { get; set; }
        public string EmpAbreviatura { get; set; }
        public string EmpTrbCodTrabajadorRepresentanteLegal { get; set; }
        public string CodArchivo { get; set; }
        public bool? EmpEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        //public virtual ICollection<Agencium> Agencia { get; set; }
        public virtual ICollection<PermisosEmpresasxUsuario> PermisosEmpresasxUsuarios { get; set; }
        //public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
