using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppGallery.XamarinForms.Classes.Conversores
{
    public class ZebraConverter : IValueConverter
    {
        private static int Contador = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Contador++;
            if(Contador % 2 == 0)
            {
                return Color.LightGray;
            }
            else
            {
                return Color.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
