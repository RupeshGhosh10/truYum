using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Utility
{
    public class DateUtility
    {
        public DateTime ConvertToShortDateString(string inputDate)
        {
            return DateTime.Parse(inputDate);
        }
    }
}
