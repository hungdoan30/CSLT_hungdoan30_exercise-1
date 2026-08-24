using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session04
{
    internal class ss4
    {
        public static void Main1(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            //Bai4();
            Bai5();

        }

        // 1. Write a C# Sharp program that takes two numbers as input and
        // performs an operation(+,-,*, x,/) on them and displays the result of that
        // operation.
        static void Bai1()
        {
            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, x, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (op == '+')
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            else if (op == '-')
                Console.WriteLine(a + " - " + b + " = " + (a - b));
            else if (op == '*' || op == 'x' || op == 'X')
                Console.WriteLine(a + " x " + b + " = " + (a * b));
            else if (op == '/')
            {
                if (b != 0)
                    Console.WriteLine(a + " / " + b + " = " + (a / b));
                else
                    Console.WriteLine("Cannot divide by zero.");
            }
            else
                Console.WriteLine("Invalid operator.");


        }

        // 2. Write a C# Sharp program to display certain values of the function x = y2
        // + 2y + 1 (using integer numbers for y, ranging from -5 to +5).

        static void Bai2()
        {
        
                for (int y = -5; y <= 5; y++)
                {
                    int x = y * y + 2 * y + 1;
                    Console.WriteLine("y = " + y + ", x = " + x);
                }
            
        }

        // 3. Write a C# Sharp program that takes distance and time (hours, minutes,
        // seconds) as input and displays speed in kilometers per hour(km / h) and
        // miles per hour(miles/h).
        
        static void Bai3()
        {
            Console.Write("Nhap khoang cach (Don vi: km): ");
            float distance = float.Parse(Console.ReadLine());

            Console.Write("Nhap thoi gian - gio: ");
            float hours = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian - phut: ");
            float minutes = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian - giay: ");
            float seconds = float.Parse(Console.ReadLine());

            
            float totalHours = hours + (minutes / 60f) + (seconds / 3600f);

            
            float kmPerHour = distance / totalHours;
            float milesPerHour = distance/ 1.609f / totalHours;

            Console.WriteLine($"Van toc: {kmPerHour} km/h");
            Console.WriteLine($"Van toc: {milesPerHour} miles/h");
        }

        // 4. Write a C# Sharp program that takes the radius of a sphere as input and
        // calculates and displays the surface and volume of the sphere.V = 4/3*π*r^3

        static void Bai4()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * radius * radius;
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
            Console.WriteLine($"Dien tich hinh cau: {surface}");
            Console.WriteLine($"The tich hinh cau: {volume}");
        }

        // 5. Write a C# Sharp program that takes a character as input and checks if it
        // is a vowel, a digit, or any other symbol.
        
        static void Bai5()

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một ký tự: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            char c = char.ToLower(ch);

            if (char.IsDigit(ch))
            {
                Console.WriteLine("Đây là một chữ số.");
            }
            else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("Đây là một nguyên âm.");
            }
            else if (char.IsLetter(ch))
            {
                Console.WriteLine("Đây là một phụ âm.");
            }
            else
            {
                Console.WriteLine("Đây là một ký tự khác.");
            }
        }

    }
}