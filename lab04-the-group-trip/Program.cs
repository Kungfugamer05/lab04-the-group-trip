

const int slicesPerPizza = 8;
const double taxRate = 0.18; 

System.Console.WriteLine("Round trip miles: ");
double roundTripMiles = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Miles per gallon ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Price per gallon ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("How many pizzas: ");
int totalPizzas = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Price per pizza ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine();

//Part 1
System.Console.WriteLine("=== Part 1: The Trip ===");

double fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon);

double totalPizzasPrice = totalPizzas * pricePerPizza;

double tripTotal = fuelCost + totalPizzasPrice;

System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
System.Console.WriteLine("Pizza cost: " + totalPizzasPrice.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

System.Console.WriteLine();

//Part 2 