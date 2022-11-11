namespace Polymorphism;

public class Calc
{
	public int X;
	public int Y;

	public Calc() {
		Console.WriteLine("Zavolal sa prázdny konštruktor");
	}

	public Calc(int x)
	{
		this.X = x;
		Console.WriteLine($"Zavolal sa konštruktor pre X ({x})");
	}

	public Calc(int x, int y)
	{
		this.X = x;
		this.Y = y;
		Console.WriteLine($"Zavolal sa konštruktor pre X ({x}) a Y ({y})");
	}

	public void DoSomething(string s)
	{
		Console.WriteLine(s);
	}

	public void DoSomething(string s,int n)
	{
		Console.WriteLine(s.Substring(0,n));
	}

	public void DoSomething(string s, bool b)
	{
		if (b)
		{
			Console.WriteLine(s.ToUpper());
		}else Console.WriteLine(s.ToLower());
	}

	public void DoSomething(int n1,int n2)
	{
		Console.WriteLine(Math.Pow(n1,n2));
	}

	public void DoSomething(int n, double f)
	{
		Console.WriteLine(".");
	}
}
