using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DbModelContext context) : base(context) { }

        public async Task<List<Usuario>> GetListarUsuarios()
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","1")
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion";

                var response = await _context.Usuarios.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<Usuario>> GetUsuarioXCedula(string cedula)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","2"),
                    new SqlParameter("@Cedula", cedula)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Cedula = @Cedula";

                var response = await _context.Usuarios.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<Usuario>> GetUsuarioPorId(int id)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","3"),
                    new SqlParameter("@Id", id)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Id = @Id";

                var response = await _context.Usuarios.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> PostCrearUsuario(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","4"),
                    new SqlParameter("@Cedula", usuario.UsrCedula),
                    new SqlParameter("@TipoUsuario", usuario.UsrTusrCodTipoUsuario),
                    new SqlParameter("@Nombres", usuario.UsrNombres),
                    new SqlParameter("@Apellidos", usuario.UsrApellidos),
                    new SqlParameter("@Email", usuario.UsrEmail),
                    new SqlParameter("@Password", usuario.UsrPassword),
                    new SqlParameter("@EmpresaProceso", usuario.UsrEmpresaProceso),
                    new SqlParameter("@Estado", usuario.UsrEstado),
                    new SqlParameter("@CodArchivo", usuario.CodArchivo is null ? "0" : usuario.CodArchivo),
                    new SqlParameter("@CodUser", usuario.CodUser)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Cedula = @Cedula, @TipoUsuario = @TipoUsuario, @Nombres = @Nombres, @Apellidos = @Apellidos, @Email = @Email, " +
                    $"@Password = @Password, @EmpresaProceso = @EmpresaProceso, @Estado = @Estado, @CodArchivo = @CodArchivo, @CodUser = @CodUser";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> PutActualizarUsuario(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","5"),
                    new SqlParameter("@Id", usuario.Id),
                    new SqlParameter("@Cedula", usuario.UsrCedula),
                    new SqlParameter("@TipoUsuario", usuario.UsrTusrCodTipoUsuario),
                    new SqlParameter("@Nombres", usuario.UsrNombres),
                    new SqlParameter("@Apellidos", usuario.UsrApellidos),
                    new SqlParameter("@Email", usuario.UsrEmail),
                    //new SqlParameter("@Password", usuario.UsrPassword),
                    new SqlParameter("@EmpresaProceso", usuario.UsrEmpresaProceso),
                    new SqlParameter("@Estado", usuario.UsrEstado),
                    new SqlParameter("@CodArchivo", usuario.CodArchivo is null ? "0" : usuario.CodArchivo),
                    new SqlParameter("@CodUserUpdate", usuario.CodUserUpdate)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Id = @Id, @Cedula = @Cedula, @TipoUsuario = @TipoUsuario, @Nombres = @Nombres, @Apellidos = @Apellidos, @Email = @Email, " +
                    $"@EmpresaProceso = @EmpresaProceso, @Estado = @Estado, @CodArchivo = @CodArchivo, @CodUserUpdate = @CodUserUpdate";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> DeleteUsuario(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","6"),
                    new SqlParameter("@Id", usuario.Id),
                    new SqlParameter("@CodUserUpdate", usuario.CodUserUpdate)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Id = @Id, @CodUserUpdate = @CodUserUpdate";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<Usuario>> GetLoginByCredentials(UserLogin login)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","7"),
                    new SqlParameter("@Email", login.Email)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Email = @Email";

                var response = await _context.Usuarios.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> CambiarClaveUsuario(Usuario usuario)
        {
            try
            {
                string token = "";
                if ((bool)usuario.UsrForcePasswordChange)
                {
                    token = Core.Tools.Funciones.GetSHA256(Guid.NewGuid().ToString());
                }

                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","8"),
                    new SqlParameter("@Id", usuario.Id),
                    new SqlParameter("@Cedula", usuario.UsrCedula),
                    new SqlParameter("@Token", token),
                    new SqlParameter("@Password", usuario.UsrPassword),
                    new SqlParameter("@ForcePasswordChange", usuario.UsrForcePasswordChange),
                    new SqlParameter("@CodUserUpdate", usuario.CodUserUpdate)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Id = @Id, @Cedula = @Cedula, @Token = @Token, @Password = @Password, @ForcePasswordChange = @ForcePasswordChange, @CodUserUpdate = @CodUserUpdate";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> PutActualizarEmpresaUsuario(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","9"),
                    new SqlParameter("@Id", usuario.UsrCedula),
                    new SqlParameter("@EmpresaProceso", usuario.UsrEmpresaProceso),
                    new SqlParameter("@CodUserUpdate", usuario.CodUserUpdate)
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @CodUserUpdate = @CodUserUpdate, @Id = @Id, @EmpresaProceso = @EmpresaProceso";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> RecuperarClaveUsuario(Usuario usuario)
        {
            try
            {
                string token = Core.Tools.Funciones.GetSHA256(Guid.NewGuid().ToString());

                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","10"),
                    new SqlParameter("@Cedula", usuario.UsrCedula),
                    new SqlParameter("@Email", usuario.UsrEmail),
                    new SqlParameter("@Token", token),
                };

                string sql = $"[usr].[SpUsuario] @Operacion = @Operacion, @Cedula = @Cedula, @Email = @Email, @Token = @Token";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }
    }
}
