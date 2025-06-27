using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ST10442407_POE_PART_1
{
    class Reminder
    {
        public static List<string> TaskTitles = new List<string>();
        public static List<string> TaskDescriptions = new List<string>();
        public static List<int> Dates = new List<int>();

        public void addTask()
        {
            string title = "", description = "";

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Add Task");
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.Write("Task title: ");
            title = Console.ReadLine();

            Console.Write("Task description: ");
            description = Console.ReadLine();

            Console.Write("Would you like a reminder? ");
            string Date = Console.ReadLine();
            
            if ((Date.ToLower().Contains("remind") || Date.ToLower().Contains("yes")))
            {
                for (int i = 0; i < Date.Length; i++)
                {
                    if (Char.IsDigit(Date[i]))
                    {
                        Console.WriteLine("Date found: " + Date[i]);
                        Dates.Add(Int32.Parse(Date[i].ToString()));
                    }
                }
            } else { Dates.Add(0);  }

                try
                {
                    TaskTitles.Add(title);
                    TaskDescriptions.Add(description);

                    Console.WriteLine("Task successfully added\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong\n");
                }
        }

        public void deleteTask(int index) 
        {
            for (int i = TaskTitles.Count - 1; i >= 0; i--)
            {
                if ((i + 1) == index)
                {
                    TaskTitles.RemoveAt(index -1 );
                    TaskDescriptions.RemoveAt(index -1);
                    Dates.Remove(index -1);
                }
            }

            Console.WriteLine("Task successfully deleted\n");
        }

        public void viewTasks()
        {
            if (TaskTitles.Count.Equals(0))
            {
                Console.WriteLine("List is currently empty\n");
            }
            else
            {

                for (int i = 0; i < TaskTitles.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". Title: " + TaskTitles[i]);
                    Console.WriteLine("Description: " + TaskDescriptions[i] + "");

                    if (!Dates[i].Equals(0))
                    {
                        Console.WriteLine("Got it! I'll reminded you in " + Dates[i] + " days.");
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                }
            }
        }
    }
}
