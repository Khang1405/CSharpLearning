namespace CS25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            try
            {
                var c = a / b;
                Console.WriteLine(c);
                int[] i = {1,2};
                var x = i[5];
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace); 
                Console.WriteLine("Khong duoc chia cho 0");
            }
            catch(IndexOutOfRangeException e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine("Chi so mang khong phu hop");
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        Console.WriteLine("Ket thuc");

        }
    }
}