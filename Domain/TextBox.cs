using Homework9.Contracts;

namespace Homework9.Domain;

public class TextBox : WinControl, IMyCloneable<TextBox>, ICloneable
{
    public string Text { get; set; } = string.Empty;

    public TextBox(string name, int x, int y, int width, int height) : base(name, x, y, width, height)
    {
    }

	public TextBox Copy()
	{
		return new TextBox(string.Empty, X, Y, Width, Height) { Text = Text };
	}

	public object Clone() => Copy();
}
