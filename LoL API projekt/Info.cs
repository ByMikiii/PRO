using System.Text.Json.Serialization;
using ConsoleTables;

namespace LoL_API_projekt;

public class Info
{
    [JsonPropertyName("gameCreation")] public long GameCreation {get; set;}
    [JsonPropertyName("gameDuration")] public int GameDuration {get; set;}
    [JsonPropertyName("gameMode")] public string GameMode {get; set;}
    [JsonPropertyName("participants")] public List<Participant>participants { get; set; }

    public Info()
    {
	    participants = new List<Participant>();
    }

    public void ToString()
    {
        var created = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(this.GameCreation / 1000d)).ToLocalTime();

        var duration = this.GameDuration / 60;

        Console.WriteLine($"  Created: {created} \n  Duration: {duration} minutes \n  Gamemode: {this.GameMode} \n");

        var table = new ConsoleTable("  NAME  ", "  LANE  ", "  CHAMPION  ", "  CS  ", "  KILLS  ", "  DEATHS  ", "  ASSISTS  ", "  KDA  ", "  GOLD  ", "  VISION  ",
	        "FIRST BLOOD");

        var table2 = new ConsoleTable("  NAME  ", "  LANE  ", "  CHAMPION  ", "  CS  ", "  KILLS  ", "  DEATHS  ", "  ASSISTS  ", "  KDA  ", "  GOLD  ", "  VISION  ",
	        "FIRST BLOOD");

        int i = 0;
        foreach (var part in participants)
        {
	        string fb = "";
	        if (part.FirstBlood == true)
	        {
		        fb = "*";
	        }
	        if (i == 0)
	        {
		        if (part.Win == false)
		        { Console.WriteLine("                                                             BLUE TEAM  -  DEFEAT"); }
		        else { Console.WriteLine("                                                             BLUE TEAM  -  VICTORY"); }
	        }

	        if (i < 5)
	        {
		        table.AddRow(part.SummonerName,part.Lane, part.ChampName, part.Cs+part.Css, part.Kills, part.Deaths, part.Assists, Math.Round((part.Kills + part.Assists) / part.Deaths, 2), part.GoldEarned, part.VisionScore, fb);
	        }

	        if (i == 5)
	        {
		        table.Write(Format.MarkDown);
		        if (part.Win == false) { Console.WriteLine("\n                                                             RED TEAM  -  DEFEAT");
		        }else{Console.WriteLine("\n                                                             RED TEAM  -  VICTORY");}
	        }
	        if (i >= 5)
	        {
		        table2.AddRow(part.SummonerName, part.Lane, part.ChampName, part.Cs+part.Css, part.Kills, part.Deaths, part.Assists, Math.Round((part.Kills + part.Assists) / part.Deaths, 2), part.GoldEarned, part.VisionScore, fb);
	        }
	        i++;
        }
        table2.Write(Format.MarkDown);
    }
}
