using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color) // set color
    {
        _color = color;
    }

    public string GetColor() => _color; // get color arrow function method

    // by making the method abstract, it is an emptry virtual function
    public abstract double GetArea();
}