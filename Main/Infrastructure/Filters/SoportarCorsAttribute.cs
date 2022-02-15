using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Filters
{
    public class SoportarCorsAttribute : IAsyncActionFilter
    {
        private readonly IRefererServidoresService _refererHostService;
        private readonly IPeticionesCorsService _peticionesCorsService;

        public SoportarCorsAttribute(IRefererServidoresService refererHostService, IPeticionesCorsService peticionesCorsService)
        {
            _refererHostService = refererHostService;
            _peticionesCorsService = peticionesCorsService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            var GetReferer = "unknow";
            var Request = filterContext.HttpContext.Request;
            RequestHeaders headers = Request.GetTypedHeaders();

            if (headers.Referer != null)
            {
                string AbsoluteUri = headers.Referer.AbsoluteUri;
                //string AbsolutePath = header.Referer.AbsolutePath;
                string PathAndQuery = headers.Referer.PathAndQuery;
                GetReferer = AbsoluteUri.Substring(0, AbsoluteUri.Length - PathAndQuery.Length);
            }

            var controllerActionDescriptor = filterContext.ActionDescriptor as ControllerActionDescriptor;
            string controllerName = controllerActionDescriptor?.ControllerName;
            string actionMethod = controllerActionDescriptor?.ActionName;

            string Grupo = Request.Query["Grupo"].ToString();

            string token = headers.Headers["Authorization"].ToString();
            string metodo = Request.Method;
            //------Grabar Log
            GrabarLog(new PeticionesCors
            {
                ActionMethod = actionMethod,
                CodUser = "7777777",
                ControllerName = controllerName,
                FechaRegistro = DateTime.Now,
                Grupo = Grupo,
                MethodType = metodo,
                RequestHeadersReferer = GetReferer,
                Token = token,
            });

            //-----Validar que el Referrer tenga permisos.
            bool PermitirHostRemoto;
            PermitirHostRemoto = await _refererHostService.GetPermisoAccesoPorRefererServidores(GetReferer, Grupo);

            if (!PermitirHostRemoto)
            {
                throw new BusinessException($"El Host Remoto: {GetReferer} actualmente no tiene permisos de acceso.");
            }

            await next();
        }

        private void GrabarLog(PeticionesCors peticionesCors)
        {
            _peticionesCorsService.RegisterLog(peticionesCors);
        }
    }
}
