using AutoMapper;
using PremiumCalculator.Application.DTOs;
using PremiumCalculator.Domain.Entities;
namespace PremiumCalculator.Application.Mappers
{
    public class OccupationMappers : Profile
    {
        public OccupationMappers()
        {
            CreateMap<Occupation, OccupationDTO>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                 .ForMember(dest => dest.Occupation, opt => opt.MapFrom(src => src.Occupation1))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
        }
    }
}
