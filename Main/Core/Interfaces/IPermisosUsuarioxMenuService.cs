using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPermisosUsuarioxMenuService
    {
        Task<List<PermisosUsuarioxMenu>> GetListado();
        Task<List<PermisosUsuarioxMenu>> GetPorId(int id);
        Task<List<ResponseAction>> PostCrear(PermisosUsuarioxMenu permisosUsuarioxMenu);
        Task<List<ResponseAction>> PutActualizar(PermisosUsuarioxMenu permisosUsuarioxMenu);
        Task<List<ResponseAction>> DeleteRegistro(PermisosUsuarioxMenu permisosUsuarioxMenu);
    }
}
