using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppShopping.Libraries.Converters
{
    public class PassingTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "-";
            
            Ticket ticket = (Ticket)value;
            TimeSpan dif = ticket.EndDate.Value - ticket.StartDate;

            return $"{dif.Hours}h {dif.Minutes}m";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
