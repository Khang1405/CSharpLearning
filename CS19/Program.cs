namespace CS19
{
    interface iHinhHoc
    {
        public double tinhChuVi();
        public double tinhDienTich();
    }

    class hinhChuNhat : iHinhHoc
    {
        public double a {get; set;}
        public double b {get; set;}
        public hinhChuNhat (double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        public double tinhChuVi()
        {
            return (a + b) * 2;
        }

        public double tinhDienTich()
        {
            return a * b;
        }
    }
    class hinhTron : iHinhHoc
    {
        public double r {get; set;}
        public hinhTron(double _r) => r = _r;

        public double tinhChuVi()
        {
            return 2 * Math.PI * r;
        }

        public double tinhDienTich()
        {
            return r*r * Math.PI;
        }
    }
    abstract class Product
    {
        protected double giaSP {get; set;}
        public abstract void InFo();
        public void Test() => InFo();
    }
    class iPhone : Product
    {
        public iPhone() => giaSP = 1200;
        public override void InFo()
        {
            Console.WriteLine("Dien thoai Iphone");
            Console.WriteLine($"Gia san pham = {giaSP}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            iPhone ip1 = new iPhone();
            ip1.Test();
            hinhChuNhat hcn1 = new hinhChuNhat(4,5);
            Console.WriteLine($"DT hinh chu nhat la : {hcn1.tinhDienTich()}");
            Console.WriteLine($"CV hinh chu nhat la {hcn1.tinhChuVi()}"); 
            hinhTron ht1 = new hinhTron(5);
            Console.WriteLine($"DT hinh tron la : {ht1.tinhDienTich()}");
            Console.WriteLine($"CV hinh tron la : {ht1.tinhChuVi()}"); 
        }
        
    }
}