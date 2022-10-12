using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace CV_4
{
	public class Board
	{
		public List<Vehicle> vehiclesList = new List<Vehicle>();

		public Board()
		{

		}

		public void addVehicle(Vehicle newVeh)
		{
			vehiclesList.Add(newVeh);
		}

		public void printAllVehicles()
		{
			Console.WriteLine("Zoznam vsetkych vozidiel: ");
			foreach (Vehicle v in vehiclesList)
			{
				Console.Write($"{v.Name}, ");
			}
		}

		public double calcEuclidDistance(Vehicle v1, Vehicle v2)
		{
			double dist = Math.Sqrt(Math.Pow(v1.PosX - v2.PosX, 2) + Math.Pow(v1.PosY - v2.PosY, 2));
			return dist;
		}

		public void printVehiclesInRange(int id)
		{
			string name = vehiclesList[id].Name;
			double range = vehiclesList[id].Range;

			foreach (Vehicle v in vehiclesList)
			{
				if (v.Name != name) {
					double dist = calcEuclidDistance(vehiclesList[id], v);
					if(dist <= range)
					{
						Console.WriteLine($"{name} dostreli na {v.Name} kt. lezi na suradniciach x = {v.PosX} a y = {v.PosY}.");
					}
					
				}
			}
		}
	}
}

