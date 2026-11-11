// Tee toistolause, joka käy läpi luvut 1-10 ja tulostaa kunkin luvun kerrottuna
// itsellään
// • Tee tämä for-lauseella ja while-lauseella

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i * i);
}

Console.WriteLine("-------");

int k = 1;
while (k < 11)
{
    Console.WriteLine(k * k);
    k++; // k = k + 1
}
