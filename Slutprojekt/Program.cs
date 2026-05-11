
Iformen f = new();

// här är själva loopen för programmet Som går i ordningen.  Meny -> val -> visar dem kriterierna ->starta om loopen
string C = "_C nivå";
while (true)
{
    Console.WriteLine("skriv vilken kriterie grupp du vill köra från menyn.");
    Console.WriteLine(@$"
0 - EXIT
1 - Teori{C}
2 - Generisklass{C}");


    string val = Console.ReadLine();//input för vad som ska köras
    //Så här är den underbara if-sats ormen som bestömmer vad som ska köras
    if (val == "0") { break; }
    else if (val == "1") { f.Körareademo(); }
    else if (val == "2") { Container<string>.Testdemo(); }
    else if (val == "3")
    {
        // Motorcykel motorcykel = new Kawasaki();
        // motorcykel.Stegra();
        Info info = new();
        info.AddFordon();
        info.showlist();
        info.slangabens();

    }
    else
    {
        Console.WriteLine("Du måste skriva in en siffra från menyn för att komma vidare!");
    }
}
