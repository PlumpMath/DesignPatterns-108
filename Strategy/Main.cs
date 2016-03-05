using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategyPattern
    {
        static void Main(string[] args)
        {
            Animal bruno = new Dog();
            Animal tisay = new Bird();

            Console.WriteLine(string.Format("Dog: {0}", bruno.flyingType.fly()));
            Console.WriteLine(string.Format("Bird: {0}", tisay.flyingType.fly()));
            Console.ReadKey();

            bruno.setFlyingAbility(new ItFlys());
            Console.WriteLine(string.Format("Dog: {0}", bruno.flyingType.fly()));
            Console.ReadKey();

        }
    }
}


//When To Use Strategy Pattern?

//When You want to define a class that will have one behavior that is similar to other behaviors in a list

//When you need to use one of several behaviors dynamically.

//I want the class object to be able to choose from
//  -Not Flying
//  -Fly with wings
//  -Fly super fast

