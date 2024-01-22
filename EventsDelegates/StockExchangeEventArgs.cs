
namespace EventsDelegates
{
    public class StockExchangeEventArgs : EventArgs
    {
        public readonly decimal OldPrice;
        public readonly decimal NewPrice;

        public StockExchangeEventArgs(decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }
}
