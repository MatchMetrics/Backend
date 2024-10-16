using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("placeholder")]
    public class LeagueController : ControllerBase {
        private readonly LeagueService _leagueService;

        public LeagueController(LeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        [HttpGet]
        public async Task<IActionResult> GetLeagues()
        {
            var leagues = await _leagueService.GetAllLeagues();
            return Ok(leagues);
        }
}