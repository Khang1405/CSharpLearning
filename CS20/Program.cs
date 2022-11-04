namespace CS20
{
    // delegate khong co phan than
    public delegate void ShowLog(string m);
    class Program
    {
        static void inFo(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            ShowLog log = null;
            log += inFo;
            log += inFo;
            log += inFo;
            log += warning;
            log += warning;
            log.Invoke("HEHEHHEHEHE, SIUUU");
            log("Adu");

            static int tong(int a , int b) => a + b;

            static void hieu(int a, int b, ShowLog log)
            {
                int kq = a - b;
                log?.Invoke($"Tong la {kq}");
            }
            Action action;
            Action <int, double> action1; // == public delegate void ShowLog(string m);
            Action <string> action2;
            action2 = warning; // yeu cau phai tuong dong
            action2 += inFo;
            action2?.Invoke("heheheb siuu");

            Func<int> f1; // == delegate int Kieu1()
            Func<string, int, string> f2; // == delegate string f2 (string s , int i)

            Func<int, int, int> so; // delegate int so (int a, int b)
            int a = 5; 
            int b = 2;

            so = tong;
            Console.WriteLine($"Tong la = {so(a,b)}");
            hieu(a, b, inFo);

        }
    }
}