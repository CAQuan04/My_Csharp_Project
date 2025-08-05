/*//Lesson 14 - Methods
using System;

namespace Lesson_Chapter_2
{
    
    internal class Program
    {      
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of 5 and 10 is: {0}", Add(5, 10));
            Multiply(5, 6);
            Console.Read();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply {0} and {1} is: {2}", a, b, a * b);
        }
    }
}
*/
/*//Lesson 15 - ExceptionsHandler
try
{
    int a = 5;
    float b = a / 5;
}
catch (dividebyzeroexception dividebyzeroex)
{
    console.writeline("cannot divide by zero");
}
catch (exception ex)
{
    throw;
}
finally
{
    console.writeline("ok");
}

console.readkey();*/
/*// Lesson 17 - ifElseStructure
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

ConsoleConsole.Write("Nhập vào một số: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Là số chẵn.");
}
else
{
    Console.WriteLine("Là số lẻ.");
}

/*Console.Write("Nhập vào giá sản phẩm: ");
double price = double.Parse(Console.ReadLine());
Console.Write("Đã bao gồm thuế hay chưa y/n: ");
string answer = Console.ReadLine().ToLower();
bool includeVat = answer == "y" ? true : false;
if (!includeVat)
{
    price += price * 0.1;
}
Console.WriteLine("Giá sản phẩm sau thuế là: {0}", price);

//BMI (Body Mass Index) - Chỉ số khối cơ thể
//Dưới chuẩn: BMI ít hơn 18.5
//Chuẩn: BMI từ 18.5 đến 24.9
//Thừa cân: BMI từ 25 đến 29.9
//Thừa cân béo phì: BMI từ 30 trở lên
//Rất thừa cân béo phì: BMI từ 40 trở lên
//Công thức tính BMI: Cân nặng (kg) / (Chiều cao (cm) * Chiều cao (cm))

Console.Write("Hãy nhập cân nặng (kg): ");
double weight = double.Parse(Console.ReadLine());
Console.Write("Hãy nhập chiều cao (cm): ");
double height = double.Parse(Console.ReadLine());

double heightInMeters = height / 100; // Chuyển đổi chiều cao từ cm sang mét
double bmi = weight / (heightInMeters *heightInMeters); // Tính chỉ số BMI
Console.WriteLine("Chỉ số BMI của bạn là: {0}", bmi);
if (bmi <= 18.5)
{
    Console.WriteLine("Bạn quá gầy.");
}
else
{
    if (bmi >= 18.5 && bmi <= 24.5)
    {
        Console.WriteLine("Bạn đạt chuẩn");
    }
    else if (bmi >= 25 && bmi <= 29.9)
    {
        Console.WriteLine("Bạn thùa cân");
    }
    else if (bmi >=30 && bmi <= 40)
    {
        Console.WriteLine("Bạn quá thừa cân cần giảm cân ngay");
    }
}
Console.WriteLine();*/
/*// Lesson 18 - SwitchCaseStructure
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Nhập vào một số từ 1 đến 8:");

var day = Console.ReadLine();

switch (day)
{
    case "2":
        Console.WriteLine("Thứ hai");
        break;
    case "3":
        Console.WriteLine("Thứ ba");
        break;
    case "4":
        Console.WriteLine("Thứ tư");
        break;
    case "5":
        Console.WriteLine("Thứ năm");
        break;
    case "6":
        Console.WriteLine("Thứ sáu");
        break;
    case "7":
        Console.WriteLine("Thứ bảy");
        break;
    case "1":
    case "8":
        Console.WriteLine("Chủ nhật");
        break;
    default:
        Console.WriteLine("Không phải ngày trong tuần hợp lệ.");
        break;
}
*/
Console.Read();


