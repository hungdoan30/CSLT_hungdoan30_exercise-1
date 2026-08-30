using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session04
{
    internal class ex4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1_sochanle();
            Bai2_Timsolonnhat();
            Bai3_Kiemtratamgiac();
            Bai4_XacDinhGocToaDo();
        }

        // BÀI 1: KIỂM TRA SỐ CHẴN LẺ

        static void Bai1_sochanle()
        {
            Console.Write("Nhập một số nguyên: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n % 2 == 0)
                    Console.WriteLine($"{n} là số chẵn.");
                else
                    Console.WriteLine($"{n} là số lẻ.");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
            }
        }

       
        // BÀI 2: TÌM SỐ LỚN NHẤT TRONG 3 SỐ
  
        static void Bai2_Timsolonnhat()
        {
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ ba: ");
            double c = double.Parse(Console.ReadLine());

            double max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
        }

        // BÀI 3: KIỂM TRA LOẠI TAM GIÁC
        static void Bai3_Kiemtratamgiac()
        {
            Console.Write("Nhập chiều dài cạnh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều dài cạnh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều dài cạnh c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Đây là tam giác đều.");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Đây là tam giác cân.");
                else
                    Console.WriteLine("Đây là tam giác thường.");
            }
            else
            {
                Console.WriteLine("Lỗi, ba cạnh nhập vào không thể tạo thành một tam giác.");
            }
        }

        // BÀI 4: XÁC ĐỊNH GÓC PHẦN TƯ TRÊN HỆ TỌA ĐỘ XY
        static void Bai4_XacDinhGocToaDo()
        {
            Console.Write("Nhập tọa độ x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập tọa độ y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ nhất.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ hai.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ ba.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ tư.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm tại gốc tọa độ.");
            else if (x == 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm trên trục Y.");
            else
            {
                Console.WriteLine($"Tọa độ ({x},{y}) nằm trên trục X.");
            }
            
        }
    }
}


