namespace MarysCandyShop;

public class ProductsController
{

    internal List<Products> GetProducts()
    {
        var products = new List<Products>();
        try
        {
            using StreamReader reader = new(Configuration.docPath);
            reader.ReadLine(); // discard firstline
            var line = reader.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split(',');
                var product = new Products(int.Parse(parts[0]));
                product.Name = parts[1];
                product.Price= decimal.Parse(parts[2]);
                
                products.Add(product);
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
    
    internal void AddProduct(Products product)
    {
        var id = GetProducts().Count;
        try
        {
            using (StreamWriter outputFile = new(Configuration.docPath, true))
            {

                if (outputFile.BaseStream.Length == 0)
                {
                    outputFile.WriteLine("Id,Type,Name,Price, CocoaPercentage, Shape");
                }

                var csvLine = $"{id}, {name}, {price}";
                outputFile.WriteLine(csvLine);
                
            }

            Console.WriteLine("Product saved");

        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error saving products: " + ex.Message);

        }
    }
    
    internal void AddProducts(List<Products> products)
    {
        
        try
        {
            using (StreamWriter outputFile = new(Configuration.docPath))
            {

                foreach (var product in products)
                {
                    outputFile.WriteLine($"{product.Id}, {product.Name}, {product.Price}");
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