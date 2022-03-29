namespace TestLab;

public class Shape
{
    private readonly string _name;

    public Shape(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        if (string.IsNullOrWhiteSpace(_name))
            throw new ArgumentNullException();
        
        return _name;
    }
}