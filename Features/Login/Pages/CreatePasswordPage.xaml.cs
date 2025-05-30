namespace Transact;

public partial class CreatePasswordPage : BasePage
{
    public CreatePasswordPage(CreatePasswordPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}