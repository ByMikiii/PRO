namespace PisomkaBratislavaDOD;

public class Firm
{
	public List<Employee> Employees { get; set; }

	public Firm()
	{
		Employees = new List<Employee>();
	}

	public void PrintEmployeesWithIncome(double income)
	{
		foreach (var e in Employees)
		{
			if (e.calculateSalaryNetoo() >= income)
			{
				Console.WriteLine(e);
				Console.WriteLine("-----------------");
			}
		}
	}
}
