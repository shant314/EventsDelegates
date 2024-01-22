using EventsDelegates;
using EventsDelegates.WithoutEventArgs;



#region Without Event Args sample
PriceChangeHandler priceChange;// this is the delegate 

var receiver = new BroadCastReceiver();

priceChange = receiver.PrintToConsole;
priceChange += receiver.PrintGreenToConsole;// multi cast delegate, because we are subscribing more than one listener.

Broadcaster broadcaster = new Broadcaster();
broadcaster.PriceChanged += priceChange;

broadcaster.Price = 10m;
Thread.Sleep(1000);
broadcaster.Price = 100m;

#endregion Without Event Args sample





StockExchange stockExchange = new StockExchange();

stockExchange.Price = 27.10M;
Thread.Sleep(1000);

// Register with the PriceChanged event
stockExchange.PriceChanged += StockExchange_OnPriceChanged;
stockExchange.Price = 31.59M;


void StockExchange_OnPriceChanged(object sender, StockExchangeEventArgs e)
{
    {
        if ((e.NewPrice - e.OldPrice) / e.OldPrice > 0.1M)
            Console.WriteLine("Alert, 10% stock price increase!");
    }
}



 public delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);