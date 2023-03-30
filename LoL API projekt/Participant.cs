using System.Text.Json;
using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Participant
{
	[JsonPropertyName("championName")] public string ChampName { get; set; }

	[JsonPropertyName("champLevel")] public  int ChampLevel { get; set; }

	[JsonPropertyName("lane")] public  string Lane { get; set; }
	[JsonPropertyName("win")] public bool Win { get; set; }



	public void ToString()
	{
		Console.WriteLine($"{this.ChampName}  Level: {this.ChampLevel}  Lane: {this.Lane}");
	}
}
