using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IParametrosInicialesService
    {
        Task<ParametrosIniciales> GetParametrosIniciales();
    }
}
