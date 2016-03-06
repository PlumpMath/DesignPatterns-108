using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Animal
    {
        string name { get; set; }
        public Fly flyingType { get; set; } // Composition
                                            // Behavior can change without side effects
                                            // The behavior is not tied to the superclass or subclasses

        //Gets the flying type
        public string tryToFly()
        {
            return flyingType.fly();
        }

        //Sets the flying type
        public void setFlyingAbility(Fly newFlyType)
        {
            flyingType = newFlyType;
        }
    }
}
