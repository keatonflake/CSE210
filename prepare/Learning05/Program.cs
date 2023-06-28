using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square(10, "blue");
        Console.WriteLine(square.GetArea());
    }
}

class Shape
{

public Shape(string color)
{
    _color = color;
}
 string _color;

 public string GetColor()
 {
    return _color;
 }

 public void SetColor(string color)
 {
    _color = color;
 }

 public virtual double GetArea()
 {
    return 0;
 }
}

class Square : Shape
{
    double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea(){
        return Math.Pow(_side, 2);
    }
}

class Rectangle : Shape
{
    public Rectangle(double width, double height, string color) : base(color)
    {
        _width = width;
        _height = height;
    }

    double _width;
    double _height;

    public override double GetArea(){
        return _width * _height;
    }
}

class Circle : Shape
{
    public Circle(double radius, string shape) : base (shape) 
    {
        _radius = radius;
    }

    double _radius;

     public override double GetArea(){
        return Math.PI * (Math.Pow(_radius, 2));
    }
    
}