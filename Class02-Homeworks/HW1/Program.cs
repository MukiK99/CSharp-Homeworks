// Real Calculator
Console.WriteLine("Enter the first number!");
bool isValidFirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
Console.WriteLine("Enter the second number!");
bool isValidSecondNumber = double.TryParse(Console.ReadLine(), out double secondNumber);
//var sign = '+';
//Console.WriteLine(sign.GetType());

if (!isValidFirstNumber || !isValidSecondNumber)
{
    Console.WriteLine("You entered invalid values!");
}
else
{
    Console.WriteLine("Enter the wanted operator!");
    string sign = Console.ReadLine();
    double result;
    switch (sign)
    {
        case "+":
            result = firstNumber + secondNumber;
            Console.WriteLine($"The result is:{result}");
            break;
        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine($"The result is:{result}");
            break;
        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine($"The result is:{result}");
            break;
        case "/":
            result = firstNumber / secondNumber;
            Console.WriteLine($"The result is:{result}");
            break;
        default:
            Console.WriteLine("You have entered invalid operator");
            break;


    }


}
Console.ReadKey();