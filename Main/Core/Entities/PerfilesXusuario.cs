using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class PerfilesXusuario : BaseEntity
    {
        public int PxuUsrCodUsuario { get; set; }
        public int PxuAplCodAplicacion { get; set; }
        public int PxuPrfCodPerfil { get; set; }
        public bool PxuEstado { get; set; }
        public string CodArchivo { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Aplicacion PxuAplCodAplicacionNavigation { get; set; }
        public virtual Perfil PxuPrfCodPerfilNavigation { get; set; }
    }
}
