using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Summoner
{

    [JsonPropertyName("id")] public string Id {get; set;}
    [JsonPropertyName("name")] public string Name {get; set;}
    
    [JsonPropertyName("accountId")] public string AccountId {get; set;}
    
    [JsonPropertyName("puuid")] public string PuuId {get; set;}
    
    [JsonPropertyName("summonerLevel")] public int Level {get; set;}

    public void option()
    {
        Console.WriteLine("Select option:");
        Console.WriteLine("  [1] Show summoners data");
        Console.WriteLine("  [2] Show summoners champion mastery");
        Console.WriteLine("  [3] Show summoners games");

        string useroption = Console.ReadLine();

        if (useroption == "1")
        {
            Console.WriteLine(this.ToString());
        } 
        else if(useroption == "2")
        {
            Console.WriteLine("2");
        }
    }

    public void championMastery()
    {
        
    }
    public override string ToString()
    {
        return $" Name: {this.Name} \n Id: {this.Id} \n PuuId: {this.PuuId} \n Level: {this.Level}";
    }
}