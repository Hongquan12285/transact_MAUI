namespace Transact;

public partial class SettingPage : ContentPage
{
	public SettingPage(SettingViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}