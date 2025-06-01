namespace Transact;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        //LoadPlatformSpecificXaml();
        ServicesExtension.RegisterRoute();
    }
    //private void LoadPlatformSpecificXaml()
    //{
    //    if (DeviceInfo.Platform == DevicePlatform.Android)
    //    {
    //        this.LoadFromXaml(typeof(AndroidTabBarLayout));
    //    }
    //    else if (DeviceInfo.Platform == DevicePlatform.WinUI)
    //    {
    //        this.LoadFromXaml(typeof(WindowsFlyoutLayout));
    //    }
    //}
}
