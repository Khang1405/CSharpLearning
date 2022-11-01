namespace CS12
{
    class Program
    {
        public struct DienThoai
        {
            public string tenDT;
            public double giaThanh;
            public string GetInfo()
            {
                return $"Ten San Phan {tenDT} , Gia Thanh:{giaThanh}";
            }
            public string Info()
            {
                return $"{tenDT}, {giaThanh}";
            }
            public DienThoai( string _name, double _gia)
            {
                this.tenDT = _name;
                this.giaThanh = _gia;
            }
        }
        enum HOCLUC 
        {
            Yeu = 12,
            TrungBinh = 13,
            Kha = 14,
            Gioi = 100
        }
        static void Main(string[] args)
        {
            DienThoai dt1;
            dt1.tenDT = "Iphone 14";
            dt1.giaThanh = 1100.5;
            DienThoai dt2 =new DienThoai("Galaxy S10", 3000.2);
            Console.WriteLine(dt1.GetInfo());
            Console.WriteLine(dt2.GetInfo());
            HOCLUC hocluc = HOCLUC.Yeu;
            hocluc = (HOCLUC)(100);
            // Console.WriteLine(a);
            switch (hocluc)
            {
                case HOCLUC.Yeu:
                    Console.WriteLine("Hoc sinh yeu");
                break;
                case HOCLUC.TrungBinh:
                    Console.WriteLine("Hoc sinh trung binh");
                break;
                case HOCLUC.Kha:
                    Console.WriteLine("Hoc sinh tien tien");
                break;
                case HOCLUC.Gioi:
                    Console.WriteLine("Hoc sinh gioi");
                break;
            }
        }
    }
}