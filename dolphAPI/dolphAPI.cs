using dolphLib;
using dolph.Input;

namespace dolphAPI
{
    static class Program
    {
        public static void Main()
        {
            // N number
            var departmentNumber = Checker.ParseIntOrReturn0(ReturnUserInput.DepartmentNumberConfigurator(1));
            
            var departmentRules = new int[departmentNumber]; // Array with absolute rules
            var rulesElse = new int[departmentNumber]; // Array with conditional rules
            // Configure department rules
            for (var i = 0; i < departmentNumber; i++)
            {
                var rule = Checker.ParseIntOrReturn0(ReturnUserInput.DepartmentNumberConfigurator(2));
                departmentRules[i] = ReturnAbsOrCondRule(rule);
                rulesElse[i] = ReturnElseRule(rule);
            }
            ReturnUserInput.ResultPrinter(departmentRules, rulesElse);
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
                var temporaryRule = Checker.ParseIntOrReturn0(ReturnUserInput.DepartmentNumberConfigurator(3));
                if (temporaryRule is > 6 and < 10)
                {
                    return temporaryRule;
                }
            }
            return 0;
        }
    }
}