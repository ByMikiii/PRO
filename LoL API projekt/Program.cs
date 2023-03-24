// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Nodes;
using LoL_API_projekt;

Console.WriteLine("Hello, World!");

string api_key = "?api_key=RGAPI-1a693bd4-2e3a-4ec8-9e37-24307766a813";

string url =
	"https://euw1.api.riotgames.com/lol/platform/v3/champion-rotations?api_key=RGAPI-1a693bd4-2e3a-4ec8-9e37-24307766a813";

using(HttpClient client = new HttpClient())
{
	HttpResponseMessage response = await client.GetAsync(url);

	if (response.IsSuccessStatusCode)
	{
		string json = await response.Content.ReadAsStringAsync();
		Console.WriteLine(json);
	}
}

Champion champ = new Champion();
using(var sr = new StreamReader("../../../champions.json"))
{

	string str = sr.ReadToEnd();

	champ = JsonSerializer.Deserialize<Champion>(str);
}

champ.ToString();

