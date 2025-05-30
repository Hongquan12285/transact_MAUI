namespace Transact;

public partial class TransactionDetailsPage : BasePage
{
    public TransactionDetailsPage(TransactionDetailsPageViewModel vm)
    {
        InitializeComponent();
        LoadPlatformSpecificXaml();
        BindingContext = vm;
    }

    private void LoadPlatformSpecificXaml()
    {
        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            this.LoadFromXaml(typeof(TransactionDetailsPage_Android));
        }
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            this.LoadFromXaml(typeof(TransactionDetailsPage_WinUI));
        }
    }
}