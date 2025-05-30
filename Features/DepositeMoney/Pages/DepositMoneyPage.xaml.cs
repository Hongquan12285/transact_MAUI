namespace Transact;

public partial class DepositMoneyPage : BasePage
{
    public DepositMoneyPage(DepositMoneyPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}