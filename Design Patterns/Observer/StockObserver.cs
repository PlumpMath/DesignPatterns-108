using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockObserver : Observer
    {
        double _ibmPrice;
        double _aaplPrice;
        double _googlPrice;

        public static int _observerIDTracker = 0;
        int _observerID;
        Subject _stockGrabber;


        public StockObserver(Subject stockGrabber)
        {
            _stockGrabber = stockGrabber;
            _observerID = _observerIDTracker++;

            Console.WriteLine("New Observer:" + _observerID);

            stockGrabber.Register(this); 
        }

        public void Update(double ibmPrice, double aaplPrice, double googlPrice)
        {
            _ibmPrice = ibmPrice;
            _aaplPrice = aaplPrice;
            _googlPrice = googlPrice;

            PrintPrice();
        }

        public void PrintPrice()
        {
            Console.WriteLine(_observerID + "\n");
            Console.WriteLine("IBM:" + _ibmPrice);
            Console.WriteLine("Apple:" + _aaplPrice);
            Console.WriteLine("Google:" + _googlPrice);

        }
    }
}
