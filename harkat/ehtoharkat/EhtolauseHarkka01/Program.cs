// Luo muuttujat joihin tallennat ikäsi ja etunimesi
int age = 22;
string fname = "Liisa";
// • Luo ehtolause joka tarkistaa, että nimi ja ikä ovat samat kuin
// muuttujien arvot
// • Jos lause totta, tulosta 'moi <nimi>!'. (‘<nimi>' on muuttujan arvo)
// • Jos lause ei ole totta, tulosta 'henkilö ei tunnistettu'
if ((age == 22) && (fname == "Jaakko"))
{
    Console.WriteLine("moi " + fname + "!");
}
else
{
    Console.WriteLine("henkilö ei tunnistettu");
}
