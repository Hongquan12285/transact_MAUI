namespace Transact;

public partial class SignUpPage : BasePage
{
    public SignUpPage(SignUpPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}