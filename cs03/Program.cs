class Program 
{
    static void Main(string[] args)
    {
        int a = 6;
        int b = 6;
        Console.WriteLine("a + b = {0}",a + b);
        Console.WriteLine("a - b = {0}",a - b);
        Console.WriteLine("a * b = {0}",a * b);
        Console.WriteLine("a / b = {0}",a / b);
        Console.WriteLine("a % b = {0}",a % b);
        // do uu tien ve toan hoc
        int kq = a + b * 2;
        Console.WriteLine(kq);
    }
}