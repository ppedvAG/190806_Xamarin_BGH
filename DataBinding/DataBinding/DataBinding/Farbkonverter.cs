using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DataBinding
{
    class Farbkonverter : IValueConverter
    {
        // OneWay
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Variante "primitiv"
            //string farbe = (string)value;

            //if (farbe == "Red")
            //    return Color.Red;
            //// ...
            //else
            //    return Color.Black;


            // Variante mit Reflection:
            string farbe = (string)value;
            var farbField = typeof(Color).GetFields().FirstOrDefault(x => x.Name == farbe);
            if (farbField == null) // Farbe nicht gefunden
                return Color.Black;
            else
                return farbField.GetValue(typeof(Color));
        }

        // TwoWayBinding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
