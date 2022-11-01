namespace CS10
{
    public class vukhi
    {
        public string name = "vu khi dang cap nhat the gioi 1123";
        int st = 0;
        // public vukhi()
        // {
        //     st = 1;
        // }
        public vukhi(string name, int TinhST )
        {
            this.st = TinhST;
            this.name = name;
        }
        //  public vukhi(string tenvk)
        // {
        //     Console.WriteLine(tenvk);
        // }
        // public void TinhSatThuong(int st)
        // {
        //     //this = ref
        //     this.st = st;
        // }
        public void TanCong()
        {
            Console.Write(this.name + ": \t");
            for (int i = 0; i < st; i++)
            {
                Console.Write("* ");
            }
        }
        public string NoiSanXuat{set; get;}
        public int SThuong 
        {
            set
            {
                this.st = value;
            }
            get
            {
                return st;
            }
        }
    }
} 