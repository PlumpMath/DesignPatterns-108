using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Flys
    {
        string fly();
    }

    public class ItFlys : Flys
    {
        public string fly()
        {
            return "Flying High";
        }
    }

    public class CantFly : Flys
    {
        public string fly()
        {
            return "I Can't Fly";
        }
    }
}
