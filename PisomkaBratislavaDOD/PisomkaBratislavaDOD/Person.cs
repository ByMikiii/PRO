namespace PisomkaBratislavaDOD;

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public double Heigh { get; set; }

	public Person(string _firstname, string _lastname, int _age, double _height)
	{
		this.FirstName = _firstname;
		this.LastName = _lastname;
		this.Age = _age;
		this.Heigh = _height;
	}

	public override string ToString()
	{
		return $"Name: {this.FirstName} \n Surname: {this.LastName} \n Age: {this.Age} \n Height: {this.Heigh}";
	}
}
