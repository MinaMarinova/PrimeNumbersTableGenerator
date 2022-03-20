namespace PrimeNumbersTableGenerator
{
    using Extreme.Mathematics;

    internal static class TableGenerator
    {
        internal static int?[,] FillTableWithPrimeNumbers(int input)
        {
            int?[,] matrix = new int?[input + 1, input + 1];
            int primeNumbersCount = 0;
            int counter = 0;
            while (primeNumbersCount < input)
            {
                if (IntegerMath.IsPrime(counter))
                {
                    matrix[0, primeNumbersCount + 1] = counter;
                    matrix[primeNumbersCount + 1, 0] = counter;
                    primeNumbersCount++;
                };
                counter++;
            }
            return matrix;
        }
    }
}
