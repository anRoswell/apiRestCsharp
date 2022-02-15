using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    /// <summary>
    /// Clase encargada de guardar los cambios en la Base de Datos
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbModelContext _context;
        //private readonly IPostRepository _postRepository; // Para cuando se hacen otras operaciones, a parte del CRUD (IEntityRepository)
        //private readonly IRepository<Entity> _userRepository; // Para entidades que sólo hacen CRUD
        private readonly IRepository<AppsFileServerPath> _appsFileServerPathRepository;
        private readonly IRepository<PeticionesCors> _peticionesCorsRepository;
        private readonly IRepository<Menu> _menuRepository;
        private readonly IRefererServidoresRepository _refererHostRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPerfilRepository _perfilesRepository;
        private readonly IPerfilesXusuarioRepository _perfilesXusuarioRepository;
        private readonly IPermisosEmpresasxUsuarioRepository _permisosEmpresasxUsuarioRepository;
        private readonly IPermisosMenuXPerfilRepository _permisosMenuXPerfilRepository;
        private readonly IPermisosUsuarioxMenuRepository _permisosUsuarioxMenuRepository;
        private readonly IParametrosInicialesRepository _parametrosInicialesRepository;

        public UnitOfWork(DbModelContext context)
        {
            _context = context;
        }

        //public IPostRepository PostRepository => _postRepository ?? new PostRepository(_context);

        //public IRepository<Entity> UserRepository => _userRepository ?? new BaseRepository<User>(_context);
        public IRepository<AppsFileServerPath> AppsFileServerPathRepository => _appsFileServerPathRepository ?? new BaseRepository<AppsFileServerPath>(_context);
        public IRepository<PeticionesCors> PeticionesCorsRepository => _peticionesCorsRepository ?? new BaseRepository<PeticionesCors>(_context);
        public IRepository<Menu> MenuRepository => _menuRepository ?? new BaseRepository<Menu>(_context);
        public IRefererServidoresRepository RefererServidoresRepository => _refererHostRepository ?? new RefererServidoresRepository(_context);
        public IUsuarioRepository UsuarioRepository => _usuarioRepository ?? new UsuarioRepository(_context);
        public IPerfilRepository PerfilesRepository => _perfilesRepository ?? new PerfilRepository(_context);
        public IPerfilesXusuarioRepository PerfilesXusuarioRepository => _perfilesXusuarioRepository ?? new PerfilesXusuarioRepository(_context);
        public IPermisosEmpresasxUsuarioRepository PermisosEmpresasxUsuarioRepository => _permisosEmpresasxUsuarioRepository ?? new PermisosEmpresasxUsuarioRepository(_context);
        public IPermisosMenuXPerfilRepository PermisosMenuXPerfilRepository => _permisosMenuXPerfilRepository ?? new PermisosMenuXPerfilRepository(_context);
        public IPermisosUsuarioxMenuRepository PermisosUsuarioxMenuRepository => _permisosUsuarioxMenuRepository ?? new PermisosUsuarioxMenuRepository(_context);
        public IParametrosInicialesRepository ParametrosInicialesRepository => _parametrosInicialesRepository ?? new ParametrosInicialesRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
