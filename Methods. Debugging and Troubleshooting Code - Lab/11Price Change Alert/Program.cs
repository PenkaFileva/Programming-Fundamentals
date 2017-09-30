using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double thresholdOfSignificance = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = Percent(lastPrice, currentPrice);
            bool significantDifference = realDiff(difference, thresholdOfSignificance);
            string message = GetResult(currentPrice, lastPrice, difference, significantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string GetResult(double currentPrice, double lastPrice, double difference, bool significantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!significantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (significantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (significantDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return message;
    }
    private static bool realDiff(double thresholdOfSignificance, double difference)
    {
        if (Math.Abs(thresholdOfSignificance) >= Math.Abs(difference))
        {
            return true;
        }
        return false;
    }

    private static double Percent(double lastPrice, double currentPrice)
    {
        double difference = (currentPrice - lastPrice) / lastPrice;
        return difference;
    }
}
