namespace CS18
{
    class bac 
    {
        public void xinchao()
        {
            Console.WriteLine("Hehehe, Siu");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bac a = new bac();
            a?.xinchao();
            // tham tri khong the nhan gia tri null nhung co the nullable
            int? name;
            name = null;
            name = 10;
            if(name.HasValue)
            {
                int _name = name.Value;
                Console.WriteLine(_name);
            }
        }
    }
}