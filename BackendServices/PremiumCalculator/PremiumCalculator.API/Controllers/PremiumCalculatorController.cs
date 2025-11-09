using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Application.Services.Abstractions;
using PremiumCalculator.Application.DTOs;

namespace PremiumCalculator.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PremiumCalculatorController : ControllerBase
    {
        private readonly IPremiumCalculatorService _premiumCalculatorService;

        public PremiumCalculatorController(IPremiumCalculatorService premiumCalculatorService)
        {
            _premiumCalculatorService = premiumCalculatorService;
        }

        [HttpPost]
        public IActionResult CalculatePremium([FromBody] MemberDTO member)
        {
            try
            {
              
                var premium = _premiumCalculatorService.CalculatePremium(member);
                return Ok(premium);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        public IActionResult GetOccupationList()
        {
            try
            {

                var occupations = _premiumCalculatorService.GetOccupationList();
                return Ok(occupations);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }       

    }
}
