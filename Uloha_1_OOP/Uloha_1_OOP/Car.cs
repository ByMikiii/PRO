using System;
namespace Uloha_1_OOP
{
	public class Car
	{
		public string vyrobca { get; set; }
		public string model { get; set; }
		public double cena { get; set; }
		public string typ_prevodovky { get; set; }
		public string fuel { get; set; }
		public int horsepower { get; set; }

		public Car(string _vyrobca, string _model, double _cena, string _typ_prevodovky, string _fuel, int _horsepower)
		{
			this.vyrobca = _vyrobca;
			this.model = _model;
			this.cena = _cena;
			this.typ_prevodovky = _typ_prevodovky;
			this.fuel = _fuel;
			this.horsepower = _horsepower;
		}

		public void PrintInfo()
		{
			Console.WriteLine("Vyrobca: " + this.vyrobca);
			Console.WriteLine("Model: " + this.model);
			Console.WriteLine("Cena: " + this.cena);
			Console.WriteLine("Typ prevodovky: " + this.typ_prevodovky);
			Console.WriteLine("Fuel: " + this.fuel);
			Console.WriteLine("Horsepower: " + this.horsepower);

		}
	}
}
//ctor - Vyrobca, model , Cena, typ prevodovky, fuel , horsepower

