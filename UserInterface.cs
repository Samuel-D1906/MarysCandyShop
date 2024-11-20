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

            var usersChoice = Console.ReadLine()!.Trim().ToUpper();
            var menuMessage = "Press any key  To Go Back to Menu";

            switch (usersChoice)
            {
                case "A":
                    productsController.AddProduct();
                    Console.WriteLine(menuMessage);
                    break;
                case "D":
                    productsController.DeleteProduct("User chose D");
                    Console.WriteLine(menuMessage);
                    break;
                case "V":
                    var products = productsController.GetProducts();
                    ViewProducts(products);
                    break;
                case "U":
                    productsController.UpdateProduct("User chose U");
                    Console.WriteLine(menuMessage);
                    break;
                case "Q":
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

    internal static void ViewProducts(List<string> products)
    {
        Console.WriteLine(divide);

        foreach (var product in products)
        {
            Console.WriteLine(product);
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
            var menu = GetMenu();

            Console.WriteLine(title);
            Console.WriteLine(divide);
            Console.WriteLine("Today's date: " + dateTime);
            Console.WriteLine("Day's since opening: " + daysSinceOpening);
            Console.WriteLine("Today's profit: " + todayProfit + "$");
            Console.WriteLine("Today's target achieved: " + targetAchieved);
            Console.WriteLine(divide);
            Console.WriteLine(menu);
        }



    }

    private static string GetMenu()
    {
        var menu = "Choose one option:\n"
                   + 'V' + " to view products\n"
                   + 'A' + " to add products\n"
                   + 'D' + " to delete products\n"
                   + 'U' + " to update products\n"
                   + 'Q' + " to Quit \n";
        return menu;
    }
}
    
    