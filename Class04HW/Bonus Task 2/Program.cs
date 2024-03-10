static string CheckEmailAdress()
{
  
    while (true)
    {
        Console.WriteLine("Enter your email adress!");
        string email = (Console.ReadLine()).Trim();
        if (!email.Contains('.') || email.Contains("..") || !email.Contains('@') || email.IndexOf("@") == 0 || (email.LastIndexOf("@") > email.LastIndexOf(".")) || email.IndexOf("@") != email.LastIndexOf("@"))
        {
            Console.WriteLine("Invalid email adress! Try again!");
            continue;
        }
        else
        {
            Console.WriteLine($"Correct! Your email adress is: {email}");
           
        }
        return email;
    }
}

CheckEmailAdress();
Console.ReadLine();