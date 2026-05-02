

public class Container<T>
{
    public T inneholl {get; set;}

    public static void Testdemo()
    {
        var nummer = new Container<int>();
        nummer.inneholl = 42;

        var ord = new Container<string>();
        ord.inneholl = "pappa skämt";

        //lite yap om vad jag gjort
        Console.WriteLine("jag la in två inputs en siffra och en text som sparas i två variabler som kommer från den här klassen");
        // skriver ut vad som ligger i dem variablerna jag skapade med olika innehål trots dem har "" samma orgin
        Console.WriteLine(nummer.inneholl);
        Console.WriteLine(ord.inneholl);
        Console.WriteLine("");
        Console.WriteLine("Eller här har jag gjort en lista med en generisk klass som håller årtal som exempel");

        // Hör gjorde jag en till generisk klass
        List<string> årtal = new List<string>();
        årtal.Add("2007");
        årtal.Add("2006");

    }

}
