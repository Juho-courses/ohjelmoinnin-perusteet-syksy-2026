// int[] numeroita2 = new int[] { 23, 321, 123 };
// int[] numeroita3 = [23, 321, 123];

int[] numeroita1 = new int[3];
// indx: 0, 1, 2

numeroita1[0] = 23;
numeroita1[1] = 321;
// numeroita1[2] = 123;
numeroita1[numeroita1.Length - 1] = 123;

for (int i = numeroita1.Length - 1; i >= 0; i--)
{
    // arrayn_nimi[indeksi]
    // Console.WriteLine(i);
    Console.WriteLine(numeroita1[i]);
}

// foreach (int num in numeroita1)
// {
//     Console.WriteLine(num);
// }

// string[] names = { "SAMK", "XAMK", "HAMK" };
// Console.WriteLine(names[1]);

string sana = "ohjelmointi";
Console.WriteLine(sana);

if (sana[0] == 'o')
{
    Console.WriteLine("eka merkki on o");
}

if (sana[sana.Length - 1] == 'ä')
{
    Console.WriteLine("viimine merkki o ä");
}