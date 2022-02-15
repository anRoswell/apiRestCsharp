using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class ReqQuestionAnswer
    {
        public int RqaIdReqQuestionAnswer { get; set; }
        public int RqaCodRequerimiento { get; set; }
        public int RqaCodProveedor { get; set; }
        public int RqaCodUsuario { get; set; }
        public string RqaComentario { get; set; }
        public bool RqahasUploadFile { get; set; }
        public bool RqaisPrivate { get; set; }
        public bool? RqaEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Requerimiento RqaCodRequerimientoNavigation { get; set; }
    }
}
