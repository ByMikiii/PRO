using System;

namespace uloha_pro_IV // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new();

            //string Name, int Health
            Player player = new("Kratos", 200);

            //list of item drops
            List<Item> items = new()
            {
                //string Name, int Attack, int Defense
                new Item("B.F. Sword", 3, 0),
                new Item("Bloodthirster", 5, 0),
                new Item("Death's Dance", 2, 1),
                new Item("Dead Man's Plate", 0, 3),
                new Item("Spirit Visage", 0, 2),
                new Item("Warden's Mail", 0, 1),
                new Item("Force of Nature", 0, 3),
                new Item("Serpent's Fang", 4, 0),
            };

            //list of names of the enemies
            List<string> names = new()
            {
                "Kikimora",
                "Striga",
                "Golden Dragon",
                "Djinn",
                "Ghoul",
                "Wyvern"
            };

            while (true)
            {
                //list of item drops of enemy
                List<Item> ItemDrops = new();
                for (int i = 0; i < 3; i++)
                {
                    ItemDrops.Add(items[rand.Next(items.Count)]);
                }

                //creation of enemy
                Enemy enemy = new(names[rand.Next(names.Count)], rand.Next(100, 150), ItemDrops);
                Console.WriteLine($"You met {enemy.ToString()}");

                //fight
                while (true)
                {
                    enemy.TakeDamage(player.Attack());
                    if (!enemy.Alive)
                    {
                        break;
                    }
                    //wait 300 ms
                    Thread.Sleep(300);

                    player.TakeDamage(enemy.Attack());
                    if (!player.Alive)
                    {
                        break;
                    }
                    //wait 300 ms
                    Thread.Sleep(300);

                }

                //chceck if player is dead
                if (!player.Alive)
                {
                    Console.WriteLine("You died!");
                    Console.WriteLine($"{enemy.ToString()} HP left: {enemy.Health}");

                    return;
                }
                else
                {
                    //enemy drops loot
                    Item drop = enemy.DropLoot();
                    Console.WriteLine($"You killed {enemy.Name} | HP left {player.Health}");
                    Console.WriteLine($"{enemy.Name} dropped");
                    Console.WriteLine(drop);

                    Console.WriteLine("Take? (Y/N/I(Look at inventory)");
                    string takeItem = Console.ReadLine();

                    while (true)
                    {
                        if (takeItem == "Y" || takeItem == "N")
                            break;

                        if (takeItem == "I")
                            player.MyInventory.PrintInventory();

                        Console.WriteLine("Take? (Y/N/I(Look at inventory)");
                        takeItem = Console.ReadLine();
                    }

                    //taking loot
                    if (takeItem == "Y")
                    {
                        player.MyInventory.AddItem(drop);
                    }
                }


                Console.WriteLine("Continue? (Y/N)");
                string _continue = Console.ReadLine();
                while (true)
                {
                    if (_continue == "Y" || _continue == "N")
                        break;

                    Console.WriteLine("Continue? (Y/N)");
                    _continue = Console.ReadLine();
                }

                if (_continue == "N")
                {
                    return;
                }


                //heal player
                player.Health += 50;

            }
        }
    }
}
