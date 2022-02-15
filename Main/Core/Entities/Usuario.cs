using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Usuario : BaseEntity
    {
        public Usuario()
        {
            PermisosEmpresasxUsuarios = new HashSet<PermisosEmpresasxUsuario>();
            PermisosUsuarioxMenus = new HashSet<PermisosUsuarioxMenu>();
        }

        public string UsrCedula { get; set; }
        public int UsrTusrCodTipoUsuario { get; set; }
        public string UsrNombres { get; set; }
        public string UsrNombreCompleto { get; set; }
        public string UsrApellidos { get; set; }
        public string UsrEmail { get; set; }
        public string UsrPassword { get; set; }
        public int UsrEmpresaProceso { get; set; }
        public bool UsrTmpSuspendido { get; set; }
        public bool? UsrForcePasswordChange { get; set; }
        public bool? UsrEstado { get; set; }
        public string CodArchivo { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual TipoUsuario UsrTusrCodTipoUsuarioNavigation { get; set; }
        public virtual ICollection<PermisosEmpresasxUsuario> PermisosEmpresasxUsuarios { get; set; }
        public virtual ICollection<PermisosUsuarioxMenu> PermisosUsuarioxMenus { get; set; }
    }
}
