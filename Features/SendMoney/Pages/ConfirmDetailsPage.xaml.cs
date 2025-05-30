using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class ConfirmDetailsPage 
{
	public ConfirmDetailsPage(ConfirmDetailsPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

        // Ẩn HeaderView nếu chạy trên Android
        if (Microsoft.Maui.Devices.DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
        {
            HeaderView.IsVisible = false;
            HeaderNavigateView.IsVisible = true;
            Navigation.IsVisible = false;
        }
        else
        {
            Navigation.IsVisible = true;
            HeaderNavigateView.IsVisible = false;
        }
    }

    private async void GoBack_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void TransactionPinPage_Clicked(object sender, EventArgs e)
	{
        Popup popup;

        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            popup = new TransactionPinPageAndroid(); // BottomSheet cho Android
        }
        else
        {
            popup = new TransactionPinPage(); // Giao diện mặc định cho nền tảng khác
        }
        this.ShowPopup(popup);
    }

    //private void OpenBottomSheet(object sender, EventArgs e) 
    //{ 
    //    bottomSheet.Show();
    //}
}