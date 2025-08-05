
var child = new Child();
child.Name = "John";
child.Display(); // Calls the method from the Parent class
child.ShowMessage(); // Calls the method from the Child class
class Parent
{
    public string Name { get; set; }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Child: Parent
{
    public void ShowMessage()
    {
        Console.WriteLine("This is a child class");
    }
}

