public class FixturesByDateDTO
{
    public string? Name { get; set; }
    public string? League { get; set; }
    public string? StartingAt { get; set; }
    public string? ResultInfo { get; set; }

}

/*

FIXTURES BY DATE

https://api.sportmonks.com/v3/football/fixtures/date/2022-07-24

{
  "data": [
    {
      "id": 18528480,
      "sport_id": 1,
      "league_id": 271,
      "season_id": 19686,
      "stage_id": 77457696,
      "group_id": null,
      "aggregate_id": null,
      "round_id": 273989,
      "state_id": 5,
      "venue_id": null,
      "name": "AGF vs Viborg",
      "starting_at": "2022-07-24 12:00:00",
      "result_info": "AGF won after full-time.",
      "leg": "1/1",
      "details": null,
      "length": 90,
      "placeholder": false,
      "has_odds": true,
      "starting_at_timestamp": 1658664000
    },

*/