using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeInSeconds
{
    public static class Prompt
    {
        public static int AskForInt(string prompt, int min, int max)
        {
            int result;

            do
            {
                result = AskForInt(prompt);

                if (result < min)
                {
                    Console.WriteLine("Value too small");
                }
                else if (result > max)
                {
                    Console.WriteLine("Value too big");
                }
            } while (result < min || result > max);

            return result;
        }

        public static int AskForInt(string prompt)
        {
            int result;
            bool isValid;

            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
            } while (!isValid);

            return result;
        }
    }
}
