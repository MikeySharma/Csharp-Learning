// See https://aka.ms/new-console-template for more information

// Learning variables and data types in C#

// Value types or Primitive types

//Numeric data types
// Max Values
int intMax = int.MaxValue; // 32-bit
long longMax = long.MaxValue; // 64-bit
short shortMax = short.MaxValue; //32-bit
byte byteMax = byte.MaxValue; //32-bit

Console.WriteLine("Int Max: " + intMax);
Console.WriteLine("Long Max: " + longMax);
Console.WriteLine("Short max: " + shortMax);
Console.WriteLine("Byte Max: " + byteMax);

// Min Values
Console.WriteLine("Int Min: " + int.MinValue);
Console.WriteLine("Long Min: " + long.MinValue);
Console.WriteLine("Short Min: " + short.MinValue);
Console.WriteLine("Byte Min: " + byte.MinValue);

// Floating Point Types
float temperature = 36.5f;   // 32-bit
double pi = 3.14159;         // 64-bit (default)
decimal money = 99.99m;      // High precision (financial)

Console.WriteLine("Temperature :" + temperature);
Console.WriteLine("Pi :" + pi);
Console.WriteLine("Money :" + money);

//Boolean Types
bool falseValue = false;
bool trueValue = true;

Console.WriteLine(falseValue + " " + trueValue);

// Character Types
char letter = 'M';

Console.WriteLine("Character Value : " + letter);

// Referenced types or Non-Primitive Types

//String type
string name = "Mikey Sharma";
Console.WriteLine("Name: " + name);

//Object type
//Boxing
int number = 100;
object obj = number;

Console.WriteLine("Boxed obj value: " + obj);

// Unboxing
int unBoxedNumber = (int)obj;
Console.WriteLine("Unboxed obj value : " + unBoxedNumber);

// Type inference (var)
var varName = "Mikey Sharma";
var varNum = 29;

Console.WriteLine("var type Name: " + varName);
Console.WriteLine("var type Num value: " + varNum);

// Nullable types
int? nullNum = null;
// Nullable<int> nullableInt = null;

Console.WriteLine("Null num value: " + nullNum);

// Constants
const int fixedNum = 80;
Console.WriteLine("fixed num using const: " + fixedNum);

Console.Write("Fixed values if not initialized: \nint -> 0, bool -> false, double -> 0.0, string -> null\n");

//Memory Model
int a = 5;
int b = a;
b = 10;
Console.WriteLine("Value of a: " + a);
Console.Write("`Code used for Memory model example to set value of a: \nint a = 5;\nint b = a;\nb = 10;`\n");