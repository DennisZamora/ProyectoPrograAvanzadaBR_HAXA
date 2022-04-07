using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using data = BE.DAL.DO.Objects;

namespace BE.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<data.Rol, DataModels.Rol>().ReverseMap();
            CreateMap<data.Usuario, DataModels.Usuario>().ReverseMap();
            CreateMap<data.Categoria, DataModels.Categoria>().ReverseMap();
            CreateMap<data.Estado, DataModels.Estado>().ReverseMap();
            CreateMap<data.Propiedad, DataModels.Propiedad>().ReverseMap();
            CreateMap<data.Empleado, DataModels.Empleado>().ReverseMap();
        }
    }
}
