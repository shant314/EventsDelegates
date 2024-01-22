
namespace EventsDelegates.WithoutEventArgs
{
    public class Broadcaster
    {
        private decimal _price= 1m;

        public event PriceChangeHandler PriceChanged; // this is declared as global in my sample

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                    return;
                var oldValue = _price;
                _price = value;

                if (PriceChanged != null)
                    PriceChanged(oldValue, value);
            }
        }
    }
}
