using PremiumCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Application.DTOs
{
    public class MemberDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public byte AgeNextBirthDay { get; set; }

        public int OccupationId { get; set; }

        public decimal SumInsured { get; set; }
       
        //public string  Occupation { get; set; }
    }
}
