

public class Container<T>
{
    public T inneholl {get; set;}

    public static void Testdemo()
    {
        Console.WriteLine("Jag ska demonstrera en generisk klass. jag förstod det som ngn typ av klass som kan ta emot input av olika typer beronde på vad man väljer isch");
        Console.WriteLine("i alla fall så här är två variabler från samma klass men dem håller olika typer av input int och string");
        Console.WriteLine("man skulle nog kunna göra detta till något coolare men jag gjorde bara så här för att det var det jag förstod det som");
        Thread.Sleep(2000);
        var nummer = new Container<int>();
        nummer.inneholl = 42;

        var ord = new Container<string>();
        ord.inneholl = "pappa skämt";

        Console.WriteLine("jag la in två inputs en siffra och en text som sparas i två variabler som kommer från den här klassen");
        Console.WriteLine(nummer.inneholl);
        Console.WriteLine(ord.inneholl);
        
    }

}
