namespace CS24
{
    class CountNumber
    {
        public static int number = 0;
        public static void Info()
        {
            Console.WriteLine("So lan truy cap: "+ number);
        }
        public void Count()
        {
            CountNumber.number++; 
        }
    }
    class Student
    {
        // readonly chi doc 
        public readonly string name = "Nguyen Huynh Chi Khang";
        public Student(string s)
        {
            this.name = s;
        }
    }
    class Vector
    {
        double x, y;
        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public void Info()
        {
            Console.WriteLine("x = {0} y = {1}", x, y);
            
        }
        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x , v1.y + v2.y);
        }
        public double this[int i]
        {
            set
            {
                switch (i)
            {
                case 0:
                x = value;
                break;
                case 1:
                y = value;
                break;                    
                default:
                    throw new Exception();
            }


            }
            get
            {
                switch (i)
            {
                case 0:
                return x;
                case 1:
                return y;            
                default:
                    throw new Exception();

            }

            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // CountNumber c1 = new CountNumber();
            // CountNumber c2 = new CountNumber();
            // c1.Count();
            // c2.Count();
            // CountNumber.Info();
            // Student std = new Student("Nguyen j");
            // Console.WriteLine(std.name);
            Vector v1 = new Vector(3,5);
            Vector v2 = new Vector(7,4);
            var v3 = v1 + v2;
            v1.Info();
            v2.Info();
            v3.Info();
            v1[0]=5;
            v1[1]=6;
            v1.Info();

        }
    }
}