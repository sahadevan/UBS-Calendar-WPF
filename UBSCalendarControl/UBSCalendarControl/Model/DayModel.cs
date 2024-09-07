namespace UBSCalendarControl
{
	public class DayModel
	{
		public int DayNumber { get; set; }
		public bool IsHoliday { get; set; }
		public string HolidayReason { get; set; } = string.Empty;
	}
}