namespace CS21
{
    class Program
    {
        static void Main(string[] args)
        {
            // phai phu hop ve kieu tham so va kieu tra ve
            // Co the dung action hoac delegate void Kieu(string s)
            Action<string, int> thongbao;
            thongbao = (name , he) => Console.WriteLine(name + " " + he);
            thongbao?.Invoke("Hehehe",5);
            thongbao?.Invoke("XinChao",6);

            // gan lambda ma kh co tham so dau vao thi
            // Action thongbao;
            // thongbao = () => Console.WriteLine(SIUu);
            Func <int , int, int> nucuoi;
            nucuoi = (int a, int b) => 
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                int kq = a + b;
                return kq;
            };
            Console.WriteLine($"Tong cua {4} va {6} la {nucuoi.Invoke(4,6)}");
            int[] mang = {4,5,5,6,1,3,7,8};
            var w = mang.Select((int x) => {
                return Math.Sqrt(x);
                }
            ); 
            foreach (var item in w)
            {
                Console.WriteLine(item);  
            }

            mang.ToList().ForEach(
                (int x) =>
                {
                    if (x %2 == 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            );
        }
    }
}