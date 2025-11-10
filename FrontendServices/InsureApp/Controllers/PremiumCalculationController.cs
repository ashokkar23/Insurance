using InsureApp.Controllers;
using InsureApp.web.HttpClients;
using InsureApp.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsureApp.web.Controllers
{
    public class PremiumCalculationController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PremiumCalculationServiceClient _premiumCalculationServiceClient;
        public PremiumCalculationController( PremiumCalculationServiceClient premiumCalculationServiceClient,ILogger<HomeController> logger)
        {
            _logger = logger;
            _premiumCalculationServiceClient = premiumCalculationServiceClient;
        }

        public IActionResult CalculatePremium()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalculatePremium(MemberModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var premium = _premiumCalculationServiceClient.GetPremiumAsync(model).Result;
                    ViewBag.Premium = premium;
                    //return RedirectToAction( "DisplayPremium", "PremiumCalculation");                    
                }
                catch(Exception ex)
                {
                    _logger.LogError("Error calculating premium: {Message}", ex.Message);
                    ModelState.AddModelError(string.Empty, "An error occurred while calculating the premium. Please try again later.");
                }
            }

            return View();
        }

        public IActionResult DisplayPremium()
        {
            return View();
        }
    }
}
