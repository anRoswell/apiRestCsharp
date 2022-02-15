﻿using Core.Entities;
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
    public class PermisosEmpresasxUsuarioRepository : BaseRepository<PermisosEmpresasxUsuario>, IPermisosEmpresasxUsuarioRepository
    {
        public PermisosEmpresasxUsuarioRepository(DbModelContext context) : base(context) { }

        public async Task<List<PermisosEmpresasxUsuario>> GetListado()
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","1")
                };

                string sql = $"[usr].[SpPermisoEmpresasXusuarios] @Operacion = @Operacion";

                var response = await _context.PermisosEmpresasxUsuarios.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<PermisosEmpresasxUsuario>> GetPorId(int id)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","2"),
                    new SqlParameter("@IdPermiso", id)
                };

                string sql = $"[usr].[SpPermisoEmpresasXusuarios] @Operacion = @Operacion, @IdPermiso = @IdPermiso";

                var response = await _context.PermisosEmpresasxUsuarios.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> PostCrear(PermisosEmpresasxUsuario permisosEmpresasxUsuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","3"),
                    new SqlParameter("@CodUsuario", permisosEmpresasxUsuario.PeuUsrCodUsuario),
                    new SqlParameter("@CodEmpresa", permisosEmpresasxUsuario.PeuEmpCodEmpresa),
                    new SqlParameter("@Estado", permisosEmpresasxUsuario.PeuEstado),
                    new SqlParameter("@CodArchivo", permisosEmpresasxUsuario.CodArchivo is null ? "0" : permisosEmpresasxUsuario.CodArchivo),
                    new SqlParameter("@CodUser", permisosEmpresasxUsuario.CodUser)
                };

                string sql = $"[usr].[SpPermisoEmpresasXusuarios] @Operacion = @Operacion, @CodUsuario = @CodUsuario, @CodEmpresa = @CodEmpresa, @Estado = @Estado, " +
                    $"@CodArchivo = @CodArchivo, @CodUser = @CodUser";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> PutActualizar(PermisosEmpresasxUsuario permisosEmpresasxUsuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","4"),
                    new SqlParameter("@IdPermiso", permisosEmpresasxUsuario.Id),
                    new SqlParameter("@CodUsuario", permisosEmpresasxUsuario.PeuUsrCodUsuario),
                    new SqlParameter("@CodEmpresa", permisosEmpresasxUsuario.PeuEmpCodEmpresa),
                    new SqlParameter("@Estado", permisosEmpresasxUsuario.PeuEstado),
                    new SqlParameter("@CodArchivo", permisosEmpresasxUsuario.CodArchivo is null ? "0" : permisosEmpresasxUsuario.CodArchivo),
                    new SqlParameter("@CodUserUpdate", permisosEmpresasxUsuario.CodUserUpdate),
                };

                string sql = $"[usr].[SpPermisoEmpresasXusuarios] @Operacion = @Operacion, @IdPermiso = @IdPermiso, @CodUsuario = @CodUsuario, @CodEmpresa = @CodEmpresa, " +
                    $"@Estado = @Estado, @CodArchivo = @CodArchivo, @CodUserUpdate = @CodUserUpdate";

                var response = await _context.ResponseActions.FromSqlRaw(sql, parameters: parameters).ToListAsync();
                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }

        public async Task<List<ResponseAction>> DeleteRegistro(PermisosEmpresasxUsuario permisosEmpresasxUsuario)
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","5"),
                    new SqlParameter("@IdPermiso", permisosEmpresasxUsuario.Id),
                    new SqlParameter("@CodUserUpdate", permisosEmpresasxUsuario.CodUserUpdate)
                };

                string sql = $"[usr].[SpPermisoEmpresasXusuarios] @Operacion = @Operacion, @IdPermiso = @IdPermiso, @CodUserUpdate = @CodUserUpdate";

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
