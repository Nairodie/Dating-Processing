using System;

public class Program
{
    public static void Main()
    {
        double width, height, woodLength, glassArea;
        const double Max_Width = 5.0;
        const double Min_Width = 0.5;
        const double Max_Height = 3.0;
        const double Min_Height = 0.75;

        string widthString;
        string heightString;
        
        do
        {
            Console.Write("Give the width of the window between " + Min_Width + " and " + Max_Width + " :");

            widthString = Console.ReadLine();
            width = double.Parse(widthString);
        }
        while (width < Min_Width || width > Max_Width);

        do
        {
            Console.Write("Give the height of the window between " + Min_Height + " and " + Max_Height + " :");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);
        }
        while (height < Min_Height || height > Max_Height);

        woodLength = 2 * (width + height);
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + "  feet");

        Console.WriteLine("The area of the glass is " + glassArea + " square metres");

    }
}
