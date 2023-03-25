using System.Text.Json.Serialization;

namespace LoL_API_projekt;

public class Champions
{
	[JsonPropertyName("champions")] public List<Champion>Championss {get; set;}

	public Champions()
	{
		Championss = new List<Champion>();
	}

	public void ToString()
	{
		foreach (var chmp in Championss)
		{
			Console.WriteLine(chmp.Name);
			Console.WriteLine(chmp.Id);
			Console.WriteLine("--------------------");
		}
	}

	public void GetChampById(string id)
	{
		foreach (var chmp in Championss)
		{
			if (chmp.Id == id)
			{
				Console.WriteLine(chmp.Name);
				Console.WriteLine(chmp.Id);
			}
		}
	}
}
