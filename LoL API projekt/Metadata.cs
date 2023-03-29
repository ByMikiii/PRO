using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Metadata
{
    [JsonPropertyName("dataVersion")] public string DataVersion {get; set;}

    public void ToString()
    {
        Console.WriteLine(this.DataVersion);
    }
}