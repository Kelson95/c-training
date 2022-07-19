// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Podaj szerokosc prostokonta : ");
string xs = Console.ReadLine();

Console.WriteLine("Podaj wysokosc prostokonta : ");
string ys = Console.ReadLine();

int x = int.Parse(xs);
int y = int.Parse(ys);
for (int i = 0; i < y; i++)
{
    for (int j = 0; j < x; j++)
    {
        Console.Write("*");

    }
    Console.WriteLine();

}



Console.WriteLine(x + " " + y);




Console.ReadKey();