namespace CS29
{
    class Program
    {
        static void DoSome(int seconds , string mgs, ConsoleColor cl)
        {
            for (int i = 0; i < seconds; i++)
            {
                lock(Console.Out)
                {
                    Console.ForegroundColor = cl;
                    Console.WriteLine($"{mgs} {i}");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
        }
        static async Task void Main(string[] args)
        {
            Console.WriteLine("----");
            
            // synchronization di theo trinh tu nhu thuo so khai dong 1 -> dong 2 -> dong 3
            // asynchronously cho phep chay song song 
            Task t1 = new Task(
              () =>  {
                DoSome(4,"ngu", ConsoleColor.Green);
              }
            );
            Task t2 = new Task(
              () =>  {
                DoSome(4,"thong minh", ConsoleColor.Red);
              }
            );
            // Task t2 = new Task(
            //     (object ob) => {
            //         string tentacvu = (string)ob;
            //         DoSome(4,tentacvu, ConsoleColor.Red);
            //     }
            //     , "Thong minh");
            t1.Start();
            t2.Start();
            // wait: de no hoan thanh
            // async  
            // static async Task 
            // {
            //     await t2;
            //     // tai thoi diem hoan thanh khi chay song song
            // }
       }
    }
}