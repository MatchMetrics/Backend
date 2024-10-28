using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LeagueController : ControllerBase
{
    private readonly LeagueService _leagueService;

    public LeagueController(LeagueService leagueService)
    {
        _leagueService = leagueService;
    }

    [HttpGet("leagues")]
    public async Task<IActionResult> GetLeagues()
    {
        try
        {
            var leagues = await _leagueService.GetAllLeagues();
            return Ok(leagues);
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
