static class Operators
{
    public static void Run()
    {
        int x = 10;
        int y = 5;

        // Arightmetic operators
        Console.WriteLine($"Value of x: {x}, and y: {y}");
        Console.WriteLine("Arithmetic Operators: ");
        Console.WriteLine("X + Y : " + (x + y));
        Console.WriteLine("X - Y : " + (x - y));
        Console.WriteLine("X * Y : " + (x * y));
        Console.WriteLine("X / Y : " + (x / y));
        Console.WriteLine("X % Y : " + (x % y));

        Console.WriteLine("Post increment is x++, which returns old value, then increments: " + x++);
        Console.WriteLine("Value of x after post increment: " + x);
        Console.WriteLine("Pre increment is ++x, which increments first, then returns new value: " + ++x);
        Console.WriteLine("Value of x after pre increment: " + x);

        //Logical Operators
        Console.WriteLine("Logical Operators: ");
        bool a = true;
        bool b = false;
        Console.WriteLine($"Value of a: {a}, and b: {b}");
        Console.WriteLine("a && b : " + (a && b));
        Console.WriteLine("a || b : " + (a || b));
        Console.WriteLine("!a : " + (!a));

        // Non-short cuircuiting operators
        Console.WriteLine("Non-short circuiting operators: ");
        Console.WriteLine("a & b : " + (a & b));
        Console.WriteLine("a | b : " + (a | b));

        //Bitwise Operators
        Console.WriteLine("Bitwise Operators: ");
        int m = 6; // 110 in binary
        int n = 3; // 011 in binary
        Console.WriteLine($"Value of m: {m}, and n: {n}");
        Console.WriteLine("m & n : " + (m & n)); // 110 & 011 = 010 (2 in decimal)
        Console.WriteLine("m | n : " + (m | n)); // 110 | 011 = 111 (7 in decimal)
        Console.WriteLine("m ^ n : " + (m ^ n)); // 110 ^ 011 = 101 (5 in decimal)
        Console.WriteLine("~m : " + (~m)); // ~110 = 001 (1 in decimal)

        Console.WriteLine("Explanation: ");
        Console.WriteLine("The bitwise AND operator (&) compares each bit of its first operand to the corresponding bit of its second operand. If both bits are 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.");
        Console.WriteLine("The bitwise OR operator (|) compares each bit of its first operand to the corresponding bit of its second operand. If either bit is 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.");
        Console.WriteLine("The bitwise XOR operator (^) compares each bit of its first operand to the corresponding bit of its second operand. If the bits are different, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.");
        Console.WriteLine("The bitwise NOT operator (~) takes one operand and inverts all the bits of that operand. For example, if the operand is 6 (which is 110 in binary), the result of ~6 would be -7 (which is 001 in binary, but with a negative sign due to two's complement representation).");

    }
}