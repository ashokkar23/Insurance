using PremiumCalculator.Application.Services.Abstractions;
using PremiumCalculator.Application.DTOs;
using PremiumCalculator.Application.Repositories;
using AutoMapper;

namespace PremiumCalculator.Application.Services.Implementations
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        private readonly IPremiumCalculatorRepository _premiumCalculatorRepository;
        private readonly IOccupationRepository _occupationRepository;
        private readonly IMapper _mapper;
        public PremiumCalculatorService(IPremiumCalculatorRepository premiumCalculatorRepository, IOccupationRepository occupationRepository, IMapper mapper) {

            _premiumCalculatorRepository = premiumCalculatorRepository;
            _mapper = mapper;
            _occupationRepository = occupationRepository;
        }
        public decimal CalculatePremium(MemberDTO member)
        {
            var  premium = _premiumCalculatorRepository.CalculatePremium(_mapper.Map<Domain.Entities.Member>(member));
            return premium;
        }

        public IEnumerable<OccupationDTO> GetOccupationList()
        {
            return _mapper.Map<IEnumerable<OccupationDTO>>(_occupationRepository.GetOccupationList());
        }
    }

    //public class OccupationService : IOccupationService
    //{
    //    private readonly IOccupationRepository _occupationRepository;
    //    private readonly IMapper _mapper;
    //    public OccupationService(IOccupationRepository occupationRepository, IMapper mapper)
    //    {
    //        _occupationRepository = occupationRepository;
    //        _mapper = mapper;
    //    }

    //    IEnumerable<OccupationDTO> IOccupationService.GetOccupationList()
    //    {
    //        return _mapper.Map<IEnumerable<OccupationDTO>>(_occupationRepository.GetOccupationList());
    //    }
    //}
}
