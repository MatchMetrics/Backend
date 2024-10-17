public class FixturesBetweenDatesDTO {
    public int LeagueId { get; set; }
    public string Name { get; set; }
    public string StartingAt { get; set; }
}

/*

FIXTURES BETWEEN DATES 

https://api.sportmonks.com/v3/football/fixtures/between/2022-07-17/2022-07-25

{
  "data": [
    {
      "id": 18528474,
      "sport_id": 1,
      "league_id": 271,
      "season_id": 19686,
      "stage_id": 77457696,
      "group_id": null,
      "aggregate_id": null,
      "round_id": 273988,
      "state_id": 5,
      "venue_id": 1467,
      "name": "Viborg vs AaB",
      "starting_at": "2022-07-17 12:00:00",
      "result_info": "Viborg won after full-time.",
      "leg": "1/1",
      "details": null,
      "length": 90,
      "placeholder": false,
      "has_odds": true,
      "starting_at_timestamp": 1658059200
    },

*/