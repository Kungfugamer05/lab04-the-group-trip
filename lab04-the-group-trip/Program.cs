

const int slicesPerPizza = 8;
const double taxRate = 0.18; 

//Ask questions abt the trip
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
System.Console.WriteLine("=== Part 2: The Group ===");

string[] names = {"Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = {22, 15, 30, 18};
double[] hourlyRates = {13.50, 16.00, 11.20, 14.80};

double howManySlices = totalPizzas * slicesPerPizza; 

double howManySlicesEachPersonGets = howManySlices / names.Length; 

double costPerPerson = tripTotal / names.Length; 

System.Console.WriteLine("People going: " + names.Length);
System.Console.WriteLine("Slices each: " + howManySlicesEachPersonGets.ToString("F1"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));

System.Console.WriteLine();

//Part 3
System.Console.WriteLine("=== Part 3: Who Works How Long ===");

double totalHoursWorked = 0;
double totalTakeHomePay = 0;
double longest = 0;

for (int i = 0; i < names.Length; i++)
{
    double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);

    double takeHomePayPerHour = takeHomePay / hoursWorked[i]; 

    double hoursYouMustWork = HoursToCover(costPerPerson, takeHomePayPerHour);

    System.Console.WriteLine(names[i] + ": takes home" +
    takeHomePay.ToString("C") + " for " + 
    hoursWorked[i].ToString("F0") + " hours, " +
    takeHomePayPerHour.ToString("C") + " per hour, must work " + 
    hoursYouMustWork.ToString("F2") + " hours");

totalHoursWorked = totalHoursWorked +hoursWorked[i];
totalTakeHomePay= totalTakeHomePay + takeHomePay; 
longest = Math.Max(longest, hoursYouMustWork);

}
System.Console.WriteLine();

System.Console.WriteLine("Total hours worked: " + totalHoursWorked.ToString("F0"));
System.Console.WriteLine("Total take home pay: " + totalTakeHomePay.ToString("C"));
System.Console.WriteLine("Longest anyone must work: " + longest.ToString("F2"));

//Return the total amount spent on gas 
