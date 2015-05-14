using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoodShop
{
    public static class ValidationUtility
    {

        public static DateTime getDateTime(Object dt)
        {
            DateTimePicker typed = (DateTimePicker)dt;
            DateTime result = typed.Value;
            return result;
        }


        public static string isNull(object colValue)
        {
            string value = "";
            if (colValue.Equals(null) || colValue.Equals("") || colValue.Equals("NULL"))
            {
                value = "null";
            }
            else if (colValue.ToString() == "1")
            {
                value = "yes";
            }
            else
            {
                value = "no";
            }
            return value;
        }


        public static string stringValidator(string text)
        {
            string name;
            if (text.Length <= 20)
                name = text;
            else
                name = text.Substring(0, 20);
            return name;
        }


        // Validate rate of pay
        public static decimal validateRateOfPay(string pay)
        {
            decimal num;
            bool isValid = decimal.TryParse(pay, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out num);
            return num;
        }
    }
}
