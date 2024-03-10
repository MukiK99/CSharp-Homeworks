Console.WriteLine("Enter 6 numbers");
string number1 = Console.ReadLine();
bool isValidFirstnumber = int.TryParse(number1, out int firstNumber);
string number2 = Console.ReadLine();
bool isValidSecondnumber = int.TryParse(number2, out int secondNumber);
string number3 = Console.ReadLine();
bool isValidThirdnumber = int.TryParse(number3, out int thirdNumber);
string number4 = Console.ReadLine();
bool isValidFourthnumber = int.TryParse(number4, out int fourthNumber);
string number5 = Console.ReadLine();
bool isValidFifthnumber = int.TryParse(number5, out int fifthNumber);
string number6 = Console.ReadLine();
bool isValidSixthnumber = int.TryParse(number6, out int sixthNumber);
if (!isValidFirstnumber || !isValidSecondnumber || !isValidThirdnumber || !isValidFourthnumber || !isValidFifthnumber || !isValidSixthnumber)
{
    Console.WriteLine("Please enter valid integer values!");
}
else
{
    int[] integerArray = { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber };
    int sum = 0;
    for (int i = 0; i < integerArray.Length; i++)
    {
        if (integerArray[i] % 2 == 0) 
        {
            sum += integerArray[i];

        }
    }
    Console.WriteLine($"The sum of the numbers is:{sum}");
}
Console.ReadLine();
