// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using System.Text.Json.Serialization;
using opakovanie_JSON;

string url = "https://uselessfacts.jsph.pl/api/v2/facts/random?language=en";
List<Fact> FactList = new List<Fact>();


for (int i = 0; i < 10; i++)
{
	using (HttpClient client = new HttpClient())
{
	HttpResponseMessage response = await client.GetAsync(url);

	if (response.IsSuccessStatusCode)
	{
		string json = await response.Content.ReadAsStringAsync();

		Fact f = JsonSerializer.Deserialize<Fact>(json);

		FactList.Add(f);

		// Console.WriteLine(f.ToString());
		// f.ContainsPalindrom();
		//
	}
}
}

foreach (var fact in FactList)
{
	Console.WriteLine(fact.ToString());
	Console.WriteLine($"Pocet slov:{fact.WordCount()}");

	if (fact.ContainsPalindrom() == true)
	{
		Console.WriteLine("JE TAM PALINDROM");
	}
	else
	{
		Console.WriteLine("NIE JE TAM PALINDROM");
	}

	Console.WriteLine();
}
