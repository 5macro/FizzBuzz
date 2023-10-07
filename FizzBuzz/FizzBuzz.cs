using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CountOff(int number)
        {
            var ans = string.Empty;

            if (IsMultiplesOf(number, 3))
            {
                ans += "Fizz";
            }

            if (IsMultiplesOf(number, 5))
            {
                ans += "Buzz";
            }

            if (IsMultiplesOf(number, 7))
            {
                ans += "Whizz";
            }

            return ans.Length == 0 ? number.ToString() : ans;
        }

        private static bool IsMultiplesOf(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
