public static class StatisticsHelper
{
    public static string FormatValues(int[] values)
    {
        return string.Join(", ", values);
    }

    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("The values array cannot be empty.");
        }

        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return (double)sum / values.Length;
    }
}