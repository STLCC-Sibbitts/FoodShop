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


        // Validate rate of pay
        public static decimal validateRateOfPay(string pay)
        {
            /*   if (decimal.Parse(pay) < 0)
               {
                   MessageBox.Show("The pay rate cannot be less than zero. Please enter a valid rate of pay.");
               }
               else
                   rateOfPay = decimal.Parse(txt_rateOfPay.Text); */


            decimal num;
            bool isValid = decimal.TryParse(pay, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out num);
            return num;
        }
    }
}
