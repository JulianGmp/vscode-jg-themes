// The formatting in this file is intetionally garbage so I could take the screenshots more easily

using System;
using System.Text;

namespace TestProject
{
class Program
{

#region Properties

public int Value { get; protected set; }
public string Text { get; set; }

#endregion

// I'm a single-line comment!

/*
 * I'm a multi-line comment!
 */

/// <summary>
/// I'm a documentation comment!
/// Repeats a string a certain amount of times.
/// <para> Uses <see cref="System.Text.StringBuilder"/> to append strings. </para>
/// </summary>
/// <param name="str">String to be repeated</param>
/// <param name="amount">Amount of times str is repeated</param>
/// <returns>Output string</returns>
public static string RepeatString(String str, ushort amount)
{
	if (String.IsNullOrEmpty(str))
	{
		return String.Empty;
	}
	else
	{
		var builder = new StringBuilder();
		for (int i = 0; i < amount; i++)
		{
			builder.Append(str);
		}
		return builder.ToString();
	}
}





public static void Main(string[] args)
{
	Console.WriteLine("Hello World!");
}

}
}
