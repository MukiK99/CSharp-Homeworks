
static double AgeCalculator(DateTime birthdayDate)
{
    TimeSpan age = DateTime.Today - birthdayDate;
    double doubleAgeInYears = age.TotalDays / 365.25;
    Console.WriteLine($"The user has {Math.Floor(doubleAgeInYears)} years");
    return doubleAgeInYears;
}

AgeCalculator(new DateTime(1999, 3, 9, 00, 00, 00));





Console.ReadLine();