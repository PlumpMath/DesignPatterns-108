using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Define a family of algorithms, encapsulate each one, and make them iterchangeable.
    /// The strategy pattern lets the algorithm vary independently from clients that use it.
    /// </summary>
    public class Program
    {   
        static void Main(string[] args)
        {
            var lupin = new Dog();
            var tisay = new Cat();
            Console.WriteLine("Dog : " + lupin.tryToFly());
            Console.WriteLine("Cat : " + tisay.tryToFly());

            lupin.setFlyingAbility(new ItFlys()); 
            Console.WriteLine("Dog : " + tisay.tryToFly());
            Console.Read();


        }
    }
    // Strategy Pattern
    // Often reduces long lists of conditionals
    // Keeps class changes from forcing other class changes
    // Can hide complicated / secret code from the user
    // Negative : Increased number of classes and objects
}
