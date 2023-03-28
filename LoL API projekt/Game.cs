using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Game
{
	[JsonPropertyName("metadata")] public Metadata metadata {get; set;}
	[JsonPropertyName("info")] public Info info {get; set;}
	
}
