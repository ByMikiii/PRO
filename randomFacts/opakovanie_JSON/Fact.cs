using System.Text.Json.Serialization;

namespace opakovanie_JSON;

public class Fact
{
	[JsonPropertyName("text")] public string Text { get; set; }
	[JsonPropertyName("source_url")] public string Url { get; set; }


	public override string ToString()
	{
		return $"text: {this.Text} \n url: {this.Url}";
	}

	public int WordCount()
	{
		string phrase = this.Text;
		string[] seperated;    // this is where you would split the full name
		int word = 0;


		seperated=phrase.Split(' ');

		for (int i = 0; i<seperated.Length; i++)
		{
			word++;
		}

		return word;
	}

	public bool ContainsPalindrom()
	{
		string phrase = this.Text;
		string[] seperated; // this is where you would split the full name

		seperated = phrase.Split(' ');

		for (int i = 0; i < seperated.Length; i++)
		{
			string word = seperated[i];
			string newword = ReverseString(word);

			if (word.Length != 1)
			{
				if (newword == word)
				{
					// Console.WriteLine(newword);
					// Console.WriteLine(word);
					// Console.WriteLine("contains");
					return true;
				}
				// else
				// {
				// 	Console.WriteLine(newword);
				// 	Console.WriteLine(word);
				// 	Console.WriteLine("no");
				// }
			}
		}

		return false;
	}
	static string ReverseString(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}


}
