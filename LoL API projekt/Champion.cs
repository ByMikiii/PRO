using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Champion
{
    [JsonPropertyName("key")] public string Id {get; set;}
    [JsonPropertyName("name")] public string Name {get; set;}

}