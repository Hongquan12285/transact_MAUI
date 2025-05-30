namespace Transact;

public partial class SignUpOtpPage : BasePage
{
    public SignUpOtpPage(SignUpOtpPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}