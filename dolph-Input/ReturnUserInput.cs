using System;

namespace dolph_Input
{
    public static class ReturnUserInput
    {
        static void Main(string[] args)
        {
            
        }
        public static string DepartmentNumberConfigurator(int iterator)
        {
            switch (iterator)
            {
                case 1:
                Console.WriteLine("Enter number of departments: ");
                return Console.ReadLine();
                case 2:
                    Console.WriteLine(
                        "Enter number of absolute or conditional rule \n Set absolute rule: \n \n 1) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 2) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 3) Send Vasiliy to the next department K. \n \nSet conditional rule: \n If the bypass sheet has an uncrossed N stamp, then: \n 4) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 5) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 6) Send Vasiliy to the next department K.");
                    return Console.ReadLine();
                case 3:
                    Console.WriteLine(
                        "\n \n ConsoleInput else rule \n \n 7) Put a new stamp T if it does not already exist (or is crossed out) or do not put any. \n 8) Cross out the existing R stamp if it already exists (or not) or do not cross out any. \n 9) Send Vasiliy to the next department P. \n");
                    return Console.ReadLine();
                case 4: 
                    Console.WriteLine("\n Enter goto department parameter");
                    return Console.ReadLine();
                case 5: 
                    Console.WriteLine("\n Enter stamp number");
                    return Console.ReadLine();
                case 6:
                    Console.WriteLine("\n Enter cross out number of stamp");
                    return Console.ReadLine();
                case 7:
                    Console.WriteLine("\n Enter goto department parameter"); 
                    return Console.ReadLine();
            }
            
            return "";
        }
        
        // Print Library and API output 
        public static void ResultPrinter(int[] departmentRules, int[] rulesElse)
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
        }

        public static void Printer(string str)
        {
            Console.WriteLine(str);
        }

        public static void DifferencesPrinter(int[] bypassSheet)
        {
            // Console output of differences in the bypass sheet
            Console.WriteLine("\n Differences in bypass sheet: ");
            foreach (var t in bypassSheet)
            {
                Console.Write($"| {t} ");
            }
        }
    }
}