using System.Diagnostics;
using System.Net.Mime;
using System.Text.Json;
using LoL_API_projekt;

void getName()
{
	Console.WriteLine("Enter summoners name:");
	string name = Console.ReadLine();
	Constants.name = name;
	getRegion();
}

void getRegion()
{
	Console.WriteLine("Enter region: (eun1, euw1)");
	string regionn = Console.ReadLine();
	if (regionn == "euw1" || regionn == "eun1")
	{
		Constants.region = regionn;
	}
	else
	{
		getRegion();
	}
}
getName();

	Summoner summoner = new Summoner();

	string url = "https://" + Constants.region + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" +
	             Constants.name + Constants.api_key;
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url);
		string json = await response.Content.ReadAsStringAsync();

		if (json.Contains("status") || json == "")
		{
			Console.WriteLine("Something went wrong! Try again!");
			getName();
			getRegion();
		}

		summoner = JsonSerializer.Deserialize<Summoner>(json);
	}
await summoner.option();

public static class Constants
{
	public const string api_key = "?api_key=";
	public static string name = "";
	public static string region = "";
}
