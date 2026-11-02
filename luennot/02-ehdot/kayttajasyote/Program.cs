Console.Write("Kirjot nimes: ");

string nimi = Console.ReadLine();

if (nimi.Length == 4)
{
    Console.WriteLine("neljä merkkii pitkä");
}
else
{
    Console.WriteLine("Moro " + nimi + "!");
}
