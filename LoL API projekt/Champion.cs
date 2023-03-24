using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Champion
{
	[JsonPropertyName("champions")] public List<Champion>Champions {get; set;}

	public Champion()
	{
		Champions = new List<Champion>();
	}

	public void ToString()
	{
		foreach (var ch in Champions)
		{
			Console.WriteLine(ch);
		}
	}
}
