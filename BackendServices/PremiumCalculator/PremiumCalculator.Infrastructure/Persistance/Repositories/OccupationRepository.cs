using Microsoft.Extensions.Logging;
using PremiumCalculator.Application.Repositories;
using PremiumCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Persistance.Repositories
{
    public class OccupationRepository: IOccupationRepository
    {
        private readonly PremiumCalculatorDbContext _db;
        private readonly ILogger<OccupationRepository> _logger;

        public OccupationRepository(PremiumCalculatorDbContext db, ILogger<OccupationRepository> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IEnumerable<Occupation> GetOccupationList() { 
            try
            {
                _logger.LogInformation("Retrieving occupation list from database.");
                return _db.Occupations.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving occupation list.");
                throw new Exception("An error occurred while retrieving occupation list."); ;
            }
        }
    }
}
