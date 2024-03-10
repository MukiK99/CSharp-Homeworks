string[] studentsG1 = { "Ivo", "Ivan", "Aneta", "Darko", "Gorjan" };
string[] studentsG2 = { "Murat", "Radica", "Anamarija", "Sara", "Simeon" };
Console.WriteLine("Enter 1 or enter 2");
string input = Console.ReadLine();
bool isValidNumber = int.TryParse(input, out int number);
if (!isValidNumber)
{
    Console.WriteLine("Please enter valid number");
}
else
{
    if(number == 1)
    {
        Console.WriteLine("G1 students:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
   else if(number == 2)
    {
        Console.WriteLine("G2 students:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("The student group is not found!");
    }
}
Console.ReadLine();