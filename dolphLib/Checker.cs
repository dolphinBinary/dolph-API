namespace dolphLib
{
    public static class Checker
    {
        // Parse user input or return 0 if user input is no valid 
        public static int ParseIntOrReturn0(string input)
        {
            return int.TryParse(input, out var parsed) && parsed >= 1 ? parsed : 0;
        }

        public static string IsLoop(int[] bypass, int[] tempBypass)
        {
            var output = "";
            if (bypass == tempBypass)
            {
                output = "Using this iterator further, you get into a loop";
            }
            return output;
        }
    }
}