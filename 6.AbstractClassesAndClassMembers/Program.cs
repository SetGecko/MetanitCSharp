Transport car = new Car();
Transport ship = new Ship();
Transport aircraft = new Aircraft();

car.Move();         // машина едет
ship.Move();        // корабль плывет
aircraft.Move();    // самолет летит

abstract class Transport
{
    public abstract void Move();
}
// класс корабля
class Ship : Transport
{
    // мы должны реализовать все абстрактные методы и свойства базового класса
    public override void Move()
    {
        Console.WriteLine("Корабль плывет");
    }
}
// класс самолета
class Aircraft : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самолет летит");
    }
}
// класс машины
class Car : Transport
{
    public override void Move()
    {
        Console.WriteLine("Машина едет");
    }
}