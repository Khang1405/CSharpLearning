namespace CS13
{
    class Program
    {
        static void Main(string[] args)
        {
            // hang so
            // Console.WriteLine($"So Pi {Math.PI}");
            int a = 40, b = 24, c = -100;
            Console.WriteLine($"Max {Math.Max(Math.Max(a,b),c)}");

            Console.WriteLine($"Gia tri tuyet doi : {Math.Abs(c)}");

            Console.WriteLine($"Sin: {Math.Sin(Math.PI/2)}");
            double deg = 60;
            double rad = Math.PI*deg / 180;
            for (int i = 0; i <= 90; i++)
            {
                rad = Math.PI * i/ 180;  
                Console.WriteLine($"Sin {i} : {Math.Sin(rad)}");
            }
            Console.WriteLine($"Luy thua: {Math.Pow(3,5)}");
            Console.WriteLine($"Can: {Math.Sqrt(3)}");

            Console.WriteLine($"Lam tron: {Math.Round(Math.Sqrt(3))}");
            Console.WriteLine($"Lam tron tren: {Math.Ceiling(Math.Sqrt(3))}");
            Console.WriteLine($"Lam tron duoi: {Math.Floor(Math.Sqrt(3))}");


            Console.WriteLine($"Cat hang thap phan: {Math.Truncate(Math.Sqrt(3))}");


        }
    }
}