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

double average = StatisticsHelper.CalculateAverage(values);

Console.WriteLine($"Average: {average:F2}");

if (average >= 15)
{
    Console.WriteLine("Average is high.");
}
else
{
    Console.WriteLine("Average is moderate.");
}