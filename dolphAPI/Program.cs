using System;

namespace dolphAPI
{
    static class Program
    {
        public static void Main()
        {
            // N number
            Console.WriteLine("Enter number of departments: ");
            var depNum = Validation(Console.ReadLine());

            // Configure department rules
            int[] depRules = new int[depNum];
            int[] rulesElse = new int[depNum];
            for (int i = 0; i < depNum; i++)
            {
                Console.WriteLine("Enter rules: in format: number of absolute rule or conditional rule \nSet absolute rule: \n \n 1) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 2) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 3) Send Vasya to the next department K. \n \nSet conditional rule: \n If the bypass sheet has an uncrossed N stamp, then: \n 4) Put a new stamp I if it does not already exist (or it is crossed out) or do not put any. \n 5) Cross out the existing seal J if it already exists and is not crossed out, or do not cross out any seal. \n 6) Send Vasya to the next department K.");
                var rule = Validation(Console.ReadLine());
                depRules[i] = rule;
                if (rule > 3 && rule < 7)
                {
                    Console.WriteLine("\n \n Input else rule \n \n 7) Put a new stamp T if it does not already exist (or is crossed out) or do not put any. \n 8) Cross out the existing R stamp if it already exists (or not) or do not cross out any. \n 9) Send Vasya to the next department P. \n");
                    var tempRule = Validation(Console.ReadLine());
                    rulesElse[i] = tempRule;
                }
                else
                {
                    rulesElse[i] = 0;
                }
            }
            
            for (int i = 0; i < depRules.Length; i++)
            {
                Console.Write($"| {depRules[i]} ");
                Console.Write($" {rulesElse[i]} ");
            }
        }

        static int Validation(string input)
        {
            int i;
            var res = int.TryParse(input, out i);
            if (res == false)
            {
                input = "0";
            }
            Console.WriteLine(res);
            return Convert.ToInt32(input);
        }
    }
}
