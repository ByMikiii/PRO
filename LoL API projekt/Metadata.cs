using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Metadata
{
    [JsonPropertyName("dataVersion")] public int DataVersion {get; set;}

    public void ToString()
    {
        Console.WriteLine("xdd");
        //Console.WriteLine(this.GameCreation);
    }
}