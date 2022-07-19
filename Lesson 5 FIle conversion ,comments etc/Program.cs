// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//////////skroty klawiszow ctrl k i d ukladanie kodu
// ctrl k i c komentowanie oznaczonego kodu  ctrl k i u odkomentowywanie kodu 
// snippet jak cw i dwa razy tab console writeline 
// for i dwa razy tab full petla for .



////////rzutowanie zmiennych 

int i = int.MaxValue;
double d = 5.9;

i = (int)d;
Console.WriteLine(i);



////Wczytywanie danych z konsoli 

string s = Console.ReadLine();
Console.WriteLine(s);


if (Console.ReadKey().Key == ConsoleKey.D1)
    Console.WriteLine("PRAWDA");

////// Konwersja Typow string >ing lub int > string
string p = Console.ReadLine();
int l = int.Parse(p) + 2;
Console.WriteLine(l);

string k = Console.ReadLine();
int j = int.Parse(k) + 2;
Console.WriteLine(j + 4  + "to jest int ze stringa + 4\n");
k = j.ToString();
Console.WriteLine(k  + "to jest string z inta ");

////// Łączenie tekstu & formatowanie "WriteLine"
//Konkatenacja 
string s1 = "Witaj";
string s2 = "Swiecie";
string s3 = s1 + s2;
Console.WriteLine(s3);
Console.WriteLine(s1 + s2);
Console.WriteLine(s1 + s2 +"!!!!\n {0}\n\n{1}",s1,s2);


Console.WriteLine(s1 + s2 +"!!!!\n {0}\n\n{1}",s1,s2);
//index zerowy  {0} bo od zera pierwsza liczba

////////Modyfikacja wygladu konsoli
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(s1 + s2 + "!!!!\n {0}\n\n{1}", s1, s2);
Console.ResetColor();
Console.WriteLine(s1 + s2 + "!!!!\n {0}\n\n{1}", s1, s2);

Console.ReadKey();
Console.Clear();

Console.ReadKey();