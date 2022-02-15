using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Menu : BaseEntity
    {
        public Menu()
        {
            PermisosMenuXperfils = new HashSet<PermisosMenuXperfil>();
            PermisosUsuarioxMenus = new HashSet<PermisosUsuarioxMenu>();
        }

        public string MenModuloDescripcion { get; set; }
        public int MenAplCodAplicacion { get; set; }
        public int MenTusrCodTipoUsuario { get; set; }
        public int MenNivelUno { get; set; }
        public int MenNivelDos { get; set; }
        public int MenNivelTres { get; set; }
        public string MenImagen { get; set; }
        public string MenControlador { get; set; }
        public string MenAccion { get; set; }
        public bool? MenEstado { get; set; }
        public string CodArchivo { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Aplicacion MenAplCodAplicacionNavigation { get; set; }
        public virtual TipoUsuario MenTusrCodTipoUsuarioNavigation { get; set; }
        public virtual ICollection<PermisosMenuXperfil> PermisosMenuXperfils { get; set; }
        public virtual ICollection<PermisosUsuarioxMenu> PermisosUsuarioxMenus { get; set; }
    }
}
