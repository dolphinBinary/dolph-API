using System;

namespace dolphLib
{
    public static class Configurator
    {
        // Parse user input or return 0 if user input is no valid 
        public static int ParseIntOrReturn0(string input)
        {
            return int.TryParse(input, out var parsed) && parsed >= 1 ? parsed : 0;
        }
    }
}