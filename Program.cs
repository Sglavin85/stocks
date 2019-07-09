using System;
using System.Collections.Generic;

namespace stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var stocks = new Dictionary<string, string>();

            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AMD", "Advanced Micro Devices");
            stocks.Add("MSFT", "MicroSoft Inc");
            stocks.Add("TWTR", "Twitter Inc");
            stocks.Add("AAPL", "Apple Inc");
            stocks.Add("AMZN", "Amazon.com Inc");

            var purchases = new Dictionary<string, List<double>>() {
                {"AAPL", new List<double>(){1123.94, 343.34, 3123.22}},
                {"CAT", new List<double>(){124.12, 245.35, 5314.21, 2414.11}},
                {"AMZN", new List<double>(){134.31, 3151.13, 3661.13, 631.13}},
                {"TWTR", new List<double>(){180.44, 298.01, 9092.35}},
                {"AMD", new List<double>(){1122.22, 3642.23, 742.42, 4426.22}},
                {"GM", new List<double>(){4892.12}},
                {"MSFT", new List<double>(){3582.33, 592.53, 92.53, 2992.22}}
            };

            foreach (KeyValuePair<string, List<double>> position in purchases)
            {
                double total = 0.00;
                position.Value.ForEach(ammount => total = total + ammount);
                Console.WriteLine($"The position in {stocks[position.Key]} is worth ${total}");
            }
        }


    }
}
