using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session04
{
    internal class giai_pt_bac_2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Giải phương trình bậc 2: ax^2 + bx + c = 0");

            Console.Write("Nhập hệ số a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            float c = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm. ");
                    }
                    else
                    {
                        Console.WriteLine(" Phương trình vô nghiệm. ");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Nghiệm của phương trình là: x = {x}");
                }


            }
            else
            { float delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double xkep = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {xkep}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }

        }
    }
}