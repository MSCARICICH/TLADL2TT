using System;
using System.Text;

namespace PrimerParcial
{
    public class Util
    {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string Numbers = "0123456789";
        public const string Alphabetnumerics = Alphabet + Numbers;

        public static string GenerateRandomGeneric(string data, int length)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(data.Length);
                stringBuilder.Append(data[index]);
            }

            return stringBuilder.ToString();
        }
        public static string GenerateRandomAlphabet(int length)
        {
            return GenerateRandomGeneric(Alphabet, length);
        }

        public static string GenerateRandomString(int length)
        {
            return GenerateRandomGeneric(Alphabetnumerics, length);
        }

        public static int[] GenerateRandomNumbers(int min, int max, int count)
        {
            Random random = new Random();
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = random.Next(min, max + 1);
            }

            return result;
        }
    }

}