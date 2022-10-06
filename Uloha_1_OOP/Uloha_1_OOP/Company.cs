using System;
using System.Collections.Generic;

namespace Uloha_1_OOP
{
	public class Company
	{

		public string adresa { get; set; }
		public string otvaracie_hodiny { get; set; }
		public int telefonne_cislo { get; set; }
		private List<Car> carList = new List<Car>();
		private List<Employee> employeeList = new List<Employee>();


		public Company(string _adresa, string _otvaracie_hodiny, int _telefonne_cislo)
		{
			this.adresa = _adresa;
			this.otvaracie_hodiny = _otvaracie_hodiny;
			this.telefonne_cislo = _telefonne_cislo;
		}

		public void AddCar(Car Car)
		{
			carList.Add(Car);
		}

		public void PrintAllCars()
		{
			Console.WriteLine("Zoznam vsetkych aut: ");
			foreach (Car c in carList) {
				Console.Write($"{c.model}, ");
			}
		}

		public void AddEmployee(Employee employee)
		{
			employeeList.Add(employee);
		}

		public void PrintAllEmployees()
		{
			Console.WriteLine("Zoznam vsetkych zamestnancov: ");
			foreach (Employee e in employeeList)
			{
				Console.Write($"{e.meno}, ");
			}
		}

		public void spacer()
		{
			Console.WriteLine(" ");
			Console.WriteLine("----------------");
		}

	}
}

//ctor - adresa, otvaracie hodiny (string), telefonne cislo
