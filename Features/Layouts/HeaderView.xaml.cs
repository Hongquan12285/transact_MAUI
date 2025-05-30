using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class HeaderView : ContentView
{
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(HeaderView), string.Empty);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    private readonly IAppNavigator _appNavigator;
    public HeaderView() : this(App.Current.Handler.MauiContext.Services.GetService<IAppNavigator>())
    {
    }
  
    public HeaderView(IAppNavigator appNavigator)
    {
        InitializeComponent();
        BindingContext = this;

        _appNavigator = appNavigator ?? throw new ArgumentNullException(nameof(appNavigator));
    }
   
    [RelayCommand]
    private async Task GoToMyAccountAsync()
    {
        await _appNavigator.NavigateAsync(UriHelper.StandardPath(AppRoutes.MyAccount) , animated:true);
    }
    private void OnNotificationTapped(object sender, TappedEventArgs e)
    {
        var notificationViewModel = App.Current.Handler.MauiContext.Services.GetService<NotificationViewModel>();

        if (notificationViewModel != null )
        {
            var popup = new NotificationsPopup(notificationViewModel);
            Application.Current.MainPage.ShowPopup(popup);
        }
    }
}
