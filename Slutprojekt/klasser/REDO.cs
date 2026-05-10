

public class Info
{
    public List<Bil> Cars = [];
    public List<Motorcykel> Motos = [];

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

    
    

    
}

public class Bil: Fordon
{

    private int _hp;
    public int hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if(value != 0) _hp = value;
        }
    }
    
}


public class Motorcykel: Fordon
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
            if(value != 0) _kubik = value;
        }
    }

}

public class Kawasaki: Motorcykel
{
    private int 
    
}












// Mattebok mb = new();
// mb.kapitel.Add(new Kapitel() { Name = "Geomtri" });
// mb.kapitel[0].Name = "";
