Transport tesla = new Auto();
tesla.Move();           // легковая машина едет
abstract class Transport
{
    public abstract void Move();
}
// класс машины
abstract class Car : Transport { }

class Auto : Car
{
    public override void Move()
    {
        Console.WriteLine("легковая машина едет");
    }
}