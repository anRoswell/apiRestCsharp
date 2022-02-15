using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPerfilesXusuarioRepository
    {
        Task<List<PerfilesXusuarioView>> GetListado();
        Task<List<PerfilesXusuario>> GetPorId(int id);
        Task<List<ResponseAction>> PostCrear(PerfilesXusuario perfilesXusuario);
        Task<List<ResponseAction>> PutActualizar(PerfilesXusuario perfilesXusuario);
        Task<List<ResponseAction>> DeleteRegistro(PerfilesXusuario perfilesXusuario);
    }
}
