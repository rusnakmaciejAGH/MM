using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class MathFunctions
    {     
        public static int MathMod(int a, int b)
        {
            return ((a % b) + b) % b;
        }
    }
}
