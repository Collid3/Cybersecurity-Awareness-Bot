using System.Media;


// Welcome tome
if (OperatingSystem.IsWindows())
{
    SoundPlayer player = new SoundPlayer("Intro.wav");
    player.Play();
}

// Logo
string logo = "  *****";

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
//Console.ResetColor();
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        //Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|" + logo.Substring(i, i + 3) + "  | Cybersecurity |" + logo.Substring(i, i + 3) + "  |");
    }
    else if (i == 1)
    {
        Console.WriteLine("|" + logo.Substring(i, i + 3) + " |   Awareness   |" + logo.Substring(i, i + 3) + " |");
    }
    else
    {
        Console.WriteLine("|" + logo.Substring(i, i + 3) + "|      Bot      |" + logo.Substring(i, i + 3) + "|");
    }
}

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.ResetColor();

// Border
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

Console.Write("Username: ");
String username = Console.ReadLine();

if (username == "")
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid username input, Please rephrase");
        Console.ResetColor();
        Console.Write("Username: ");
        username = Console.ReadLine();
    } while (username == "");
}

// Border
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

// Welcome message
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(String.Format($"\nGreetings {username.ToUpper()}, What topic would you like to know about"));
Console.WriteLine("Topics includes phishing, safe passwords, and last but not least, safe browsing techniques");
Console.ResetColor();

