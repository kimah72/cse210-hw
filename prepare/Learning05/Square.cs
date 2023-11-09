using System;

public class Square : Shape
{
    private double _side; // attribute

    public Square(string color, double side) : base (color) // set side
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}