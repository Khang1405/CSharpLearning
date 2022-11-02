namespace CS14
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Khoi tao Animal");
        }
        public Animal(string abc)
        {
            Console.WriteLine($"Khoi tao {abc}");
        }
        public int Legs {set; get;}
        public float Weight{set; get;}

        public void ShowLegs()
        {
            Console.WriteLine($"Legs = {Legs}");
        }
    }
    class Cat : Animal
    {
        public Cat(string s) : base(s)
        {
            this.Legs = 4;
            this.Food = "Mouse";
            Console.WriteLine("Khoi tao lop Cat");
        }
        public string Food;
        public new void ShowLegs()
        {
            Console.WriteLine($"Con meo co {Legs} chan");
        }
        public void Eat ()
        {
            Console.WriteLine(Food);
        }
        public void GetInfo()
        {
            base.ShowLegs();
            ShowLegs();
        }
    }
    class A {}
    class B: A{};
    class C: B{};
    class Program
    {
        
        static void Main(string[] args)
        {
            Cat c = new Cat("Anh Khang");
            // c.ShowLegs();
            // c.Eat();
            // c.GetInfo();
        }
    }
}