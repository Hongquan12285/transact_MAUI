using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class MyAccountPage : BasePage
{
    public MyAccountPage(MyAccountViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}