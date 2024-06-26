using Plugin.Maui.CalendarStore;

namespace CascadePOCHomePage.View;

public partial class CalenderStoreView : ContentPage
{
	readonly ICalendarStore calendarStore;
	public CalenderStoreView(ICalendarStore calendarStore)
	{
		InitializeComponent();

		this.calendarStore = calendarStore;

		ReadCalendars();

	}
	
	public async Task ReadCalendars()
	{
		var calendars = await calendarStore.GetCalendars();

		//foreach (var c in calendars)
		//{
		//	Console.WriteLine(c.Name);
		//}
	}
}