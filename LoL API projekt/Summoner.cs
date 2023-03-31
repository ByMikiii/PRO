using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace LoL_API_projekt;

public class Summoner
{
    [JsonPropertyName("id")] public string Id {get; set;}
    [JsonPropertyName("name")] public string Name {get; set;}

    [JsonPropertyName("accountId")] public string AccountId {get; set;}
    [JsonPropertyName("puuid")] public string PuuId {get; set;}
    [JsonPropertyName("summonerLevel")] public int Level {get; set;}
    [JsonPropertyName("revisionDate")] public long RevisionDate {get; set;}

    public async Task<string> option()
    {
        while (true)
        {
            Console.WriteLine("\n Select option:");
            Console.WriteLine("  [1] Show summoners data");
            Console.WriteLine("  [2] Show summoners champion mastery");
            Console.WriteLine("  [3] Show most recent game");
            Console.WriteLine("  [4] Show free champion rotation");

        string useroption = Console.ReadLine();

        if (useroption == "1")
        {
            Console.WriteLine(this.ToString());
        }
        else if(useroption == "2")
        {
            string url = "https://eun1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/"+this.Id+Constants.api_key;
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string json = "{ \"masteries\": "+ await response.Content.ReadAsStringAsync()+" }";

                Masteries mastrs = new Masteries();

                mastrs = JsonSerializer.Deserialize<Masteries>(json);
                mastrs.ToString();
            }
        }
        else if (useroption == "3")
        {
	        Console.WriteLine("");

	        string url = "https://europe.api.riotgames.com/lol/match/v5/matches/by-puuid/"+ this.PuuId+"/ids"+Constants.api_key;
	        using(HttpClient client = new HttpClient())
	        {
		        HttpResponseMessage response = await client.GetAsync(url);
		        string json = "{ \"games\": "+ await response.Content.ReadAsStringAsync()+" }";

				Games games = new Games();

		        games = JsonSerializer.Deserialize<Games>(json);

		        games.ToString();

                Thread.Sleep(300);
                Game game = new Game();
                using(var sr = new StreamReader("../../../game.json"))
                {
                    string str = sr.ReadToEnd();
                    game = JsonSerializer.Deserialize<Game>(str);
                }

                game.info.ToString();
            }

        }
        else if (useroption == "4")
        {

        }
        }
        return "";
        }

    public override string ToString()
    {
        var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(this.RevisionDate / 1000d)).ToLocalTime();

        return $" Name: {this.Name} \n Id: {this.Id} \n PuuId: {this.PuuId} \n Level: {this.Level} \n Revision date: {dt}";
    }
}
