using System;
namespace Uloha_1_OOP
{
	public class Employee
	{

		public string meno { get; set; }
		public string priezvisko { get; set; }
		public int telefonne_cislo { get; set; }
		public string email { get; set; }
		public double peniaze_za_hodinu { get; set; }
		public int odpracovane_hodiny { get; set; }


		public Employee(string _meno, string _priezvisko, int _telefonne_cislo, string _email, double _peniaze_za_hodinu)
		{
			this.meno = _meno;
			this.priezvisko = _priezvisko;
			this.telefonne_cislo = _telefonne_cislo;
			this.email = _email;
			this.peniaze_za_hodinu = _peniaze_za_hodinu;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Meno: {meno}");
			Console.WriteLine($"Priezvisko: {priezvisko}");
			Console.WriteLine($"Telefonne cislo: {telefonne_cislo}");
			Console.WriteLine($"Email: {email}");
			Console.WriteLine($"Peniaze za hodinu: {peniaze_za_hodinu}");
			Console.WriteLine($"Odpracovane hodiny: {odpracovane_hodiny}");
		}

		public void CalcSalary()
		{
			double vyplata = peniaze_za_hodinu * odpracovane_hodiny;
			Console.WriteLine($"{meno} bude mat vyplatu: {vyplata}");
		}

	}
}

