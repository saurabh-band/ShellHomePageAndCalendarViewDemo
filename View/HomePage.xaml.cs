namespace CascadePOCHomePage.View;

public partial class HomePage : ContentPage
{
	public List<string> Pages = new List<string>();
	public HomePage()
	{
		InitializeComponent();
		BindingContext = this;
		for(int i = 0; i < 6; i++)
		{
			Pages.Add("QWERTY QWERTY");
		}
		LeaveEmployee.ItemsSource = Pages;
	}
}