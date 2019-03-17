using AutoMapper;
using CountriesCurrency.Application.Dtos;
using CountriesCurrency.Entities;

namespace CountriesCurrency.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CountryEntity, CountryDto>()
                .ReverseMap();

            CreateMap<CurrenciesEntity, CurrenciesDto>()
                .ReverseMap();
        }
    }
}
