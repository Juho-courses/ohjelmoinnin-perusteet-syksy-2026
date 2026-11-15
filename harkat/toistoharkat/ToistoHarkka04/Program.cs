// • Kysy käyttäjältä kuinka monta arvoa hän haluaa syöttää
// • Kysy käyttäjältä määritelty määrä merkkijonoja
// • Arvo ei saa olla tyhjä merkkijono
// • Tulosta syötettyjen merkkijonojen yhteenlaskettu pituus

Console.Write("Montako sanaa sanot (int): ");
string syote = Console.ReadLine();
int vaadittu_maara = int.Parse(syote);

int merkkimaara_yhteensa = 0;

int lailliset_arvot = 0;
string sana;

while (lailliset_arvot < vaadittu_maara)
{
    Console.Write("Kirjoita sana (pidempi kuin 1 merkki): ");
    sana = Console.ReadLine();

    // laillinen sana
    if (sana.Length > 0)
    {
        lailliset_arvot++;
        merkkimaara_yhteensa = merkkimaara_yhteensa + sana.Length;
    }
}

Console.WriteLine("Yhteenlaskettu merkkimäärä: " + merkkimaara_yhteensa);
