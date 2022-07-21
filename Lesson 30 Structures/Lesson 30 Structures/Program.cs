namespace Lesson_30_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // struktura podobna do klas , roznica inicjalizacji klas (bez slowka new ,ktora sie  kopiuje .
            //struktura jest bytem skonczonym a klasa moze dziedziczyc
            Console.WriteLine("Hello, World!");
            //   Console.WriteLine(Point2D.x);
            // Point2D point1 = new Point2D(); metoda obiektu dla klas // wywolywanie konstruktora
            Point2D point1 = new Point2D(9,4); //dwa rodzaje konstruktorow zadeklarowanych
            Point2D point2;
            point2 = point1;
            point2.x = 7;

            Point2D point3 = point1 + point2;
            Console.WriteLine(point1.x);
            Console.WriteLine(point1.y);
            Console.WriteLine(point1.RangeFromCenter());
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);
            Console.WriteLine(point2.RangeFromCenter());
            Console.WriteLine(point3.x);
            Console.WriteLine(point3.y);
            Console.WriteLine(point3.RangeFromCenter());
        }
    }
    //struck tab tab 
    struct Point2D
    {
        //moze byc konstruktor w strukturze
     public static Point2D operator +(Point2D a, Point2D b)
        {
            return new Point2D(a.x + b.x, a.y + b.y);
        }

        //wartosci  kostruktora musi byc zainicjaliwana
        public Point2D(int x,int y) //zawartosc nawiasow ?
        {
            this.x = x;
            this.y = y;
        }
        //nie mozna w trukturze umiescic inicjatorow czyli przypisac zmiennej wartosc x= 5;
        public int x;
        public int y;
       
        public double RangeFromCenter()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),1); //pitagoras ,one place after dot

        }

    }
    //w mozna dziedziczyn interface
//    struct Point3D : IComparable
//    {
//        public int CompareTo(object? obj)
//        {
//            throw new NotImplementedException();
//        }
//    }

}
