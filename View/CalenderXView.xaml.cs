using XCalendar.Core.Models;

namespace CascadePOCHomePage.View;

public partial class CalenderXView : ContentPage
{
	public Calendar<CalendarDay> MyCalendar { get; set; } 
	public CalenderXView()
	{
		InitializeComponent();
		
		MyCalendar = new Calendar<CalendarDay>();
		this.Content = myCalendar;

	}
}