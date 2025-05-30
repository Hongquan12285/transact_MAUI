namespace Transact;

public partial class ForgotPasswordPage : BasePage
{
    public ForgotPasswordPage(ForgotPasswordPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}