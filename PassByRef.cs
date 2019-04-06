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
		// passing in the reference, now both are 21
		i = i + 1;
		Console.WriteLine("i is: " + i);
	}
}
