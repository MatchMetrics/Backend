using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

public class LeagueService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiSettings _apiSettings;

        public LeagueService(HttpClient httpClient, IOptions<ApiSettings> apiSettings)
        {
            _httpClient = httpClient;
            _apiSettings = apiSettings.Value; // ApiSettings from appsettings.json
        }

        // fetch all leagues and return them as LeagueDTOs
        public async Task<List<LeagueDTO>> GetAllLeagues()
        {
            // Set up the full URL, including the API key as a query parameter (depends on API requirements)
            var requestUrl = $"{_apiSettings.BaseUrl}/leagues?apiKey={_apiSettings.ApiKey}";

            // GET request to the external API
            var response = await _httpClient.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                // Deserialize the JSON response into a list of League models
                var leagues = await response.Content.ReadFromJsonAsync<List<LeagueDTO>>();

                // Map the League models to LeagueDTOs
                var leagueDTOs = leagues.Select(league => new LeagueDTO
                {
                    Id = league.Id,
                    Name = league.Name,
                   // Country = league.Country,
                   // LogoUrl = league.LogoUrl
                }).ToList();

                return leagueDTOs; // Return the list of LeagueDTOs
            }

            throw new HttpRequestException("Error fetching leagues from API");
        }
    }

