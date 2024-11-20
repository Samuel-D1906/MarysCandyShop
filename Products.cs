namespace MarysCandyShop;

public class Products
{
    private string name;


    internal string GetName()
    {
        return name;
    }

    internal string SetName(string value)
    {
        name = value;
        return name;
    }
}