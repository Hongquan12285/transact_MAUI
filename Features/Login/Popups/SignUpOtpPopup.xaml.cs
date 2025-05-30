using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class SignUpOtpPopup : BasePopup
{
    public SignUpOtpPopup(SignUpOtpPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}