using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.lib
{
  public  class mathcomparision
    {
        public int Divide(int dividend, int devisor)
        {
            return dividend / devisor;
        }

        public int CompareTwoNumbers(int firstNo, int secondNo)
        {
            if (firstNo <= 0 && secondNo <= 0)
            {
                return 0;
            }

            if (firstNo > secondNo)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
