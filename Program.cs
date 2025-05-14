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
string username = Console.ReadLine();

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

// user query
Console.Write("> ");
string response = Console.ReadLine();

if (response == "")
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid input, please rephrase");
        Console.ResetColor();
        Console.Write("> ");
        response = Console.ReadLine();
    }
    while (response == "");
}

string[] topics = { "phishing", "password", "browsing", "your purpose", "how are you", "ask you about", "help" };

string[] phishingResponses = { "Phishing uses scam emails to convince users to click on a malicious attachment or link to steal information or install viruses on your device", "Phishing attacks may claim there is a problem with your account and ask you to verify information, or offer \"special offer\" that requires you to click a link and enter sensitive information which may then be used against you. Beware." };
string[] passwordResponses = { "You are adviced to create a strong password that is atleast 8 characters long and includes special characters and numbers, as attackers can crack weak or easily guessable passwords", "It is safe to regularly change your password every once in a while and enable a multi-factor authentification when available" };
string[] browsingResponses = { "To browse safely on the internet, make sure you are using a secure internet connection, enable multi-factor authentication, and use a strong password", "Ensure that the software you are using and the operating system is updated, check for the reliability of the website, and last but not least, understand the privacy policy and review your privacy settings" };
string[] purposeResponses = { "My main purpose is to help you understand the importance of cyber security and how to keep safe in the digital world!" };
string[] howAreYouResponses = { "I am supercalifragilisticexpialidocious thanks :)", "I am having a blissful time thanks for asking and i hope you are too :)" };
string[] helpResponses = { "You can ask about Cybersecurity related topics including password safety, phishing, safe browsing, and more. Try asking about phishing to get knowledge", "Apart from asking cybersecurity related questions, you can ask me how i am and i will let you know." };

List<string[]> answers = new List<string[]>();

answers.Add(phishingResponses);
answers.Add(passwordResponses);
answers.Add(browsingResponses);
answers.Add(purposeResponses);
answers.Add(howAreYouResponses);
answers.Add(helpResponses);
answers.Add(helpResponses);

// follow-up responses
string[] phishingFollowUp = { "Phishing is basically a form of social engeneering and a scam where attackers decieve people into revealing sensitive information or installing malwares such as viruses through a dull clickable link" };
string[] passwordFollowUp = { "You should basically never reveal your password to anyone and create a strong password that is not guessable. To be fully secured, you can also use a multi-factor authentification that sends a code to your phone or email after entering the password." };
string[] browsingFollowUp = { "You should be cautious about visiting websites with untrusted sources and also the wifi network you are connected to. To stay safe online, a VPN is a good choice as it can protect your data from prying eyes." };
string[] purposeFollowUp = { "To fully understand what i do, ask me any cybersecurity related topics like password safety and phishing." };

List<string[]> followUpResponses = new List<string[]>();

followUpResponses.Add(phishingFollowUp);
followUpResponses.Add(passwordFollowUp);
followUpResponses.Add(browsingFollowUp);
followUpResponses.Add(purposeFollowUp);

string output = "";
int answer = -1;

// Mood detector 
string[] mood = { "worried", "curious", "frustrated" };

// interest
//string interest = "";

do
{


    for (int i = 0; i < topics.Length; i++)
    {


        if (response.ToLower().Contains("more details"))
        {
            output = followUpResponses[answer][0];
            answer = -1;
        }

        else if (response.ToLower().Contains(topics[i]))
        {
            Random rand = new Random();
            output = answers[i][rand.Next(answers[i].Length)];
            answer = i;
        }
    }

    if (output == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nSorry I didn't understand that, please rephrase");
        Console.ResetColor();
        Console.Write("> ");
        response = Console.ReadLine();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(output);

        Console.ResetColor();
        output = "";
        Console.ForegroundColor = ConsoleColor.Yellow;

        if (!answer.Equals(-1) && answer <= 3 ) {
            Console.WriteLine("\nEnter \"more details\" for more details or a topic you would like to know about");
        } else
        {
            Console.WriteLine("What do you want to know about?");
        }
        Console.ResetColor();
        Console.Write("> ");
        response = Console.ReadLine();
    }

} while (true);
