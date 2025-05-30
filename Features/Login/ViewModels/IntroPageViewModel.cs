namespace Transact;

public partial class IntroPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void LoginNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.Login);
}