Console.WriteLine("Enter a string");
string inputString = Console.ReadLine();
static string ReverseString(string input)
{
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        if (char.IsLower(chars[i]))
        {
            chars[i] = char.ToUpper(chars[i]);
        }
        else
        {
            chars[i] = char.ToLower(chars[i]);
        }
    }
    return new string(chars);

}
string example = ReverseString(inputString);
Console.WriteLine(example);

Console.ReadLine();

