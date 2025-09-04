using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("BÀI 1 trang 9:");
        RunBai19();

        Console.WriteLine("\nBÀI 2 trang 9:");
        RunBai29();

        Console.WriteLine("\nBÀI 3 trang 9:");
        RunBai39();

        Console.WriteLine("\nBÀI 4 trang 9:");
        RunBai49();

        Console.WriteLine("\nBÀI 5 trang 9:");
        RunBai59();

        Console.WriteLine("\nBÀI 1 trang 22:");
        RunBai122();

        Console.WriteLine("\nBÀI 2 trang 22:");
        RunBai222();

        Console.WriteLine("\nBÀI 3 trang 22:");
        RunBai322();

        Console.WriteLine("\nBÀI 4 trang 22:");
        RunBai422();

        Console.WriteLine("\nBÀI 5 trang 22:");
        RunBai522();

        Console.WriteLine("\nBÀI 6 trang 22:");
        RunBai622();

        Console.WriteLine("\nBÀI 7 trang 22:");
        RunBai722();

        Console.WriteLine("\nBÀI 8 trang 22:");
        RunBai822();

        Console.WriteLine("\nChương trình đã chạy xong 13 bài!");
    }
    //TRANG09
    //BAI01
    static void RunBai19()
    {
        Console.Write("Nhập số thứ nhất: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập phép toán (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result = 0;
        bool valid = true;

        switch (op)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/':
                if (b != 0) result = a / b;
                else { Console.WriteLine("Không thể chia cho 0!"); valid = false; }
                break;
            default: Console.WriteLine("Phép toán không hợp lệ."); valid = false; break;
        }

        if (valid) Console.WriteLine($"Kết quả: {a} {op} {b} = {result}");
    }

    //BAI02
    static void RunBai29()
    {
        Console.WriteLine("y\t|\tx");
        Console.WriteLine("------------------");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"{y}\t|\t{x}");
        }
    }

    //BAI03
    static void RunBai39()
    {
        Console.Write("Nhập quãng đường (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập giờ: ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập phút: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập giây: ");
        int s = Convert.ToInt32(Console.ReadLine());

        double timeInHours = h + (m / 60.0) + (s / 3600.0);
        double speedKmh = distance / timeInHours;
        double speedMph = speedKmh / 1.609;

        Console.WriteLine($"Vận tốc: {speedKmh:F2} km/h | {speedMph:F2} miles/h");
    }

    //BAI04
    static void RunBai49()
    {
        Console.Write("Nhập bán kính hình cầu: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        Console.WriteLine($"Diện tích mặt cầu = {surface:F2}");
        Console.WriteLine($"Thể tích hình cầu = {volume:F2}");
    }

    //BAI05
    static void RunBai59()
    {
        Console.Write("Nhập một ký tự: ");
        char ch = Convert.ToChar(Console.ReadLine().ToLower());

        if ("aeiou".IndexOf(ch) >= 0)
            Console.WriteLine("Đây là nguyên âm.");
        else if (char.IsDigit(ch))
            Console.WriteLine("Đây là chữ số.");
        else
            Console.WriteLine("Đây là ký tự khác.");
    }
    //TRANG22
    //BAI01
    static void RunBai122()
    {
        Console.Write("Nhập cạnh a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập cạnh b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập cạnh c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Tam giác đều (Equilateral).");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Tam giác cân (Isosceles).");
        else
            Console.WriteLine("Tam giác thường (Scalene).");
    }

    //BAI02
    static void RunBai222()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nhập số thứ {i}: ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        double avg = sum / 10.0;
        Console.WriteLine($"Tổng = {sum}, Trung bình = {avg}");
    }

    //BAI03
    static void RunBai322()
    {
        Console.Write("Nhập số nguyên: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }

    //BAI04
    static void RunBai422()
    {
        Console.Write("Nhập số dòng: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }
    }

    //BAI05
    static void RunBai522()
    {
        Console.WriteLine("Pattern 1:");
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        Console.WriteLine("\nPattern 2:");
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write($"{num++} ");
            Console.WriteLine();
        }

        Console.WriteLine("\nPattern 3:");
        num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write($"{num++} ");
            Console.WriteLine();
        }
    }

    //BAI06
    static void RunBai622()
    {
        Console.Write("Nhập n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = 0.0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
            Console.Write($"1/{i} ");
        }
        Console.WriteLine($"\nTổng của {n} số hạng = {sum:F4}");
    }

    //BAI07
    static void RunBai722()
    {
        Console.Write("Nhập giới hạn trên: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Các số hoàn hảo <= {limit}:");

        for (int num = 2; num <= limit; num++)
        {
            int sum = 1;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) sum += i;
            }
            if (sum == num) Console.WriteLine(num);
        }
    }

    //BAI08
    static void RunBai822()
    {
        Console.Write("Nhập số cần kiểm tra: ");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) { isPrime = false; break; }
        }
        Console.WriteLine(isPrime ? "Số nguyên tố." : "Không phải số nguyên tố.");
    }
}

