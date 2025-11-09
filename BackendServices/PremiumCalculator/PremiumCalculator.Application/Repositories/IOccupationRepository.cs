using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremiumCalculator.Domain.Entities;

namespace PremiumCalculator.Application.Repositories
{
    public interface IOccupationRepository
    {
        IEnumerable<Occupation> GetOccupationList();
    }
}
