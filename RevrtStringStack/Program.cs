static string ReverseString(string value)
{
    //h,e,l,l,o
    Stack<char> chars = new Stack<char>();
    foreach (char c in value)
    {
        chars.Push(c); // Push each character onto the stack
    }
    string reversed = string.Empty;
    while (chars.Count > 0)
    {
        reversed += chars.Pop(); // Pop each character from the stack to form the reversed string
    }
    return reversed;

}
Console.WriteLine("Input string:");
string input = Console.ReadLine();
string result = ReverseString(input);
Console.WriteLine($"Result: {result}"); 
