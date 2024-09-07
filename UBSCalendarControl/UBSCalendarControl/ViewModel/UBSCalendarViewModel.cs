using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace UBSCalendarControl
{
	public class UBSCalendarViewModel : INotifyPropertyChanged
	{
		private int _numberOfMonthsToDisplay = 1;
		private int _selectedYear = 2024;
		private bool _isYearView = false;

		public UBSCalendarViewModel()
		{
			MonthOptions = new List<int> { 1, 3, 6, 9 };
			YearOptions = Enumerable.Range(2000, 30).ToList();

			Months = new ObservableCollection<UBSMonthViewModel>();
			YearMonths = new ObservableCollection<UBSMonthViewModel>();

			PopulateMonths();
		}

		public List<int> MonthOptions { get; }

		public List<int> YearOptions { get; }

		public int NumberOfMonthsToDisplay
		{
			get => _numberOfMonthsToDisplay;
			set
			{
				if (_numberOfMonthsToDisplay != value)
				{
					_numberOfMonthsToDisplay = value;
					OnPropertyChanged(nameof(NumberOfMonthsToDisplay));
					PopulateMonths();
				}
			}
		}

		public int SelectedYear
		{
			get => _selectedYear;
			set
			{
				if (_selectedYear != value)
				{
					_selectedYear = value;
					OnPropertyChanged(nameof(SelectedYear));
					PopulateMonths();
					PopulateYearMonths();
				}
			}
		}

		public bool IsYearView
		{
			get => _isYearView;
			set
			{
				if (_isYearView != value)
				{
					_isYearView = value;
					OnPropertyChanged(nameof(IsYearView));
					if (IsYearView)
					{
						PopulateYearMonths();
					}
				}
			}
		}

		public ObservableCollection<UBSMonthViewModel> Months { get; }

		public ObservableCollection<UBSMonthViewModel> YearMonths { get; }


		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		private void PopulateMonths()
		{
			Months.Clear();
			DateTime startDate = new DateTime(_selectedYear, 1, 1);

			for (int i = 0; i < NumberOfMonthsToDisplay; i++)
			{
				var monthViewModel = new UBSMonthViewModel(startDate.Year, startDate.Month);
				Months.Add(monthViewModel);
				startDate = startDate.AddMonths(1);
			}
		}

		private void PopulateYearMonths()
		{
			YearMonths.Clear();
			DateTime startDate = new DateTime(_selectedYear, 1, 1);

			for (int i = 0; i < 12; i++)
			{
				var monthViewModel = new UBSMonthViewModel(startDate.Year, startDate.Month);
				YearMonths.Add(monthViewModel);
				startDate = startDate.AddMonths(1);
			}
		}
	}
}
