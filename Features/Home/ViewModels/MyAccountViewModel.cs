using CommunityToolkit.Maui.Views;
namespace Transact;

public partial class MyAccountViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private async Task ShowChangePasswordPopupAsync()
    {
        await AppNavigator.NavigateAsync(AppRoutes.SignUpOtpPopup);
    }

    [RelayCommand]
    private async Task GoToSettingsAsync()
    {
        await AppNavigator.NavigateAsync(AppRoutes.Setting);
    }
    
    [RelayCommand]
    private async Task ChangeTransactionPinAsync()
    {
        var notificationViewModel = new NotificationViewModel(AppNavigator);
        var popup = new TransactionpinPopup(notificationViewModel);
        var result = await Application.Current.MainPage.ShowPopupAsync(popup);

        if (result != null)
        {
            string transactionPin = result.ToString();
            await Application.Current.MainPage.DisplayAlert("Transaction Pin", $"Your new PIN is {transactionPin}", "OK");
        }
    }
   
    [RelayCommand]
    private async Task LogoutAsync()
    {
        bool confirm = await Application.Current.MainPage.DisplayAlert(
            "Logout",
            "Are you sure you want to logout?",
            "Yes",
            "No");

        if (confirm)
        {
            await Application.Current.MainPage.DisplayAlert("Logged Out", "You have been logged out successfully.", "OK");
            await AppNavigator.NavigateAsync(AppRoutes.Login);
        }
    }
}
