using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Usuario>> GetListarUsuarios()
        {
           return await _unitOfWork.UsuarioRepository.GetListarUsuarios();
        }

        public async Task<List<Usuario>> GetUsuarioXCedula(string cedula)
        {
           return await _unitOfWork.UsuarioRepository.GetUsuarioXCedula(cedula);
        }

        public async Task<List<Usuario>> GetUsuarioPorId(int id)
        {
            return await _unitOfWork.UsuarioRepository.GetUsuarioPorId(id);
        }

        public async Task<List<ResponseAction>> PostCrearUsuario(Usuario usuario)
        {
           return await _unitOfWork.UsuarioRepository.PostCrearUsuario(usuario);
        }

        public async Task<List<ResponseAction>> PutActualizarUsuario(Usuario usuario)
        {
           return await _unitOfWork.UsuarioRepository.PutActualizarUsuario(usuario);
        }

        public async Task<List<ResponseAction>> DeleteUsuario(Usuario usuario)
        {
           return await _unitOfWork.UsuarioRepository.DeleteUsuario(usuario);
        }

        public async Task<List<Usuario>> GetLoginByCredentials(UserLogin login)
        {
           return await _unitOfWork.UsuarioRepository.GetLoginByCredentials(login);
        }

        public async Task<List<ResponseAction>> CambiarClaveUsuario(Usuario usuario)
        {
            return await _unitOfWork.UsuarioRepository.CambiarClaveUsuario(usuario);
        }

        public async Task<List<ResponseAction>> PutActualizarEmpresaUsuario(Usuario usuario)
        {
            return await _unitOfWork.UsuarioRepository.PutActualizarEmpresaUsuario(usuario);
        }

        public async Task<List<ResponseAction>> RecuperarClaveUsuario(Usuario usuario)
        {
            return await _unitOfWork.UsuarioRepository.RecuperarClaveUsuario(usuario);
        }
    }
}
