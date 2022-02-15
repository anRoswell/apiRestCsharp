using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Core.Entities
{
    public partial class DbContPrueba : DbContext
    {
        public DbContPrueba()
        {
        }

        public DbContPrueba(DbContextOptions<DbContPrueba> options)
            : base(options)
        {
        }

        public virtual DbSet<Agencium> Agencia { get; set; }
        public virtual DbSet<Aplicacion> Aplicacions { get; set; }
        public virtual DbSet<AppsFileServerPath> AppsFileServerPaths { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cdocumentacion> Cdocumentacions { get; set; }
        public virtual DbSet<CertificadosEspeciale> CertificadosEspeciales { get; set; }
        public virtual DbSet<Contrato> Contratos { get; set; }
        public virtual DbSet<DocPrv> DocPrvs { get; set; }
        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<DocumentsType> DocumentsTypes { get; set; }        
        public virtual DbSet<FormasPago> FormasPagos { get; set; }
        public virtual DbSet<HashRecoveryAccount> HashRecoveryAccounts { get; set; }
        public virtual DbSet<IdentidadesGlobale> IdentidadesGlobales { get; set; }
        public virtual DbSet<LogErrore> LogErrores { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<ModulosXaplicacion> ModulosXaplicacions { get; set; }
        public virtual DbSet<OrdenesCompra> OrdenesCompras { get; set; }
        public virtual DbSet<PathsPortal> PathsPortals { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Periodo> Periodos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<PrvCondicionesPago> PrvCondicionesPagos { get; set; }
        public virtual DbSet<PrvDocumento> PrvDocumentos { get; set; }
        public virtual DbSet<PrvFormHojaVidum> PrvFormHojaVida { get; set; }
        public virtual DbSet<PrvProdServ> PrvProdServs { get; set; }
        public virtual DbSet<PrvReferencia> PrvReferencias { get; set; }
        public virtual DbSet<PrvRequiredSign> PrvRequiredSigns { get; set; }
        public virtual DbSet<PrvSocio> PrvSocios { get; set; }
        public virtual DbSet<RefererServidore> RefererServidores { get; set; }
        public virtual DbSet<ReqArtSerRequerido> ReqArtSerRequeridos { get; set; }
        public virtual DbSet<ReqCriterio> ReqCriterios { get; set; }
        public virtual DbSet<ReqCriterosEvaluacion> ReqCriterosEvaluacions { get; set; }
        public virtual DbSet<ReqListDocumento> ReqListDocumentos { get; set; }
        public virtual DbSet<ReqLog> ReqLogs { get; set; }
        public virtual DbSet<ReqOfertado> ReqOfertados { get; set; }
        public virtual DbSet<ReqPolizasSeguro> ReqPolizasSeguros { get; set; }
        public virtual DbSet<ReqQuestionAnswer> ReqQuestionAnswers { get; set; }
        public virtual DbSet<ReqQuestionAnswerNotification> ReqQuestionAnswerNotifications { get; set; }
        public virtual DbSet<ReqRtaCriteriosEvaluacion> ReqRtaCriteriosEvaluacions { get; set; }
        public virtual DbSet<Requerimiento> Requerimientos { get; set; }
        public virtual DbSet<TipoCertificado> TipoCertificados { get; set; }
        public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }
        public virtual DbSet<TipoProveedor> TipoProveedors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Agencium>(entity =>
            {
                entity.HasKey(e => e.AgnIdAgencia)
                    .HasName("PK__Agencia__9CCBE52620E11A10");

                entity.ToTable("Agencia", "par");

                entity.Property(e => e.AgnIdAgencia)
                    .ValueGeneratedNever()
                    .HasColumnName("Agn_IdAgencia");

                entity.Property(e => e.AgnAbreviatura)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Agn_Abreviatura")
                    .HasComment("Especifique una abreviatura para ser utilizada en reportes.");

                entity.Property(e => e.AgnCiuCodCiudad).HasColumnName("Agn_ciuCodCiudad");

                entity.Property(e => e.AgnDireccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Agn_Direccion");

                entity.Property(e => e.AgnEmpCodEmpresa)
                    .HasColumnName("Agn_Emp_CodEmpresa")
                    .HasComment("Una empresa puede tener mas de una agencia.");

                entity.Property(e => e.AgnEstado)
                    .IsRequired()
                    .HasColumnName("Agn_Estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AgnNombreAgencia)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Agn_NombreAgencia");

                entity.Property(e => e.AgnTelefono)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Agn_Telefono");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                //entity.HasOne(d => d.AgnEmpCodEmpresaNavigation)
                //    .WithMany(p => p.Agencia)
                //    .HasForeignKey(d => d.AgnEmpCodEmpresa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Agencia_Empresas");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.BanIdBancos)
                    .HasName("PK__Bancos__9C6E3008CCE0BDE5");

                entity.ToTable("Bancos", "par");

                entity.Property(e => e.BanIdBancos).HasColumnName("banIdBancos");

                entity.Property(e => e.BanDescripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("banDescripcion")
                    .HasComment("Descripcion del banco");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.CatIdCategoria)
                    .HasName("PK__Categori__03ECD441E22D4D8D");

                entity.ToTable("Categorias", "par");

                entity.Property(e => e.CatIdCategoria).HasColumnName("catIdCategoria");

                entity.Property(e => e.CatNombreCategoria)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("catNombreCategoria")
                    .HasComment("Descripcion de la categoria");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");
            });

            modelBuilder.Entity<Cdocumentacion>(entity =>
            {
                entity.HasKey(e => e.CdocIdCdocumentacion)
                    .HasName("PK__CDocumen__D85006B71B225697");

                entity.ToTable("CDocumentacion", "cont");

                entity.Property(e => e.CdocIdCdocumentacion).HasColumnName("cdocIdCDocumentacion");

                entity.Property(e => e.CdocCodContrato)
                    .HasColumnName("cdocCodContrato")
                    .HasComment("Id del requerimiento");

                entity.Property(e => e.CdocEstado)
                    .HasColumnName("cdocEstado")
                    .HasComment("Estado del registro");

                entity.Property(e => e.CdocTipoDocumento)
                    .HasColumnName("cdocTipoDocumento")
                    .HasComment("Indica el tipo de documento cargado para el contrato Ej: Seguimiento, Acta Inicio, Acta fin, etc");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.HasOne(d => d.CdocCodContratoNavigation)
                    .WithMany(p => p.Cdocumentacions)
                    .HasForeignKey(d => d.CdocCodContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CDocumentacion_Contratos");

                entity.HasOne(d => d.CdocTipoDocumentoNavigation)
                    .WithMany(p => p.Cdocumentacions)
                    .HasForeignKey(d => d.CdocTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CDocumentacion_DocumentsType");
            });

            modelBuilder.Entity<CertificadosEspeciale>(entity =>
            {
                entity.HasKey(e => e.CerIdCertificadosEspeciales)
                    .HasName("PK__Certific__F0FF115A2A8D5879");

                entity.ToTable("CertificadosEspeciales", "cer");

                entity.Property(e => e.CerIdCertificadosEspeciales).HasColumnName("cerIdCertificadosEspeciales");

                entity.Property(e => e.CerAlcanceTerritorial)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cerAlcanceTerritorial")
                    .HasComment("Seleccionar las empresas en las cuales desea la certificación");

                entity.Property(e => e.CerCodPeriodo)
                    .HasColumnName("cerCodPeriodo")
                    .HasComment("Id del periodo del certificado a descargar");

                entity.Property(e => e.CerCodTipoCertificado)
                    .HasColumnName("cerCodTipoCertificado")
                    .HasComment("Individual por empresa, corporativo");

                entity.Property(e => e.CerDescripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cerDescripcion")
                    .HasComment("Descripción de la solicitud");

                entity.Property(e => e.CerDestinatario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cerDestinatario")
                    .HasComment("Destinatario");

                entity.Property(e => e.CerEstado)
                    .IsRequired()
                    .HasColumnName("cerEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");

                entity.Property(e => e.CerEstadoCertificado)
                    .HasColumnName("cerEstadoCertificado")
                    .HasComment("Estado en el que se encuentra certificado");

                entity.Property(e => e.CerIncluirGarantia)
                    .HasColumnName("cerIncluirGarantia")
                    .HasComment("Incluir garantias?");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.HasOne(d => d.CerCodPeriodoNavigation)
                    .WithMany(p => p.CertificadosEspeciales)
                    .HasForeignKey(d => d.CerCodPeriodo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificadosEspeciales_Periodo");

                entity.HasOne(d => d.CerCodTipoCertificadoNavigation)
                    .WithMany(p => p.CertificadosEspeciales)
                    .HasForeignKey(d => d.CerCodTipoCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificadosEspeciales_TipoCertificado");
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.HasKey(e => e.ContIdContratos)
                    .HasName("PK__Contrato__F8CC530EF65D43FB");

                entity.ToTable("Contratos", "cont");

                entity.Property(e => e.ContIdContratos)
                    .HasColumnName("contIdContratos")
                    .HasComment("(generado automáticamente por el sistema),");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.ContCcrepresentanteCtante)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contCCRepresentanteCtante")
                    .HasComment("CC del representante");

                entity.Property(e => e.ContCcrepresentanteCtista)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contCCRepresentanteCtista")
                    .HasComment("CC del representante");

                entity.Property(e => e.ContClaseContrato)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contClaseContrato")
                    .HasComment("clase [de servicios | de suministros | etc.]");

                entity.Property(e => e.ContCodCoordinaroContratoCtante)
                    .HasColumnName("contCodCoordinaroContratoCtante")
                    .HasComment("id del coordinador del contrato");

                entity.Property(e => e.ContCodCoordinaroContratoCtista)
                    .HasColumnName("contCodCoordinaroContratoCtista")
                    .HasComment("nombre del coordinador o supervisor,");

                entity.Property(e => e.ContCodFormaPago)
                    .HasColumnName("contCodFormaPago")
                    .HasComment("Id de la forma de pago");

                entity.Property(e => e.ContCodGestorContratoCtante)
                    .HasColumnName("contCodGestorContratoCtante")
                    .HasComment("Id del gestor del contrato");

                entity.Property(e => e.ContCodGestorContratoCtista)
                    .HasColumnName("contCodGestorContratoCtista")
                    .HasComment("Id del gestor del contrato");

                entity.Property(e => e.ContCodRequerimiento)
                    .HasColumnName("contCodRequerimiento")
                    .HasComment("Id del requerimiento q necesita contrato");

                entity.Property(e => e.ContContratante)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("contContratante")
                    .HasComment("información del contratante (empresa de Urbaser que suscribe el contrato),");

                entity.Property(e => e.ContContratista)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("contContratista")
                    .HasComment("información del contratista,");

                entity.Property(e => e.ContDiasNotificacionNoRenovacionAutomatica)
                    .HasColumnName("contDiasNotificacionNoRenovacionAutomatica")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Días para notificación de no renovación automática");

                entity.Property(e => e.ContDireccionNotificacionCtante)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("contDireccionNotificacionCtante")
                    .HasComment("Direccion de la notificación");

                entity.Property(e => e.ContDireccionNotificacionCtista)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("contDireccionNotificacionCtista")
                    .HasComment("Direccion de la notificación");

                entity.Property(e => e.ContDuracionContrato)
                    .HasColumnName("contDuracionContrato")
                    .HasComment("Duracion del contrato en dias");

                entity.Property(e => e.ContFechaLiquidacionEsperada)
                    .HasColumnType("datetime")
                    .HasColumnName("contFechaLiquidacionEsperada")
                    .HasComment("fecha liquidacion esperada");

                entity.Property(e => e.ContFechaLiquidacionReal)
                    .HasColumnType("datetime")
                    .HasColumnName("contFechaLiquidacionReal")
                    .HasComment("fecha liquidacion real");

                entity.Property(e => e.ContNitCtante)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contNitCtante")
                    .HasComment("Nit del contratante");

                entity.Property(e => e.ContNitCtista)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contNitCtista")
                    .HasComment("Nit del contratante");

                entity.Property(e => e.ContObjetoContrato)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contObjetoContrato")
                    .HasComment("Objeto del contrato");

                entity.Property(e => e.ContObligacionesEspecificas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contObligacionesEspecificas")
                    .HasComment("Obligaciones especificas");

                entity.Property(e => e.ContPreavisoProrrogaMeses)
                    .HasColumnName("contPreavisoProrrogaMeses")
                    .HasComment("Pre aviso prorroga en meses");

                entity.Property(e => e.ContProrrogaAutomatica)
                    .HasColumnName("contProrrogaAutomatica")
                    .HasComment("¿renovación automática? [si | no],");

                entity.Property(e => e.ContRequiereActaInicio)
                    .HasColumnName("contRequiereActaInicio")
                    .HasComment("¿requiere acta de inicio? [si | no],");

                entity.Property(e => e.ContRequiereActaLiquidacion)
                    .HasColumnName("contRequiereActaLiquidacion")
                    .HasComment("¿requiere acta de liquidacion? [si | no],");

                entity.Property(e => e.ContRequiereIngresoPersonal)
                    .HasColumnName("contRequiereIngresoPersonal")
                    .HasComment("¿ingresará personal del contratista a las instalaciones del contratante? [si | no],");

                entity.Property(e => e.ContRteLegalCtante)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("contRteLegalCtante")
                    .HasComment("Representante legal");

                entity.Property(e => e.ContRteLegalCtista)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("contRteLegalCtista")
                    .HasComment("Representante legal");

                entity.Property(e => e.ContTelefonoCtante)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contTelefonoCtante")
                    .HasComment("Telefono");

                entity.Property(e => e.ContTelefonoCtista)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contTelefonoCtista")
                    .HasComment("Telefono");

                entity.Property(e => e.ContTipoDocumento)
                    .HasColumnName("contTipoDocumento")
                    .HasComment("1 = Contrato, 2 = Prorroga");

                entity.Property(e => e.ContUnidadNegocio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contUnidadNegocio")
                    .HasComment("Unidad de negocio");

                entity.Property(e => e.ContValorContrato)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("contValorContrato")
                    .HasComment("valor del contrato en pesos");

                entity.Property(e => e.ContVigenciaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("contVigenciaDesde")
                    .HasComment("Vigencia desde");

                entity.Property(e => e.ContVigenciaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("contVigenciaHasta")
                    .HasComment("Vigencia hasta");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.HasOne(d => d.ContCodFormaPagoNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.ContCodFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contratos_FormasPago");

                entity.HasOne(d => d.ContCodRequerimientoNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.ContCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contratos_Requerimientos");
            });

            modelBuilder.Entity<DocPrv>(entity =>
            {
                entity.HasKey(e => e.DocIdDocPrv)
                    .HasName("PK__DocPrv__051C86F306B3B247");

                entity.ToTable("DocPrv", "par");

                entity.Property(e => e.DocIdDocPrv).HasColumnName("docIdDocPrv");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.DocCodDocumento)
                    .HasColumnName("docCodDocumento")
                    .HasComment("id del documento a relacionar");

                entity.Property(e => e.DocCodProveedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("docCodProveedor")
                    .HasComment("Id de la tabla a relacionar");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.CocIdDocumentos)
                    .HasName("PK__Document__073A4CEDE0596C1F");

                entity.ToTable("Documentos", "par");

                entity.Property(e => e.CocIdDocumentos).HasColumnName("cocIdDocumentos");

                entity.Property(e => e.CocDescripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cocDescripcion")
                    .HasComment("Descripcion a mostrar como texto informativo");

                entity.Property(e => e.CocEstado)
                    .IsRequired()
                    .HasColumnName("cocEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica el estado del registro");

                entity.Property(e => e.CocNombreDocumento)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cocNombreDocumento")
                    .HasComment("Descripción del registro");

                entity.Property(e => e.CocVigencia)
                    .HasColumnName("cocVigencia")
                    .HasComment("Indica si el documento tiene vigencia");

                entity.Property(e => e.CocVigenciaMaxima)
                    .HasColumnName("cocVigenciaMaxima")
                    .HasComment("Indica vigencia maxima, en dias");

                entity.Property(e => e.CoclimitLoad)
                    .HasColumnName("coclimitLoad")
                    .HasComment("Indica si este documento tiene limite de cargas");

                entity.Property(e => e.Cocrequiered)
                    .HasColumnName("cocrequiered")
                    .HasComment("Indica si el documento es requerido");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");
            });

            modelBuilder.Entity<DocumentsType>(entity =>
            {
                entity.HasKey(e => e.TipDidDocumentsType)
                    .HasName("PK__Document__E78E4133EA8E1205");

                entity.ToTable("DocumentsType", "par");

                entity.Property(e => e.TipDidDocumentsType).HasColumnName("tipDIdDocumentsType");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.TipDnombreDocumentType)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("tipDNombreDocumentType")
                    .HasComment("Descripcion del tipo de documento");
            });

            modelBuilder.Entity<FormasPago>(entity =>
            {
                entity.HasKey(e => e.FpagIdFormasPago)
                    .HasName("PK__FormasPa__6AAFE1C4F5E7F814");

                entity.ToTable("FormasPago", "par");

                entity.Property(e => e.FpagIdFormasPago).HasColumnName("fpagIdFormasPago");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.FpagDescripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("fpagDescripcion")
                    .HasComment("Descripción de la forma de pago");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");
            });

            modelBuilder.Entity<HashRecoveryAccount>(entity =>
            {
                entity.HasKey(e => e.IdHashRecoveryAccount);

                entity.ToTable("HashRecoveryAccount", "usr");

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("Usuario");

                entity.Property(e => e.CodigoHash)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Token");

                entity.Property(e => e.Estado).HasComment("Estado del token");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha del registro");
            });

            modelBuilder.Entity<IdentidadesGlobale>(entity =>
            {
                entity.HasKey(e => e.AuIdentidad)
                    .HasName("PK_Identidades");

                entity.ToTable("IdentidadesGlobales", "conf");

                entity.HasIndex(e => new { e.Ididentidad, e.Consecutivo }, "UK_Identidades")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Ididentidad)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDIdentidad");
            });

            modelBuilder.Entity<LogErrore>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Controlador)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Funcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModulosXaplicacion>(entity =>
            {
                entity.HasKey(e => new { e.IdModulo, e.CodAplicacion });

                entity.ToTable("ModulosXAplicacion", "conf");

                entity.Property(e => e.IdModulo).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.Listador).HasColumnName("LIstador");

                entity.Property(e => e.NombreModulo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenesCompra>(entity =>
            {
                entity.HasKey(e => e.OrdIdOrdenesCompra)
                    .HasName("PK__OrdenesC__C3BCCACC6467F644");

                entity.ToTable("OrdenesCompra", "ord");

                entity.Property(e => e.OrdIdOrdenesCompra).HasColumnName("ordIdOrdenesCompra");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.OrdCodRequerimiento)
                    .HasColumnName("ordCodRequerimiento")
                    .HasComment("Relacion requerimiento / orden");

                entity.Property(e => e.OrdCondicionesEntrega)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ordCondicionesEntrega")
                    .HasComment("CondicionesEntrega");

                entity.Property(e => e.OrdDireccionEntrega)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ordDireccionEntrega")
                    .HasComment("DireccionEntrega");

                entity.Property(e => e.OrdEstado)
                    .IsRequired()
                    .HasColumnName("ordEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado de la orden");

                entity.Property(e => e.OrdObservacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ordObservacion")
                    .HasComment("Observacion");

                entity.Property(e => e.OrdProcesoFacturacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ordProcesoFacturacion")
                    .HasComment("ProcesoFacturacion");

                entity.HasOne(d => d.OrdCodRequerimientoNavigation)
                    .WithMany(p => p.OrdenesCompras)
                    .HasForeignKey(d => d.OrdCodRequerimiento)
                    .HasConstraintName("FK_OrdenesCompra_Requerimientos");
            });

            modelBuilder.Entity<PathsPortal>(entity =>
            {
                entity.ToTable("PathsPortal", "conf");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID")
                    .HasComment("Estos codigos no pueden ser modificados porque conectan con la tabla conf.ArchivosAdjuntos campos CodPathsInterno y CodPathsWeb");

                entity.Property(e => e.Clasificar)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Sin Clasificar')")
                    .HasComment("clasificar si por ejemplo es un path para un formulario en específico.");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((7777777))")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((7777777))")
                    .HasComment("Cedula del usuario que actualiza el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de Actualización del registro.");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Sin Observacion')");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Red')")
                    .HasComment("Indicar si es un link de red o web");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasKey(e => e.PerIdPeriodo)
                    .HasName("PK__Periodo__92B3474AE4CD4290");

                entity.ToTable("Periodo", "par");

                entity.Property(e => e.PerIdPeriodo).HasColumnName("perIdPeriodo");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.PerDescripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("perDescripcion")
                    .HasComment("Descripcion del periodo");

                entity.Property(e => e.PerEstado)
                    .IsRequired()
                    .HasColumnName("perEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.PrvIdProveedores)
                    .HasName("PK__Proveedo__839B99868A8BBA5E");

                entity.ToTable("Proveedores", "prv");

                entity.Property(e => e.PrvIdProveedores)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("prvIdProveedores")
                    .HasComment("Nit del proveedor");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.PrvCodBanco)
                    .HasColumnName("prvCodBanco")
                    .HasComment("Id del banco");

                entity.Property(e => e.PrvCodCiudad)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("prvCodCiudad")
                    .HasComment("Codigo dane de la ciudad.");

                entity.Property(e => e.PrvCodEmpresa)
                    .HasColumnName("prvCodEmpresa")
                    .HasComment("Cod empresa seleccionada");

                entity.Property(e => e.PrvCodTipoCuenta)
                    .HasColumnName("prvCodTipoCuenta")
                    .HasComment("Id del tipo de cuenta");

                entity.Property(e => e.PrvCodTipoProveeedor)
                    .HasColumnName("prvCodTipoProveeedor")
                    .HasComment("Id tipo de proveedor seleccionado");

                entity.Property(e => e.PrvContacto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvContacto")
                    .HasComment("Contactos del proveedor separados por comas (,)");

                entity.Property(e => e.PrvCpaCodCondicionesPago)
                    .HasColumnName("prvCpaCodCondicionesPago")
                    .HasComment("Id de la condicion de pago seleccionada (Cpa => Condiciones pago)");

                entity.Property(e => e.PrvCpaContadoCual)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("prvCpaContadoCual")
                    .HasComment("Si el pago es de contado indica porcentaje de descuento");

                entity.Property(e => e.PrvCpaCual)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("prvCpaCual")
                    .HasComment("En caso de seleccionar otro, describir cual");

                entity.Property(e => e.PrvDeclaramientoInhabilidadesInteres)
                    .HasColumnName("prvDeclaramientoInhabilidadesInteres")
                    .HasComment("Declaramiento");

                entity.Property(e => e.PrvDireccion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvDireccion")
                    .HasComment("Dirección");

                entity.Property(e => e.PrvDtllesBanNroCuenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prvDtllesBanNroCuenta")
                    .HasComment("Numero de cuenta");

                entity.Property(e => e.PrvExperienciaSector)
                    .HasColumnName("prvExperienciaSector")
                    .HasComment("Consulta si tiene experiencia en el sector (Si/No)");

                entity.Property(e => e.PrvMail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prvMail")
                    .HasDefaultValueSql("('NoTieneCorreo')")
                    .HasComment("Correo electrónico del proveedor");

                entity.Property(e => e.PrvNombreProveedor)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("prvNombreProveedor")
                    .HasComment("Nombre o Razon Social del proveedor");

                entity.Property(e => e.PrvPoliticaTratamientoDatosPersonales)
                    .HasColumnName("prvPoliticaTratamientoDatosPersonales")
                    .HasComment("id de la refer");

                entity.Property(e => e.PrvProveeedor)
                    .HasColumnName("prvProveeedor")
                    .HasComment("Proveedor (Juridico - Natural)");

                entity.Property(e => e.PrvRteLegalApellido)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvRteLegalApellido")
                    .HasComment("Apellido del representante legal");

                entity.Property(e => e.PrvRteLegalCodCiudad)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("prvRteLegal_CodCiudad")
                    .HasComment("Ciudad representante legal");

                entity.Property(e => e.PrvRteLegalEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prvRteLegalEmail")
                    .HasDefaultValueSql("('NoTieneCorreo')")
                    .HasComment("Email del representante legal");

                entity.Property(e => e.PrvRteLegalIdentificacion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvRteLegalIdentificacion")
                    .HasComment("Identificación del representante legal");

                entity.Property(e => e.PrvRteLegalNombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvRteLegalNombre")
                    .HasComment("Nombre del representante legal");

                entity.Property(e => e.PrvRteLegalTelefonoMovil)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvRteLegalTelefonoMovil")
                    .HasComment("Telefono movil del representante legal");

                entity.Property(e => e.PrvTelefono)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prvTelefono")
                    .HasComment("Telefono del proveedor");

                entity.HasOne(d => d.PrvCodBancoNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.PrvCodBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proveedores_Bancos");

                //entity.HasOne(d => d.PrvCodCiudadNavigation)
                //    .WithMany(p => p.Proveedores)
                //    .HasForeignKey(d => d.PrvCodCiudad)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Proveedores_Ciudades");

                //entity.HasOne(d => d.PrvCodEmpresaNavigation)
                //    .WithMany(p => p.Proveedores)
                //    .HasForeignKey(d => d.PrvCodEmpresa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Proveedores_Empresas");

                entity.HasOne(d => d.PrvCodTipoCuentaNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.PrvCodTipoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proveedores_TipoCuenta");

                entity.HasOne(d => d.PrvCodTipoProveeedorNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.PrvCodTipoProveeedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proveedores_TipoProveedor");

                entity.HasOne(d => d.PrvCpaCodCondicionesPagoNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.PrvCpaCodCondicionesPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proveedores_PrvCondicionesPago");
            });

            modelBuilder.Entity<PrvCondicionesPago>(entity =>
            {
                entity.HasKey(e => e.CondPagoIdPrvCondicionesPago)
                    .HasName("PK__PrvCondi__E958C1CF89611E6C");

                entity.ToTable("PrvCondicionesPago", "prv");

                entity.Property(e => e.CondPagoIdPrvCondicionesPago).HasColumnName("condPagoIdPrvCondicionesPago");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.CondPagoEstado)
                    .IsRequired()
                    .HasColumnName("condPagoEstado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");
            });

            modelBuilder.Entity<PrvDocumento>(entity =>
            {
                entity.HasKey(e => e.PrvdIdPrvDocumentos)
                    .HasName("PK__PrvDocum__85852292807EBCE5");

                entity.ToTable("PrvDocumentos", "prv");

                entity.Property(e => e.PrvdIdPrvDocumentos).HasColumnName("prvdIdPrvDocumentos");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.PrvdCodDocumento)
                    .HasColumnName("prvdCodDocumento")
                    .HasComment("id del documento a relacionar");

                entity.Property(e => e.PrvdCodProveedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("prvdCodProveedor")
                    .HasComment("Id de la tabla a relacionar");

                entity.Property(e => e.PrvdEstadoDocumento)
                    .HasColumnName("prvdEstadoDocumento")
                    .HasComment("Estado del documento");

                entity.Property(e => e.PrvdExpedicion)
                    .HasColumnType("datetime")
                    .HasColumnName("prvdExpedicion")
                    .HasComment("Fecha de vencimiento del documento, si aplica");

                entity.Property(e => e.PrvdExtDocument)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("prvdExtDocument");

                entity.Property(e => e.PrvdNameDocument)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prvdNameDocument");

                entity.Property(e => e.PrvdOriginalNameDocument)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prvdOriginalNameDocument");

                entity.Property(e => e.PrvdSendNotification)
                    .HasColumnName("prvdSendNotification")
                    .HasComment("Este campo indica si ya ha sido envio correo electronico con la notificacion del cambio");

                entity.Property(e => e.PrvdSizeDocument).HasColumnName("prvdSizeDocument");

                entity.Property(e => e.PrvdUrlDocument)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("prvdUrlDocument");

                entity.Property(e => e.PrvdValidationDocument)
                    .HasColumnName("prvdValidationDocument")
                    .HasComment("Este campo indica si el documento ha sido validado por el gestor de documentos al ser cargado por el proveedor");

                entity.HasOne(d => d.PrvdCodProveedorNavigation)
                    .WithMany(p => p.PrvDocumentos)
                    .HasForeignKey(d => d.PrvdCodProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrvDocumentos_Proveedores");
            });

            modelBuilder.Entity<PrvFormHojaVidum>(entity =>
            {
                entity.HasKey(e => e.PrvFrmIdPrvFormHojaVida)
                    .HasName("PK__PrvFormH__5C0F80CDE431976C");

                entity.ToTable("PrvFormHojaVida", "prv");

                entity.Property(e => e.PrvFrmIdPrvFormHojaVida).HasColumnName("prvFrmIdPrvFormHojaVida");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')");

                entity.Property(e => e.PrvFrmCodProveedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("prvFrmCodProveedor")
                    .HasComment("Id del proveedor creado");

                entity.Property(e => e.PrvFrmEstado)
                    .HasColumnName("prvFrmEstado")
                    .HasComment("Estado en el q se encuentra el registro");

                entity.Property(e => e.PrvFrmFirmado)
                    .HasColumnName("prvFrmFirmado")
                    .HasComment("Indica si el documento se encuentra firmado electronicamente por las personas correspondientes");

                entity.Property(e => e.PrvFrmpathPdfHojaVida)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("prvFrmpathPdfHojaVida")
                    .HasComment("Url de la ruta donde se guarda la hoja de vida del proveedor");

                entity.HasOne(d => d.PrvFrmCodProveedorNavigation)
                    .WithMany(p => p.PrvFormHojaVida)
                    .HasForeignKey(d => d.PrvFrmCodProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrvFormHojaVida_Proveedores");
            });

            modelBuilder.Entity<PrvProdServ>(entity =>
            {
                entity.HasKey(e => e.ProSerIdPrvProdServ)
                    .HasName("PK__PrvProdS__2CF42FFCC42A401D");

                entity.ToTable("PrvProdServ", "prv");

                entity.Property(e => e.ProSerIdPrvProdServ).HasColumnName("proSer_IdPrvProdServ");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.ProSerEstado)
                    .IsRequired()
                    .HasColumnName("proSerEstado")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PrvReferencia>(entity =>
            {
                entity.HasKey(e => e.RefIdPrvReferencias)
                    .HasName("PK__PrvRefer__5568189159A20183");

                entity.ToTable("PrvReferencias", "prv");

                entity.Property(e => e.RefIdPrvReferencias).HasColumnName("refIdPrvReferencias");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RefContacto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("refContacto")
                    .HasComment("Contacto");
            });

            modelBuilder.Entity<PrvRequiredSign>(entity =>
            {
                entity.HasKey(e => e.PrvSignIdPrvRequiredSign)
                    .HasName("PK__PrvRequi__40D7E17145A78F05");

                entity.ToTable("PrvRequiredSign", "prv");

                entity.Property(e => e.PrvSignIdPrvRequiredSign).HasColumnName("prvSignIdPrvRequiredSign");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.PrvSignCodRequiredSign)
                    .HasColumnName("prvSignCodRequiredSign")
                    .HasComment("Id de las firmas requeridas para el Formulario de Hoja de Vida");
            });

            modelBuilder.Entity<PrvSocio>(entity =>
            {
                entity.HasKey(e => e.SocIdPrvSocios)
                    .HasName("PK__PrvSocio__C7504AB2EED62747");

                entity.ToTable("PrvSocios", "prv");

                entity.Property(e => e.SocIdPrvSocios)
                    .HasColumnName("socIdPrvSocios")
                    .HasComment("Id socios");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.SocIdentificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("socIdentificacion")
                    .HasComment("Identificación");
            });

            modelBuilder.Entity<ReqArtSerRequerido>(entity =>
            {
                entity.HasKey(e => e.RasrIdReqArtSerRequeridos)
                    .HasName("PK__ReqArtSe__AF946C97ECE704F0");

                entity.ToTable("ReqArtSerRequeridos", "req");

                entity.Property(e => e.RasrIdReqArtSerRequeridos).HasColumnName("rasrIdReqArtSerRequeridos");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RasrCantidad)
                    .HasColumnName("rasrCantidad")
                    .HasComment("Cantidad del articulo o servicio");

                entity.Property(e => e.RasrCodCategoria)
                    .HasColumnName("rasrCodCategoria")
                    .HasComment("Id de la categoría");

                entity.Property(e => e.RasrCodRequerimiento)
                    .HasColumnName("rasrCodRequerimiento")
                    .HasComment("Id del requerimiento");

                entity.Property(e => e.RasrCodUnidadMedida)
                    .HasColumnName("rasrCodUnidadMedida")
                    .HasComment("Medida del articulo o servicio");

                entity.Property(e => e.RasrDescripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("rasrDescripcion")
                    .HasComment("Descripcion del articulo o servicio");

                entity.Property(e => e.RasrFichaTecnica)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rasrFichaTecnica")
                    .HasComment("Url de la ficha tecnica");

                entity.Property(e => e.RasrItem)
                    .HasColumnName("rasrItem")
                    .HasComment("Nro del item");

                entity.Property(e => e.RasrItemEquivalente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rasrItemEquivalente")
                    .HasComment("Item equivalente");

                entity.Property(e => e.RasrObligatorio)
                    .IsRequired()
                    .HasColumnName("rasrObligatorio")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Si o No en lo obligatorio");

                entity.HasOne(d => d.RasrCodCategoriaNavigation)
                    .WithMany(p => p.ReqArtSerRequeridos)
                    .HasForeignKey(d => d.RasrCodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqArtSerRequeridos_Categoria");

                entity.HasOne(d => d.RasrCodRequerimientoNavigation)
                    .WithMany(p => p.ReqArtSerRequeridos)
                    .HasForeignKey(d => d.RasrCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqArtSerRequeridos_Requerimientos");
            });

            modelBuilder.Entity<ReqCriterio>(entity =>
            {
                entity.HasKey(e => e.RcriIdReqCriterios)
                    .HasName("PK__ReqCrite__6589D4330F016B4E");

                entity.ToTable("ReqCriterios", "req");

                entity.Property(e => e.RcriIdReqCriterios).HasColumnName("rcriIdReqCriterios");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RcriCodTypeQuestion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rcriCodTypeQuestion")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Id del tipo de dato a recibir (Text, number, selección)");

                entity.Property(e => e.RcriCriterio)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("rcriCriterio")
                    .HasComment("Creterio para la evaluación");

                entity.Property(e => e.RcriEstado)
                    .IsRequired()
                    .HasColumnName("rcriEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");
            });

            modelBuilder.Entity<ReqCriterosEvaluacion>(entity =>
            {
                entity.HasKey(e => e.RcevIdReqCriterosEvaluacion)
                    .HasName("PK__ReqCrite__2EB385477F9CA31E");

                entity.ToTable("ReqCriterosEvaluacion", "req");

                entity.Property(e => e.RcevIdReqCriterosEvaluacion).HasColumnName("rcevIdReqCriterosEvaluacion");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RcevCodCriterio)
                    .HasColumnName("rcevCodCriterio")
                    .HasComment("Id criterio");

                entity.Property(e => e.RcevCodRequerimiento)
                    .HasColumnName("rcevCodRequerimiento")
                    .HasComment("Id del requerimiento al q se le agregaran los criterios");

                entity.Property(e => e.RcevEstado)
                    .IsRequired()
                    .HasColumnName("rcevEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");

                entity.HasOne(d => d.RcevCodCriterioNavigation)
                    .WithMany(p => p.ReqCriterosEvaluacions)
                    .HasForeignKey(d => d.RcevCodCriterio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqCriterosEvaluacion_ReqCriterios");

                entity.HasOne(d => d.RcevCodRequerimientoNavigation)
                    .WithMany(p => p.ReqCriterosEvaluacions)
                    .HasForeignKey(d => d.RcevCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqCriterosEvaluacion_Requerimientos");
            });

            modelBuilder.Entity<ReqListDocumento>(entity =>
            {
                entity.HasKey(e => e.RldocIdReqListDocumentos)
                    .HasName("PK__ReqListD__C18E147F707FF302");

                entity.ToTable("ReqListDocumentos", "req");

                entity.Property(e => e.RldocIdReqListDocumentos).HasColumnName("rldocIdReqListDocumentos");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RlCodRequerimiento)
                    .HasColumnName("rlCodRequerimiento")
                    .HasComment("Id del requerimiento");

                entity.Property(e => e.RldocCodDocument)
                    .HasColumnName("rldocCodDocument")
                    .HasComment("Id del requerimiento");

                entity.Property(e => e.RldocCodUser)
                    .HasColumnName("rldocCodUser")
                    .HasComment("Id del documento registrado para cargue en el requerimiento");

                entity.Property(e => e.RldocFechaRegistro)
                    .IsRequired()
                    .HasColumnName("rldocFechaRegistro")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");

                entity.HasOne(d => d.RlCodRequerimientoNavigation)
                    .WithMany(p => p.ReqListDocumentos)
                    .HasForeignKey(d => d.RlCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqListDocumentos_Requerimientos");
            });

            modelBuilder.Entity<ReqLog>(entity =>
            {
                entity.HasKey(e => e.RlogIdReqLog)
                    .HasName("PK__ReqLog__B81AC86C7C8827BD");

                entity.ToTable("ReqLog", "req");

                entity.Property(e => e.RlogIdReqLog).HasColumnName("rlogIdReqLog");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RlogControlador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rlogControlador")
                    .HasComment("Controlador en que se genera la acción");

                entity.Property(e => e.RlogEstado)
                    .IsRequired()
                    .HasColumnName("rlogEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");

                entity.Property(e => e.RlogVista)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rlogVista")
                    .HasComment("Vista en la que se genera la acción");
            });

            modelBuilder.Entity<ReqOfertado>(entity =>
            {
                entity.HasKey(e => e.RoferIdReqOfertados)
                    .HasName("PK__ReqOfert__7661702E7628206C");

                entity.ToTable("ReqOfertados", "req");

                entity.Property(e => e.RoferIdReqOfertados).HasColumnName("roferIdReqOfertados");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RoferCodRequerimiento)
                    .HasColumnName("roferCodRequerimiento")
                    .HasComment("Id del requerimiento ofertado");

                entity.Property(e => e.RoferEstado)
                    .HasColumnName("roferEstado")
                    .HasComment("Estado de la oferta");

                entity.Property(e => e.RoferfechaFinOfertaPresentada)
                    .HasColumnType("datetime")
                    .HasColumnName("roferfechaFinOfertaPresentada")
                    .HasComment("Fecha fin de la oferta presentada");

                entity.HasOne(d => d.RoferCodRequerimientoNavigation)
                    .WithMany(p => p.ReqOfertados)
                    .HasForeignKey(d => d.RoferCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqOfertados_Requerimientos");
            });

            modelBuilder.Entity<ReqPolizasSeguro>(entity =>
            {
                entity.HasKey(e => e.RpsIdReqPolizasSeguro)
                    .HasName("PK__ReqPoliz__5939D7D4E0DE2BE4");

                entity.ToTable("ReqPolizasSeguro", "req");

                entity.Property(e => e.RpsIdReqPolizasSeguro).HasColumnName("rpsIdReqPolizasSeguro");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RpsCobertura)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("rpsCobertura")
                    .HasComment("Descripción de la cobertura");

                entity.Property(e => e.RpsCodRequirimiento)
                    .HasColumnName("rpsCodRequirimiento")
                    .HasComment("Id del requerimiento");

                entity.Property(e => e.RpsEstado)
                    .IsRequired()
                    .HasColumnName("rpsEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado Activo/Inactivo del registro");

                entity.Property(e => e.RpsTermino)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rpsTermino")
                    .HasComment("Descripción del termino");

                entity.HasOne(d => d.RpsCodRequirimientoNavigation)
                    .WithMany(p => p.ReqPolizasSeguros)
                    .HasForeignKey(d => d.RpsCodRequirimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqPolizasSeguro_Requerimientos");
            });

            modelBuilder.Entity<ReqQuestionAnswer>(entity =>
            {
                entity.HasKey(e => e.RqaIdReqQuestionAnswer)
                    .HasName("PK__ReqQuest__B958DCF844C41D27");

                entity.ToTable("ReqQuestionAnswer", "req");

                entity.Property(e => e.RqaIdReqQuestionAnswer).HasColumnName("rqaIdReqQuestionAnswer");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RqaCodProveedor)
                    .HasColumnName("rqaCodProveedor")
                    .HasComment("Id del proveedor");

                entity.Property(e => e.RqaCodRequerimiento)
                    .HasColumnName("rqaCodRequerimiento")
                    .HasComment("Id del requerimiento");

                entity.Property(e => e.RqaCodUsuario)
                    .HasColumnName("rqaCodUsuario")
                    .HasComment("Id del gestor de proveedor");

                entity.Property(e => e.RqaComentario)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("rqaComentario")
                    .HasComment("Comentario realizado");

                entity.Property(e => e.RqaEstado)
                    .IsRequired()
                    .HasColumnName("rqaEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica el estado del comentario");

                entity.Property(e => e.RqahasUploadFile)
                    .HasColumnName("rqahasUploadFile")
                    .HasComment("Indica si el comentario tiene algun archivo adjunto");

                entity.Property(e => e.RqaisPrivate)
                    .HasColumnName("rqaisPrivate")
                    .HasComment("Indica si el comentario es privado");

                entity.HasOne(d => d.RqaCodRequerimientoNavigation)
                    .WithMany(p => p.ReqQuestionAnswers)
                    .HasForeignKey(d => d.RqaCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqQuestionAnswer_Requerimientos");
            });

            modelBuilder.Entity<ReqQuestionAnswerNotification>(entity =>
            {
                entity.HasKey(e => e.RqanIdReqQuestionAnswerNotification)
                    .HasName("PK__ReqQuest__FAD3488DD69B061C");

                entity.ToTable("ReqQuestionAnswerNotification", "req");

                entity.Property(e => e.RqanIdReqQuestionAnswerNotification).HasColumnName("rqanIdReqQuestionAnswerNotification");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RqanCodProveedor)
                    .HasColumnName("rqanCodProveedor")
                    .HasComment("Id del proveedor");

                entity.Property(e => e.RqanCodRequerimiento).HasColumnName("rqanCodRequerimiento");

                entity.Property(e => e.RqanCodUsuario)
                    .HasColumnName("rqanCodUsuario")
                    .HasComment("Id del gestor de requerimiento");

                entity.Property(e => e.RqanEstado)
                    .HasColumnName("rqanEstado")
                    .HasComment("Indicado el estado de la notificación");

                entity.HasOne(d => d.RqanCodRequerimientoNavigation)
                    .WithMany(p => p.ReqQuestionAnswerNotifications)
                    .HasForeignKey(d => d.RqanCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqQuestionAnswerNotification_Requerimientos");
            });

            modelBuilder.Entity<ReqRtaCriteriosEvaluacion>(entity =>
            {
                entity.HasKey(e => e.RcriIdReqRtaCriteriosEvaluacion)
                    .HasName("PK__ReqRtaCr__42D386FE814F525E");

                entity.ToTable("ReqRtaCriteriosEvaluacion", "req");

                entity.Property(e => e.RcriIdReqRtaCriteriosEvaluacion).HasColumnName("rcriIdReqRtaCriteriosEvaluacion");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.RcriCodCriterio)
                    .HasColumnName("rcriCodCriterio")
                    .HasComment("Id del criterio");

                entity.Property(e => e.RcriCodRequerimiento)
                    .HasColumnName("rcriCodRequerimiento")
                    .HasComment("Id de la requisición");

                entity.Property(e => e.RcriEstado)
                    .IsRequired()
                    .HasColumnName("rcriEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado de la respuesta del criterio");

                entity.Property(e => e.RcriRtaCriterio)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rcriRtaCriterio")
                    .HasComment("Rta del criterio evaluado");

                entity.HasOne(d => d.RcriCodCriterioNavigation)
                    .WithMany(p => p.ReqRtaCriteriosEvaluacions)
                    .HasForeignKey(d => d.RcriCodCriterio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqRtaCriteriosEvaluacion_ReqCriterios");

                entity.HasOne(d => d.RcriCodRequerimientoNavigation)
                    .WithMany(p => p.ReqRtaCriteriosEvaluacions)
                    .HasForeignKey(d => d.RcriCodRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqRtaCriteriosEvaluacion_Requerimientos");
            });

            modelBuilder.Entity<Requerimiento>(entity =>
            {
                entity.HasKey(e => e.ReqIdRequerimientos)
                    .HasName("PK__Requerim__B6C121E02AB7CB32");

                entity.ToTable("Requerimientos", "req");

                entity.Property(e => e.ReqIdRequerimientos)
                    .ValueGeneratedNever()
                    .HasColumnName("reqIdRequerimientos");

                entity.Property(e => e.Bn)
                    .HasColumnType("datetime")
                    .HasColumnName("bn")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.ReqCierraOferta)
                    .HasColumnType("datetime")
                    .HasColumnName("reqCierraOferta")
                    .HasComment("Fecha de cierre de la oferta");

                entity.Property(e => e.ReqCodAgencia)
                    .HasColumnName("reqCodAgencia")
                    .HasComment("Id de la agencia seleccionada");

                entity.Property(e => e.ReqCodCategoria)
                    .HasColumnName("reqCodCategoria")
                    .HasComment("Id de la categoria");

                entity.Property(e => e.ReqCodEmpresa)
                    .HasColumnName("reqCodEmpresa")
                    .HasComment("Empresa que requiere los productos o servicios: lista desplegable con las empresas de Urbaser Colombia");

                entity.Property(e => e.ReqCodGestorCompras)
                    .HasColumnName("reqCodGestorCompras")
                    .HasComment("Id del gesor de compras asignado");

                entity.Property(e => e.ReqCodGestorContrato)
                    .HasColumnName("reqCodGestorContrato")
                    .HasComment("Id del gestor de contrato, si aplica");

                entity.Property(e => e.ReqCodLugarEntrega)
                    .HasColumnName("reqCodLugarEntrega")
                    .HasComment("Id lugar entrega");

                entity.Property(e => e.ReqCompraPrevista)
                    .HasColumnType("datetime")
                    .HasColumnName("reqCompraPrevista")
                    .HasComment("Fecha de compra prevista");

                entity.Property(e => e.ReqDescription)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("reqDescription")
                    .HasComment("Campo de texto enriquecido mediante el cual se puede describir de forma general el requerimiento");

                entity.Property(e => e.ReqEstado)
                    .HasColumnName("reqEstado")
                    .HasComment("Estado en que se encuentra el registro");

                entity.Property(e => e.ReqFechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("reqFechaEntrega")
                    .HasComment("Fecha de entrega prevista");

                entity.Property(e => e.ReqGarantiasExigidas)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("reqGarantiasExigidas")
                    .HasComment("Texto en WYSING con las garatias exigidas");

                entity.Property(e => e.ReqLugarEntrega)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("reqLugarEntrega")
                    .HasComment("Lugar de entrega");

                entity.Property(e => e.ReqNombreCentroCosto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("reqNombreCentroCosto")
                    .HasComment("Nombre");

                entity.Property(e => e.ReqReqType)
                    .HasColumnName("reqReqType")
                    .HasComment("Indica si es una orden de compra o de servicio");

                entity.Property(e => e.ReqRequiereContrato)
                    .HasColumnName("reqRequiereContrato")
                    .HasComment("Indica si la requisicion requiere o no contrato");

                entity.Property(e => e.ReqfinOfertaPresentada)
                    .HasColumnType("datetime")
                    .HasColumnName("reqfinOfertaPresentada")
                    .HasComment("Fecha en que vence la oferta presentada");
            });

            modelBuilder.Entity<TipoCertificado>(entity =>
            {
                entity.HasKey(e => e.TicIdTipoCertificado)
                    .HasName("PK__TipoCert__CE39B97D4DF18410");

                entity.ToTable("TipoCertificado", "par");

                entity.Property(e => e.TicIdTipoCertificado).HasColumnName("ticIdTipoCertificado");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.TicDescripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ticDescripcion")
                    .HasComment("Descripcion del tipo de certificado");

                entity.Property(e => e.TicEstado)
                    .IsRequired()
                    .HasColumnName("ticEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro");
            });

            modelBuilder.Entity<TipoCuentum>(entity =>
            {
                entity.HasKey(e => e.TipCtaIdTipoCuenta)
                    .HasName("PK__TipoCuen__503E2C3E2D93F0F1");

                entity.ToTable("TipoCuenta", "par");

                entity.Property(e => e.TipCtaIdTipoCuenta).HasColumnName("tipCtaIdTipoCuenta");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.TipCtaEstado)
                    .IsRequired()
                    .HasColumnName("tipCtaEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro Activo - Inactivo");

                entity.Property(e => e.TipCtaNombreTipoCuenta)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("tipCtaNombreTipoCuenta")
                    .HasComment("Descripcion del tipo de cuenta");
            });

            modelBuilder.Entity<TipoProveedor>(entity =>
            {
                entity.HasKey(e => e.TipPrvIdTipoProveedor)
                    .HasName("PK__TipoProv__3F2A1FFD1325F21B");

                entity.ToTable("TipoProveedor", "par");

                entity.Property(e => e.TipPrvIdTipoProveedor).HasColumnName("tipPrvIdTipoProveedor");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del usuario que crea el registro");

                entity.Property(e => e.CodUserUpdate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('7777777')")
                    .HasComment("Cedula del ultimo usuario que actualizó el registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de creación del registro.");

                entity.Property(e => e.FechaRegistroUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Fecha de la ultima actualización del registro.");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.InfoUpdate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0|0|0')")
                    .HasComment("En este campo almacenamos la ultima direccion ip, navegador y version del navegador del cliente.");

                entity.Property(e => e.TipPrvEstado)
                    .IsRequired()
                    .HasColumnName("tipPrvEstado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Estado del registro Activo - Inactivo");

                entity.Property(e => e.TipPrvNombreTipoProveedor)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("tipPrvNombreTipoProveedor")
                    .HasComment("Descripcion del tipo de proveedor");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
