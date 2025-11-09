using PremiumCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Application.DTOs
{
    public class OccupationDTO
    {
        public int Id { get; set; }

        public string Occupation { get; set; }

        public string  Rating { get; set; }
        
    }
}
