using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits.Digital_Root
{
    public class Number
    {
        public int DigitalRoot(long n)
        {
            long sum = 0;

            while ((Math.Log10(n) + 1) >= 1)
            {
                sum += (n % 10);
                n /= 10;                
            }

            if ((Math.Log10(sum) + 1) >= 1)
            {
                n = sum;
                sum = 0;

                while ((Math.Log10(n) + 1) >= 1)
                {
                    sum += (n % 10);
                    n /= 10;
                }
                return (Int32)sum;
            }
            else
            {
                return (Int32)sum;
            }            
        }
    }
}
