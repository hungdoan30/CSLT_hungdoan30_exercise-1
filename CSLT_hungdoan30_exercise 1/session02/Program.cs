namespace CSLT_hungdoan30_exercise_1.session2;

class Program
{
    static void Main1(string[] args)
    {
        // 1. to Add / Sum Two Numbers.

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("The sum of the two numbers is: " + sum);

        // 2.to Swap Values of Two Variables.

        Console.Write("Enter the value of variable A: ");
        string a = Console.ReadLine();
        Console.Write("Enter the value of variable B: ");
        string b = Console.ReadLine();

        Console.WriteLine($"Before swapping: A = {a}, B = {b}");
        string temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swapping: A = {a}, B = {b}");

        // 3.to Multiply two Floating Point Numbers

        Console.Write("Enter the first floating point number: ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Enter the second floating point number: ");
        float d = float.Parse(Console.ReadLine());

        float product = c * d;
        Console.WriteLine($"The product of the two numbers is: {product}");

        // 4.to convert feet to meter

        Console.Write("Enter the length in feet: ");
        double feet = double.Parse(Console.ReadLine());
        double meters = feet * 0.3048;
        Console.WriteLine($"The length in meters is: {meters}");

        // 5.to convert Celsius to Fahrenheit and vice versa

        Console.Write("Enter Celsius degree: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}");

        // vice versa

        Console.Write("Enter Fahrenheit degree: ");
        double fahrenheitdegree = double.Parse(Console.ReadLine());
        double celsiusdegree = (fahrenheitdegree - 32) * 5 / 9;
        Console.WriteLine($"The temperature in Celsius is: {celsiusdegree}");

        // 6.to find the Size of data types
        Console.WriteLine("int = " + sizeof(int));
        Console.WriteLine("float = " + sizeof(float));
        Console.WriteLine("double = " + sizeof(double));
        Console.WriteLine("char = " + sizeof(char));
        Console.WriteLine("bool = " + sizeof(bool));
        // 7.to Print ASCII Value(tip: read character, print number of this char)

        Console.WriteLine("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;

        Console.WriteLine();
        Console.WriteLine("ASCII = " + (int)ch);

        // 8.to Calculate Area of Circle
        Console.Write("Radius: ");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;

        Console.WriteLine($"Area of circle= {area}");

        // 9.to Calculate Area of Square
        Console.Write("Enter the side of the square: ");
        double side = double.Parse(Console.ReadLine());

        double areasquare = side * side;
        Console.WriteLine($"Area of square= {areasquare}");

        // 10.to convert days to years, weeks and days
        Console.Write("Enter daysnumber: ");
        int totaldays = int.Parse(Console.ReadLine());
        int years = totaldays / 365;
        int remainingdays = totaldays % 365;
        int weeks = remainingdays / 7;
        int days = remainingdays % 7;
        Console.WriteLine($"total days is {years} years, {weeks} weeks, and {days} days");
    }
}
