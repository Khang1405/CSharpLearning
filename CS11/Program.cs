using System.Text;
namespace CS11 
{
    class Program 
    {
        static void Main(string[] args)
        {
            string thongbao1;
            thongbao1 = "Xin";
            thongbao1+= " chao cac ban";
            thongbao1 = thongbao1.Replace("Xin chao", "Chao mung 1 ");
            Console.WriteLine(thongbao1);


            StringBuilder string_new =   new StringBuilder();
            string_new.Append("Xin");
            string_new.Append(" chao cac ban");
            string_new.Replace("Xin chao", "Chao mung");
            string kq = string_new.ToString();
            Console.WriteLine(kq);

            // dung \ de them 1 ki tu dac biet nhu \\ \"
            string loichao = "\\Xin \t \nchao";
            string ten = "\"Siu\"";
            string thongbao = loichao +" "+ ten;
            thongbao += "!";
            // hai dau "" "" bang mot " "
            // su dung  @ de ghi thoai mai
            string hoten = @"*****Hom nay that ""la""khong the tin duoc tuyet voi dung khong a                ";
            // can le ben phai {a , 10}
            // can le ben trai {a , -   10}
            // co the ket hop $@
            int dem = hoten.Length;

            Console.WriteLine(thongbao);
            Console.WriteLine(hoten);
            Console.WriteLine(dem);

            hoten = hoten.Trim('*', ' ');
            dem = hoten.Length;
            Console.WriteLine(hoten);
            Console.WriteLine(dem);
            Console.WriteLine(hoten);
            hoten= hoten.Replace("khong the", "hehehehe");
            hoten = hoten.Insert(10,"2020");
            // hoten = hoten.Substring(12,5);
            // hoten = hoten.Remove(3);
            string[] cacchuoicon = {
                "Toi",
                "Ten",
                "La",
                "Tao"
            };
            
            hoten = string.Join(' ', cacchuoicon);
            Console.WriteLine(hoten);

            // foreach(var abc in cacchuoicon)
            // {
            //     Console.WriteLine(abc);
            // }
            // Console.WriteLine(hoten);

        }
    }
}