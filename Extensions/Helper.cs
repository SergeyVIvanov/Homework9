namespace Homework9.Extensions;

public static class Helper
{
	public static T DoWithSelf<T>(this T component, Action<T> action)
	{
		action(component);
		return component;
	}
}
