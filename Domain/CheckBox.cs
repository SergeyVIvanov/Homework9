using Homework9.Contracts;

namespace Homework9.Domain;

public class CheckBox : WinControl, IMyCloneable<CheckBox>, ICloneable
{
    public bool Checked { get; set; }

    public CheckBox(string name, int x, int y, int width, int height) : base(name, x, y, width, height)
    {
    }

	public CheckBox Copy()
	{
		return new CheckBox(string.Empty, X, Y, Width, Height) { Checked = Checked };
	}

	public object Clone() => Copy();
}
