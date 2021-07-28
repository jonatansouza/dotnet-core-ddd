using Api.Domain.Dtos;
using Api.Domain.Dtos.UF;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Cep;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();

            CreateMap<UfModel, UfDto>().ReverseMap();

            CreateMap<MunicipioModel, MunicipioDto>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>().ReverseMap();

            CreateMap<CepModel, CepDto>().ReverseMap();
            CreateMap<CepModel, CepDtoCreate>().ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>().ReverseMap();

        }
    }
}
