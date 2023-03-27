using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Games
{
	[JsonPropertyName("games")] public List<Game>Gamess {get; set;}

	public Games()
	{
		Gamess = new List<Game>();
	}
}
