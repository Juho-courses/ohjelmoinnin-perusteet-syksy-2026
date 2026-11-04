// Luo muuttuja, joka pitää tiedon moottorin tilasta
// • Moottori voi olla joko käynnissä tai ei käynnissä
bool isRunning = false;
// • Luo muuttuja, joka sisältää tiedon lämpötilasta
int temperature = 31;
// • Luo ehtolause, joka tarkastelee lämpötilaa
// • Jos lämpötila yli 30, käynnistä moottori (muuta muuttujan arvoa)
if (temperature > 30)
{
    isRunning = true;
}
// • Luo toinen ehtolause, joka tarkastelee moottorin tilaa
// • Jos moottori käynnissä, tulosta 'motor is running'
if (isRunning == true)
{
    Console.WriteLine("motor is running");
}
// • Jos moottori ei käy, tulosta 'motor not running'
else if (isRunning == false)
{
    Console.WriteLine("motor not running");
}
