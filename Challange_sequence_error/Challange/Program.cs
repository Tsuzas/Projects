
using System;

class Program
{
    static void Main()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        int minLength = 4;
        int maxLength = 4;
        string[] items = orderStream.Split(',');

        foreach (string item in items)
        {

            try
            {
                ValidateStringLength(item, minLength, minLength);
                ValidateStringLength(item, minLength, maxLength);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Error in: {item}");
            }
            static void ValidateStringLength(string str, int minLength, int maxLength)
            {
                if (str.Length < minLength)
                {
                    throw new ArgumentException($"The string must be at least {minLength} characters long.");
                }
                if (str.Length > maxLength)
                {
                    throw new ArgumentException($"The string must be at least {maxLength} characters long.");
                }
            }
            Console.WriteLine(item);
        }
    }
}

