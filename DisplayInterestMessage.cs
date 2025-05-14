using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10442407_POE_PART_1
{
    class DisplayInterestMessage
    {
        public DisplayInterestMessage (string interest)
        {
            // random talks about interest
            bool[] displayRandomInterest = { false, false, true, false, false, true, false };

            Random rand2 = new Random();

            bool selectedValue = displayRandomInterest[rand2.Next(displayRandomInterest.Length)];

            if (!interest.Equals("") && selectedValue.Equals(true))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Plus as someone interested" + interest + ", it is always a great choice to stay safe online");
                Console.ResetColor();
            }

        }
}
}
