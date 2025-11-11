
using InsureApp.web.Models;
using System.Configuration;
using System.Text;
using System.Text.Json;

namespace InsureApp.web.HttpClients
{
    public class PremiumCalculationServiceClient
    {
        HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public PremiumCalculationServiceClient(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;

            var passkey = _configuration["PassKey"];            
            _httpClient.DefaultRequestHeaders.Add("X-PassKey", passkey );
            
        }

        public async Task<IEnumerable<OccupationModel>> GetOccupationListAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("PremiumCalculator/GetOccupationList");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IEnumerable<OccupationModel>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            return null;
        }


        
        public async Task<MemberModel> GetPremiumAsync(MemberModel model)
        {                      

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("PremiumCalculator/CalculatePremium", model);
            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error calculating premium: {errorMessage}");
            }
            else
            {
                //var result = await response.Content.ReadFromJsonAsync<PremiumRequest>();
                //model.Premium = result.Premium;

                string resContent = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<MemberModel>(resContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                
            }
        }
        
    }
}
