// Tee toistolause, joka käy läpi luvut 0-100 ja tulostaa luvun vain jos
// se on jaollinen kuudellatoista
// • Käytä siis jakojäännösoperaattoria %
// • 0 ja 100 molemmat sisältyvät tarkastettavaan joukkoon
for (int i = 0; i < 101; i++)
{
    if (i % 16 == 0)
    {
        Console.WriteLine(i);
    }
}
