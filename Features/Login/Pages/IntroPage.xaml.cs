namespace Transact;

public partial class IntroPage : BasePage
{
    public IntroPage(IntroPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}