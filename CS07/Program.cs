namespace CS07
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 1 ;  i <= 10 ; i++ )
            // {
            //     Console.WriteLine($"i = {i}");
            //     Console.WriteLine("Minh ten la Siuuu");
            // }
            // bang cuu chuong 9
            for(int i = 1 ; i <= 10 ; i++)
            {
                Console.WriteLine($"9 x {i} = {9 * i}");
            }
            int a  = 1;
            // Bang cuu chuong 8
            while(a <= 10)
            {
                Console.WriteLine($"8 x {a} = {8 * a}");
                a++;
            }
            // Bang cuu chuong 7
            int b = 1;
            do 
            {
                Console.WriteLine($"7 x {b} = {b * 7}");
                b++;
            }
            while(b <= 10);
            // break in so 12
            int c = 1;
            while (c <= 1000)
            {
                Console.WriteLine($"i = {c}");
                if ( c == 12 )
                    break;
                c++;
            }
            // continue in ra so le
            for(int d = 1 ; d <= 20 ; d++)
            {
                if (d % 2 == 0)
                {
                    continue;
                }   
                Console.WriteLine(d);
            }
        }
    }
}