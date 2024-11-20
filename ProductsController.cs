namespace MarysCandyShop;

public class ProductsController
{

    internal List<string> GetProducts()
    {
        var products = new List<string>();
        try
        {
            using StreamReader reader = new(Configuration.docPath);
            var line = reader.ReadLine();
            while (line != null)
            {
                products.Add(line);
                line = reader.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(UserInterface.divide);

        }
        return products;
    }
    
    internal void AddProduct()
    {
        Console.WriteLine("Product name:");
        var product = Console.ReadLine();
        try
        {
            using (StreamWriter outputFile = new(Configuration.docPath))
            {
         
                
                outputFile.WriteLine(product!.Trim(), true);
                
            }

            Console.WriteLine("Product saved");

        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error saving products: " + ex.Message);

        }
    }
    
    internal void AddProducts(List<string> products)
    {
        
        try
        {
            using (StreamWriter outputFile = new(Configuration.docPath))
            {

                foreach (var product in products)
                {
                    outputFile.WriteLine(product.Trim());
                }
                
                
            }

            Console.WriteLine("Product saved");

        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error saving products: " + ex.Message);

        }
    }
    
    internal void DeleteProduct(string message)
    {
        Console.WriteLine(message);
    }
    
    internal void UpdateProduct(string message)
    {
        Console.WriteLine(message);
    }
    
}