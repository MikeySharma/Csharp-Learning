static class ClassesAndObjects
{
    public static void Run()
    {
        Console.WriteLine("Defining a class:");
        Console.WriteLine("A class is a blueprint for creating objects. It defines properties and methods that the objects created from the class will have.");
        Console.WriteLine("Defining an object:");
        Console.WriteLine("An object is an instance of a class. It has its own state and behavior defined by the class.");

        Console.WriteLine("\nCreating a BankAccount class with properties and methods:");
        BankAccount account1 = new("Alice", 1000.0, "NYC001");
        account1.DisplayAccountInfo();
    }
}