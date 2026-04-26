
// Startup visas en gång i början bara för en kort introduktion
Startup intro = new Startup();
intro.test();// körs utanför sjölva loopen för att det är bara för att förklara programmet inte viktigt



// här är själva loopen för programmet Som går i ordningen.  Meny -> val -> visar dem kriterierna ->starta om loopen
while (true)
{
    Console.WriteLine("skriv vilken kriterie grupp du vill köra obs om du skriver en bokstav osv så kör den om");
    Console.WriteLine(@"
1 - Teori_C-nivå");

    string val = Console.ReadLine();//input för vad som ska köras


//Så här är den underbara if-sats ormen som bestömmer vad som ska köras
    if (val == "1")
    {
        Körareademo();
    }
}

// här ligger koden som If-ormen använder för valje alternativ.
// Jag gör såhär så det inte blir full sprängt av kod i if ormen.
// så det ligger som skit vi inte rör längsttttt ned i programmet.
// det är inte alls optimiserat för att vara fint men skitsama.
static void Körareademo()
{
    Areademo demo = new Areademo();
    demo.intro();
    demo.araedemo(5,5);
    Console.WriteLine("Tryck vartsom för att starta menyn igen");
    Console.ReadKey(); Console.WriteLine("");
}