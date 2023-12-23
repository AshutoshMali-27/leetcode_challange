
//Best Time to Buy and Sell Stock

//You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.



using System;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            // Update the minimum price if a lower price is found
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                // Calculate the potential profit if selling on the current day
                int currentProfit = prices[i] - minPrice;

                // Update the maximum profit if the current profit is higher
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
        }

        return maxProfit;
    }
}
