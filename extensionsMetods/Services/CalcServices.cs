using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionsMetods.Services
{
    public class CalcServices
    {
        public static double Max(double x, double y) { 
        
            return (x > y) ? x : y;
        }
        public static double Min(double x, double y)
        {

            return (x < y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
    }
}
