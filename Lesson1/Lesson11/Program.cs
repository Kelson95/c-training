// See https://aka.ms/new-console-template for more information


int a = 2;
int b = 3;


// % reszta z dzielenia 
//a += b;// dodawanie do aktualnej wartosci a= a+b; to samo z - * / 

a += 1; //a++
a -= 1; //a--

bool d = 2 >= 1;

bool e = 3 == 2; //przyrownanie wartrosci
bool f = 3 != 4;   //przyrownanie roznosci

bool g = !(2 == 2); // negacja argumentu 


int c = (a + a) * a; ;// 

bool h = 1 == 1 && 1 != 1;  // I  czyli AND 

bool t = 1 == 1 || 2 != 2; // LUB czyli OR

bool r = true || true && false;
bool w = (true || true) && false;

Math.Pow(2, 3);

Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine("Teraz znaki logiczne po znakach przyrownaniu wartosci ");

Console.WriteLine(h);
Console.WriteLine(t);
Console.WriteLine(r);
Console.WriteLine(w);

Console.WriteLine("Mnozenie dzielenie z math biblioteki system");
Console.WriteLine((Math.Pow(2, 3) + 1) * 2);
Console.WriteLine(Math.Pow(2, 3));
Console.WriteLine(Math.Sqrt(9));//pierwiastek
Console.WriteLine(Math.Abs(-5));// bezwzgledna
Console.ReadKey();

