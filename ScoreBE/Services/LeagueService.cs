using System.Net.Http.Json;
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

    // Fetch all leagues and return them as LeagueDTOs
    public async Task<List<LeagueDTO>> GetAllLeagues()
    {
        var requestUrl = $"{_apiSettings.ApiBaseUrl}{_apiSettings.ApiLeague}{_apiSettings.ApiKey}";

        var response = await _httpClient.GetAsync(requestUrl);
        if (response.IsSuccessStatusCode)
        {
            // Deserialize the JSON response into a wrapper object that includes "data"
            var responseData = await response.Content.ReadFromJsonAsync<ApiResponse<List<LeagueDTO>>>();

            // Map only the Id and Name from the API response
            return responseData?.Data.Select(league => new LeagueDTO
            {
                Id = league.Id,
                Name = league.Name
            }).ToList() ?? new List<LeagueDTO>();
        }

        var errorContent = await response.Content.ReadAsStringAsync();
        throw new HttpRequestException($"Error fetching leagues from API: {response.StatusCode} - {errorContent}");
    }
}

// Wrapper class to match the structure of the API response
public class ApiResponse<T>
{
    public T Data { get; set; }
}
