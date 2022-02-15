﻿using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> GetListarUsuarios();
        Task<List<Usuario>> GetUsuarioXCedula(string cedula);
        Task<List<Usuario>> GetUsuarioPorId(int id);
        Task<List<ResponseAction>> PostCrearUsuario(Usuario usuario);
        Task<List<ResponseAction>> PutActualizarUsuario(Usuario usuario);
        Task<List<ResponseAction>> DeleteUsuario(Usuario usuario);
        Task<List<Usuario>> GetLoginByCredentials(UserLogin login);
        Task<List<ResponseAction>> CambiarClaveUsuario(Usuario usuario);
        Task<List<ResponseAction>> PutActualizarEmpresaUsuario(Usuario usuario);
        Task<List<ResponseAction>> RecuperarClaveUsuario(Usuario usuario);
    }
}
