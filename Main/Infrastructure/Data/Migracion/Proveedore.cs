using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Proveedore : BaseEntity
    {
        public Proveedore()
        {
            PrvDocumentos = new HashSet<PrvDocumento>();
            PrvFormHojaVida = new HashSet<PrvFormHojaVidum>();
        }
        public int PrvIdProveedores { get; set; }
        public string PrvNombreProveedor { get; set; }
        public string PrvDireccion { get; set; }
        public string PrvCodCiudad { get; set; }
        public string PrvTelefono { get; set; }
        public string PrvContacto { get; set; }
        public string PrvMail { get; set; }
        public string PrvRteLegalNombre { get; set; }
        public string PrvRteLegalApellido { get; set; }
        public string PrvRteLegalIdentificacion { get; set; }
        public string PrvRteLegalCodCiudad { get; set; }
        public string PrvRteLegalTelefonoMovil { get; set; }
        public string PrvRteLegalEmail { get; set; }
        public int PrvCodBanco { get; set; }
        public string PrvDtllesBanNroCuenta { get; set; }
        public int PrvCodTipoCuenta { get; set; }
        public int PrvProveeedor { get; set; }
        public int PrvCodTipoProveeedor { get; set; }
        public int PrvCpaCodCondicionesPago { get; set; }
        public string PrvCpaCual { get; set; }
        public string PrvCpaContadoCual { get; set; }
        public int PrvCodEmpresa { get; set; }
        public bool PrvExperienciaSector { get; set; }
        public bool PrvPoliticaTratamientoDatosPersonales { get; set; }
        public bool PrvDeclaramientoInhabilidadesInteres { get; set; }
        public string CodUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUserUpdate { get; set; }
        public DateTime FechaRegistroUpdate { get; set; }
        public string Info { get; set; }
        public string InfoUpdate { get; set; }

        public virtual Banco PrvCodBancoNavigation { get; set; }
        public virtual Ciudade PrvCodCiudadNavigation { get; set; }
        public virtual Empresa PrvCodEmpresaNavigation { get; set; }
        public virtual TipoCuentum PrvCodTipoCuentaNavigation { get; set; }
        public virtual TipoProveedor PrvCodTipoProveeedorNavigation { get; set; }
        public virtual PrvCondicionesPago PrvCpaCodCondicionesPagoNavigation { get; set; }
        public virtual ICollection<PrvDocumento> PrvDocumentos { get; set; }
        public virtual ICollection<PrvFormHojaVidum> PrvFormHojaVida { get; set; }
    }
}
