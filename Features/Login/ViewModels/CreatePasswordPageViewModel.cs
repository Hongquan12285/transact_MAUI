namespace Transact;

public partial class CreatePasswordPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void SignUpOtpNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.SignUpOtp);
    [RelayCommand]
    private void LoginNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.Login);
}