namespace Transact;

public partial class NotificationPopup_WinUI : BasePopup
{
    public NotificationPopup_WinUI(NotificationPopupViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}