using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremiumCalculator.Application.DTOs;

namespace PremiumCalculator.Application.Services.Abstractions
{
    public interface  IPremiumCalculatorService
    {
        decimal CalculatePremium(MemberDTO member);
    }
}
