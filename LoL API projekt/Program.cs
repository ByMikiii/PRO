using System.Text.Json;
using System.Text.Json.Nodes;
using LoL_API_projekt;

Console.WriteLine("Enter summoners name:");
string name = Console.ReadLine();

Console.WriteLine("Enter region: (eun1, euw1)");
string regionn = Console.ReadLine();


Summoner summoner = new Summoner();

string url = "https://"+regionn+".api.riotgames.com/lol/summoner/v4/summoners/by-name/"+name+Constants.api_key;
using(HttpClient client = new HttpClient())
{
	HttpResponseMessage response = await client.GetAsync(url);
	string json = await response.Content.ReadAsStringAsync();
	summoner = JsonSerializer.Deserialize<Summoner>(json);
}

await summoner.option();


public static class Constants
{
	public const string api_key = "?api_key=";

}
