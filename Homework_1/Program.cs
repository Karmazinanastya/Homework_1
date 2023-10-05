using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Calculate the area and perimeter of a square
        Console.Write("Enter the side length of the square (a): ");
        int a = int.Parse(Console.ReadLine());
        int areaOfSquare = a * a;
        int perimeterOfSquare = 4 * a;
        Console.WriteLine($"Area of the square: {areaOfSquare}");
        Console.WriteLine($"Perimeter of the square: {perimeterOfSquare}");

        // Task 2: Get user's name and age
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write($"How old are you, {name}? ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your name is {name} and you are {age} years old.");

        // Task 3: Calculate length, area, and volume of a circle
        Console.Write("Enter the radius of the circle (r): ");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double lengthOfCircle = 2 * pi * r;
        double areaOfCircle = pi * r * r;
        double volumeOfCircle = (4 / 3) * pi * r * r * r;
        Console.WriteLine($"Length of the circle: {lengthOfCircle}");
        Console.WriteLine($"Area of the circle: {areaOfCircle}");
        Console.WriteLine($"Volume of the circle: {volumeOfCircle}");
        Console.Read();
    }
}
