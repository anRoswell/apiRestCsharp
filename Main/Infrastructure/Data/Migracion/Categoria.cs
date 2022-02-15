using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            ReqArtSerRequeridos = new HashSet<ReqArtSerRequerido>();
        }

        public int CatIdCategoria { get; set; }
        public string CatNombreCategoria { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<ReqArtSerRequerido> ReqArtSerRequeridos { get; set; }
    }
}
