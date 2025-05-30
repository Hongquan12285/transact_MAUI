using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class HeaderViewMobile : ContentView
{
    private readonly IAppNavigator _appNavigator;

    public HeaderViewMobile() : this(App.Current.Handler.MauiContext.Services.GetService<IAppNavigator>())
    {
    }

    public HeaderViewMobile(IAppNavigator appNavigator)
    {
        InitializeComponent();
        _appNavigator = appNavigator ?? throw new ArgumentNullException(nameof(appNavigator));
    }

    [RelayCommand]
    private async Task GoToMyAccountAsync()
    {
        await _appNavigator.NavigateAsync(AppRoutes.MyAccountMobile);
    }

    [RelayCommand]
    private async Task GoToNotificationAsync()
    {
        await _appNavigator.NavigateAsync(AppRoutes.NotificationPage);
    }
}
