
namespace CS08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] hovaten = {"Nguyen Khang ", "Thanh San" , "Phuoc Trinh",  "Anh Hung" ,"Siuuu", "Anh la Siu nhan"};
            int l = hovaten.Length;
            for(int i = 0; i <= l-1 ; i ++ )
            {
                Console.WriteLine(hovaten[i]);
            }
            for(int i = l-1; i >=  0 ; i -- )
            {
                Console.WriteLine(hovaten[i]);
            }
            foreach (var i in hovaten)
            {
                Console.WriteLine(i);
            }
            // sap xep mang
            Array.Sort(hovaten); 
            foreach (var i in hovaten)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Do dai cua mang {hovaten.Length}");
            Console.WriteLine($"Max cua mang {hovaten.Max()}");
            Console.WriteLine($"Min cua mang {hovaten.Min()}");
            // mang 2 chieu
            double[,] mang = {{3.5, 3 ,5 }, {5.2,2.4,5}};
            int hang = 2;
            int cot = 3;
            for (int i = 0; i < hang; i++)
            {
                for(int j = 0 ; j < cot ;j++)
                {
                    Console.Write(mang[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}