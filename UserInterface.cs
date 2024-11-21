using System.Reflection.Metadata;
using Spectre.Console;

namespace MarysCandyShop;

public static class UserInterface
{
    internal const string divide = "------------------";

    internal static void RunMainMenu()
    {
        var productsController = new ProductsController();
        var isMenuRunning = true;
        while (isMenuRunning)
        {
            PrintHeader();

            var usersChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.MainMenuOptions>().Title("What would you like to do?").AddChoices(
                    Enums.MainMenuOptions.ViewProducts,
                    Enums.MainMenuOptions.AddProduct,
                    Enums.MainMenuOptions.UpdateProduct,
                    Enums.MainMenuOptions.DeleteProduct,
                    Enums.MainMenuOptions.QuitProgram));
            var menuMessage = "Press any key  To Go Back to Menu";

            switch (usersChoice)
            {
                case Enums.MainMenuOptions.AddProduct:
                    var product = GetProductInput();
                    productsController.AddProduct(product);
                    Console.WriteLine(menuMessage);
                    break;
                case Enums.MainMenuOptions.DeleteProduct:
                    productsController.DeleteProduct("User chose D");
                    Console.WriteLine(menuMessage);
                    break;
                case Enums.MainMenuOptions.ViewProducts:
                    var products = productsController.GetProducts();
                    ViewProducts(products);
                    break;
                case Enums.MainMenuOptions.UpdateProduct:
                    productsController.UpdateProduct("User chose U");
                    Console.WriteLine(menuMessage);
                    break;
                case Enums.MainMenuOptions.QuitProgram:
                    Console.WriteLine("Goodbye");
                    isMenuRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose one of the above");
                    break;
            }


            Console.ReadKey();
            Console.Clear();


        }
    }

    internal static void ViewProducts(List<Products> products)
    {
        Console.WriteLine(divide);

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id},{product.Name}, {product.Price},");
        }
        Console.WriteLine(divide);
    }

    internal static void PrintHeader()
    {
        {
            const string title = "Mary's Candy Shop";
            const string divide = "------------------";
            var dateTime = DateTime.Now;
            const decimal todayProfit = 5.5m;
            const bool targetAchieved = false;
            var daysSinceOpening = Helpers.GetDaysSinceOpening();
            

            Console.WriteLine(title);
            Console.WriteLine(divide);
            Console.WriteLine("Today's date: " + dateTime);
            Console.WriteLine("Day's since opening: " + daysSinceOpening);
            Console.WriteLine("Today's profit: " + todayProfit + "$");
            Console.WriteLine("Today's target achieved: " + targetAchieved);
            Console.WriteLine(divide);
            
        }



    }

    private static Products GetProductInput()
    {
        Console.WriteLine("Product name:");
        var name = Console.ReadLine();
        
        Console.WriteLine("Product Price:");
        var price = decimal.Parse(Console.ReadLine()!);
        var type = AnsiConsole.Prompt(
            new SelectionPrompt<Enums.ProductType>().Title("Product Type")
                .AddChoices(
                    Enums.ProductType.Lollipop,
                    Enums.ProductType.ChocolateBar));
        if (type == Enums.ProductType.ChocolateBar)
        {
            Console.WriteLine("Cocoa %");
            var cocoa = int.Parse(Console.ReadLine()!);

            return new ChocolateBar()
            {
                Name = name,
                Price = price,
                CocoaPercentage = cocoa
            };
        }
        
        Console.WriteLine("Shape: ");
        var shape = Console.ReadLine();

        
                return new Lollipop
                {
                    Name = name,
                    Price = price,
                    Shape = shape
                };
    }

    
}
    
    