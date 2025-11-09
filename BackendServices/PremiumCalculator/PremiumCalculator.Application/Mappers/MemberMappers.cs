using AutoMapper;
using PremiumCalculator.Application.DTOs;
using PremiumCalculator.Domain.Entities;

namespace PremiumCalculator.Application.Mappers
{
    public class MemberMappers: Profile
    {
        public MemberMappers() { 
        
            CreateMap<Member, MemberDTO>().ReverseMap();
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
