using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace UBSCalendarControl
{
	public class DayNumberToVisibiltyConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (int)value < 0 ? Visibility.Hidden : Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is Visibility && (Visibility)value == Visibility.Visible)
			{
				return (int)value;
			}
			return -1;
		}
	}
}
