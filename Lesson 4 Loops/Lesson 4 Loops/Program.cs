// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//WHILE | FOR | DO WHILE

int a = 0;
while (a <= 15)
{
    Console.WriteLine(a);
    Console.WriteLine("Tekst");
    a+=2;
}
Console.WriteLine(a);
Console.WriteLine("To byla petla WHILE ");
Console.WriteLine("----------------------------------------------p---");
int b = 0;
for (  ; b<5 ; b++ )
{
    
    Console.WriteLine(b);
    Console.WriteLine("tekst");
}
Console.WriteLine(b);
Console.WriteLine("To byla petla  FOR ");
Console.WriteLine("--------------------------------------------------");

do
{
    Console.WriteLine("Tekst");
}
while (false);


Console.WriteLine("To byla petla DO WHILE");
Console.WriteLine("--------------------------------------------------");
Console.ReadKey();