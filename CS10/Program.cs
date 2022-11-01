// https://xuanthulab.net/su-dung-lop-thuoc-tinh-trong-c-tao-va-su-dung-doi-tuong-lop.html
namespace CS10
{
    class Program
    {
        // Quan li qua trinh thu hoi
        class Student : IDisposable
        {
            
            public string name;
            public Student(string name)
            {
                this.name = name;
                Console.WriteLine("Khoi tao " +name)  ;
            }
            // Het hieu luc tren .Net Core
            // Den khi nao no can giai phong thi no se lam
            ~Student()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Huy "+name);
                Console.ResetColor();
            }

            public void Dispose()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Huy (boi dispose)"+name);
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            // vukhi sungluc;
            // sungluc = new vukhi();
            // sungluc.name = "Dai Dao";
            // sungluc.TinhSatThuong(10);
            // sungluc.TanCong();
            // vukhi sungmay = new vukhi("Sung May", 20);
            // sungmay.TanCong();
            // sungmay.SThuong = 40;    
            // sungmay.NoiSanXuat = "Khang";
            // Console.WriteLine(sungmay.NoiSanXuat); 
            // Student student ;
            // for (int i = 0; i < 100000; i++)
            // {
            //     student = new Student("Nguyen Huynh Chi Khang"+ i);
            //     student = null;
            // }
            //Dispose tu dong thi hanh khi no di ra ngoai using 
            
            using (Student s = new Student("Ten sinh vien"))
            {

            }
        }
    }

}