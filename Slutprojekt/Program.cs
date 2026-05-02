

// Startup visas en gång i början bara för en kort introduktion
Startup intro = new Startup();
intro.Test();// körs utanför sjölva loopen för att det är bara för att förklara programmet inte viktigt




// här är själva loopen för programmet Som går i ordningen.  Meny -> val -> visar dem kriterierna ->starta om loopen
string C = "_C nivå"; // bara för att spara text haha
while (true)
{
    Console.WriteLine("skriv vilken kriterie grupp du vill köra från menyn.");
    Console.WriteLine(@$"
0 - EXIT
1 - Teori{C}
2 - Generisklass{C}");


    string val = Console.ReadLine();//input för vad som ska köras
    //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
    //Så här är den underbara if-sats ormen som bestömmer vad som ska köras
    if (val == "0")
    {
        break;
    }
    else if (val == "1")
    {
        Iformen.Körareademo();
    }
    else if (val == "2")
    {
        Container<string>.Testdemo();
    }
    else
    {
        Console.WriteLine("Du måste skriva in en siffra från menyn för att komma vidare!");
    }
}
