using PremiumCalculator.Domain.Entities;

namespace PremiumCalculator.Application.Repositories
{
    public interface IOccupationRepository
    {
        IEnumerable<VOccupationRating> GetOccupationList();
    }
}
