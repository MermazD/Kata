using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    public class BitCounter
    {
        public static int CountBits(int n)
        {
            int res = 0;
            while (n != 0)
            {
                res += 1;
                n &= (n - 1);
            }
            return res;
        }
    }
}
