namespace Transact;

public partial class BankTransferPage : BasePage
{
    public BankTransferPage(BankTransferPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}