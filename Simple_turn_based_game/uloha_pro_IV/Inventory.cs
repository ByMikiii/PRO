namespace uloha_pro_IV;

public class Inventory
{
	public List<Item> Items = new List<Item>();

	public Inventory()
	{
		Items = new List<Item>();
	}

	public void AddItem(Item newItem)
	{
		Items.Add(newItem);
	}

	public int CalcAttack()
	{
		int sumAttack = 0;
		foreach (Item i in Items)
		{
			sumAttack += i.Attack;
		}

		return sumAttack;
	}

	public int CalcDefense()
	{
		int sumDefense = 0;
		foreach (Item i in Items)
		{
			sumDefense += i.Defense;
		}

		return sumDefense;
	}

	public void PrintInventory()
	{
		foreach (Item i in Items)
		{
			Console.WriteLine(i.Name);
		}
	}
}
