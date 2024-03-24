//## Task 1
//*Give the user an option to input numbers
//* After inputing each number ask them if they want to input another with a Y/N question
//* Store all numbers in a QUEUE
//* When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

Console.WriteLine("=================== Task 1 ======================");

static void PrintNumbers()
{
    Queue<int> intQueue = new Queue<int>();
    while (true)
    {


        Console.WriteLine("Please enter some integer value");
        string input = Console.ReadLine();
        bool isValidNumber = int.TryParse(input, out int number);
        if (!isValidNumber)
        {
            Console.WriteLine("Please enter valid integer value!\n");
            Console.WriteLine("Try again!");
            continue;
        }
        intQueue.Enqueue(number);
        Console.WriteLine("Do you want to enter another integer value?");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "yes")
        {
            continue;
        }
        break;
    }
    Console.WriteLine("\n\nThe user inputs stored in the queue are:");
    foreach (int number in intQueue)
    {
        
        Console.WriteLine(number);

    }
}

PrintNumbers();
Console.ReadLine();