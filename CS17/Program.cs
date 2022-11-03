namespace CS17
{
    class SinhVien 
    {
        public string hoTen {get; set;} = default!;
        public int namSinh{get; set;}
        public string noiSinh {get; set;} = default!;
        public void InfSinhVien()
        {
            Console.WriteLine(hoTen);
        }
    }
    class Program 
    {
        
        static void printIF(dynamic obj)
        {
            obj.hoTen = "Khangg";
            obj.InfSinhVien();
        }  
        static void Main(string[] args)
        {
            // Console.WriteLine("Siuu");
            // var sanpham1 = new 
            // {
            //     Gia = 10000,
            //     TenSP = "Dien thoai",
            //     NamSX = 2020
            // };
            // Console.WriteLine(sanpham1.Gia);
            // Console.WriteLine(sanpham1.NamSX);
            List<SinhVien> listSV = new List<SinhVien>()
            {
                new SinhVien() {hoTen = "khang", namSinh= 2002 , noiSinh = "Gia Lai"},
                new SinhVien() {hoTen = "khan", namSinh = 2001 ,noiSinh = "Quang Nam"},
                new SinhVien() {hoTen = "kha", namSinh = 2000,noiSinh = "Quang Ngai"}

            };
            var ketqua = from sv in listSV
                        where sv.hoTen.Contains("n")
                        select new 
                        {
                            Ten = sv.hoTen,
                            Nam = sv.namSinh
                        };
            foreach (var sv in ketqua)
            {
                Console.WriteLine(sv.Nam  + " " + sv.Ten);
            }

            SinhVien sv1 = new SinhVien();
            printIF(sv1);
        }
    }
}
