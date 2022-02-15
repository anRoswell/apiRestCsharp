using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ParametrosInicialesRepository : IParametrosInicialesRepository
    {
        protected readonly DbModelContext _context;

        public ParametrosInicialesRepository(DbModelContext context)
        {
            _context = context;
        }

        public async Task<List<Ciudade>> GetCiudades()
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","1")

                };

                string sql = $"[par].[SpParametrosIniciales] @Operacion=@Operacion";

                var response = await _context.Ciudades.FromSqlRaw(sql, parameters: parameters).ToListAsync();

                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.ToString()}");
            }
        }

        public async Task<List<Departamento>> GetDepartamentos()
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","2")

                };

                string sql = $"[par].[SpParametrosIniciales] @Operacion=@Operacion";

                var response = await _context.Departamentos.FromSqlRaw(sql, parameters: parameters).ToListAsync();

                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.ToString()}");
            }
        }

        public async Task<List<Empresa>> GetEmpresas()
        {
            try
            {
                SqlParameter[] parameters = new[] {
                    new SqlParameter("@Operacion","3")

                };

                string sql = $"[par].[SpParametrosIniciales] @Operacion=@Operacion";

                var response = await _context.Empresas.FromSqlRaw(sql, parameters: parameters).ToListAsync();

                return response;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.ToString()}");
            }
        }

        public async Task<ParametrosIniciales> GetParametrosIniciales()
        {
            try
            {
                ParametrosIniciales paramsIniciales = new ParametrosIniciales();
                paramsIniciales.Ciudades = await GetCiudades();
                paramsIniciales.Departamentos = await GetDepartamentos();
                paramsIniciales.Empresas = await GetEmpresas();

                return paramsIniciales;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error: {e.Message}");
            }
        }
    }
}
