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


