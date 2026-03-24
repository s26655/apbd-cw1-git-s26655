int[] values = { 12, 7, 25, 3, 18 };

Console.WriteLine("Statistics Calculator");
Console.WriteLine("---------------------");
Console.WriteLine($"Numbers: {StatisticsHelper.FormatValues(values)}");
Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(values):F2}");