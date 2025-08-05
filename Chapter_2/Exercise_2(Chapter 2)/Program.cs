//Bài tập 2: Viết phương trình giải phương trình
//bậc 2 (ax2 + bx +c = 0) với a,b,c nhập vào từ bàn phím.

using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập a (a khác 0): ");
int a = int.Parse(Console.ReadLine());
Console.Write("Nhập b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Nhập c: ");
int c = int.Parse(Console.ReadLine());
int delta = b * b - 4 * a * c;
if(delta == 0)
{
    Console.WriteLine("Phương trình có một nghiệm kép x=-b/2a = {0}", -b / (2 * a));
}
else
{
    if(delta < 0)
    {
        Console.WriteLine("Phương trình vô nghiệm.");
    }
    else
    {
        Console.WriteLine("Phương trình có hai nghiệm phân biệt x1 = {0} và x2 = {1}", 
            (-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a));
    }    
}
Console.Read();