using System;
					
public class Program
{
	public static void Main()
	{
		int x = 20;
		addOneToParam(x);
		Console.WriteLine("x is: " + x);
	}
	
	static void addOneToParam (int i)
		{
			i = i + 1;
			Console.WriteLine("i is: " + i);
		}
}
