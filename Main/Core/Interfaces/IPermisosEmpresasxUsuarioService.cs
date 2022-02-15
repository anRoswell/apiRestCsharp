using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPermisosEmpresasxUsuarioService
    {
        Task<List<PermisosEmpresasxUsuario>> GetListado();
        Task<List<PermisosEmpresasxUsuario>> GetPorId(int id);
        Task<List<ResponseAction>> PostCrear(PermisosEmpresasxUsuario permisosEmpresasxUsuario);
        Task<List<ResponseAction>> PutActualizar(PermisosEmpresasxUsuario permisosEmpresasxUsuario);
        Task<List<ResponseAction>> DeleteRegistro(PermisosEmpresasxUsuario permisosEmpresasxUsuario);
    }
}
