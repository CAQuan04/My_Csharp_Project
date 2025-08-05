//Bài tập 1: Viết chương trình giải phương trình bậc nhất (ax+b=0)
//với a,b nhập vào từ bàn phím.
using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Nhập b: ");
int b = int.Parse(Console.ReadLine());

if(a!=0)
{
    Console.WriteLine("Phương trình có nghiệm x =-b/a {0}", (-b/a));
}
else
{
    if(a==0 && b != 0)
    {
       Console.WriteLine("Phương trình vô nghiệm."); 
    }
    else if(a==0)
    {
        Console.WriteLine("Phương trình vô số nghiệm.");    
    }
}

    Console.Read();