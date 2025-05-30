namespace Transact;

public partial class LoginPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void SignUpNavigate() =>
      AppNavigator.NavigateAsync(AppRoutes.SignUp);
    [RelayCommand]
    private void ForgotPasswordNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.ForgotPassword);
}