using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Aplicacion : BaseEntity
    {
        public Aplicacion()
        {
            AppsFileServerPaths = new HashSet<AppsFileServerPath>();
            Menus = new HashSet<Menu>();
            PerfilesXusuarios = new HashSet<PerfilesXusuario>();
            PermisosMenuXperfils = new HashSet<PermisosMenuXperfil>();
            PermisosUsuarioxMenus = new HashSet<PermisosUsuarioxMenu>();
        }

        public string AplNombre { get; set; }
        public string AplDescripcion { get; set; }
        public bool? AplEstado { get; set; }
        public string CodArchivo { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<AppsFileServerPath> AppsFileServerPaths { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<PerfilesXusuario> PerfilesXusuarios { get; set; }
        public virtual ICollection<PermisosMenuXperfil> PermisosMenuXperfils { get; set; }
        public virtual ICollection<PermisosUsuarioxMenu> PermisosUsuarioxMenus { get; set; }
    }
}
