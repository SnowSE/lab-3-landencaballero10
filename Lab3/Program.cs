//Creating a (one) program that will produce the following output twice.
Console.WriteLine("    A   ");
Console.WriteLine("   BCD  ");
Console.WriteLine("  EFGHI ");
Console.WriteLine(" JKLMNOP");
Console.WriteLine("QRSTUVWXYZ");

Console.WriteLine("    A   \n   BCD  \n  EFGHI \n JKLMNOP\nQRSTUVWXYZ");

//Integer part
int Num1;
int Num2;
Console.Write("Enter first integer: ");
Num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second integer: ");
Num2 =int.Parse(Console.ReadLine());

int Num3= Num1 + Num2;
Console.WriteLine($"\nSum is............{Num3}");
int Num4= Num1 - Num2;
Console.WriteLine($"Difference is.....{Num4}");
int Num5 = Num1 * Num2;
Console.WriteLine($"Product is........{Num5}");
int Num6 = Num1 / Num2;
Console.WriteLine($"Quotient is.......{Num6}");

