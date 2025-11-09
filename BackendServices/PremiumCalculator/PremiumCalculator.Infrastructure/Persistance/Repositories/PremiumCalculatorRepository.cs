using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PremiumCalculator.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Persistance.Repositories
{
    public class PremiumCalculatorRepository: IPremiumCalculatorRepository
    {
        private readonly PremiumCalculatorDbContext _db;
        private readonly ILogger<PremiumCalculatorRepository> _logger;

        public PremiumCalculatorRepository(PremiumCalculatorDbContext db, ILogger<PremiumCalculatorRepository> logger)
        {
            _db = db;
            _logger = logger;
        }
        public decimal CalculatePremium(Domain.Entities.Member member)
        {
            _logger.LogInformation("Calculating premium for member: {Name}", member.Name);

            var ratingFactor = (from o in _db.Occupations
                                join r in _db.Ratings on o.RatingId equals r.Id
                                where o.Id == member.OccupationId
                                select r.Factor).FirstOrDefault();
            if (ratingFactor == 0)
            {
                
                _logger.LogError("Invalid Occupation Id or Rating Factor not found.{1}", JsonSerializer.Serialize(member));

                throw new Exception("Invalid Occupation Id or Rating Factor not found.");
            }

            decimal premium = (member.SumInsured * ratingFactor * member.AgeNextBirthDay) / 1000 * 12;
            _logger.LogInformation("Premium calculated: {Premium}", premium);
            return premium;
        }
    }
}
