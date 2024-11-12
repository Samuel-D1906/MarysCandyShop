// Variables

string title = "Mary's Candy Shop";
string divide = "------------------";
DateTime dateTime = DateTime.Now;
decimal todaysProfit = 5.5m;
bool targetAchieved = false;
int daysSinceOpening = 1;
string menu = "Choose one option:"
              + 'V' + "to view products\n"
              + 'A' + "to add products\n"
              + 'D' + "to delete products\n"
              + 'U' + "to update products\n";

Console.WriteLine(title);
Console.WriteLine(divide);
Console.WriteLine("Today's date: " + dateTime);
Console.WriteLine("Day's since opening: " + daysSinceOpening);
Console.WriteLine("Today's profit: " + todaysProfit +"$");
Console.WriteLine("Today's target achieved: " + targetAchieved);
Console.WriteLine(divide);
Console.WriteLine(menu);

var usersChoice = Console.ReadLine().Trim().ToUpper();
switch (usersChoice)
{
    case "A":
        Console.WriteLine("User chose A");
        break;
    case "D":
        Console.WriteLine("User chose D");
        break;
    case "V":
        Console.WriteLine("User chose V");
        break;
    case "U":
        Console.WriteLine("User chose U");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}