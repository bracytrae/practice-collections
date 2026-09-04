using System;

class Program
{
    static void Main()
    {
        // controls if the calculator can continue running 
        bool running = true;

        // repeats the program while running is true 
        while (running)
        {
            // asks the user to enter the radius of a circle
            Console.Write("Radius: ");

            // reads the user's input and converts it into a number
            double radius = Convert.ToDouble(Console.ReadLine());

            // calculates the area of the circle using: area = π * radius².
            double area = 3.14 * radius * radius;

            // prints the calculated area
            Console.WriteLine($"The area is {area}");
            Console.WriteLine();

            // asks the user if they wish to calculate another circle
            Console.Write("Calculate again? (y/n): ");

            // store the user's response
            string answer = Console.ReadLine();

            // if the user does not enter "y", it stops the loop
            if (answer != "y")
            {
                running = false;
            }

            // adds an empty line to make the console easier to read
            Console.WriteLine();
        }
    }
}