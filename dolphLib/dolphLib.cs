using System;

namespace dolphLib
{
    public static class Configurator
    {
        // The method goes through the department configuration and returns a completed bypass sheet
        public static int[] RuleParser(int[] depRules, int[] rulesElse)
        {
            var bypass = new int[depRules.Length]; // bypass sheet

            for (int i = 0; i < depRules.Length; i++)
            {
                switch (depRules[i])
                {
                    case 1: case 4:
                        if (bypass[i] is 0) // if stamp in bypass sheet is 0 write stamp
                        {
                            bypass[i] = i + 1;
                        }
                        // Checking Else block of rules 
                        i = ReturnRuleElse(rulesElse, bypass, i);
                        break;
                    
                    case 2: case 5:
                        if (bypass[i] >= 0) // If the bypass sheet has a stamp i, the parser crosses it out
                        {
                            bypass[i] = -1;
                        }
                        i = ReturnRuleElse(rulesElse, bypass, i);
                        
                        break;
                    
                    case 3: case 6:
                        Console.WriteLine("\n Enter goto department parameter");
                        var tempEnum = Checker.ParseIntOrReturn0(Console.ReadLine());
                        // The user sets the department number to which he wants to move the pointer, the ternary operator checks the entered rule using the ReturnParameterOrZero method
                        i = rulesElse[i] < 7 ? ReturnParameterOrZero(tempEnum, depRules) : ReturnRuleElse(rulesElse, bypass, i);
                        
                        var tempBypass = bypass; // temporary bypass sheet for checking loop
                        Console.WriteLine(Checker.IsLoop(bypass, tempBypass));
                        break;
                }
            }
            // Console output of differences in the bypass sheet
            Console.WriteLine("\n Differences in bypass sheet: ");
            foreach (var t in bypass)
            {
                Console.Write($"| {t} ");
            }
            return bypass;
        }
        
        // A method that returns the value of the rule from the Else block
        private static int ReturnRuleElse(int[] rulesElse, int[] bypass, int i)
        {
            switch (rulesElse[i])
            {
                case 7:
                    if (bypass[i] is 0) // if stamp in bypass sheet is 0 write stamp
                    {
                        Console.WriteLine("\n Enter stamp number");
                        var tempStamp = Checker.ParseIntOrReturn0(Console.ReadLine());
                        bypass[ReturnParameterOrZero(tempStamp, rulesElse)] = ReturnParameterOrZero(tempStamp, rulesElse);
                    }
                    break;
                
                case 8:
                    Console.WriteLine("\n Enter cross out number of stamp");
                    var tempDep = Checker.ParseIntOrReturn0(Console.ReadLine()); // temporary stamp number for cross out 
                    if (bypass[i] == i + 1) // If the bypass sheet has a stamp i, the parser crosses it out
                    {
                        bypass[ReturnParameterOrZero(tempDep, rulesElse)] = ReturnParameterOrZero(tempDep, rulesElse);
                    }
                    break;
                
                case 9:
                    Console.WriteLine("\n Enter goto department parameter"); 
                    var tempEnum = Checker.ParseIntOrReturn0(Console.ReadLine()); // Temporary enumerator for switching to a given department 
                    i = ReturnParameterOrZero(tempEnum, rulesElse); // Write to iterator temporary enumerator fr goto department
                    break;
            }
            return i;
        }

        private static int ReturnParameterOrZero(int tempParam, int[] rules)
        {
            // check the parameter so that it does not go beyond the bypass sheet
            return tempParam <= rules.Length ? tempParam : 0;
        }
    }
}