using Homework9.Domain;
using Homework9.Extensions;

var cb1 = new CheckBox("checkBox1", 4, 4, 121, 21) { Checked = true };
var tb1 = new TextBox("textBox1", 4, 29, 121, 21) { Text = "Some text" };

OutInfo("до клонирования", cb1);
OutInfo("до клонирования", tb1);
OutInfo("после клонирования", cb1.Copy().DoWithSelf(c => c.Name = "checkBox2"));
OutInfo("после клонирования", tb1.Copy().DoWithSelf(c => c.Name = "textBox2"));

Console.ReadKey();

static void OutInfo(string caption, Component component)
{
	Console.WriteLine(component.GetType().Name + " " + caption);
	Console.WriteLine("    " + component);
}
