using System;
					
public class Program
{
	public static void Main()
	{
		int x = 20;
		addOneToRef(ref x);
		Console.WriteLine("x is: " + x);
	}
	
	static void addOneToRef (ref int i)
	{
		i = i + 1;
		Console.WriteLine("i is: " + i);
	}
}
