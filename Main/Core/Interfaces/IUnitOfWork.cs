using Core.Entities;
using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    /// <summary>
    /// Interfaz encargada de indicar los atributos y métodos que la unidad de trabajo debe implementar
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IRepository<AppsFileServerPath> AppsFileServerPathRepository { get; }
        IRepository<PeticionesCors> PeticionesCorsRepository { get; }
        IRepository<Menu> MenuRepository { get; }
        IRefererServidoresRepository RefererServidoresRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        IPerfilRepository PerfilesRepository { get; }
        IPerfilesXusuarioRepository PerfilesXusuarioRepository { get; }
        IPermisosEmpresasxUsuarioRepository PermisosEmpresasxUsuarioRepository { get; }
        IPermisosMenuXPerfilRepository PermisosMenuXPerfilRepository { get; }
        IPermisosUsuarioxMenuRepository PermisosUsuarioxMenuRepository { get; }
        IParametrosInicialesRepository ParametrosInicialesRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
