using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Info
{
    [JsonPropertyName("gameCreation")] public long GameCreation {get; set;}
    [JsonPropertyName("gameDuration")] public int GameDuration {get; set;}
    [JsonPropertyName("gameMode")] public string GameMode {get; set;}

    public void ToString()
    {
        var created = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(this.GameCreation / 1000d)).ToLocalTime();
        
        Console.WriteLine($"  Created: {created} \n  Duration: {this.GameDuration} \n  Gamemode: {this.GameMode}");
    }
}