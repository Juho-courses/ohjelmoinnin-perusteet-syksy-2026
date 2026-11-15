// • Kirjoita ohjelma, joka kysyy käyttäjältä syötettä ja tulostaa syötteen
// sisältävien vokaalien määrän.
// • Esimerkiksi syöte “moikka moro” tulostaa ”Syötteestä löytyi 5
// vokaalia.”
// • Miten teet tarkastuksen siten, että molemmat kirjainkoot (isot ja
// pienet kirjaimet) otetaan huomioon?

Console.Write("Sano jotain: ");
string syote = Console.ReadLine();

int vokaalien_maara = 0;

foreach (char merkki_orig in syote)
{
    char merkki = Char.ToLower(merkki_orig);
    // a, e, i, o, u, y, ä, ö
    if (merkki == 'a' || merkki == 'e'
        || merkki == 'i' || merkki == 'o'
        || merkki == 'u' || merkki == 'y'
        || merkki == 'ä' || merkki == 'ö')
    {
        vokaalien_maara++;
    }
}

Console.WriteLine($"Syötteestä löytyi {vokaalien_maara} vokaalia.");
