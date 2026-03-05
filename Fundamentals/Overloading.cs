static class OverLoading
{
    public static void Run()
    {
        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(1.5, 2.5));
        Console.WriteLine(Add("Hello, ", "World!"));
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static string Add(string a, string b)
    {
        return a + b;
    }
}