namespace PrimeNumbersTableGenerator
{
    using ConsoleTableExt;
    using Extreme.Mathematics;

    internal static class TableGenerator
    {
        internal static int?[,] GetTableWithPrimeNumbersFilled(int input)
        {
            int?[,] table = new int?[input + 1, input + 1];
            int primeNumbersCount = 0;
            int counter = 0;
            while (primeNumbersCount < input)
            {
                if (IntegerMath.IsPrime(counter))
                {
                    primeNumbersCount++;
                    table[0, primeNumbersCount] = counter;
                    table[primeNumbersCount, 0] = counter;
                };
                counter++;
            }
            return table;
        }

        internal static List<List<object?>> GetMultiplicationTableFilled(int?[,] tableWithPrimeNumbersFilled)
        {
            List<List<object?>> multiplicationTable = new();
            for (int row = 0; row < tableWithPrimeNumbersFilled.GetLength(0); row++)
            {
                List<object?> tableRow = new();
                for (int col = 0; col < tableWithPrimeNumbersFilled.GetLength(1); col++)
                {
                    if (col > 0 && row > 0)
                    {
                        tableWithPrimeNumbersFilled[row, col] = tableWithPrimeNumbersFilled[0, col] * tableWithPrimeNumbersFilled[row, 0];
                    }
                    tableRow.Add(tableWithPrimeNumbersFilled[row, col]);
                }
                multiplicationTable.Add(tableRow);
            }

            return multiplicationTable;
        }

        internal static void Print(List<List<object?>> multiplicationTable)
            => ConsoleTableBuilder
                .From(multiplicationTable)
                .WithCharMapDefinition(CharMapDefinition.FramePipDefinition)
                .ExportAndWriteLine();
    }
}
