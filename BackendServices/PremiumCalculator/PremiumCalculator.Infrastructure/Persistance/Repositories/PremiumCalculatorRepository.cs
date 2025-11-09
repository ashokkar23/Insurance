using PremiumCalculator.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PremiumCalculator.Infrastructure.Persistance.Repositories
{
    public class PremiumCalculatorRepository: IPremiumCalculatorRepository
    {
        private readonly PremiumCalculatorDbContext _db;
        public PremiumCalculatorRepository(PremiumCalculatorDbContext db)
        {
            _db = db;
        }
        public decimal CalculatePremium(Domain.Entities.Member member)
        {
            var ratingFactor = (from o in _db.Occupations
                                join r in _db.Ratings on o.RatingId equals r.Id
                                where o.Id == member.OccupationId
                                select r.Factor).FirstOrDefault();
            if (ratingFactor == 0)
            {
                throw new Exception("Invalid Occupation Id or Rating Factor not found.");
            }
            decimal premium = (member.SumInsured * ratingFactor * member.AgeNextBirthDay) / 1000 * 12;
            return premium;
        }
    }
}
