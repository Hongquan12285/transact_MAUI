namespace Transact;

public partial class FilterPopup : BasePopup
{
    public FilterPopup(FilterPopupViewModel vm)
    {
        InitializeComponent();
        LoadPlatformSpecificXaml();
        BindingContext = vm;
    }

    private void LoadPlatformSpecificXaml()
    {
        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            this.LoadFromXaml(typeof(FilterPopup_Android));
        }
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            this.LoadFromXaml(typeof(FilterPopup_WinUI));
        }
    }
}