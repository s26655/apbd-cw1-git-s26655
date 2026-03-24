int[] values = { 12, 7, 25, 3, 18 };

Console.WriteLine("Statistics Calculator");
Console.WriteLine("---------------------");
Console.WriteLine();

if (values.Length == 0)
{
    Console.WriteLine("Error: no values were provided.");
    return;
}

Console.WriteLine("Input data");
Console.WriteLine($"Numbers: {StatisticsHelper.FormatValues(values)}");
Console.WriteLine();

Console.WriteLine("Calculated statistics");
Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(values):F2}");