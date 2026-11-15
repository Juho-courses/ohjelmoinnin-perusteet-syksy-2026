// Tee toistolause, joka käy läpi luvut 1-10 ja tulostaa kunkin luvun kerrottuna
// itsellään
// • Tee tämä for-lauseella ja while-lauseella

//  (alustus ; ehto   ; muutos)
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i * i);
}

Console.WriteLine("-------");


int k = 1; // alustus
while (k < 11) // ehto
{
    Console.WriteLine(k * k);
    k++; // muutos, k = k + 1
}
