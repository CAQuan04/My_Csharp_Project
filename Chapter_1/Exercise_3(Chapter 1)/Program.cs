const double PI = 3.14;
Console.Write("Enter radius of circle: ");
bool isValid = double.TryParse(Console.ReadLine(), out double radius);
//double radius = double.Parse(Console.ReadLine());
if (isValid)
{
    double area = radius * radius * PI;
    Console.WriteLine("Area of circle with radius {0} is: {1}", radius, area);
}
else
{
    Console.WriteLine("Your radius is not vaid.");
}
Console.ReadKey();
