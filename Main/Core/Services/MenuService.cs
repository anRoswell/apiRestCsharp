using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public class MenuService : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Menu> GetMenus()
        {
            try
            {
                return _unitOfWork.MenuRepository.GetAll();
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error al intentar consultar registros. Detalle: {e.Message}");
            }
        }
    }
}
