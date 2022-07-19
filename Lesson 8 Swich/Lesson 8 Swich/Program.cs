// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int liczba;
liczba = int.Parse(Console.ReadLine());

//liczba
//if (liczba == 1)
//{
//    Console.WriteLine("Jeden");
//}
//else if (liczba == 2)
//{
//    Console.WriteLine("Dwa");
//}
//else if (liczba == 3)
//{
//    Console.WriteLine("Trzy");
//}
//else
//{
//    Console.WriteLine("Inna wartosc");
//}

char znak = 'c';

switch (znak)
{
    case 'a':
        Console.WriteLine("Jeden A");
        goto koniec;
    case 'b':
        Console.WriteLine("Dwa B");
        goto case 'c';
    case 'c':
        Console.WriteLine("Trzy C");
        break;
    default:
        Console.WriteLine("Inna wartosc");
        break ;
}

Console.WriteLine("Dodatkowy tekst");
koniec:
Console.WriteLine("Koniec");
Console.ReadKey();