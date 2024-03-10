//Console.OutputEncoding = System.Text.Encoding.UTF8;
static string FormatDateToString(DateTime date, string format)

{
    string stringDate = "";
    if (IsValidformat(format))
    {
        stringDate = date.ToString(format);
        Console.WriteLine($"The specific string is: {stringDate}");
    }
    else
    {
        Console.WriteLine($"This format {format} is not allowed!");
       
    }

    return stringDate;
}


static bool IsValidformat(string format)
{
    string[] formatArray = { "MM/dd/yyyy", "MM/dd/yyyy hh:mm:ss", "dddd, dd MMMM yyyy HH:mm:ss", "MM.dd.yyyy" };
    bool isValid = false;
    for (int i = 0; i < formatArray.Length; i++)
    {
        if (format == formatArray[i])
        {
            isValid = true;
            break;
        }
    }
    return isValid;
}

string dateInString = FormatDateToString(DateTime.Now, "MM/dd/yyyy hh:mm:ss");
Console.ReadLine();