namespace SanPham
{
    public partial class Product
    {
        public string tenSP {get; set;}
        public decimal gia {get;set;}
        public string GetInfo()
        {
            return $"{tenSP}/{gia} : {moTa} : {nhaMay.name} : {nhaMay.addr}";
        }
    }
}