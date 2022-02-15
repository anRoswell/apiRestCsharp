using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PermisosEmpresasXUsuarioService : IPermisosEmpresasxUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermisosEmpresasXUsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<PermisosEmpresasxUsuario>> GetListado()
        {
            return _unitOfWork.PermisosEmpresasxUsuarioRepository.GetListado();
        }

        public Task<List<PermisosEmpresasxUsuario>> GetPorId(int id)
        {
            return _unitOfWork.PermisosEmpresasxUsuarioRepository.GetPorId(id);
        }

        public Task<List<ResponseAction>> PostCrear(PermisosEmpresasxUsuario permisosEmpresasxUsuario)
        {
            return _unitOfWork.PermisosEmpresasxUsuarioRepository.PostCrear(permisosEmpresasxUsuario);
        }

        public Task<List<ResponseAction>> PutActualizar(PermisosEmpresasxUsuario permisosEmpresasxUsuario)
        {
            return _unitOfWork.PermisosEmpresasxUsuarioRepository.PutActualizar(permisosEmpresasxUsuario);
        }

        public Task<List<ResponseAction>> DeleteRegistro(PermisosEmpresasxUsuario permisosEmpresasxUsuario)
        {
            return _unitOfWork.PermisosEmpresasxUsuarioRepository.DeleteRegistro(permisosEmpresasxUsuario);
        }
    }
}
