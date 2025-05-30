namespace Transact
{
    public partial class SettingViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
    {

        [RelayCommand]
        private async Task TransactionPinAsync()
        {
            await AppNavigator.NavigateAsync(AppRoutes.TransactionPin);
        }
    }
}
