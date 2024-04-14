using Cars.Domain.Entities;
using Cars.Domain.Helpers;

List<Car> cars = CarsData.Cars;
//cars.PrintEntities();

// Filter all cars that have origin from Europe.
Console.WriteLine("================== Filter all cars that have origin from Europe. ======================\n");
List<Car> allCarsFromEurope = cars.Where(car => car.Origin == "Europe").ToList();
allCarsFromEurope.PrintEntities();

// Find all unique cylinder values for cars.
Console.WriteLine("====================== Find all unique cylinder values for cars. ========================\n");
List<Car> uniqueCylinderValues = cars.DistinctBy(car => car.Cylinders).ToList();
uniqueCylinderValues.PrintEntities();

//  Select all car model names with their model names converted to uppercase.
Console.WriteLine("===================== Select all car model names with their model names converted to uppercase. ===========");
List<string> allCarModels = cars.Select(car => car.Model.ToUpper()).ToList();
allCarModels.PrintSimple();

// Check if there are any cars with horsepower greater than 300.
Console.WriteLine("================ Check if there are any cars with horsepower greater than 300. ===================");
bool carWithHpMoreThan300 = cars.Any(car => car.HorsePower > 300);
Console.WriteLine($"Is there a car with more than 300 HP?: {carWithHpMoreThan300}\n");

// Find the car with the highest horsepower.
Console.WriteLine("\n============= Find the car with the highest horsepower. =======================\n ");
//Car carwithMostHp = cars.MaxBy(car => car.HorsePower);
var carWithMostHp = cars.OrderByDescending(car => car.HorsePower).FirstOrDefault();
Console.WriteLine(carWithMostHp.GetInfo());


// Filter all "Chevrolet" cars and order them by weight in descending order.
Console.WriteLine("\n================= Filter all \"Chevrolet\" cars and order them by weight in descending order. ==========\n ");
List<Car> chevroletCarsByWeightDesc = cars.Where(car => car.Model.Contains("Chevrolet")).OrderByDescending(car => car.Weight).ToList();
chevroletCarsByWeightDesc.PrintEntities();

// Find the car with the longest model name.
Console.WriteLine("\n ===================== Find the car with the longest model name. =====================\n");
Car carWithLongestName = cars.OrderByDescending(car => car.Model.Length).FirstOrDefault();
Console.WriteLine(carWithLongestName.GetInfo());

// Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
Console.WriteLine("\n ========================= Group cars by their origin and then order the groups by the number of cars in each group, in ascending order. ============ \n");
var groupedCarsByOrigin = cars.GroupBy(car => car.Origin).ToList();
var groupedCarsByOriginAsc = groupedCarsByOrigin.OrderBy(group => group.Count()).ToList();
foreach(var group in groupedCarsByOriginAsc)
{
    Console.WriteLine($"{group.Key} - {group.Count()}");
}

//  Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
Console.WriteLine("\n============= Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take()) ============\n ");
List<Car> fiveCarsWithMostHp = cars.OrderByDescending(car => car.HorsePower).Take(5).ToList();
fiveCarsWithMostHp.PrintEntities();

// Find the car with the highest acceleration time
Console.WriteLine("\n================ Find the car with the highest acceleration time ========================\n");
Car carWithHighestAccelerationTime = cars.OrderByDescending(car => car.AccelerationTime).FirstOrDefault();
Console.WriteLine(carWithHighestAccelerationTime.GetInfo());

// Select only the model and horsepower of cars with horsepower greater than 200
Console.WriteLine("\n================== Select only the model and horsepower of cars with horsepower greater than 200 =======\n");
List<string> carsWithMoreThan200Hp = cars.Where(car => car.HorsePower > 200).Select(car => $"{car.Model} {car.HorsePower}").ToList();
carsWithMoreThan200Hp.PrintSimple();

// Select all unique origins of cars, ordered alphabetically (ascending).
Console.WriteLine("\n============== Select all unique origins of cars, ordered alphabetically (ascending). ==============\n ");
List<string> uniqueCarOrigin = cars.Select(car => car.Origin).Distinct().OrderBy(origin => origin).ToList();
uniqueCarOrigin.PrintSimple();

// Select all cars with more than 4 cylinders, and order them by origin and then by horsepower. 
Console.WriteLine("\n============ Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.  ==========\n");
List<Car> fourCylinderCars = cars.Where(car => car.Cylinders > 4).OrderBy(car => car.Origin).ThenBy(car => car.HorsePower).ToList();
fourCylinderCars.PrintEntities();

// Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
Console.WriteLine("\n====== Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result. ======\n");
List<Car> carWithMoreThan6Cyl = cars.Where(car => car.Cylinders > 6).ToList();
List<Car> carWith4CylAndMoreThan110Hp = cars.Where(car => (car.Cylinders == 4 && car.HorsePower > 110)).ToList();
List<Car> joinedCarList = carWithMoreThan6Cyl.Concat(carWith4CylAndMoreThan110Hp).ToList();
joinedCarList.PrintEntities();

// Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.
Console.WriteLine("\n================= Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars. ===============\n");
List<Car> fastCars = cars.Where(car => car.HorsePower > 200).ToList();
double lowestMilesPerGallon = fastCars.Min(car => car.MilesPerGalon);
Console.WriteLine($"Lowest miles per gallon:\n{lowestMilesPerGallon}");
double highestMilesPerGallon = fastCars.Max(car => car.MilesPerGalon);
Console.WriteLine($"Highest miles per gallon:\n{highestMilesPerGallon}");
double averageMilesPerGallon = fastCars.Average(car => car.MilesPerGalon);
Console.WriteLine($"Average miles per gallon:\n{averageMilesPerGallon}");

// Custom 1 - Find all cars that have origin from US, with 8 cylinders and above, find their acceleration time and order them in descending order, but only the unique values
Console.WriteLine("\n============== Custom 1 ===========================\n");
List<double> custom1 = cars.Where(car => (car.Origin == "US" && car.Cylinders >= 8)).Select(car => car.AccelerationTime).Distinct().OrderByDescending(cars => cars).ToList();
custom1.PrintSimple();

// Custom 2 - Select the first 10 cars with the highest unique weight, with origin from Europe and show their models and weight!
Console.WriteLine("\n================= Custom 2 ============================\n");
List<string> custom2 = cars.Where(car => car.Origin == "Europe").OrderBy(car => car.Weight).DistinctBy(car => car.Weight).Take(10).Select(car => $"{car.Model} {car.Weight}").ToList();
custom2.PrintSimple();


Console.ReadLine();