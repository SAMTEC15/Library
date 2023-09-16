using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class PatronNumberGenerator
    {
        public static string GenerateId()
        {
            Random random = new Random();
            string randomNumericPart = GenerateRandomIdNumber(random, 8).ToString("D8");
            string randomAlphabeticPart = GenerateRandomAlphabeticPart(random, 2);

            // Combine the numeric and alphabetic parts to form the final ID
            string generatedId = randomAlphabeticPart + randomNumericPart;

            return generatedId;
        }

        static string GenerateRandomAlphabeticPart(Random random, int alphabeticDigits)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabeticPart = new char[alphabeticDigits];

            for (int i = 0; i < alphabeticDigits; i++)
            {
                int index = random.Next(0, alphabet.Length);
                alphabeticPart[i] = alphabet[index];
            }

            return new string(alphabeticPart);
        }

        static long GenerateRandomIdNumber(Random random, int numericDigits)
        {
            long min = (long)Math.Pow(10, numericDigits - 1);
            long max = (long)Math.Pow(10, numericDigits) - 1;

            return random.Next((int)min, (int)max);
        }


    }
}
