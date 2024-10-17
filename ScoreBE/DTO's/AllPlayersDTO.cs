public class AllPlayersDTO
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string DateOfBirth { get; set; }

}

/*

ALL PLAYERS 

https://api.sportmonks.com/v3/football/players

{
  "data": [
    {
      "id": 14,
      "sport_id": 1,
      "country_id": 320,
      "nationality_id": 320,
      "city_id": null,
      "position_id": 25,
      "detailed_position_id": null,
      "type_id": 25,
      "common_name": "D. Agger",
      "firstname": "Daniel Munthe",
      "lastname": "Agger",
      "name": "Daniel Munthe Agger",
      "display_name": "Daniel Agger",
      "image_path": "https://cdn.sportmonks.com/images/soccer/players/14/14.png",
      "height": 191,
      "weight": 84,
      "date_of_birth": "1984-12-12",
      "gender": "male"
    },

*/