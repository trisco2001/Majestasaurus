using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Majestasaurus.Portable.Converters
{
    class BookPageNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "ERR";

            string sVal = value.ToString();

            // Convert from a page index to a page number, a super-complicated calculation.
            int iVal;
            if (int.TryParse(sVal, out iVal))
            {
                if (parameter != null && parameter.ToString() == "Title")
                {
                    return BooksDataModel.All[iVal].Title;
                }
                return iVal + 1;
            }

            return BooksDataModel.All.IndexOf(BooksDataModel.All.First(f => f.Title == sVal)) + 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
