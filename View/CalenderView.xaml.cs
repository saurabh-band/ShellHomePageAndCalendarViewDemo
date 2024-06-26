using Syncfusion.Maui.Calendar;

namespace CascadePOCHomePage.View;

public partial class CalenderView : ContentPage
{
	public CalenderView()
	{
		InitializeComponent();
		SfCalendar calendar = new SfCalendar();
		this.Content = calendar;
	}
}