using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppGallery.XamarinForms.Classes.Conversores
{
    public class OpcionalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var opcionais = (string)value;
            string opcionaisTexto = opcionais;

            opcionaisTexto = opcionaisTexto
                .Replace("1", "Ar-condicionado")
                .Replace("2", "Direção-hidráulica")
                .Replace("3", "Air-Bag")
                .Replace("4", "Roda Liga-Leve");

            return opcionaisTexto;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
