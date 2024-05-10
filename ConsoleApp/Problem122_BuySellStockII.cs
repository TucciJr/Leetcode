// See https://aka.ms/new-console-template for more information
internal class Problem122_BuySellStockII
{
    public Problem122_BuySellStockII()
    {
        Run([7, 1, 5, 3, 6, 4]);
        Run([1, 2, 3, 4, 5]);
        Run([7, 6, 4, 3, 1]);
    }

    private void Run(int[] prices)
    {
        var maxProfit = MaxProfit(prices);

        Console.WriteLine($"MaxProfit: {maxProfit}");
    }

    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;

        for (int sell = 1; sell < prices.Length; sell++)
        {
            var profit = prices[sell] - prices[sell - 1];

            if (profit > 0)
            {
                maxProfit += profit;
            }
        }

        return maxProfit;
    }
}