using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            flyingType = new CantFly();
        }
    }
}
