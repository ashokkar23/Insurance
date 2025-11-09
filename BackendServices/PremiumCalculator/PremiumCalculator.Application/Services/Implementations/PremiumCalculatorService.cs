using PremiumCalculator.Application.Services.Abstractions;
using PremiumCalculator.Application.DTOs;
using PremiumCalculator.Application.Repositories;
using AutoMapper;

namespace PremiumCalculator.Application.Services.Implementations
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        private readonly IPremiumCalculatorRepository _premiumCalculatorRepository;
        private readonly IMapper _mapper;
        public PremiumCalculatorService(IPremiumCalculatorRepository premiumCalculatorRepository, IMapper mapper) {

            _premiumCalculatorRepository = premiumCalculatorRepository;
            _mapper = mapper;

        }
        public decimal CalculatePremium(MemberDTO member)
        {
            var  premium = _premiumCalculatorRepository.CalculatePremium(_mapper.Map<Domain.Entities.Member>(member));
            return premium;
        }
    }
}
