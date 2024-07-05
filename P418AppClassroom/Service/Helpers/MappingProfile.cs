using AutoMapper;
using Domain.Entities;
using Service.DTOs.Cities;
using Service.DTOs.Countries;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<Country, CountryByCitiesDto>().ForMember(dest => dest.Cities, opt => opt.MapFrom(src => src.Cities.Select(m => m.Name)));
            CreateMap<City, CityDto>().ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name));
            CreateMap<CityCreateDto, City>();
        }
    }
}
