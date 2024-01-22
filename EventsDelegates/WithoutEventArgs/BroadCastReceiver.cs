
namespace EventsDelegates.WithoutEventArgs
{
    public class BroadCastReceiver
    {
        public void PrintToConsole(decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine(oldPrice + " " + newPrice);
        }

        public void PrintGreenToConsole(decimal oldPrice, decimal newPrice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(oldPrice + " " + newPrice);
            Console.ResetColor();
        }
    }
}
