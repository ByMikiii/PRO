using Uloha_1_OOP;

internal class Program
{
	private static void Main(string[] args)
	{
		Car amg = new("Mercedes-benz", "AMG GT", 999.9, "Automatic", "petrol", 585);
		Car mustang = new("Ford", "Mustang", 699.9, "Automatic", "gasoline", 480);
		Car fabka = new("Skoda", "Fabia", 29.9, "Manual", "gasoline", 150);
		Car passat = new("VW", "Passat", 79.9, "Automatic", "gasoline", 174);
		Car golf = new("VW", "Golf", 69.9, "Manual", "gasoline", 90);
		Car a4 = new("Audi", "A4", 299.9, "Automatic", "gasoline", 201);
		Car mko = new("BMW", "535i m sport", 699.9, "Automatic", "gasoline", 240);
		Car rolls = new("Rolls-royce", "Phantom", 12999.9, "Automatic", "petrol", 563);


		rolls.PrintInfo();
		Console.WriteLine("----------------------");

		Employee marek = new("Marek", "Maly", 949755321, "mmaly@email.com", 12.70);
		Employee anna = new("Anna", "Alka", 94555114, "annnnna@email.com", 12.50);
		Employee rene = new("Rene", "Rendy", 90584314, "rrednyy@email.com", 32.50);

		rene.odpracovane_hodiny = 120;

		rene.PrintInfo();

		rene.CalcSalary();

		Company pozicovna = new("Závodská cesta 6 01001 Zilina", "8:00 - 16:00", 944555631);

		pozicovna.AddCar(amg);
		pozicovna.AddCar(mustang);
		pozicovna.AddCar(fabka);
		pozicovna.AddCar(passat);
		pozicovna.AddCar(golf);
		pozicovna.AddCar(a4);
		pozicovna.AddCar(mko);
		pozicovna.AddCar(rolls);

		pozicovna.AddEmployee(rene);
		pozicovna.AddEmployee(anna);
		pozicovna.AddEmployee(marek);


		pozicovna.spacer();
		pozicovna.PrintAllCars();
		pozicovna.spacer();

		pozicovna.PrintAllEmployees();
		pozicovna.spacer();


	}
}