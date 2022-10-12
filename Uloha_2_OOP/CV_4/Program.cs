using CV_4;

internal class Program
{
	private static void Main(string[] args)
	{
		Vehicle v1 = new Vehicle("Leopard 2A7+", true, 2, 2, -3);
		Vehicle v2 = new Vehicle("M1A2 SEPv4", true, 4, 5, 1);
		Vehicle v3 = new Vehicle("T-80UM2", false, 3, 5, 5);
		Vehicle v4 = new Vehicle("Challenger 3", true, 2, -8, 3);
		Vehicle v5 = new Vehicle("Type 99A", false, 3, 5, -5);

		v2.printVehicle();

		//Vehicle: Leopard 2A7+ (team Blue) ma dostrel 2 km a lezi na suradniciach x = 2   y = -3

		Console.WriteLine();

		Board board = new Board();

		board.addVehicle(v1);
		board.addVehicle(v2);
		board.addVehicle(v3);
		board.addVehicle(v4);
		board.addVehicle(v5);

		board.printAllVehicles();

		//Vehicle: Leopard 2A7 + (team Blue) ma dostrel 2 km a lezi na suradniciach x = 2   y = -3
		//Vehicle: M1A2 SEPv4(team Blue) ma dostrel 4 km a lezi na suradniciach x = 5   y = 1
		//Vehicle: T - 80UM2(team Red) ma dostrel 3 km a lezi na suradniciach x = 5   y = 5
		//Vehicle: Challenger 3(team Blue) ma dostrel 2 km a lezi na suradniciach x = -8  y = 3
		//Vehicle: Type 99A(team Red) ma dostrel 3 km a lezi na suradniciach x = 5   y = -5

		Console.WriteLine();
		Console.WriteLine();

		Console.WriteLine(board.calcEuclidDistance(v4, v5));

		Console.WriteLine();

		int id = 1;

		board.printVehiclesInRange(id);
		//Vehicle: M1A2 SEPv4(team Blue) ma na dostrel vozidla:
		//--Vehicle: T - 80UM2(team Red) ma dostrel 3 km a lezi na suradniciach x = 5   y = 5

		Console.WriteLine();

		board.vehiclesList[id].moveVehicle(0, 0);

		board.printVehiclesInRange(id);
		//Vehicle: M1A2 SEPv4(team Blue) ma na dostrel vozidla:
		//--Vehicle: Leopard 2A7 + (team Blue) ma dostrel 2 km a lezi na suradniciach x = 2   y = -3
	}
}