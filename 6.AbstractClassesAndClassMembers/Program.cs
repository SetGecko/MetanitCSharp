abstract class Transport
{
    // абстрактное свойство для хранения скорости
    public abstract int Speed { get; set; }
}
// класс корабля
class Ship : Transport
{
    int speed;
    public override int Speed
    {
        get => speed;
        set => speed = value;
    }
}

class Aircraft : Transport
{
    public override int Speed { get; set; }
}