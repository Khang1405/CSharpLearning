class Program
{
    static void Main(string[] args)
    {
        int a = 6;
        switch (a)
        {
            case(1):
                Console.WriteLine("So a la so mot");
            break;
            case(2):
                Console.WriteLine("So a la so hai");
            break;
            case(3):
                Console.WriteLine("So a la so ba");
            break;
            case(4):
                Console.WriteLine("So a la so bon");
            break;
            default:
                Console.WriteLine("Hay thu so khac");
            break;
                
        }
        int c,d;
        Console.Write("Nhap vao so c: ");
        c = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so d: ");
        d = int.Parse(Console.ReadLine());
        Console.WriteLine("Hay chon lenh");
        Console.WriteLine("1, Tinh tong");
        Console.WriteLine("2, Tinh hieu");
        Console.WriteLine("3, Tinh tich");
        Console.WriteLine("4, Tinh thuong");

        char e ;
        e = Console.ReadKey().KeyChar;
        
        Console.WriteLine();
        switch(e)
        {
            case '1':
                Console.WriteLine("Tong la {0}", c + d );
            break;
            case '2':
                Console.WriteLine("Hieu la {0}", c - d );
            break;
            case '3':
                Console.WriteLine("Tich la {0}", c * d );
            break;
            case '4':
                Console.WriteLine("Thuong la {0}", c / d );
            break;
        }
    }
}