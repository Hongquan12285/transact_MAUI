namespace Transact;

public partial class MyAccountMobile : ContentPage
{
	public MyAccountMobile(MyAccountViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}