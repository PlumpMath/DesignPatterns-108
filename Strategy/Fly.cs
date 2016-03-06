using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Fly
    {
        string fly();
    }

    public class ItFlys : Fly
    {
        public string fly()
        {
            return "Flying High";
        }
    }

    public class CantFly : Fly
    {
        public string fly()
        {
            return "I can't Fly";
        }
    }
}
