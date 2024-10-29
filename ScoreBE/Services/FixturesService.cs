using System.Net.Http.Json;
using Microsoft.Extensions.Options;

public class FixtureService
{
    private readonly HttpClient _httpClient;
    private readonly ApiSettings _apiSettings;

    public FixtureService(HttpClient httpClient, IOptions<ApiSettings> apiSettings)
    {
        _httpClient = httpClient;
        _apiSettings = apiSettings.Value;
    }

    public async Task<List<LatestFixturesDTO>> GetAllFixtures()
    {
        var requestUrl = $"{_apiSettings.ApiBaseUrl}{_apiSettings.ApiFixtures}{_apiSettings.ApiKey}";

        var response = await _httpClient.GetAsync(requestUrl);
        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadFromJsonAsync<ApiFixtureResponse<List<LatestFixturesDTO>>>();

            return responseData?.FixtureData.Select(fixture => new LatestFixturesDTO
            {
                Name = fixture.Name,
                HomeScore = fixture.HomeScore,
                AwayScore = fixture.AwayScore,
                ResultInfo = fixture.ResultInfo,
                Length = fixture.Length,
                StartTimeStamp = fixture.StartTimeStamp,
                LeagueId = fixture.LeagueId,

            }).ToList() ?? new List<LatestFixturesDTO>();
        }

        var errorContent = await response.Content.ReadAsStringAsync();
        throw new HttpRequestException($"Error fetching leagues from API: {response.StatusCode} - {errorContent}");
    }
}

public class ApiFixtureResponse<T>
{
    public T FixtureData { get; set; }
}
