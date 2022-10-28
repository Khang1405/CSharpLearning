
class CS02
{
    static void Main(string[] args)
    {
        const string ten  = "Khang";
        string hoVaTen;
        Console.Clear();
        Console.ForegroundColor  = ConsoleColor.Blue;
        Console.BackgroundColor  = ConsoleColor.Green;
        Console.WriteLine("Ten toi la Khang");
        int a;
        a = 1000;
        Console.WriteLine(a);
        Console.Title = "Vi du su dung Console";
        Console.ResetColor();
        Console.WriteLine("Ten toi la Khang 1123");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(a);
        hoVaTen  = Console.ReadLine();
        Console.WriteLine("Xin chao {0}",hoVaTen);
        float n1, n2;
        string so;
        Console.WriteLine("Nhap tham so a: ");
        so = Console.ReadLine();
        n1 = float.Parse(so);
        
        Console.WriteLine("Nhap tham so b:" );
        so = Console.ReadLine();
        n2 = float.Parse(so);
        
        Console.WriteLine("So thu nhat = {0} So thu hai = {1}",n1,n2);
        Console.WriteLine("So thu nhat = "+ n1 +" So thu 2 = " +n2);        
        Console.WriteLine(ten);

    }
}