using System;
using System.Text.RegularExpressions;

namespace dolphAPI
{
    static class Program
    {

        public static void Main()
        {
            // N number
            Console.WriteLine("Enter number of departments: ");
            var depNum = Console.ReadLine();

            // Choose filling method
            Console.WriteLine("\nEnter number of the configuration filling method: \n 1) Manualy \n 2) Random");
            var numMethod = Console.ReadLine();

            Console.WriteLine(
                "Enter rules: in format: number of absolute rule (or number of conditional rule + else rule * 10) \nSet absolute rule: \n \n 1) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 2) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 3) Send Vasya to the next department K. \n \nSet conditional rule: \n If the bypass sheet has an uncrossed N stamp, then: \n 4) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 5) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 6) Send Vasya to the next department K. \n \nElse \n \n 7) Put a new stamp T if it does not already exist (or is crossed out) or do not put any. \n 8) Cross out the existing R stamp if it already exists (or not) or do not cross out any. \n 9) Send Vasya to the next department P.");
            var rule = Console.ReadLine();
            
            Console.WriteLine(Validation(depNum));
            
        }

        static bool Validation(string input)
        {
            Regex regex = new Regex(@"^[+]?[0-7]*\.?[0-7]+$");
            return regex.IsMatch(input);
        }
        
    }
}
