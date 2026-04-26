
public class Matte
{
    public string kapitel = "Area uträkning";
}

public class Geometri : Matte
{
    public void intro()
    {
        Console.WriteLine("innan du läser vidare så är det här faktiskt arv i två led men extremt bullshit");
        Console.WriteLine("...");
        Console.WriteLine($"vi ska göra en {kapitel}(<string från orginal klassen som körs i en metod i arv:1) nu utan readlines så säger jag bredden är 5m och höjden 5m");
    }
}

public class Areademo : Geometri
{
    public void araedemo(int hojd, int bredd)
    {
        int area = hojd * bredd;
        Console.WriteLine("arean på vår fyrkant i det här fallet är " + area+"m^2 (det här körs i arv:2)");
    }
}