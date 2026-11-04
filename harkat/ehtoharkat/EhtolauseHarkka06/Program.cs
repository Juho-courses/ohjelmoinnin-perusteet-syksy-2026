// Kirjoita ohjelma, joka kysyy käyttäjältä mitä tahansa tekstiä
// • Ohjelma tulostaa “Kiva juttu! Kirjoitit <määrä> merkkiä pitkän tekstin!”
// • <määrä> korvataan käyttäjän antaman syötteen pituudella

Console.Write("kirjoita mitä vaan (ja paina entteriä): ");

string user_input = Console.ReadLine();

Console.WriteLine("Kiva juttu! Kirjoitit " + user_input.Length + " merkkiä pitkän tekstin!");