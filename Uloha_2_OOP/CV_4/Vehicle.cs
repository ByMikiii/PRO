using System;
namespace CV_4
{
	public class Vehicle
	{
		public string Name;
		public int PosX;
		public int PosY;
		public double Range;
		public bool Team;


		public Vehicle(string _name, bool _team, double _range, int _posX, int _posY)
		{
			this.Name = _name;
			this.PosX = _posX;
			this.PosY = _posY;
			this.Range = _range;
			this.Team = _team;
		}

		public void printVehicle()
		{
			string team;
			team = Team == true? "Blue" : "Red";
			Console.WriteLine($"{Name} (team {team}) ma dostrel {Range} a lezi na suradniciach x = {PosX} y = {PosY}.");
		}
		//Leopard 2A7 + (team Blue) ma dostrel 2 km a lezi na suradniciach x = 2   y = -3

		public bool moveVehicle(int x, int y)
		{
			this.PosX = x;
			this.PosY = y;
			return true;
		}
	}
}

