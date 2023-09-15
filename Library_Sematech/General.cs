using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Sematech
{

    /// <summary>
    /// This Class includes basic members
    /// Author : Ashkan Paydari
    /// Tel : 09129734590
    /// Email : paydari.ashkann@gmail.com
    /// Version 1.0
    /// </summary>

    public static class General
    {

        public static bool ValidateNumericTextBox(char ch)
        {
            bool ans = true;

            if (char.IsDigit(ch))
            {
                return ans;
                
            }
            else 
            {
                ans = false;
            }

            return ans; 
        }
    }
}
