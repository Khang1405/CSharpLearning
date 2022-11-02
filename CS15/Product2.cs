namespace SanPham
{
    // partial chia nho nhung lop ra nam o nhieu file 
     public partial class Product
    {
        public NhaMay nhaMay {get; set;}
        public class NhaMay
        {
            public string name {get; set;}
            public string addr {get; set;}
        }
        public string moTa {get; set;}
        public void abc()
        {
            // this.gia
        }
    }
}