using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvashkinaKE.Sprint2.TaskReview.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y <= (2 - x * x)) && ((y>=x) || (y >=0)))
            {
                return true;
            }

            return false;
        }
    }
}
