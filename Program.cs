using ST10442407_POE_PART_1;
using System.Media;
using System.Numerics;
using System.Text.RegularExpressions;


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
Console.WriteLine(String.Format($"\nGreetings to you, {username.ToUpper()}"));
Console.ResetColor();

// user query
string response = "";
void menu ()
{
    Console.Write("Ask me anything or select a number from the menu below\n1. Add a Task\n2. View Tasks\n3. Delete tasks\n5. Play a quizz\n> ");
    response = Console.ReadLine();
    Console.WriteLine();
}
menu();

// Invalid input handler
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
string interest = "";

do
{
    string moodResponse = "";

    if (Regex.IsMatch(response, @"\d"))
    {
        int selectedMenu = Convert.ToInt32(response);
        var reminder = new Reminder();

        switch (selectedMenu)
        {
            case 1:
                reminder.addTask();
                menu();
                break;

            case 2:
                reminder.viewTasks();
                menu();
                break;

            case 3:
                reminder.viewTasks();
                Console.Write("Select the number of the task you want to delete: ");

                int GetNumberFromString(string index)
                {
                    Regex number = new Regex("[0-9][0-9]?");
                    Match n = number.Match(index);
                    if (n.Value != "")
                        return System.Convert.ToInt32(n.Value, 10);
                    else
                        return -1;
                }


                while (true)
                {
                    string index = Console.ReadLine();
                    int indexOfTask = GetNumberFromString(index);

                    if (!indexOfTask.Equals(-1))
                    {
                        reminder.deleteTask(indexOfTask);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of the task to delete. Try again");
                    }
                }
                menu();
                break;

            case 5:
                var quizz = new Quizz();
                quizz.playQuizz();
                menu();
                break;
        }
    }
    else
    {
        for (int i = 0; i < topics.Length; i++)

        {
            if (i <= 2 && response.ToLower().Contains(mood[i]))
            {
                moodResponse = "I understand why you feel that way. It could be difficult in the digital world. But let me share some tips with you to stay safe. \n";
            }

            if (response.ToLower().Contains("more details"))
            {
                output = followUpResponses[answer][0];
                answer = -1;
                break;
            }

            else if (response.ToLower().Contains("interested"))
            {
                interest = response.Substring(response.IndexOf("interested") + "interested".Length);
                output = "Great!. I will remember that you are interested in " + interest;
                answer = -1;
                break;
            }

            else if (response.ToLower().Contains(topics[i]))
            {
                Random rand = new Random();
                output = moodResponse + answers[i][rand.Next(answers[i].Length)];
                answer = i;
                break;
            }

            else if (!moodResponse.Equals(""))
            {
                output = moodResponse;
            }
        }

        if (output == "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSorry I didn't understand that, please rephrase");
            Console.ResetColor();
            menu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(output);

            // check if there is interest and randomly display it
            new DisplayInterestMessage(interest);

            Console.ResetColor();
            output = "";
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (!answer.Equals(-1) && answer <= 3 && moodResponse.Equals(""))
            {
                Console.WriteLine("\nEnter \"more details\" for more details or a topic you would like to know about");
            }
            else
            {
                Console.WriteLine("What do you want to know about?");
            }
            Console.ResetColor();
            menu();
        }
    }

} while (true);
