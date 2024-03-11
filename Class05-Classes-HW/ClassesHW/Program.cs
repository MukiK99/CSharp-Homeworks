using ClassesHW.Classes;

static void RaceCars(Driver driver1, Car car1, Driver driver2, Car car2)
{
    if (car1.CalculateSpeed() > car2.CalculateSpeed())
    {
        Console.WriteLine($"Driver {driver1.Name} with {car1.Model} with speed of {car1.CalculateSpeed().ToString("0.##")} kmh is the winner!");
    }
    else
    {
        Console.WriteLine($"Driver {driver2.Name} with {car2.Model} with speed of {car2.CalculateSpeed().ToString("0.##")} kmh  is the winner!");
    }
}
static Driver ChooseDriver(int choosedDriver)
{
    switch (choosedDriver)
    {
        case 1:
            return new Driver()
            {
                Name = "Bob",
                Skill = 0.85
            };
        case 2:
            return new Driver()
            {
                Name = "Greg",
                Skill = 0.88
            };
        case 3:
            return new Driver()
            {
                Name = "Jill",
                Skill = 0.84
            };
        case 4:
            return new Driver()
            {
                Name = "Anne",
                Skill = 0.83
            };
        default:
            return null;
    }
}

static Car ChooseCar(int choosedCar,Driver driver)
{
    switch (choosedCar)
    {
        case 1:
            return new Car("Hyundai", 270, driver);
        case 2:
            return new Car("Mazda", 280, driver);
        case 3:
            return new Car("Ferrari", 340, driver);
        case 4:
            return new Car("Porsche", 330,driver);
        default:
            return null;
    }
}

while (true)
{


    Console.WriteLine("Please type a number from 1-4 and choose your first wanted driver:\n1.Bob\n2.Greg\n3.Jill\n4.Anne");
    string chosenOption1 = Console.ReadLine();
    bool isValidFirstDriver = int.TryParse(chosenOption1, out int chosenDriver1);
    if (!isValidFirstDriver || chosenDriver1 <= 0 || chosenDriver1 >= 5)
    {
        Console.WriteLine("Invalid first driver chosen! Try again!\n");
        Thread.Sleep(2000);
        Console.Clear();
        continue;

    }
    else
    {
        Driver firstDriver = ChooseDriver(chosenDriver1);
        Console.WriteLine("Please type a number from 1-4 and choose your second wanted driver:\n1.Bob\n2.Greg\n3.Jill\n4.Anne");

        string chosenOption2 = Console.ReadLine();
        bool isValidSecondDriver = int.TryParse(chosenOption2, out int chosenDriver2);
        if (!isValidSecondDriver || firstDriver == null || chosenDriver2 >= 5 || chosenDriver2 <= 0 || chosenDriver2 == chosenDriver1)
        {
            Console.WriteLine("Invalid second driver chosen, first driver is null or second driver is the same driver as first driver! Try again!\n");
            Thread.Sleep(2000);
            Console.Clear();
            continue;
        }
        else
        {
            Driver secondDriver = ChooseDriver(chosenDriver2);
            Console.WriteLine("Please type a number from 1-4 and choose your first wanter car:\n1.Hyundai\n2.Mazda\n3.Ferrari\n4.Porsche");
            string chosenCarOption1 = Console.ReadLine();
            bool isValidFirstCar = int.TryParse(chosenCarOption1, out int chosenCar1);
            if (!isValidFirstCar || chosenCar1 <= 0 || chosenCar1 >= 5)
            {
                Console.WriteLine("Invalid first car chosen! Try again!\n");
                Thread.Sleep(2000);
                Console.Clear();
                continue;

            }
            else
            {
                Car firstCar = ChooseCar(chosenCar1, firstDriver);
                Console.WriteLine("Please type a number from 1-4 and choose your second wanter car:\n1.Hyundai\n2.Mazda\n3.Ferrari\n4.Porsche");
                string chosenCarOption2 = Console.ReadLine();
                bool isValidSecondCar = int.TryParse(chosenCarOption2, out int chosenCar2);
                if (!isValidSecondCar || firstCar == null || chosenCar2 >= 5 || chosenCar2 <= 0 || chosenCar1 == chosenCar2)
                {
                    Console.WriteLine("Invalid second car chosen, first car is null or second car is the same car as first Car\n! Try again!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;

                }
                else
                {
                    Car secondCar = ChooseCar(chosenCar2, secondDriver);
                    RaceCars(firstDriver, firstCar, secondDriver, secondCar);
                    Console.WriteLine("Do you want another race? Please type Yes if you do!");
                    string anotherRace = Console.ReadLine();
                    if(anotherRace == "yes" || anotherRace == "Yes" || anotherRace == "YES")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            }



        }
    }
}
 
