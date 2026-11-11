

using System.Transactions;

namespace Shape_AA;

public class Shape
{
    #region Properties
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area { get; }

    #endregion
}
public class Rectangle : Shape
{
    #region Properties
    public new double Area
    {
        get { return Height * Width; }
    }
    #endregion
}
public class Square : Shape
{
    #region Properties
    public new double Area
    {
        get { return Height * Height; }
    }
    #endregion
    #region Constractors
    public Square()
    {
        Height = 0;
        Width = 0;
    }
    public Square(double height)
    {
        Height = height;
        Width = Height;
    }
    #endregion
}
public class Triangle : Shape
{
    #region Properties
    public new double Area
    {
        get { return Height * Width / 2; }
    }
    #endregion
}
public class Circle : Shape
{
    #region Properties
    public double radios;
    public new double Area
    {
        get { return Math.PI * Math.Pow(radios, 2); }
    }
    #endregion
    #region Constarctors
    public Circle(double radios = 0)
    {
        this.radios = radios;
        Height = radios * 2;
        Width = radios * 2;
    }
    #endregion
}