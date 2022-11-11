namespace Polymorphism;

public class Stvorec : Tvar
{
	public double sideA { get; set; }

	public Stvorec(double _sideA)
	{
		this.sideA = _sideA;
	}

	public override double Obvod()
	{
		return 4 * sideA;
	}

	public override double Obsah()
	{
		return sideA * sideA;
	}
}
