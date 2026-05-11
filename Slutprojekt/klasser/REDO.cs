

public class Info
{
    public List<Motorcykel> Motos = [];

    public void AddFordon()
    {
        string val = "";
        Console.WriteLine("Välj vilken motorcykel du vill lägga till 1(Kawasaki) 2(Äcklig Harley)");
        while (true)
        {

            string tmp = Console.ReadLine();
            if (tmp == "1")
            {
                Console.WriteLine("du valde kawasaki");
                val = tmp;
                break;
            }
            else if (tmp == "2")
            {
                Console.WriteLine("du valde ew harley...");
                val = tmp;
                break;
            }
            else
            {
                Console.WriteLine("test3 fail");
            }
        }
        if (val == "1")
        {
            Motos.Add(new Kawasaki() { name = "Ninja", });
            Motos.Add(new Harley() { name = "tjockis", });
        }
        else if (val == "2")
        {
            Motos.Add(new Harley() { name = "tjockis", });
            Motos.Add(new Kawasaki() { name = "Ninja", });
        }
    }

    public void showlist()
    {
        Console.WriteLine("i din lista/garage ligger en " + Motos[0]);
        Console.WriteLine("Den har " + Motos[0].kubik + "-kubik och är av modelen " + Motos[0].name);
        Console.WriteLine("det ligger även en " + Motos[1]);
        Console.WriteLine("Den har " + Motos[1].kubik + "-kubik och är av modelen " + Motos[1].name);
    }

    public void slangabens()
    {
        if (Motos.Count >= 2)
        {
            Motos[0].fuel += Motos[1].fuel;
            Motos[1].fuel -= Motos[1].fuel;
            Console.WriteLine("Vi slanga bensin från din första mc till andra nu är deras respektive fuellevel är " + Motos[0].fuel + " och " + Motos[1].fuel);
            Console.WriteLine("sen ger vi tillbaka det");
            Motos[1].fuel += Motos[0].fuel;
            Motos[0].fuel -= Motos[0].fuel;
            Console.WriteLine("nu är deras respektive fuellevel är " + Motos[0].fuel + " och " + Motos[1].fuel);

        }


    }

}

public class Fordon
{
    private string _name = "";
    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value != "") _name = value;
        }
    }
    private int _fuel;
    public int fuel
    {
        get
        {
            return _fuel;
        }
        set
        {
            if (value >= 0) _fuel = value;
        }
    }


}

public class Motorcykel : Fordon
{

    private int _kubik;
    public int kubik
    {
        get
        {
            return _kubik;
        }
        set
        {
            if (value != 0) _kubik = value;
        }
    }
}

public class Kawasaki : Motorcykel
{
    public Kawasaki()
    {
        kubik = 1000;
        fuel = 500;
        Console.WriteLine("fuel är " + fuel);
    }
}
public class Harley : Motorcykel
{
    public Harley()
    {
        kubik = 1600;
        fuel = 1000;
        Console.WriteLine("fuel är " + fuel);
    }
}
