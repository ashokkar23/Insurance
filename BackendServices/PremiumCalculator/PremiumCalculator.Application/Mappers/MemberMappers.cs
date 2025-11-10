using AutoMapper;
using PremiumCalculator.Application.DTOs;
using PremiumCalculator.Domain.Entities;

namespace PremiumCalculator.Application.Mappers
{
    public class MemberMappers: Profile
    {
        public MemberMappers() {

            CreateMap<Member, MemberDTO>().ReverseMap();
            //CreateMap<(Member M, Occupation O), MemberDTO>()
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.M.Id))
                //.ForMember(dest => dest.Name, opt => opt.Ignore())
                //.ForMember(dest => dest.DateOfBirth, opt => opt.Ignore())
                //.ForMember(dest => dest.AgeNextBirthDay, opt => opt.Ignore())
                //.ForMember(dest => dest.Occupation, opt => opt.Ignore())
                //.ForMember(dest => dest.OccupationId, opt => opt.Ignore())
                //.ForMember(dest => dest.SumInsured, opt => opt.Ignore())
                //.ForMember(dest => dest.MonthlyPremium, opt => opt.Ignore());

            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.M.Id))
            //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.M.Name))
            //.ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.M.DateOfBirth))
            //.ForMember(dest => dest.AgeNextBirthDay, opt => opt.MapFrom(src => src.M.AgeNextBirthDay))
            //.ForMember(dest => dest.Occupation, opt => opt.MapFrom(src => src.O.OccupationName))
            //.ForMember(dest => dest.OccupationId, opt => opt.MapFrom(src => src.M.OccupationId))
            //.ForMember(dest => dest.SumInsured, opt => opt.MapFrom(src => src.M.SumInsured))
            //.ForMember(dest => dest.MonthlyPremium, opt => opt.Ignore());


            //.ForMember(dest => dest.AgeNextBirthDay, opt => opt.MapFrom(src =>
            //    {
            //        var today = DateTime.Today;
            //        var age = today.Year - src.DateOfBirth.Year;
            //        if (src.DateOfBirth > today.AddYears(-age)) age--;
            //        return (byte)(age + 1);
            //    }
            //));
        }

    }
}
