namespace PisomkaBratislavaDOD;

public class Employee : Person
{
	public double SalaryBrutto { get; set; }

	public Employee(string _firstname, string _lastname, int _age, double _height, double _salarybrutto) : base(_firstname, _lastname, _age, _height)
	{
		this.SalaryBrutto = _salarybrutto;
	}

	public double calculateSalaryNetoo()
	{
		return this.SalaryBrutto * 0.7015;
	}

	public double calculateIncomeTax()
	{
		return SalaryBrutto * 0.1645;
	}

	public double calculateInsurance()
	{
		return SalaryBrutto * 0.134;
	}

	public override string ToString()
	{
		return
			$"Name: {this.FirstName} \n Surname:{this.LastName} \n Age: {this.Age} \n Brutto salary: {this.SalaryBrutto} \n Insurance: {calculateInsurance()} \n Income Tax: {calculateIncomeTax()} \n Netto salary: {calculateSalaryNetoo()}";
	}
}
