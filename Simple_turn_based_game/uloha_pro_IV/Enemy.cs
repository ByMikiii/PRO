namespace uloha_pro_IV;

public class Enemy : Character
{
	private List<Item> LootPool = new List<Item>();

	public Enemy(string Name, int Health, List<Item> _lootPool) : base(Name, Health)
	{
		this.LootPool = _lootPool;
	}

	public Item DropLoot()
	{
		Random rnd = new Random();
		int randIndex = rnd.Next(0, LootPool.Count);
		return LootPool[randIndex];
	}

	public override string ToString()
	{
		return $"y{Name}";
	}
}
