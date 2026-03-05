static class OptionalAndNamedParams
{
    public static void Run()
    {
        // Optional parameters
        PrintMessage("Hello"); // Uses default value for 'times'
        PrintMessage("Hello", 3); // Overrides default value for 'times'

        // Named parameters
        PrintMessage(times: 2, message: "Hi"); // Order doesn't matter with named parameters
    }

    public static void PrintMessage(string message, int times = 1)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(message);
        }
    }
}