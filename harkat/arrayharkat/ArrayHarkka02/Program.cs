// Luo array, johon tallennat 3 desimaalilukua
// • Tulosta arrayn arvojen yhteenlaskettu summa
//
double[] luvut = { 3.0, 3.1, 3.9 };

double summa = 0.0;

// summa = luvut[0] + luvut[1] + luvut[2];
foreach (double luku in luvut)
{
	summa += luku;
}

Console.WriteLine($"summa on {summa}");
Console.WriteLine($"summa on {luvut[0] + luvut[1] + luvut[2]}");
Console.WriteLine($"summa on {luvut.Sum()}");
