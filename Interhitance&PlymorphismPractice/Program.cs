
Vehivcle vehicle = new Vehivcle();
Vehivcle myCar = new Car();
Vehivcle myBike = new Bike();

vehicle.Move(); // Output: Vehicle is moving
myCar.Move(); // Output: Car is driving
myBike.Move(); // Output: Bike is riding

class Vehivcle
{
    public virtual void Move()
    {
        Console.WriteLine("Vehicle is moving");
    }
}

class Car : Vehivcle
{
    public override void Move()
    {
        Console.WriteLine("Car is driving");
    }
}
class Bike : Vehivcle
{
    public override void Move()
    {
        Console.WriteLine("Bike is riding");
    }
}