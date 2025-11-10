using InsureApp.Controllers;
using InsureApp.web.HttpClients;
using InsureApp.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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
        public async Task<IActionResult> CalculatePremiumAsync(MemberModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    //var response = _premiumCalculationServiceClient.GetPremiumAsync(model).Result;
                    //ViewBag.Premium = premium;

                    var responseModels = await _premiumCalculationServiceClient.GetPremiumAsync(model);

                    if (responseModels != null)
                    {

                        model.MonthlyPremium = responseModels.MonthlyPremium;
                    }
                    else
                    {
                        throw new Exception("Error calculating premium: Returned member data is null.");
                    }
                    // var products = await _catalogServiceClient.GetProducts();
                    // return View(model);
                    //return RedirectToAction( "DisplayPremium", "PremiumCalculation");                    
                }
                catch(Exception ex)
                {
                    _logger.LogError("Error calculating premium: {Message}", ex.Message);
                    ModelState.AddModelError(string.Empty, "An error occurred while calculating the premium. Please try again later.");
                }
            }

            return View(model);
        }

        public IActionResult DisplayPremium()
        {
            return View();
        }
    }
}
