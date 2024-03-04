Console.WriteLine("Input the first number!");
bool isValidFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.WriteLine("Input the second number!");
bool isValidSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);
if(!isValidFirstNumber || !isValidSecondNumber)
{
    Console.WriteLine("You have entered some invalid value!");
}
else
{
    int temporaryVariable = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temporaryVariable;
    //(firstNumber, secondNumber) = (secondNumber, firstNumber); // drugo reshenie!
    Console.WriteLine($"The first number is:{firstNumber}");
    Console.WriteLine($"The second number is:{secondNumber}");
}
Console.ReadKey();