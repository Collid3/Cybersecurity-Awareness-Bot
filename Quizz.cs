using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ST10442407_POE_PART_1
{
    class Quizz
    {
        string[] quizzQuestions = { "What is cybersecurity?", "What are some common threats of cyber threats?", "What is a phishing attack", "What are some basic password security practices", "What is a firewall?", "What should you do when you receive an email asking for your credentials or to download an application to get rid of an unknown virus installed in your system"};
        string[][] quizzOptions =
        {
            new [] {"Practice of protecting a building from criminals", "Practice of protecting systems and networks from unauthorized access", "Software used to encrypt data over the network", "None of the above"},
            new [] {"Emails and passwords", "Antivirus and VPN", "Viruses and Worms", "Websites and Softwares" },
            new [] {"Attack where a usb is plugged into your system to gain information", "Attack where an attacker steal your phone to gain information", "Attack where an attacker impersonate a trusted entity to gain information", "None of the above"},
            new [] {"Using your birthday as password to never forget", "Sharing with your friends in case you don't remember it", "Using unique passwords for different accouts", "Using the same password for all accounts"},
            new [] {"A device that block unauthorized access", "A device that allows your internet activities to be untraceable", "When the building wall is set on fire by attackers", "A wall used to block criminals from entering the building" },
            new [] {"Enter password to get rid of the virus", "Downlaod and install the application", "Ignore and delete email", "Report the email as phishing attack"},
        };

        int[] answers = { 2, 3, 3, 3, 1, 4 };
        string[] responses = { "Cybersecurity helps in protecting systems, networks, programs, and data from cyberattacks and unauthorized access.", "Viruses and worms are malicious softwares used to harm computer systems.", "In a phishing attack actors trick individuals into revealing sensitive information by appearing to be a legitimate source.", "It is a good practice to use unique passwords in case your password is compromised, to prevent an attacker to access all accounts.", "A firewall is a device that acts as a barrier between trusted internal network and untrusted external network to prevent unauthorized access, cyberattacks, and data breaches.", "Reporting phishing emails helps in preventing scams." };
        int score = 0;

        public int playQuizz()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Cyber security Quizz. Select a number 1-4 to answer the questions");
            Console.WriteLine("-----------------------------------------------------------------------------------\n");

            for (int i = 0; i < quizzQuestions.Length; i++)
            {
                Console.WriteLine(quizzQuestions[i]);
                string response = "";

               
                    for (int j = 0; j < quizzOptions[i].Length; j++)
                    {
                        Console.WriteLine((j + 1) + ". " + quizzOptions[i][j]);
                    }

                    Console.Write("Answer: ");
                    response = Console.ReadLine();
                bool answered = false;

                do
                {
                    if (Regex.IsMatch(response, @"\d"))
                    {
                        if (Int32.Parse(response).Equals(answers[i]))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Correct! ");
                            Console.ResetColor();
                            Console.Write(responses[i] + "\n");
                            Console.WriteLine();
                            score += 1;
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Incorrect! ");
                            Console.ResetColor();
                            Console.Write(responses[i] + "\n");
                            Console.WriteLine();
                        }

                        answered = true;
                    } else
                    {
                        Console.WriteLine("Invalid option try again");
                        Console.Write("Answer: ");
                        response = Console.ReadLine();
                    }
                } while (!answered);
            }

            return score;
        }

        public string generateScore(int scoreObtained)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Final score " + scoreObtained + " / 6");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            if (scoreObtained < 4)
            {
                return "Keep learning to stay safe online!";
            } else if (scoreObtained <= 5 )
            {
                return "Great job! You are a cybersecurity pro!";
            } else
            {
                return "Excelent work! You are a cybersecurity expert!";
            }
        }

    }
}
