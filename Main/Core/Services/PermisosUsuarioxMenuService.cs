using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PermisosUsuarioxMenuService : IPermisosUsuarioxMenuService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermisosUsuarioxMenuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<PermisosUsuarioxMenu>> GetListado()
        {
            return _unitOfWork.PermisosUsuarioxMenuRepository.GetListado();
        }

        public Task<List<PermisosUsuarioxMenu>> GetPorId(int id)
        {
            return _unitOfWork.PermisosUsuarioxMenuRepository.GetPorId(id);
        }

        public Task<List<ResponseAction>> PostCrear(PermisosUsuarioxMenu permisosUsuarioxMenu)
        {
            return _unitOfWork.PermisosUsuarioxMenuRepository.PostCrear(permisosUsuarioxMenu);
        }

        public Task<List<ResponseAction>> PutActualizar(PermisosUsuarioxMenu permisosUsuarioxMenu)
        {
            return _unitOfWork.PermisosUsuarioxMenuRepository.PutActualizar(permisosUsuarioxMenu);
        }

        public Task<List<ResponseAction>> DeleteRegistro(PermisosUsuarioxMenu permisosUsuarioxMenu)
        {
            return _unitOfWork.PermisosUsuarioxMenuRepository.DeleteRegistro(permisosUsuarioxMenu);
        }
    }
}
