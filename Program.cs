// play audio
// display Ascii logo
// ask the user to enter name and display a personalised response
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
Console.ResetColor();
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
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
Console.ResetColor();

// user query
Console.Write("> ");
String response = Console.ReadLine();

if (response == "")
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input, please rephrase");
        Console.ResetColor();
        Console.Write("> ");
        response = Console.ReadLine();
    }
    while (response == "");
}

String[] topics = {"phishing", "password", "browsing", "how are you", "your purpose", "ask you about"};
String[] answers = {"Phishing uses scam emails to convince users to click on a malicious attachment or link to steal information or install viruses on your device", "Users are adviced to create strong password that are atleast 8 characters long and includes special characters and numbers, as attackers can crack weak or easily guessable passwords", "To browse safely on the internet, make sure you are using a secure internet connection, enable multi-factor authentication, ensure that the software you are using and the operating system are updated, check for the reliability of the website, and last but not least, understand the privacy policy and review your privacy settings", "I am supercalifragilisticexpialidocious thanks :)", "The main purpose of this software is to help you understand the importance of cyber security and how to keep safe in the digital world!", "You can ask about Cybersecurity related topics including password safety, phishing, safe browsing, and more."};
String output = "";

do
{
    for (int i = 0; i < topics.Length; i++)
    {
        if (response.ToLower().Contains(topics[i]))
        {
            output = answers[i];
        }
    }

    if (output == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sorry I didn't understand that, please rephrase");
        Console.ResetColor();
        Console.Write("> ");
        response = Console.ReadLine();
    } else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(output);
        Console.ResetColor();
        output = "";
        Console.WriteLine("\nWhat topic do you want to know about?");
        Console.Write("> ");
        response = Console.ReadLine();
    }

} while (true);