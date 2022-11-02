using Khang;
using xyz = Khang.ABC;
// using static System.Console;
// using static System.Math;
namespace CS15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class1.XinChao();
            // xyz.Class1.XinChao();
            SanPham.Product sp = new SanPham.Product();
            sp.tenSP = "Iphone 14";
            sp.gia  = 4100;
            sp.moTa = "Day la dong iphone doi moi 2022";
            sp.nhaMay = new SanPham.Product.NhaMay();
            sp.nhaMay.name = "Apple";
            sp.nhaMay.addr = "My";
            Console.WriteLine(sp.GetInfo());
        }
    }
}