﻿using Api.Responses;
using AutoMapper.Configuration;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Authorize(Roles = "1")] // DashboardUser
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilService _perfilService;

        public PerfilController(IPerfilService perfilesServices)
        {
            _perfilService = perfilesServices;
        }

        /// <summary>
        /// Consultar Perfil
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Search", Name = "SearchPerfil")]
        [Consumes("application/json")]
        public async Task<IActionResult> SearchPerfil(int id)
        {
            try
            {
                var resp = await _perfilService.Getperfil(id);
                var perfil = resp.Count > 0 ? resp[0] : null;

                if (perfil is null)
                {
                    return Ok(ErrorResponse.GetError(false, "Perfil Inválido", 400));
                }

                var response = new ApiResponse<Perfil>(perfil, 200);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error en la búsqueda. Detalle: {e.Message}");
            }
        }

        /// <summary>
        /// Consultar todos los perfiles
        /// </summary>
        /// <returns></returns>
        [HttpGet("SearchAll", Name = "SearchAllPerfil")]
        [Consumes("application/json")]
        public async Task<IActionResult> SearchAllPerfil()
        {
            try
            {
                var perfiles = await _perfilService.GetPerfiles();
                var response = new ApiResponse<List<Perfil>>(perfiles, 200);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error en la búsqueda. Detalle: {e.Message}");
            }
        }

        /// <summary>
        /// Crear Perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <returns></returns>
        [HttpPost("Create", Name = "CreatePerfil")]
        [Consumes("application/json")]
        public async Task<IActionResult> CreatePerfil([FromBody] Perfil perfil)
        {
            try
            {
                var responseAction = await _perfilService.PostCrear(perfil);
                var response = new ApiResponse<List<ResponseAction>>(responseAction, 200);
                if (!responseAction[0].estado)
                {
                    response.Status = 400;
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error al intentar insertar registro. Detalle: {e.Message}");
            }
        }

        /// <summary>
        /// Actualizar Perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <returns></returns>
        [HttpPut("Update", Name = "UpdatePerfil")]
        [Consumes("application/json")]
        public async Task<IActionResult> UpdatePerfil([FromBody] Perfil perfil)
        {
            try
            {
                var responseAction = await _perfilService.PutActualizar(perfil);
                var response = new ApiResponse<List<ResponseAction>>(responseAction, 200);
                if (!responseAction[0].estado)
                {
                    response.Status = 400;
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error en la actualización del registro. Detalle: {e.Message}");
            }
        }

        /// <summary>
        /// Eliminar Perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <returns></returns>
        [HttpDelete("Delete", Name = "DeletePerfil")]
        [Consumes("application/json")]
        public async Task<IActionResult> DeletePerfil(Perfil perfil)
        {
            try
            {
                var responseAction = await _perfilService.DeletePerfil(perfil);
                var response = new ApiResponse<List<ResponseAction>>(responseAction, 200);
                if (!responseAction[0].estado)
                {
                    response.Status = 400;
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error en la eliminación del registro. Detalle: {e.Message}");
            }
        }
    }
}
