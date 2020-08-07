using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_17__Propagating_Exceptions
{
    class Calculator
    {
        public int power(int x, int y)
        {
            if(x<0 || y<0)
            {
                throw new Exception("n and p should be non-negative");
            }

            else
            {
                return (int)Math.Pow(x, y);
            }           
        }


    }
}
