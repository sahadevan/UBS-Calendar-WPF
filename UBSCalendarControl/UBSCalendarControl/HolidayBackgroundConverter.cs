using System;
using System.Windows.Data;
using System.Windows.Media;

namespace UBSCalendarControl
{
	public class HolidayBackgroundConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value is bool isHoliday && isHoliday)
			{
				return Brushes.LightCoral;
			}
			return Brushes.Transparent;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
