namespace uloha_pro_IV;

public class Character
{
	public string Name { get; set; }
	public int Health { get; set; }
	public bool Alive { get; set; }

	public Character(string _name, int _health)
	{
		this.Name = _name;
		this.Health = _health;
		this.Alive = true;
	}

	public virtual int Attack()
	{
		Random rnd = new Random();

		return rnd.Next(0, 16);
	}

	public virtual void TakeDamage(int damage)
	{
		if (damage < 0)
		{
			damage = 0;
		}

		this.Health -= damage;
		Console.WriteLine($"{this.Name} dostal {damage} damage.");

		if (this.Health <= 0)
		{
			this.Alive = false;
		}
	}
}
