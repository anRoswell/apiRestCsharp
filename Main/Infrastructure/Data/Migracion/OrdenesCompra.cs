using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class OrdenesCompra
    {
        public int OrdIdOrdenesCompra { get; set; }
        public int? OrdCodRequerimiento { get; set; }
        public string OrdDireccionEntrega { get; set; }
        public string OrdCondicionesEntrega { get; set; }
        public string OrdProcesoFacturacion { get; set; }
        public string OrdObservacion { get; set; }
        public bool? OrdEstado { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Requerimiento OrdCodRequerimientoNavigation { get; set; }
    }
}
