using System.Text.Json;
using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Games
{
	[JsonPropertyName("games")] public List<string>Gamess {get; set;}

	public Games()
	{
		Gamess = new List<string>();
	}

	public async Task<string> ToString()
	{
		int i = 0;
		foreach (var gameID in Gamess)
		{
			if (i < 1)
			{
				string api_key = "?api_key=";
				string url = "https://europe.api.riotgames.com/lol/match/v5/matches/"+gameID+api_key;
				using(HttpClient client = new HttpClient())
				{
					HttpResponseMessage response = await client.GetAsync(url);
					string json = await response.Content.ReadAsStringAsync();

					using (var sw = new StreamWriter("../../../game.json"))
					{
						sw.WriteLine(json);
					}
					
				}
			}

			i++;
		}
	return "";
	}
}
