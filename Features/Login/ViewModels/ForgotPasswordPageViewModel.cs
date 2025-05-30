namespace Transact;

public partial class ForgotPasswordPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void LoginNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.Login);
}