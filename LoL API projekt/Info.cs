using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Info
{
    [JsonPropertyName("gameCreation")] public long GameCreation {get; set;}
    [JsonPropertyName("gameDuration")] public int GameDuration {get; set;}
    [JsonPropertyName("gameMode")] public string GameMode {get; set;}

    [JsonPropertyName("participants")] public List<Participant>participants { get; set; }

    public Info()
    {
	    participants = new List<Participant>();
    }

    public void ToString()
    {
        var created = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(this.GameCreation / 1000d)).ToLocalTime();

        var duration = this.GameDuration / 60;

        Console.WriteLine($"  Created: {created} \n  Duration: {duration} minutes \n  Gamemode: {this.GameMode} \n");

        int i = 0;
        foreach (var part in participants)
        {
	        if (i == 0)
	        {
		        Console.WriteLine("Blue Team");
	        }
	        else if (i == 5)
	        {
		        Console.WriteLine("\nRed Team");
	        }
	        part.ToString();
	        i++;
        }
    }
}
