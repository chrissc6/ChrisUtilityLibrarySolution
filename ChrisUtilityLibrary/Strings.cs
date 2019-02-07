using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChrisUtilityLibrary
{
    public class Strings
    {
        public static bool ValidUSZipcode(string zipCode)
        {
            Regex rgx = new Regex(@"^\d{5}(\-?\d{4})?");
            var match = rgx.IsMatch(zipCode);
            return match;
        }

        public static bool ValidUSPhoneNumber(string phoneNummber)
        {
            Regex rgx = new Regex(@"^(\d{3})?(-)?\d{3}(-)?\d{4}"); //changed from "^(\d{3}-)?\d{3}-\d{4}" to all just 7 digits
            var match = rgx.IsMatch(phoneNummber);
            return match;
        }

        public static bool EqualIgnoreCase(string strA, string strB)
        {
            var result = String.Compare(strA.ToUpper(), strB.ToUpper());
            bool returnResult;
            if (result == 0)
                returnResult = true;
            else
            {
                returnResult = false;
            }
            return returnResult;
        }
    }
}
