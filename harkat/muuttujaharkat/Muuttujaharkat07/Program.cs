// • Luo muuttuja, jonka arvoksi annat oman nimesi
string nimi = "Juho";
// • Luo toinen muuttuja, jonka arvoksi annat aiemmin luomasi muuttujat
// pituuden
int nimen_pituus = nimi.Length;
// • Tulosta teksti ”Merkkijono <muuttuja1> on <muuttuja2> merkkiä pitkä.”
Console.WriteLine("Merkkijono " + nimi + " on " + nimen_pituus + " merkkiä pitkä.");
Console.WriteLine($"Merkkijono {nimi} on {nimen_pituus} merkkiä pitkä.");

// • Merkkijonon pituutta ei ole pakko ottaa talteen muuttujaan. Miten teet
// tulostuksen ilman, että merkkijonon pituuden arvo on omassa muuttujassa?
Console.WriteLine("Merkkijono " + nimi + " on " + nimi.Length + " merkkiä pitkä.");
Console.WriteLine($"Merkkijono {nimi} on {nimi.Length} merkkiä pitkä.");
