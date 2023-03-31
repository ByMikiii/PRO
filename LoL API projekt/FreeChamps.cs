using System.Text.Json;
using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class FreeChamps
{
    [JsonPropertyName("freeChampionIds")] public int[] championIds { get; set; }

    public void ToString()
    {
        Console.WriteLine("Free champions: ");
        foreach (var champId in championIds)
        {
            Champions champs = new Champions();
            using(var sr = new StreamReader("../../../champions.json"))
            {
                string str = sr.ReadToEnd();
                champs = JsonSerializer.Deserialize<Champions>(str);
            }
            
            Console.Write(champs.GetChampNameById(champId.ToString())+", ");
        }
        Console.WriteLine();
    }
}