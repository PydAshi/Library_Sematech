using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Sematech
{
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
