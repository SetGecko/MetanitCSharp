var rectanle = new Rectangle { Width = 20, Height = 20 };
var circle = new Circle { Radius = 200 };
PrintShape(rectanle); // Perimeter: 80   Area: 400
PrintShape(circle); // Perimeter: 1256  Area: 125600

void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}  Area: {shape.GetArea()}");
}

// абстрактный класс фигуры
abstract class Shape
{
    // абстрактный метод для получения периметра
    public abstract double GetPerimeter();
    // абстрактный метод для получения площади
    public abstract double GetArea();
}
// производный класс прямоугольника
class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }

    // переопределение получения периметра
    public override double GetPerimeter() => Width * 2 + Height * 2;
    // переопрелеление получения площади
    public override double GetArea() => Width * Height;
}
// производный класс окружности
class Circle : Shape
{
    public double Radius { get; set; }

    // переопределение получения периметра
    public override double GetPerimeter() => Radius * 2 * 3.14;
    // переопрелеление получения площади
    public override double GetArea() => Radius * Radius * 3.14;
}
