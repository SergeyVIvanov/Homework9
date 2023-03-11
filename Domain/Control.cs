namespace Homework9.Domain;

public class Control : Component
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Control(string name, int x, int y, int width, int height) : base(name)
    {
        (X, Y, Width, Height) = (x, y, width, height);
    }
}
