//Collection
using System.Collections;
//Collections.Generic;
//List<T>
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
numbers.Add(6);
Console.WriteLine(string.Join(", ", numbers));
//Dictionary<TKey, TValue>
Dictionary<string, int> studentScores= new Dictionary<string, int>
{
    { "Alice", 90 },
    { "Bob", 85 },
    { "Charlie", 92 }
};
Console.WriteLine(studentScores["Alice"]);

//Collections.Non-Generic;
//ArrayList
ArrayList list = new ArrayList() { 1, "Hello", true };
list.Add(3.14);
Console.WriteLine(string.Join(", ",list.Cast<object>()));
//Hastable
Hashtable students = new Hashtable()
{
    { "Alice", 20 },
    { "Bob", 22 },
    { "Charlie", 21 }
};
Console.WriteLine(students["Alice"]);

Console.Read();
