
using InsureApp.web.Models;
using System.Text.Json;

namespace InsureApp.web.HttpClients
{
    public class PremiumCalculationServiceClient
    {
        HttpClient _httpClient;
        public PremiumCalculationServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
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

        public async Task<HttpResponseMessage> GetPremiumAsync(MemberModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("PremiumCalculator/CalculatePremium",model);
            if(!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error calculating premium: {errorMessage}");
            }
            
                return response;
        }

    }
}
