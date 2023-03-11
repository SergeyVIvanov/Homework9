using System.Text.Json;

namespace Homework9.Domain;

public class Component
{
	public string Name { get; set; }

	public Component(string name)
	{
		Name = name;
	}

	public override string ToString()
	{
		return JsonSerializer.Serialize(this, GetType());
	}
}
