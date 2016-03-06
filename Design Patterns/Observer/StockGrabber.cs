using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Test Commit
    public class StockGrabber : Subject
    {
        List<Observer> observers;
        double ibmPrice;
        double aaplPrice;
        double googlePrice;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }

        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unregister(Observer deleteObserver)
        {
            int observerIndex = observers.IndexOf(deleteObserver);
            Console.WriteLine("Observer " + (observerIndex + 1) + "deleted.");

            observers.RemoveAt(observerIndex);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(ibmPrice,aaplPrice,googlePrice);
            }
        }

        public void setIBMPrice(double newIBMPrice)
        {
            ibmPrice = newIBMPrice;
            Notify();
        }

        public void setAAPLPrice(double newAAPLPrice)
        {
            aaplPrice = newAAPLPrice;
            Notify();
        }

        public void setGOOGLPrice(double newGOOGLPrice)
        {
            googlePrice = newGOOGLPrice;
            Notify();
        }

    }
}
