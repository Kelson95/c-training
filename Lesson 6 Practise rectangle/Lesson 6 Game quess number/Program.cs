// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random rnd = new Random();
int los = (rnd.Next(1, 11));
//Console.WriteLine("Czas gry zgadnij liczbe od 1 do 10");
//string xa = Console.ReadLine();
//int x = int.Parse(xa);
//if (x == los)
//{
//    Console.WriteLine("Zgadles Brawo");
//}
//else
//{
//    Console.WriteLine("Nie zgadles zagraj ponownie");
//}
//Console.WriteLine("Liczba poprawna byla liczba "+ los);
int ileRazy = 0;
int mojaLiczba;
Console.WriteLine(" Czas Gry Zgadnij liczbe!\n Podaj liczbe od 1 do 10 ziomek");

do
{


    Console.Write("Twoja Liczba to :  ");
    mojaLiczba = int.Parse(Console.ReadLine());
    if (mojaLiczba > 10 || mojaLiczba < 1)
    {
        Console.WriteLine("Liczba z poza zakresu");
    }
    else
    {
        ileRazy++;

        if (mojaLiczba > los)
        {

            Console.WriteLine("Podales zbyt duza liczbe");

        }
        else if (mojaLiczba < los)
            Console.WriteLine("Podales zbyt mala liczbe");
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gratulacje zgadles poprawnie ! \n Za {0} razem", ileRazy);
        }
        Console.ResetColor();
    }
} while (los != mojaLiczba);



Console.ReadKey();

