namespace Transact;

public partial class NotificationPopup : BasePopup
{
    public NotificationPopup(NotificationPopupViewModel vm)
    {
        InitializeComponent();
        LoadPlatformSpecificXaml();
        BindingContext = vm;
    }

    private void LoadPlatformSpecificXaml()
    {
        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            this.LoadFromXaml(typeof(NotificationPopup_Android));
        }
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            this.LoadFromXaml(typeof(NotificationPopup_WinUI));
        }
    }
}