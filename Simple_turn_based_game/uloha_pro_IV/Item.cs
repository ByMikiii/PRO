namespace uloha_pro_IV;

public class Item
{
	public string Name { get; set; }
	public int Attack { get; set; }
	public int Defense { get; set; }

	public Item(string _name, int _attack, int _defense)
	{
		this.Name = _name;
		this.Attack = _attack;
		this.Attack = _defense;
	}

	public override string ToString()
	{
		return $" {Name}, moj attack je: {Attack}, moj defense je {Defense}.";
	}

}
