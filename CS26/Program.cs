namespace CS26
{
    class Product
    {
        public string tenSP {get; set;}
        public double giaSP {get; set;}
        public int ID {get; set;}
        public string noiSX {get; set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> ds1 = new List<int>() {3,4,6,1,2,68,7,45,6,2};
            // // List<string> dds2 = new List<string>();
            // // ds1.Add(1);
            // // ds1.Add(2);
            // // ds1.AddRange(new int[] {3,4,5});
            // // ds1.Insert(0,10);
            // // ds1.Remove(4);
            // // foreach (var item in ds1)
            // // {
            // //     Console.WriteLine(item);
            // // }
            // var n = ds1.FindAll(
            //     (e) => {
            //         return e > 5;
            //     }
            // );
            // foreach (var item in n)
            // {
            //     Console.WriteLine(item);
            // }
            List<Product> products = new List<Product>() 
            {
                new Product(){
                    tenSP = "Iphone", giaSP = 1000, ID = 1, noiSX="My"
                },
                new Product(){
                    tenSP = "Samsung", giaSP = 1200, ID = 2, noiSX="TQ"
                },
                new Product(){
                    tenSP = "Motorozla", giaSP = 1020, ID = 3, noiSX="My"
                },
                new Product(){
                    tenSP = "Oppo", giaSP = 1030, ID = 4, noiSX="TQ"
                },
            };
            products.Sort(
                (p1,p2 ) => {
                    if(p1.giaSP == p2.giaSP) return 0;
                    if(p1.giaSP < p2.giaSP) return -1;
                    return 1;

                }            
            );
            // var l = products.FindAll(
            //     (l) => {
            //         return l.noiSX == "My" ;
            //     }
            // );
            foreach (var item in products)
            {
                Console.WriteLine($"{item.giaSP}, {item.tenSP}");    
            }

        }
    }
}