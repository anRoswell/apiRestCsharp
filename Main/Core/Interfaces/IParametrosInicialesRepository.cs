using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IParametrosInicialesRepository
    {
        Task<ParametrosIniciales> GetParametrosIniciales();
    }
}
