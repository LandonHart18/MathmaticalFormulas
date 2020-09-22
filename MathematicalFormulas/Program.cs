using System;

namespace MathematicalFormulas
{
	class Program
	{
        static void Main()
        {
            try
            {
                // Part 1
                // Partially worked example
                Console.WriteLine("\nPart 1, circumference and area of a circle.");
                Console.Write("Enter an integer for the radius: ");
                string strradius = Console.ReadLine();
                int intradius = int.Parse(strradius);
                double circumference = checked(2 * Math.PI * intradius);
                Console.WriteLine($"The circumference is {circumference}");

                // Implementation for area here

                double area = checked(Math.PI * Math.Sqrt(intradius));
                Console.WriteLine($"The area is {area}");

                // Part 2
                Console.WriteLine("\nPart 2, volume of a hemisphere.");

                // Implementation here
                double volume = checked((4 / 3 * Math.PI * Math.Pow(intradius, 3)) / 2);
                Console.WriteLine($"The volume is {volume}");

                // Part 3
                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

                // Implementation here (Reference stackoverflow.com Tamir Nakar)
                double p, tarea;
                int a, b, c;

                Console.WriteLine("Enter side #1");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side #2");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side #3");
                c = int.Parse(Console.ReadLine());

                p = (a + b + c) / 2;
                tarea = checked(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

                Console.WriteLine($"The triangle's area is {tarea}");
                Quadraticequation();
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx);
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine(oEx);
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                Console.WriteLine("This program has finally terminated.");
            }

        }
		// Part 4 
		static void Quadraticequation()
        {
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            // Implementation here (Reference w3resource.com)

            int a, b, c;

            double d, x1, x2;
            Console.WriteLine("Input value of a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input value of b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input value of c:");
            c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("Both roots are equal.\n");
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("First Root Root1 = {0}\n", x1);
                Console.WriteLine("First Root Root2 = {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real and diff -2\n");
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("First Root Root1 = {0}\n", x1);
                Console.WriteLine("First Root Root2 = {0}\n", x2);
            }
            else
                Console.WriteLine("Root are imaginary; \nNo Solution. \n\n");
        }

	}
}
