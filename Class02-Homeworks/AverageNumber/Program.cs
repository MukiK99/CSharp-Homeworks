// Average Number - iskoristen e type double za pogolema preciznost, inaku mozheshe i so int za da se dobie rezultatot od primerot vo domasnata!

Console.WriteLine("Please enter 4 numbers");
bool isValidFirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
bool isValidSecondNumber = double.TryParse(Console.ReadLine(), out double secondNumber);
bool isValidThirdNumber = double.TryParse(Console.ReadLine(), out double thirdNumber);
bool isValidFourthNumber = double.TryParse(Console.ReadLine(), out double fourthNumber);

if(!isValidFirstNumber ||  !isValidSecondNumber || !isValidThirdNumber || !isValidFourthNumber)
{
    Console.WriteLine("You have entered some invalid value!");
} 
else
{
    double averageValue = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine($"The average value of the numbers is:{averageValue}");

}
Console.ReadKey();