Console.WriteLine("Enter 5 numbers");
string input1 = Console.ReadLine();
bool isValidFirstInput = int.TryParse(input1, out int firstNumber);
string input2 = Console.ReadLine();
bool isValidSecondInput = int.TryParse(input2, out int secondNumber);
string input3 = Console.ReadLine();
bool isValidThirdInput = int.TryParse(input3, out int thirdNumber);
string input4 = Console.ReadLine();
bool isValidFourthInput = int.TryParse(input4, out int fourthNumber);
string input5 = Console.ReadLine();
bool isValidFifthInput = int.TryParse(input5, out int fifthNumber);
if (!isValidFirstInput || !isValidSecondInput || !isValidThirdInput || !isValidFourthInput || !isValidFifthInput)
{
    Console.WriteLine("Please enter valid integer values!");
}
else
{
    int[] integerArray = { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber };
    int sum = 0;
    for (int i = 0; i < integerArray.Length; i++)
    {
        sum += integerArray[i];
    }
    Console.WriteLine($"The sum of the numbers is:{sum}");
}
Console.ReadLine();
