using AutoMapper;
using Core.DTOs;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile<AutomapperProfile>();
            //    cfg.AllowNullDestinationValues = false;
            //});

            //// Check that there are no issues with this configuration, which we'll encounter eventually at runtime.
            //config.AssertConfigurationIsValid();

            //config.CreateMapper();

            //CreateMap<Usuario, UsuarioDto>().ForMember(d => d.CodUsuario, a => a.Ignore());

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
