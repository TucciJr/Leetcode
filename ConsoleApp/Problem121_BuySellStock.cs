// See https://aka.ms/new-console-template for more information
internal class Problem121_BuySellStock
{
    public Problem121_BuySellStock()
    {
        Run([7, 1, 5, 3, 6, 4]);
        Run([7, 6, 4, 3, 1]);
    }

    private void Run(int[] prices)
    {
        var maxProfit = MaxProfit(prices);

        Console.WriteLine($"MaxProfit: {maxProfit}");
    }

    public int MaxProfit(int[] prices)
    {
        var profit = 0;
        var maxProfit = 0;
        var buy = 0;

        for (int i = 0; i < prices.Length; i++)
        {

            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] > prices[i])
                {
                    buy = Math.Min(buy, i);

                    profit = prices[j] - prices[i];

                    maxProfit = Math.Max(maxProfit, profit);
                }
            }
        }

        return maxProfit;
    }
}