int a;
int b;

Console.Write("Enter first number a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number b: ");
b = Convert.ToInt32(Console.ReadLine());
int total = a + b;
Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, total);
Console.Read();