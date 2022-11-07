namespace CS22
{
    public  delegate void SuKienNhapSo(int a);
    /*
    publisher -> class : phat su kien
    subcriber -> class : nhan su kien
    */
    class userInput
    {
        public event SuKienNhapSo suKienNhapSo;
        public void Input()
        {
            do
            {
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                suKienNhapSo?.Invoke(i);
            }
            while(true);
        }
    }
    class TinhCan
    {
        public  void LaySo (userInput u)
        {
           u.suKienNhapSo += Can;
        }
        public void Can(int a)
        {
            Console.WriteLine($"Can bac 2 cua so {a} la {Math.Sqrt(a)}");
        }
    }
    class TinhBinhPhuong
    {
        public void LaySo (userInput u)
        {
           u.suKienNhapSo += BinhPhuong;
        }
        public void BinhPhuong(int a)
        {
            Console.WriteLine($"Binh Phuong cua so {a} la {a*a}");
        } 
        static void Main(string[] args)
        {
            //pub
            userInput ui = new userInput();
            ui.suKienNhapSo += x => Console.WriteLine($"Ban vua nhap so {x}");
            //sub
            TinhCan can  = new TinhCan();
            can.LaySo(ui);            
            TinhBinhPhuong bp = new TinhBinhPhuong();
            bp.LaySo(ui);
            ui.Input();        


        }
    }
}