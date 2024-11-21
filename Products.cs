namespace MarysCandyShop;

internal class Products
{
    private string name;

    internal string Name { get; set; }
    internal decimal Price { get; set; }
    internal int Id { get; }
    
    internal Enums.ProductType Type { get; set; }

    internal Products()
    {
        
    }
    internal Products(int id)
    {
        Id = id;
    }
}

internal class ChocolateBar: Products
{
    internal int CocoaPercentage { get; set; }

    internal ChocolateBar()
    {
        
    }
    internal ChocolateBar(int id) : base(id)
    {
        Type = Enums.ProductType.ChocolateBar;
    }
}

internal class Lollipop: Products
{
    internal string Shape { get; set; }

    internal Lollipop()
    {
        
    }
    internal Lollipop(int id) : base(id)
    {
        Type = Enums.ProductType.Lollipop;
    }
}

    

    