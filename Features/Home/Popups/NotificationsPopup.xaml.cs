using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class NotificationsPopup : Popup
{

    public NotificationsPopup(NotificationViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        this.Color = Colors.Transparent;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Close();
    }
}
