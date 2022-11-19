namespace uloha_pro_IV;

public class Player : Character
{
	public Inventory MyInventory;

	public Player(string Name, int Health) : base(Name, Health)
	{
		MyInventory = new Inventory();

	}

	public override int Attack()
	{
		return base.Attack();
	}

	public override void TakeDamage(int damage)
	{
		base.TakeDamage(damage);
	}
}
