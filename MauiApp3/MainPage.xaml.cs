
namespace MauiApp3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnDial(object sender, EventArgs e)
	{
		try
		{
			PhoneDialer.Open(PhoneNum.Text);
   			Convert.ToInt32(PhoneNum);
		}
		catch
		{
			await DisplayAlert("Invalid input", "Please enter a valid phone number", "OK");
		}
	}
}

