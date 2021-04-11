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
                        if (bypass[i] is 0)
                        {
                            bypass[i] = i + 1;
                        }
                        i = ReturnRuleElse(rulesElse, bypass, i);
                        break;
                    
                    case 2: case 5:
                        if (bypass[i] >= 0)
                        {
                            bypass[i] = -1;
                        }
                        i = ReturnRuleElse(rulesElse, bypass, i);
                        break;
                    
                    case 3: case 6:
                        Console.WriteLine("\n Enter goto department parameter");
                        var tempEnum = Checker.ParseIntOrReturn0(Console.ReadLine());
                        i = rulesElse[i] < 7 ? ReturnParameterOrIterator(tempEnum, depRules) : ReturnRuleElse(rulesElse, bypass, i);
                        break;
                }
            }
            
            Console.WriteLine("\n Differences in bypass: ");
            foreach (var t in bypass)
            {
                Console.Write($"| {t} ");
            }
            return bypass;
        }

        private static int ReturnRuleElse(int[] rulesElse, int[] bypass, int i)
        {
            switch (rulesElse[i])
            {
                case 7:
                    if (bypass[i] is 0)
                    {
                        Console.WriteLine("\n Enter stamp number");
                        var tempStamp = Checker.ParseIntOrReturn0(Console.ReadLine());
                        bypass[ReturnParameterOrIterator(tempStamp, rulesElse)] = ReturnParameterOrIterator(tempStamp, rulesElse);
                    }
                    break;
                
                case 8:
                    Console.WriteLine("\n Enter department parameter");
                    var tempDep = Checker.ParseIntOrReturn0(Console.ReadLine());
                    if (bypass[i] == i + 1)
                    {
                        bypass[ReturnParameterOrIterator(tempDep, rulesElse)] = ReturnParameterOrIterator(tempDep, rulesElse);
                    }
                    break;
                
                case 9:
                    Console.WriteLine("\n Enter goto department parameter");
                    var tempEnum = Checker.ParseIntOrReturn0(Console.ReadLine());
                    bypass[ReturnParameterOrIterator(tempEnum, rulesElse)] = ReturnParameterOrIterator(tempEnum, rulesElse);
                    break;
            }
            return i;
        }

        private static int ReturnParameterOrIterator(int tempParam, int[] rules)
        {
            return tempParam <= rules.Length ? tempParam : 0;
        }
        
        // Parse user input or return 0 if user input is no valid 
        
    }

    public static class Checker
    {
        public static int ParseIntOrReturn0(string input)
        {
            return int.TryParse(input, out var parsed) && parsed >= 1 ? parsed : 0;
        }
    }
}