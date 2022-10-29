// so chan so le
class Program
{
    static void Main(string[] args)
    {
        // dieu kien if else else if
        int a;
        Console.Write("Nhap so nguyen a:");
        a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            // Console.WriteLine("So {0} la so chan", a);
            Console.WriteLine($"So {a} la so chan");

        }
        else
        {
            Console.WriteLine("So {0} la so le", a);
        }
        Console.WriteLine("The End");

        float dtb;
        Console.Write("Nhap diem trung binh: ");
        dtb = float.Parse(Console.ReadLine());
        if (dtb <= 10 && dtb >= 8)
        {
            Console.WriteLine("Hoc sinh gioi");
        }
        else if (dtb >= 6.5 && dtb < 8)
        {
            Console.WriteLine("Hoc sinh kha");
        }
        else if (dtb >=5  && dtb < 6.5)
        {
            Console.WriteLine("Hoc sinh trung binh");
        }
        else 
        {
            Console.WriteLine("Hoc sinh yeu");
        }
        // toan tu 2 ngoi
        Console.Write("Nhap so c: ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("Nhap so d: ");
        float d = float.Parse(Console.ReadLine());

        float max;
        max = (c > d) ? c : d; 
        Console.WriteLine("So lon nhat cua {0} va {1} la {2}",c,d,max);

        // toan tu 3 ngoi
        
        float e = 3, f = 3.2f, g = 2;
        float max1;
        max1 = (e > f) ? (e > g) ? e : g : (f > g) ? f : g;
        Console.WriteLine("So lon nhat cua {0} , {1} , {2} la {3}",e,f,g,max1);

    }
}