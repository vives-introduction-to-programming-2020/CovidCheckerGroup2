using System;

namespace CovidCheckerGroup2
{
    class Program
    {

        public static double RequestUserTemperature()
        {
            Console.Write("Please enter your current temperature: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static bool RequestHasSymptoms()
        {
            Console.Write("Do you have any symptoms [yes/no]");
            string userAnswer = Console.ReadLine();

            // if (userAnswer == "yes") {
            //   return true;
            // }
            // else {
            //   return false;
            // }

            return (userAnswer == "yes");
        }

        public static void AssessTemperature(double temperature, bool hasSymptoms)
        {
            // if (temperature >= 38) {
            //   Console.WriteLine("You may have covid. You have a fever.");
            // }
            // else {
            //   if (temperature >= 36.7) {
            //     Console.WriteLine("You might be sick");
            //   }
            //   else {
            //     Console.WriteLine("All is fine");
            //   }
            // }

            // EQUIVALENT:
            // Order is important !!!
            if (hasSymptoms && (temperature >= 38))
            {
                Console.WriteLine("You have covid. You have a fever.");
            }
            else if (temperature >= 38)
            {
                Console.WriteLine("Please see a doctor. You have a fever.");
            }
            else if (temperature >= 36.7)
            {
                Console.WriteLine("You might be sick");
            }
            else
            {
                Console.WriteLine("All is fine");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to covid checker");

            double temperature = RequestUserTemperature();
            bool hasSymptoms = RequestHasSymptoms();

            AssessTemperature(temperature, hasSymptoms);
        }
    }
}
