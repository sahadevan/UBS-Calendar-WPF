using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UBSCalendarControl
{
	public class UBSMonthViewModel
	{
		public string MonthName { get; set; }
		public int Year { get; set; }
		public ObservableCollection<DayModel> Days { get; set; }

		public UBSMonthViewModel() { }

		public UBSMonthViewModel(int year, int month)
		{
			Year = year;
			MonthName = new DateTime(year, month, 1).ToString("MMMM");
			Days = new ObservableCollection<DayModel>();
			PopulateDays(year, month);
		}

		private void PopulateDays(int year, int month)
		{
			Days.Clear();

			DateTime firstDayOfMonth = new DateTime(year, month, 1);
			int daysInMonth = DateTime.DaysInMonth(year, month);

			int emptyCellsCount = ((int)firstDayOfMonth.DayOfWeek + 6) % 7; 
			for (int i = 0; i < emptyCellsCount; i++)
			{
				Days.Add(new DayModel() { DayNumber = -1, IsHoliday = false, HolidayReason = string.Empty });
			}

			for (int day = 1; day <= daysInMonth; day++)
			{
				var currentDay = new DateTime(year, month, day);
				Days.Add(new DayModel
				{
					DayNumber = day,
					IsHoliday = Holidays.ContainsKey(currentDay),
					HolidayReason = Holidays.ContainsKey(currentDay) ? Holidays[currentDay] : string.Empty
				});
			}
		}

		private readonly Dictionary<DateTime, string> Holidays = new Dictionary<DateTime, string>
		{
			{ new DateTime(DateTime.Now.Year, 01, 01), "New Year" },
			{ new DateTime(DateTime.Now.Year, 01, 26), "Republic Day" },
			{ new DateTime(DateTime.Now.Year, 08, 15), "Independence Day" },
			{ new DateTime(DateTime.Now.Year, 09, 07), "Ganesh Chaturthi" },
			{ new DateTime(DateTime.Now.Year, 10, 2), "Gandhi Jayanthi" },
			{ new DateTime(DateTime.Now.Year, 12, 25), "Christmas Day" }
        };
	}
}
