
using System.Diagnostics.Metrics;
// det här kanske ser lite weird ut men det är lite som att öppna en bok vi öppnar Matte boken går till geometri kapitlet
// och räknar Area.


public class Mattebok
{
    public List<Kapitel> kapitel = [];
}

public class Kapitel
{
    //basicly innehåls förtäckning 
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            if (value != "") Name = value;
        }
    }
}

public class GeometriKapitel : Kapitel
{
    // här är introt till geometri kapitlet basicly där vi kör en kod som introducerar oss litegran.
    public void Intro()
    {
        Console.WriteLine("innan du läser vidare så är det här faktiskt arv i två led men extremt workaround");
        Console.WriteLine("...");
        Console.WriteLine($"vi ska göra en (<string från orginal klassen som körs i en metod i arv:1) nu");
    }
    public string enhet = "meter";
}

public class Areademo : GeometriKapitel
{
    public Areademo()
    {
        // Kapitel = "Areauträkning";
    }
    // här körs det lilla area uträkningen som en metod dock utan att vi bestämmer värdenna men det är bara onödigt...
    public void Araedemo(int hojd, int bredd)
    {
        int area = hojd * bredd;
        Console.WriteLine("arean på vår fyrkant i det här fallet är " + area + " kvadrat" + enhet + " (det här körs i arv:2)");
    }
}