string docPath = @"C:\Users\Delac\dev\Private Projekte\history.txt";
var isMenuRunning = true;
var products = new Dictionary<int, string>();
var candyNames = new List<string> {"Rainbow Lollipops", "Cotton Candy Clouds", "Choco-Caramel Delights"};
//ViewProduct();

if (File.Exists(docPath))
{
    LoadData();
}
while (isMenuRunning)
{
    PrintHeader();

    var usersChoice = Console.ReadLine()!.Trim().ToUpper();
    var menuMessage = "Press any key  To Go Back to Menu";

    switch (usersChoice)
    {
        case "A":
            AddProduct();
            Console.WriteLine(menuMessage);
            break;
        case "D":
            DeleteProduct("User chose D");
            Console.WriteLine(menuMessage);
            break;
        case "V":
            ViewProduct();
            break;
        case "U":
            UpdateProduct("User chose U");
            Console.WriteLine(menuMessage);
            break;
        case "Q":
            Console.WriteLine("Goodbye");
            SaveProducts();
            isMenuRunning = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please choose one of the above");
            break;
    }

    
    Console.ReadKey();
    Console.Clear();

    
}

void AddProduct()
{
    Console.WriteLine("Product name:");
    var product = Console.ReadLine();
    var index = products.Count;
    if (product != null) products.Add(index, product.Trim());
}

void DeleteProduct(string message)
{
    Console.WriteLine(message);
}

void ViewProduct()
{
    for (int i = 0; i < candyNames.Count; i++)
    {
        products.Add(i, candyNames[i]);
    }
}

void UpdateProduct(string message)
{
    Console.WriteLine(message);
}

void PrintHeader()
{
    {
        const string title = "Mary's Candy Shop";
        const string divide = "------------------";
        var dateTime = DateTime.Now;
        const decimal todayProfit = 5.5m;
        const bool targetAchieved = false;
        var daysSinceOpening = GetDaysSinceOpening();
        var menu = GetMenu();

        Console.WriteLine(title);
        Console.WriteLine(divide);
        Console.WriteLine("Today's date: " + dateTime);
        Console.WriteLine("Day's since opening: " + daysSinceOpening);
        Console.WriteLine("Today's profit: " + todayProfit +"$");
        Console.WriteLine("Today's target achieved: " + targetAchieved);
        Console.WriteLine(divide);
        Console.WriteLine(menu);
    }

    int GetDaysSinceOpening()
    {
        var openingDate = new DateTime(2023, 1, 1);
        var timeDifference = DateTime.Now - openingDate;
        return timeDifference.Days;
    }

    String GetMenu()
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

void SaveProducts()
{
    using (StreamWriter outputFile = new (docPath))
    {
        foreach (KeyValuePair<int, string> product in products)
        {
            outputFile.WriteLine($"{product.Key}. {product.Value}");
        }
    }
    Console.WriteLine("Product saved");
}

void LoadData()
{
    using (StreamReader reader = new (docPath))
    {
        var line = reader.ReadLine();
        while (line != null)
        {
            string[] parts = line.Split('.');
            products.Add(int.Parse(parts[0]), parts[1]);
            line = reader.ReadLine();
        }
    }
}