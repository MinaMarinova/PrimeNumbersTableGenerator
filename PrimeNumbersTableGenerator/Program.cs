using PrimeNumbersTableGenerator;

bool isInputValid = int.TryParse(Console.ReadLine(), out int primeNumbersCountInput);

if (isInputValid && primeNumbersCountInput > 0)
{
    try
    {
        int?[,] tableWithPrimeNumbersFilled = TableGenerator.GetTableWithPrimeNumbersFilled(primeNumbersCountInput);
        List<List<object?>> multiplicationTable = TableGenerator.GetMultiplicationTableFilled(tableWithPrimeNumbersFilled);
        TableGenerator.Print(multiplicationTable);
    }
    catch (Exception)
    {
        Console.WriteLine(Constants.GeneralErrorMessage);
    }
}
else
{
    Console.WriteLine(Constants.InvalidInputErrorMessage);
}

