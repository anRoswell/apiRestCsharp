using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class TipoUsuario : BaseEntity
    {
        public TipoUsuario()
        {
            Menus = new HashSet<Menu>();
            Usuarios = new HashSet<Usuario>();
        }

        public string TusrDescripcion { get; set; }
        public bool? TusrEstado { get; set; }
        public string CodArchivo { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
