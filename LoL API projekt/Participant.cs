using System.Text.Json;
using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Participant
{
	[JsonPropertyName("championName")] public string ChampName { get; set; }

	[JsonPropertyName("champLevel")] public  int ChampLevel { get; set; }

	[JsonPropertyName("teamPosition")] public  string Lane { get; set; }
	[JsonPropertyName("win")] public bool Win { get; set; }

	[JsonPropertyName("puuid")] public string Puuid { get; set; }
	[JsonPropertyName("totalMinionsKilled")] public int Cs { get; set; }
	[JsonPropertyName("neutralMinionsKilled")] public int Css { get; set; }
	[JsonPropertyName("summonerName")] public string SummonerName { get; set; }
	[JsonPropertyName("kills")] public float Kills { get; set; }
	[JsonPropertyName("deaths")] public float Deaths { get; set; }
	[JsonPropertyName("assists")] public float Assists { get; set; }





	public async void ToString()
	{
		Console.WriteLine($"  {this.SummonerName}       {this.Lane}        {this.ChampName}        {this.Cs + this.Css}        {this.Kills}        {this.Deaths}        {this.Assists}        {(this.Kills + this.Assists) / this.Deaths}");
	}


}
