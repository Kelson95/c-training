// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[,] tab = new int[2, 3];
tab[0, 0] = 1;
tab[0, 1] = 2;
tab[0, 2] = 5;
tab[1, 0] = 22;
tab[1, 1] = 30;
tab[1, 2] = 34;

Console.WriteLine();
for (int i = 0; i < tab.GetLength(0); i++)
{
    for (int j = 0; j < tab.GetLength(1); j++)

    {
        Console.Write(tab[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

int[][] tab2 = new int[2][];//do ogarniecia czemu ta druga jest pusta
tab2[0] = new int[3];
tab2[1] = new int[2];
tab2[0][0] = 2;
tab2[0][1] = 3;
tab2[0][2] = 22;
tab2[1][0] = 42;
tab2[1][1] = 12;

for (int i = 0; i < tab2.Length; i++)
{ 
    for (int j = 0; j < tab2[i].Length; j++)
    {
        Console.Write(tab2[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[] tab3 = new int[4];
tab3[0] = 5;
tab3[1] = 3;
tab3[2] = 10;
tab3[3] = 1;
Console.WriteLine(tab3.Max());
Console.WriteLine();
Console.WriteLine(tab3.Min());
Console.WriteLine();
Console.WriteLine(tab3.Sum());
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < tab3.Length; i++)
{
    Console.WriteLine(tab3[i]);
}
Console.WriteLine();
Array.Sort(tab3);
for (int i = 0; i < tab3.Length; i++)
{
    Console.WriteLine(tab3[i]);
}
Array.Reverse(tab3);
Console.WriteLine();
for (int i = 0; i < tab3.Length; i++)
{
    Console.WriteLine(tab3[i]);
}
Console.ReadKey();
