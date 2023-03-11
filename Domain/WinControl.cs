namespace Homework9.Domain;

public class WinControl : Control
{
    private static int _lastHandle;

	public int Handle { get; init; }

	public WinControl(string name, int x, int y, int width, int height) : base(name, x, y, width, height)
	{
		Handle = ++_lastHandle;
	}
}
