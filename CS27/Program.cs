namespace CS27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue
            Queue<string> cacHoSo = new Queue<string>();
            cacHoSo.Enqueue("Ho so 1");
            cacHoSo.Enqueue("Ho so 2");
            cacHoSo.Enqueue("Ho so 3");
            foreach(var hs in cacHoSo)
            {
                Console.WriteLine(hs);  
            }
            var hoso = cacHoSo.Dequeue();
            Console.WriteLine($"Xu ly ho so: {hoso}-{cacHoSo.Count}");
            // Stack
            Stack<string> hanghoa = new Stack<string>();
            hanghoa.Push("Ho so 1");
            hanghoa.Push("Ho so 2");
            hanghoa.Push("Ho so 3");
            var mathang = hanghoa.Pop();
            Console.WriteLine($"Lay ra {mathang}");
            // LinkedList
            LinkedList<string> cacbaihoc new LinkedList<string>();
            var bh1 = cacbaihoc.AddFirst("Bai hoc 1");
            var bh3 = cacbaihoc.AddLast("Bai hoc 3");
            LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1,"Bai hoc 2");
        }
    }
}