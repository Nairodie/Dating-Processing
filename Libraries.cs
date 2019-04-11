using System;
					
public class Program
{
	public static void Main()
	{
		string name;
		name = readString("Enter your name: ");
		
		int age;
		age = readInt("Enter your age: ", 0 , 100);
	}
	
	static string readString(string prompt)
	{
		string result;
		do
		{
			Console.WriteLine(prompt);
			result = Console.ReadLine();
		}
		while (result == string.Empty);
		return result;
	}
	
	static int readInt(string prompt, int low, int high)
	{
		int result;
		do
		{
			string intString = readString(prompt);
			result = int.Parse(intString);			
		}
		while ((result < low) || (result > high));
		
		return result;
	}
}
