public class LatestFixturesDTO
{

    public string Name { get; set; }
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
    public string ResultInfo { get; set; }
    public int LeagueId { get; set; }
    public int Length { get; set; }
    public int StartTimeStamp { get; set; }
}

/*

LATEST FIXTURES 

https://api.sportmonks.com/v3/football/fixtures/latest

{
  "data": [
    {
      "id": 18535602,
      "sport_id": 1,
      "league_id": 501,
      "season_id": 19735,
      "stage_id": 77457866,
      "group_id": null,
      "aggregate_id": null,
      "round_id": 274733,
      "state_id": 1,
      "venue_id": 336296,
      "name": "Hearts vs Hibernian",
      "home_score": null,
      "away_score": null,
      "starting_at": "2023-01-02 15:00:00",
      "result_info": null,
      "leg": "1/1",
      "details": null,
      "length": 90,
      "placeholder": false,
      "last_processed_at": "2023-01-02 13:10:10",
      "starting_at_timestamp": 1672671600
    },

*/