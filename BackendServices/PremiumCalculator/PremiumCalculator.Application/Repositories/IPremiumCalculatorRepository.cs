using PremiumCalculator.Domain.Entities;

namespace PremiumCalculator.Application.Repositories
{
    public interface IPremiumCalculatorRepository
    {
        decimal CalculatePremium(Member member);

    }
}
