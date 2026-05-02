

// jag skrev den här skiten innan jag lärde mig jag kan direkt kalla på en klass som jag gör med alternativ 2 så det kommer inte läggas mer skit här.



public class Iformen
{
    public static void Körareademo()
    {
        //jag valde ju att skriva koden här. som gör en ny "Areademo" sen kör intro metoden och area metoden sen avslutar den visningen
        Areademo demo = new Areademo();
        demo.Intro();
        Thread.Sleep(2000);
        Console.WriteLine("skriv höjd och bas en i taget och tryck enter efter vardera");
        int ans1clear;
        int ans2clear;
        while (true)
        {
            int.TryParse(Console.ReadLine(), out int ans1);
            int.TryParse(Console.ReadLine(), out int ans2);
            if(ans1 == 0 || ans2 == 0)
            {
                Console.WriteLine("Du måte skriva in en siffra på båda alternativen");
            }
            else
            {
                Console.WriteLine("du skrev två siffror yayy");
                Thread.Sleep(500);
                ans1clear = ans1;
                ans2clear = ans2;
                break;
            }
            
        }



        demo.Araedemo(ans1clear, ans2clear);
        Thread.Sleep(2000);
        Console.WriteLine("Tryck vartsom för att starta menyn igen");
        Console.ReadKey(); Console.WriteLine("");
    }






}
