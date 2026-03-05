static class Returntypes
{
    public static int GetInt()
    {
        return 42;
    }

    public static string GetString()
    {
        return "Hello, World!";
    }

    public static double GetDouble()
    {
        return 3.14;
    }

    public static void Run()
    {
        int intValue = GetInt();
        string stringValue = GetString();
        double doubleValue = GetDouble();

        Console.WriteLine("Int Value: " + intValue);
        Console.WriteLine("String Value: " + stringValue);
        Console.WriteLine("Double Value: " + doubleValue);
    }
}