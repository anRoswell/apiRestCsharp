using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PeticionesCorsService : IPeticionesCorsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeticionesCorsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task RegisterLog(PeticionesCors peticionesCors)
        {
            try
            {
                await _unitOfWork.PeticionesCorsRepository.Add(peticionesCors);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (System.Exception e)
            {
                throw new BusinessException($"Error al intentar insertar registro. Detalle: {e.InnerException?.Message}");
            }
        }
    }
}
