using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Mastery
{
    [JsonPropertyName("championId")] public int champID {get; set;}
    [JsonPropertyName("championPoints")] public int champPoints {get; set;}
    [JsonPropertyName("championLevel")] public int champLevel {get; set;}
    [JsonPropertyName("summonerId")] public string summId {get; set;}
    [JsonPropertyName("lastPlayTime")] public long lastPlayed {get; set;}
}