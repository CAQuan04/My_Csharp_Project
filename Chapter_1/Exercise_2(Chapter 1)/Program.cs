Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Enter your phone number: ");
string phoneNumber = Console.ReadLine();

Console.Write("Enter your gender: ");
string gender= Console.ReadLine();
//bool gender = Console.ReadLine() == "Male";

Console.WriteLine("Name: {0}, Age: {1}, Phone Number: {2}, Gender: {3}", name, age, phoneNumber, gender);
Console.Read();