namespace Transact;

public partial class NotificationPopup_Android : BasePopup
{
    public NotificationPopup_Android(NotificationPopupViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}