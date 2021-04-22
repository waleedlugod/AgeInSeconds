using System;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = Prompt.AskForInt("Enter year of birth:");
            int birthMonth = Prompt.AskForInt("Enter number of month of birth:", 1, 12);
            int birthDay = Prompt.AskForInt("Enter day of birth:", 1, 31);

            int seconds = Convert.AgeToSeconds(birthDay, birthMonth, birthYear);

            Console.WriteLine($"Your age in seconds: {seconds}");
        }
    }
}
