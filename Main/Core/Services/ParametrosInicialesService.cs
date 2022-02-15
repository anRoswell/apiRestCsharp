using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ParametrosInicialesService : IParametrosInicialesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ParametrosInicialesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<ParametrosIniciales> GetParametrosIniciales()
        {
            return await _unitOfWork.ParametrosInicialesRepository.GetParametrosIniciales();
        }
    }
}
