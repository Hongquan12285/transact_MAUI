namespace Transact;

public partial class OtherBanksPage
{
	public OtherBanksPage()
	{
		InitializeComponent();

        // Ẩn HeaderView nếu chạy trên Android
        if (Microsoft.Maui.Devices.DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
        {
            HeaderView.IsVisible = false;
            Navigation.IsVisible = false;
            OtherBanksLabel.IsVisible = true;
        }
        else
        {
            Navigation.IsVisible = true;
            OtherBanksLabel.IsVisible = false;
        }
    }

	private async void GoBack_Tapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}