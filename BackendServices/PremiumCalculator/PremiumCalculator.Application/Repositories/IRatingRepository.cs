using PremiumCalculator.Domain.Entities;

namespace PremiumCalculator.Application.Repositories
{
    public interface IRatingRepository
    {
        decimal GetFactorByRating(string rating);
    }
}
