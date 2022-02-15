using Core.Entities;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public partial class DbModelContext : DbContext
    {
        public DbModelContext()
        {
        }

        public DbModelContext(DbContextOptions<DbModelContext> options)
            : base(options)
        {
        }

        #region Propiedades Contexto
        public virtual DbSet<ResponseAction> ResponseActions { get; set; }
        public virtual DbSet<ParametrosIniciales> ParametrosIniciales { get; set; }
        public virtual DbSet<Aplicacion> Aplicaciones { get; set; }
        public virtual DbSet<AppsFileServerPath> AppsFileServerPaths { get; set; }
        public virtual DbSet<Ciudade> Ciudades { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Perfil> Perfiles { get; set; }
        public virtual DbSet<PerfilesXusuario> PerfilesXusuarios { get; set; }
        public virtual DbSet<PermisosEmpresasxUsuario> PermisosEmpresasxUsuarios { get; set; }
        public virtual DbSet<PermisosMenuXperfil> PermisosMenuXperfils { get; set; }
        public virtual DbSet<PermisosUsuarioxMenu> PermisosUsuarioxMenus { get; set; }
        public virtual DbSet<PeticionesCors> PeticionesCors { get; set; }
        public virtual DbSet<RefererServidore> RefererServidores { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<PerfilesXusuarioView> PerfilesXusuariosView { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.ApplyAllConfigurations();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
