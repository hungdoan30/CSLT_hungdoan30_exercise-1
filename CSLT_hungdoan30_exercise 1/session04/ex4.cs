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
            Bai3_KiemTraTamGiac();
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
            Console.WriteLine("--- BÀI 2: TÌM SỐ LỚN NHẤT ---");
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ ba: ");
            double c = double.Parse(Console.ReadLine());

            // Thuật toán: Giả sử 'a' là lớn nhất, sau đó lần lượt so sánh với 'b' và 'c'
            double max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
        }

        // =================================================================
        // BÀI 3: KIỂM TRA LOẠI TAM GIÁC
        // =================================================================
        static void Bai3_KiemTraTamGiac()
        {
            Console.WriteLine("--- BÀI 3: PHÂN LOẠI TAM GIÁC ---");
            Console.Write("Nhập chiều dài cạnh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều dài cạnh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều dài cạnh c: ");
            double c = double.Parse(Console.ReadLine());

            // Bước 1: Kiểm tra xem 3 cạnh có tạo thành một tam giác hợp lệ không
            // (Tổng 2 cạnh bất kỳ phải lớn hơn cạnh còn lại)
            if (a + b > c && a + c > b && b + c > a)
            {
                // Bước 2: Dùng if - else if để phân loại
                if (a == b && b == c)
                    Console.WriteLine("Đây là tam giác Đều (Equilateral).");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Đây là tam giác Cân (Isosceles).");
                else
                    Console.WriteLine("Đây là tam giác Thường (Scalene).");
            }
            else
            {
                Console.WriteLine("Lỗi: Ba cạnh nhập vào không thể tạo thành một tam giác.");
            }
        }

        // =================================================================
        // BÀI 4: XÁC ĐỊNH GÓC PHẦN TƯ (QUADRANT) TRÊN HỆ TỌA ĐỘ XY
        // =================================================================
        static void Bai4_XacDinhGocToaDo()
        {
            Console.WriteLine("--- BÀI 4: XÁC ĐỊNH GÓC TỌA ĐỘ ---");
            Console.Write("Input the value for X coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            // Áp dụng chính xác logic từ biểu đồ luồng (Flowchart) trong ảnh
            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");

            // Xử lý thêm các trường hợp đặc biệt (nằm trên trục hoặc tại gốc tọa độ)
            else if (x == 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            else if (x == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
            else
            {

            }
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
        }
    }
}


