using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class FontConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fuente2="";
            switch ((string)value)
            {
                case "China":
                    fuente2 = "Chinese Wok Food St";
                    break;
                case "Mexicana":
                    fuente2 = "Taco Salad";
                    break;
                case "Americana":
                    fuente2 = "Slim Summer";
                    break;
                default:
                    break;
            }
            return fuente2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
