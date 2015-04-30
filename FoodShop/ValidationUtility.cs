using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
