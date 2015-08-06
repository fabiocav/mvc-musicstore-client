using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zumomusicstore
{
    public class AlbumImageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;

            string url = value.ToString();

            if (url.StartsWith("/"))
            {
                return string.Format("http://zumomusicstore.azurewebsites.net{0}", url.Replace(".gif", ".jpg"));
            }

            return url;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
