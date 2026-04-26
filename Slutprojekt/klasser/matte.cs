
public class Matte
{
    public string kapitel = "Area uträkning";
}

public class Geometri : Matte
{
    public void intro()
    {
        Console.WriteLine($"vi ska göra en {kapitel} nu utan readlines så säger jag bredden är 5m och höjden 5m");
    }
}

public class Areademo : Geometri
{
    public void araedemo(int hojd, int bredd)
    {
        int area = hojd * bredd;
        Console.WriteLine("arean på vår fyrkant i det här fallet är " + area+"m^2");
    }
}