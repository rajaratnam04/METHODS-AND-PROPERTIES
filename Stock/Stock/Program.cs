using System;
class Stock
{
    public string StockName;
    public string StockSymbol;
    public double PreviousClosingPrice;
    public double CurrentClosingPrice;

    public Stock(string name, string symblol, double previousClosingPrice, double currentClosingPrice)
    {
        StockName = name;
        StockSymbol = symblol;
        PreviousClosingPrice = previousClosingPrice;
        CurrentClosingPrice = currentClosingPrice;
    }

    public double GetChangePercentage()
    {
        return ((CurrentClosingPrice - PreviousClosingPrice) / PreviousClosingPrice) * 100;
    }

    public void Display()
    {
        Console.WriteLine("\n ----- Stock Details ------");
        Console.WriteLine("Stock Name             : " + StockName);
        Console.WriteLine("Stock Symbol           : " + StockSymbol);
        Console.WriteLine("Previous Closing Price : " +  PreviousClosingPrice);
        Console.WriteLine("Current Closing Price  : " +  CurrentClosingPrice);
        Console.WriteLine("Percentage Change      : " + GetChangePercentage().ToString("F2") + "%");
    }

    static void Main()
    {
        Console.Write("Enter Stock Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Stock Symbol: ");
        string symbol = Console.ReadLine();

        Console.Write("Enter Previous Closing Price: ");
        double previous = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Current Closing Price: ");
        double current = Convert.ToDouble(Console.ReadLine());

        Stock stock = new Stock(name, symbol, previous, current);

        stock.Display();
    }
}