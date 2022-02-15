using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPerfilService
    {
        Task<List<Perfil>> GetPerfiles();
        Task<List<Perfil>> Getperfil(int id);
        Task<List<ResponseAction>> PostCrear(Perfil perfil);
        Task<List<ResponseAction>> PutActualizar(Perfil perfil);
        Task<List<ResponseAction>> DeletePerfil(Perfil perfil);
    }
}
