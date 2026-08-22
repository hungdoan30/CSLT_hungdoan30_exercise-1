using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session03
{
    internal class session3
    {
        // 1. convert celsius to fahrenheit and kelvin
        public static void Main2(string[] args)
        {
            Console.Write("Enter Celsius degree: ");
            double celsius = double.Parse(Console.ReadLine());
            int fahrenheit = (int)Math.Round(celsius * 18/10) + 32;
            double kelvin = celsius + 273;


            Console.WriteLine("kelvin = " + kelvin);
            Console.WriteLine("fahrenheit = " + fahrenheit);



        // 2. calculate the surface and volume of a sphere, given its radius

            Console.Write("Radius: ");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volume = (4/3) * Math.PI * r * r * r;

            Console.WriteLine($"surface = {surface}");
            Console.WriteLine($"volume = {volume}");


        // 3. calculates the result of adding, subtracting,
        // multiplying and dividing two numbers entered by the user

            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + "+" + b + "=" + (a+b));
            Console.WriteLine(a + "-" + b + "=" + (a-b));
            Console.WriteLine(a + "*" + b + "=" + (a*b));
            Console.WriteLine(a + "/" + b + "=" + (a/b));
            Console.WriteLine(a + "%" + b + "=" + (a%b));
        }

    }
}
