public class AllLeaguesDTO
{
    public string? Name { get; set; }
    public string? ShortCode { get; set; }
    public string? ImagePath { get; set; }

}


/*
GET ALL LEAGUES 
https://api.sportmonks.com/v3/football/leagues

{
    "data": [
        {
            "id": 271,
            "sport_id": 1,
            "country_id": 320,
            "name": "Superliga",
            "active": true,
            "short_code": "DNK SL",
            "image_path": "https://cdn.sportmonks.com/images/soccer/leagues/271.png",
            "type": "league",
            "sub_type": "domestic",
            "last_played_at": "2024-10-06 18:00:00",
            "category": 2,
            "has_jerseys": false
        },

*/