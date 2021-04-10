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
            var depNum = Configurator.ParseIntOrReturn0(Console.ReadLine());

            
            var depRules = new int[depNum]; // Array with absolute rules
            var rulesElse = new int[depNum]; // Array with conditional rules
            // Configure department rules
            for (int i = 0; i < depNum; i++)
            {
                Console.WriteLine("Enter number of absolute or conditional rule \n Set absolute rule: \n \n 1) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 2) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 3) Send Vasya to the next department K. \n \nSet conditional rule: \n If the bypass sheet has an uncrossed N stamp, then: \n 4) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 5) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 6) Send Vasya to the next department K.");
                var rule = Configurator.ParseIntOrReturn0(Console.ReadLine());
                depRules[i] = rule;
                
                rulesElse[i] = ReturnTempRule(rule);
                
            }
            Printer(depRules, rulesElse);
        }
        
        // Method which configure else rule 
        private static int ReturnTempRule(int rule)
        {
            if (rule is > 3 and < 7)
            {
                Console.WriteLine(
                    "\n \n Input else rule \n \n 7) Put a new stamp T if it does not already exist (or is crossed out) or do not put any. \n 8) Cross out the existing R stamp if it already exists (or not) or do not cross out any. \n 9) Send Vasya to the next department P. \n");
                var tempRule = Configurator.ParseIntOrReturn0(Console.ReadLine());
                if (tempRule is > 6 and < 10)
                {
                    return tempRule;
                }
            }
            return 0;
        }
        

        // Print Library and API output 
        private static void Printer(int[] depRules, int[] rulesElse)
        {
            for (var i = 0; i < depRules.Length; i++)
            {
                Console.Write($"| {depRules[i]} ");
                Console.Write($" {rulesElse[i]} ");
            }
        }
    }
}