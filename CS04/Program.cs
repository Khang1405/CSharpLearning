class CS04
{
    static void Main(string[] args)
    {
        bool checkTF;
        // checkTF = false;
        checkTF = true;
        Console.WriteLine(checkTF);
        
        int a = 6;
        int b = 1;
        
        bool kq = a == b;
        Console.WriteLine("a == b la {0}", kq);
        Console.WriteLine("a != b la {0}", !kq);
        Console.WriteLine($"a > b la {a > b}") ;
        Console.WriteLine($"a >= b la {a >= b}") ;
        Console.WriteLine($"a <  b la {a < b}");
        Console.WriteLine($"a <= b la {a <= b}") ;

        bool c = true;
        bool d = false;
        Console.WriteLine(c || d);
        Console.WriteLine(c && d);

    }
}