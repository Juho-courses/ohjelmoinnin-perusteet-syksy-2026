// 0123
string sana = "ohjelmointi";

for (int i = 0; i < sana.Length; i += 2)
{
    Console.Write(sana[i]);
}

Console.WriteLine();

int j = 0;
while (j < sana.Length)
{
    Console.Write(sana[j]);
    j = j + 2;
}