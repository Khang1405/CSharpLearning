using myLib;
namespace CS23
{
    // Xay dung lop tinh
    // tro thanh 1 phuong thuc mo rong bang cach them this
    static class ABC
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
    }
    class Program
    {
           static void Main(string[] args)
        {
            int [] mang = {3,4,6,1,7};
            int max = mang.Max();
            Console.WriteLine(max);
            string s = "KhangHC123";
            s.Print(ConsoleColor.Red);
            double a = 5;
            Console.WriteLine(a.BinhPhuong());
            Console.WriteLine(a.CanBacHai());
            Console.WriteLine(a.Sin());
            Console.WriteLine(a.Cos());

        }
    }
}