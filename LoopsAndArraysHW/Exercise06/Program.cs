string[] names = new string[5];
int counter = 0;
for (int i = 0; i < names.Length; i++)
{
    counter++;
    Console.WriteLine("Please enter a name that make some logic!");
    string userInput = Console.ReadLine();
    names[i] = userInput;
    if (counter < 5)
    {
        Console.WriteLine("Do you want to enter another name?");

    }
    else
    {
        break;
    }
    string userAnswer = Console.ReadLine();
    if (userAnswer == "No" || userAnswer == "no" || userAnswer == "NO")
    {
        break;
    }

}
Console.WriteLine($"The names are:");
foreach (string name in names)
{
    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine(name);

    }
}


Console.ReadLine();