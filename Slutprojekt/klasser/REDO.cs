

public class Fysik
{
    public List<Chapter> kapitel = [];

}

public class Chapter
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














// Mattebok mb = new();
// mb.kapitel.Add(new Kapitel() { Name = "Geomtri" });
// mb.kapitel[0].Name = "";
