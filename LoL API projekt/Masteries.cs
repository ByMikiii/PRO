using System.Text.Json;
using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Masteries
{
    [JsonPropertyName("masteries")] public List<Mastery>Masteriess {get; set;}

    public Masteries()
    {
        Masteriess = new List<Mastery>();
    }
    
    public void ToString()
    {
        Champions champs = new Champions();
        using(var sr = new StreamReader("../../../champions.json"))
        {
            string str = sr.ReadToEnd();
            champs = JsonSerializer.Deserialize<Champions>(str);
        }

        int i = 1;
        foreach (var mstr in Masteriess)
        {
            foreach (var chmp in champs.Championss)
            {
                if (chmp.Id == mstr.champID.ToString())
                {
                    Console.WriteLine("["+i+"] "+chmp.Name);
                }
            }
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(mstr.lastPlayed / 1000d)).ToLocalTime();
            
            Console.WriteLine($"  Points: {mstr.champPoints} \n  Level: {mstr.champLevel} \n  Last played: {dt}");
            
            Console.WriteLine("-----------------------------------------");
            i++;
        }
    }
}