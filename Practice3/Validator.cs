using System;

namespace Practice3
{
    public static class Validator
    {
        public const int MAX_ATTEMPTS = 10;

        public static int GetValidatedInput()
        {
            Console.WriteLine("What is the Value, should be more than 0");
            int attempt = 0;
            int border = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                string inputString = Console.ReadLine();
                if (inputString.ToString() != string.Empty)
                {
                    try
                    {
                        if ((inputString.IndexOf('0') != -1) && (inputString.Length == 1))
                        {
                            Console.WriteLine("\nIncorrect Input: Zero is not allowed");
                            attempt++;
                            continue;
                        }
                        else if (Convert.ToInt32(inputString) < 0)
                        {
                            Console.WriteLine("\nIncorrect Input: Negative values are not allowed");
                            attempt++;
                            continue;
                        }
                        else
                        {
                            border = Convert.ToInt32(inputString);
                            Console.WriteLine("\nBorder is " + border);
                            return border;
                        }
                    }
                    catch (SystemException ex)
                    {
                        Console.WriteLine("\nIncorrect Input, error: " + ex.Message);
                        Console.WriteLine("\nTry again to populate correct border");
                        attempt++;
                    }
                }
                else
                {
                    Console.WriteLine("\nIncorrect Input: Empty value is not allowed");
                }
            }
        return 0;
        }
    }
}