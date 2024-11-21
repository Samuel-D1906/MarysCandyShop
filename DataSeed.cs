namespace MarysCandyShop;

public class DataSeed
{
    string[] _candyNames = {"Rainbow Lollipops", "Cotton Candy Clouds", "Choco-Caramel Delights"};
    
    void SeedData()
    {

        var products = new List<Products>
        {
            new Products(1) { Name = _candyNames[0], Price = 10m },
            new Products(2) { Name = _candyNames[1], Price = 15m },
            new Products(3) { Name = _candyNames[2], Price = 20m },
        };
        var productsController = new ProductsController();
        productsController.AddProducts(products);
    }
}