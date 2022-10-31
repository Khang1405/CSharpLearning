namespace CS09
{
    class Program
    {
        static void Main(string[] args)
        {
            xinchao();
            Console.WriteLine(tong (3,4));
            Clone1.Program.Hello();
            double ketqua  = TinhToan.Program.chia(5,4);
            Console.WriteLine("Ket qua cua phep chia la {0}",ketqua);
        }
        static int tong(int a , int b)
        {
            return a + b;
        }
        static void xinchao()
        {
            Console.WriteLine("Xin chao");
            Console.WriteLine("Minh ten la SIUUUUUU");
        }

    }
}