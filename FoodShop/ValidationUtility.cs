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
            var result = DateTime.MinValue;
            try
            {
                DateTimePicker typed = (DateTimePicker)dt;
                result = typed.Value;
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid Data");
            }
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
            //        else value = colValue.ToString();
            return value;
        }


        public static string stringValidator(string text)
        {
            string name;
            if (text.Length <= 20)
                //employee.employeeLast = txt_lastName.Text;
                name = text;
            else
                //employee.employeeLast = txt_lastName.Text.Substring(0, 20);
                name = text.Substring(0, 20);
            return name;
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
