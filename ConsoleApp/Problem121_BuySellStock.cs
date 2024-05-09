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
        var maxProfit = 0;
        int buy = 0;

        for (int sell = 1; sell < prices.Length; sell++)
        {
            if (prices[sell] < prices[buy])
            {
                buy = sell;
                continue;
            }

            maxProfit = Math.Max(maxProfit, prices[sell] - prices[buy]);
        }
        GC.Collect();

        return maxProfit;
    }
}