static class ParamsArray
{
    public static void Run()
    {
        Console.WriteLine("Params Array");
        Console.WriteLine("============");
        Console.WriteLine();

        // A params array allows you to pass a variable number of arguments to a method.
        // The params keyword is used to specify that a method parameter can take a variable number of arguments.

        // Example:
        PrintNumbers(1, 2, 3, 4, 5);
        PrintNumbers(10, 20);
        PrintNumbers(); // No arguments

        Console.WriteLine();
    }

    static void PrintNumbers(params int[] numbers)
    {
        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
    }
}