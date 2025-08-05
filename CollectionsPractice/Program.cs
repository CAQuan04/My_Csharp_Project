
using System.Collections;
using System.Diagnostics;

Console.WriteLine("Practice 1");

//Bài 1
List<string> students = new List<string>() { "Alice", "Bob", "Charlie" };
students.Add("David");
Console.WriteLine(string.Join(", ", students));

students.Remove("Bob");
Console.WriteLine("List sudents after removing Bob:");
Console.WriteLine(string.Join(", ", students));

string searchName = "Charlie";
if (students.Contains(searchName))
{
    Console.WriteLine($"Found name:{searchName}");
}
else
{
    Console.WriteLine($"Name {searchName} not found in the list.");
}
    Console.WriteLine();
    Console.WriteLine("Practice 2");

//Bài 2
Dictionary<string, int> studentScores = new Dictionary<string, int>()
{
    { "Alice", 9 },
    { "Bob", 8 },
    { "Charlie", 7 },
    { "Daivd", 5 }
};
Console.WriteLine("List stdents have mark greater than 8");
foreach (var student in studentScores)
{
    if(student.Value > 8)
    {
        Console.WriteLine($"{student.Key} has score: {student.Value}");
    }
}

Console.WriteLine();
Console.WriteLine("Practice 3");

// Bài 3
const int itemCount = 10000000;

ArrayList arrayList = new ArrayList();
for (int i = 0; i < itemCount; i++)
{
    arrayList.Add(i);
}

List<int> List = new List<int>();
for (int i = 0; i < itemCount; i++)
{
    List.Add(i);
}

Stopwatch stopwatch = Stopwatch.StartNew();
foreach (int i in arrayList)
{
    int value = (int)i;
}
stopwatch.Stop();
Console.WriteLine($"Time spend: {stopwatch.ElapsedMilliseconds}");

stopwatch.Restart();
foreach (int i in List)
{
    int value = i; 
}
stopwatch.Stop();
Console.WriteLine($"Time spend: {stopwatch.ElapsedMilliseconds}");
