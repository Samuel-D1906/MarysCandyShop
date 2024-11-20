namespace MarysCandyShop;

public class DataSeed
{
    string[] _candyNames = ["Rainbow Lollipops", "Cotton Candy Clouds", "Choco-Caramel Delights"];
    
    void SeedData()
    {
        var productsController = new ProductsController();
        productsController.AddProducts(_candyNames.ToList());
    }
}