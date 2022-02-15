using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Requerimiento
    {
        public Requerimiento()
        {
            Contratos = new HashSet<Contrato>();
            OrdenesCompras = new HashSet<OrdenesCompra>();
            ReqArtSerRequeridos = new HashSet<ReqArtSerRequerido>();
            ReqCriterosEvaluacions = new HashSet<ReqCriterosEvaluacion>();
            ReqListDocumentos = new HashSet<ReqListDocumento>();
            ReqOfertados = new HashSet<ReqOfertado>();
            ReqPolizasSeguros = new HashSet<ReqPolizasSeguro>();
            ReqQuestionAnswerNotifications = new HashSet<ReqQuestionAnswerNotification>();
            ReqQuestionAnswers = new HashSet<ReqQuestionAnswer>();
            ReqRtaCriteriosEvaluacions = new HashSet<ReqRtaCriteriosEvaluacion>();
        }

        public int ReqIdRequerimientos { get; set; }
        public string ReqNombreCentroCosto { get; set; }
        public int ReqCodEmpresa { get; set; }
        public int ReqCodAgencia { get; set; }
        public int ReqCodCategoria { get; set; }
        public int ReqCodLugarEntrega { get; set; }
        public string ReqDescription { get; set; }
        public string ReqLugarEntrega { get; set; }
        public DateTime ReqCierraOferta { get; set; }
        public DateTime ReqCompraPrevista { get; set; }
        public DateTime ReqFechaEntrega { get; set; }
        public string ReqGarantiasExigidas { get; set; }
        public DateTime ReqfinOfertaPresentada { get; set; }
        public int ReqReqType { get; set; }
        public int ReqCodGestorCompras { get; set; }
        public bool ReqRequiereContrato { get; set; }
        public int? ReqCodGestorContrato { get; set; }
        public bool ReqEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime Bn { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<OrdenesCompra> OrdenesCompras { get; set; }
        public virtual ICollection<ReqArtSerRequerido> ReqArtSerRequeridos { get; set; }
        public virtual ICollection<ReqCriterosEvaluacion> ReqCriterosEvaluacions { get; set; }
        public virtual ICollection<ReqListDocumento> ReqListDocumentos { get; set; }
        public virtual ICollection<ReqOfertado> ReqOfertados { get; set; }
        public virtual ICollection<ReqPolizasSeguro> ReqPolizasSeguros { get; set; }
        public virtual ICollection<ReqQuestionAnswerNotification> ReqQuestionAnswerNotifications { get; set; }
        public virtual ICollection<ReqQuestionAnswer> ReqQuestionAnswers { get; set; }
        public virtual ICollection<ReqRtaCriteriosEvaluacion> ReqRtaCriteriosEvaluacions { get; set; }
    }
}
