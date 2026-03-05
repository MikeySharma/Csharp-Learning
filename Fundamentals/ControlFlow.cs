static class ControlFlow
{
    public static void Swap(ref int x, ref int y)
    {
        (y, x) = (x, y);
    }

    public static bool TryParse(string input, out int result)
    {
        return int.TryParse(input, out result);
    }
    public static void PrintValue(in int value)
    {
        Console.WriteLine($"Value: {value}");
        // value++; // This will cause a compile-time error because 'value' is read-only in this context.
    }

    public static void Run()
    {
        int age = 18;

        // if-else statement
        Console.WriteLine("If else statement:");
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else if (age >= 13)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        // switch statement
        Console.WriteLine("\nSwitch statement:");
        switch (age)
        {
            case 0:
                Console.WriteLine("You are a newborn.");
                break;
            case 1:
            case 2:
                Console.WriteLine("You are an infant.");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("You are a toddler.");
                break;
            default:
                Console.WriteLine("You are older than a toddler.");
                break;
        }

        // for loop
        Console.WriteLine("\nFor loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // for each loop
        Console.WriteLine("\nFor each loop:");
        string[] fruits = ["Apple", "Banana", "Cherry"];
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // while loop
        Console.WriteLine("\nWhile loop:");
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }

        // do-while loop
        Console.WriteLine("\nDo-while loop:");
        int doCount = 0;
        do
        {
            Console.WriteLine($"Do Count: {doCount}");
            doCount++;
        } while (doCount < 5);

        Console.WriteLine("Main difference between while and do-while is that do-while executes the block at least once, while while may not execute at all if the condition is false.");


        // Ref-Out-In parameters
        Console.WriteLine("\nRef-Out-In parameters:");
        int a = 5;
        int b = 10;

        // ref parameters
        Console.WriteLine($"Before: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After: a = {a}, b = {b}");

        // out parameters
        Console.WriteLine("\nOut parameters:");
        if (TryParse("123", out int result))
        {
            Console.WriteLine($"Parsed number: {result}");
        }
        else
        {
            Console.WriteLine("Failed to parse number.");
        }

        // in parameters
        Console.WriteLine("\nIn parameters:");
        int x = 5;
        PrintValue(in x);
    }
}