// for (alustus; ehto; muutos)
// for (int i = 1; i < 21; i += 2)
// {
//     Console.WriteLine(i);
// }
// for (int k = 10; k > 2; k--)
// {
//     Console.Write(k + ", ");
// }

// int count = 0;
// while (count < 5)
// {
//     Console.WriteLine(count);
//     count++; // count = count + 1
// }

// string syote = "";
// while (true)
// {
//     Console.Write("kirjoita sana ('lopeta' lopettaa): ");
//     syote = Console.ReadLine();

//     if (syote == "lopeta")
//     {
//         // lopetetaan looppi
//         break;
//     }
//     Console.WriteLine("sanoit: " + syote);
// }

for (int i = 0; i < 5; i++)
{
    if (i == 3)
    {
        continue;
    }
    Console.WriteLine(i);
}