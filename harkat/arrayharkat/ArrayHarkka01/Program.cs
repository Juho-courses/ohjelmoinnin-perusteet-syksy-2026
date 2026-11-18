// • Luo array johon tallennat 5 merkkijonoa
// • Tulosta arrayn kaikki arvot omille riveilleen

string[] merkkijonot = new string[5];

// merkkijonot[1] = "string1";
// merkkijonot[0] = "string0";
// merkkijonot[2] = "string2";
// merkkijonot[3] = "string3";
// merkkijonot[4] = "string4";
for (int i = 0; i < merkkijonot.Length; i++)
{
    merkkijonot[i] = "string" + i;
}

foreach (string sana in merkkijonot)
{
    Console.WriteLine(sana);
}