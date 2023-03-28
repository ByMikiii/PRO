using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Info
{
    [JsonPropertyName("gameCreation")] public int GameCreation {get; set;}

    public void ToString()
    {
        Console.WriteLine("xdd");
        //Console.WriteLine(this.GameCreation);
    }
}