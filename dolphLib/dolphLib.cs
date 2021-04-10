using System;

namespace dolphLib
{
    public static class Configurator
    {
        public static int[] RuleParser(int[] depRules, int[] rulesElse)
        {
            var bypass = new int[depRules.Length];
            
            for (int i = 0; i < depRules.Length; i++)
            {
                switch (depRules[i])
                {
                    case 1: case 4:
                        bypass[i] = i + 1;
                        i = ReturnRuleElse(rulesElse, i, bypass);
                        break;
                    case 2: case 5:
                        bypass[i] = -1;
                        i = ReturnRuleElse(rulesElse, i, bypass);
                        break;
                    case 3: case 6:
                        Console.WriteLine("\n Enter goto parameter");
                        i = ReturnRuleElse(rulesElse, i, bypass);
                        break;
                }
            }

            foreach (var t in bypass)
            {
                Console.Write($"| {t} ");
            }
            return bypass;
        }

        private static int ReturnRuleElse(int[] rulesElse, int i, int[] bypass)
        {
            switch (rulesElse[i])
            {
                case 7:
                    bypass[i] = i + 1;
                    break;
                case 8:
                    bypass[i] = -1;
                    break;
                case 9:
                    Console.WriteLine("\n Enter goto parameter");
                    var tempEnum = ParseIntOrReturn0(Console.ReadLine());
                    if (tempEnum < rulesElse.Length)
                    {
                        return tempEnum;
                    }
                    break;
            }
            return i;
        }
        
        // Parse user input or return 0 if user input is no valid 
        public static int ParseIntOrReturn0(string input)
        {
            return int.TryParse(input, out var parsed) && parsed >= 1 ? parsed : 0;
        }
    }
}