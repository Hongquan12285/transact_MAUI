namespace Transact;

public partial class SignUpPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void SignUpOtpNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.SignUpOtp);
    [RelayCommand]
    private void LoginNavigate() =>
      AppNavigator.NavigateAsync(AppRoutes.Login);
    [RelayCommand]
    private void ForgotPasswordNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.ForgotPassword);
}