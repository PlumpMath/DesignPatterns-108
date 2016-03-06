using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// an object (called the subject), maintains a list of its dependents (called observers)) and 
    /// notifies them automatically of any state changes
    /// ussaly by calling on of their methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer1 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAAPLPrice(247.00);
            stockGrabber.setGOOGLPrice(537.00);

            StockObserver observer2 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAAPLPrice(247.00);
            stockGrabber.setGOOGLPrice(537.00);

            stockGrabber.Unregister(observer1);

            stockGrabber.setIBMPrice(583.00);
            stockGrabber.setAAPLPrice(682.00);
            stockGrabber.setGOOGLPrice(234.00);

            Console.Read();
        }

        // Observer Pattern
        // When you need many other objects to receive an update when another object changes
        // --Stock market with thousands of stocks needs to send update to objects representing individual stocks
        // --The Subject (publisher) sends many stocks to the Observer.
        // --The Observers (subscribers) takes the ones they want and use them.
        // --Loose coupling is a benefit  - The Subject (publisher)doesn't need to know anything about the Observers (subscribers)
        // --Negaties : The subject (publisher) may send updates that don't matter to the Observer (subscriber)
    }

     

}
