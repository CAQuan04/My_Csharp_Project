
//Inheritance    
var child = new Child();
child.Name = "John";
child.Display(); // Calls the method from the Parent class
child.ShowMessage(); // Calls the method from the Child class

Caculartor caculartor = new Caculartor();
Console.WriteLine(caculartor.Add(5, 10)); // Calls the int version
Console.WriteLine(caculartor.Add(5.5, 10.5)); // Calls the double version

Animal myDog = new Dog();
myDog.Speak(); // Calls the overridden method in Dog class
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

// Polymorphism
// Method Overloading
class Caculartor
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}

// Method Overriding
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}