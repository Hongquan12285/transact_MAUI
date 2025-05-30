namespace Transact;

public partial class SendMoneyPage
{
	public SendMoneyPage(SendMoneyPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;

        // Ẩn HeaderView nếu chạy trên Android
        if (Microsoft.Maui.Devices.DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
        {
            HeaderView.IsVisible = false;
            SendMoneyLabel.IsVisible = false;
            HeaderNavigateView.IsVisible = true;
            //Title = "Send Money";
        }
        else
        {
            HeaderNavigateView.IsVisible = false;
            //SendMoneyLabel.IsVisible = true;
            //Title = string.Empty;
        }
    }

	private async void ConfirmDetailsPage_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("confirmDetails");
    }
}