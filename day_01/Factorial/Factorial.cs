namespace Functions
{
    public class Func
    {

        public static long GetFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException($"{number} must be non negative number.");
            }

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }

}