
namespace EventsDelegates
{
    public class StockExchange
    {
        private decimal _price;
        public event EventHandler<StockExchangeEventArgs>? PriceChanged;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value == _price)
                    return;

                var oldPrice = _price;
                _price = value;

                //PriceChanged?.Invoke(this, new StockExchangeEventArgs(oldPrice, _price));
                OnPriceChanged(new StockExchangeEventArgs(oldPrice, _price));
            }
        }

        protected virtual void OnPriceChanged(StockExchangeEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
