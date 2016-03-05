using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Animal
    {
        protected string name { get; set; }
        double height { get; set; }
        int weight { get; set; }

        public Flys flyingType { get; set; }    // Composition, also provides functionality for the property to be changed at runtime

        public void setFlyingAbility(Flys newFlyType)
        {
            flyingType = newFlyType;
        }

        public string tryToFly()
        {
            return flyingType.fly();
        }
    }
}
