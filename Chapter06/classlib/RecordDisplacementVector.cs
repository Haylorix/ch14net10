namespace Packt.Shared;

public record struct RecordDisplacementVector
{
    public int X { get; set; }
    public int Y { get; set; }

    public RecordDisplacementVector(int initialX, int initialY)
    {
        X = initialX;
        Y = initialY;
    }

    public static RecordDisplacementVector operator +(
      RecordDisplacementVector vector1,
      RecordDisplacementVector vector2)
    {
        return new(
          vector1.X + vector2.X,
          vector1.Y + vector2.Y);
    }

    public static RecordDisplacementVector operator -(
      RecordDisplacementVector vector1,
      RecordDisplacementVector vector2)
    {
        return new(
          vector1.X - vector2.X,
          vector1.Y - vector2.Y);
    }
}