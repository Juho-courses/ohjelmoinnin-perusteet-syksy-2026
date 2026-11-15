// Tee toistolause, joka tulostaa luvut 0 ja 20 väliltä, jotka eivät ole
// jaollisia kolmella
for (int i = 0; i < 21; i++)
{
    if (i % 3 != 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("----");

// int luku = 0;
// while (luku < 21)
// {
//     if (luku % 3 != 0)
//     {
//         Console.WriteLine(luku);
//     }
//     luku++;
// }

int luku = 0;
int isoin_tarkastettava_luku = 20;
while (true)
{
    if (luku % 3 != 0)
    {
        Console.WriteLine(luku);
    }
    luku++;
    if (luku > isoin_tarkastettava_luku)
    {
        break;
    }
}