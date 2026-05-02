

// jag skrev den här skiten innan jag lärde mig jag kan direkt kalla på en klass som jag gör med alternativ 2 så det kommer inte läggas mer skit här.



public class Iformen
{
    public static void Körareademo()
    {
        //jag valde ju att skriva koden här. som gör en ny "Areademo" sen kör intro metoden och area metoden sen avslutar den visningen
        Areademo demo = new Areademo();
        demo.Intro();
        Thread.Sleep(2000);
        demo.Araedemo(5, 5);
        Thread.Sleep(2000);
        Console.WriteLine("Tryck vartsom för att starta menyn igen");
        Console.ReadKey(); Console.WriteLine("");
    }






}
