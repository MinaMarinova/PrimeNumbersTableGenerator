using PrimeNumbersTableGenerator;

bool isInputValid = int.TryParse(Console.ReadLine(), out int input);

if (isInputValid && input > 0)
{
    try
    {
        int?[,] tableWithPrimeNumbersFilled = TableGenerator.FillTableWithPrimeNumbers(input);
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

