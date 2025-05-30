namespace Transact;

public partial class SignUpOtpPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void SignUpNavigate() =>
       AppNavigator.NavigateAsync(AppRoutes.SignUp);
    [RelayCommand]
    private async Task CreatePasswordNavigateAsync()
    {
        await AppNavigator.GoBackAsync();
        await AppNavigator.NavigateAsync(AppRoutes.CreatePasswordpopup);
    }
    [RelayCommand]
    private async Task LoginNavigateAsync()
    {
        await AppNavigator.NavigateAsync(AppRoutes.Login);
    }
}