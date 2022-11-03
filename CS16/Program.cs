namespace CS16_Genetic
// genetic giup su dung lai code 1 cach toi da
{

    class Product<a>
    {
        a ID;
        public void SetID(a _id)
        {
            this.ID = _id;
        }
        public void PrintInf()
        {
            Console.WriteLine($"ID = {this.ID}");
        }
    }
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            string a = " hehehe ";
            string b = "Siu";
            
            Swap<string>(ref a, ref b);
            Console.WriteLine($"{a}, {b}");

            Product<string> sp1 = new Product<string>();
            sp1.SetID("Hehehehe, Siuuuuu");
            sp1.PrintInf();

            List<int> l1 = new List<int>();
            List<string> l2 = new List<string>();

            Stack<int> stack;
            Queue<string> queue;
        }
    }
}