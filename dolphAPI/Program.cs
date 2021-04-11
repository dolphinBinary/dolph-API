using System;
using dolphLib;

namespace dolphAPI
{
    static class Program
    {
        public static void Main()
        {
            // N number
            Console.WriteLine("Enter number of departments: ");
            var departmentNumber = Checker.ParseIntOrReturn0(Console.ReadLine());
            
            var departmentRules = new int[departmentNumber]; // Array with absolute rules
            var rulesElse = new int[departmentNumber]; // Array with conditional rules
            // Configure department rules
            for (var i = 0; i < departmentNumber; i++)
            {
                Console.WriteLine("Enter number of absolute or conditional rule \n Set absolute rule: \n \n 1) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 2) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 3) Send Vasya to the next department K. \n \nSet conditional rule: \n If the bypass sheet has an uncrossed N stamp, then: \n 4) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 5) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 6) Send Vasya to the next department K.");
                var rule = Checker.ParseIntOrReturn0(Console.ReadLine());
                departmentRules[i] = ReturnAbsOrCondRule(rule);
                rulesElse[i] = ReturnElseRule(rule);
            }
            Printer(departmentRules, rulesElse);
        }
        
        // Method which configure absolute or conditional rule
        private static int ReturnAbsOrCondRule(int rule)
        {
            if (rule is > 0 and < 7)
            {
                return rule;
            }
            return 0;
        }
        
        // Method which configure else rule 
        private static int ReturnElseRule(int rule)
        {
            if (rule is > 3 and < 7)
            {
                Console.WriteLine(
                    "\n \n Input else rule \n \n 7) Put a new stamp T if it does not already exist (or is crossed out) or do not put any. \n 8) Cross out the existing R stamp if it already exists (or not) or do not cross out any. \n 9) Send Vasya to the next department P. \n");
                var temporaryRule = Checker.ParseIntOrReturn0(Console.ReadLine());
                if (temporaryRule is > 6 and < 10)
                {
                    return temporaryRule;
                }
            }
            return 0;
        }
        
        // Print Library and API output 
        private static void Printer(int[] departmentRules, int[] rulesElse)
        {
            Console.WriteLine("Defined configuration \n");
            for (var i = 0; i < departmentRules.Length; i++)
            {
                Console.Write($"| {departmentRules[i]} ");
                Console.Write($" {rulesElse[i]} ");
            }

            Console.WriteLine("\n");
            // Configurator.RuleParser(departmentRules, rulesElse);
            Console.WriteLine("\n Output of the bypass sheet filled with stamps");
            for (var i = 0; i < departmentRules.Length; i++)
            {
                Console.Write($"| {Configurator.RuleParser(departmentRules, rulesElse)[i]} ");
            }
        }
    }
}