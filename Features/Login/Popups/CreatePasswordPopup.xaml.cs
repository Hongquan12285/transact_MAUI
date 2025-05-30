namespace Transact;

public partial class CreatePasswordPopup : BasePopup
{
    public CreatePasswordPopup(SignUpOtpPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}