namespace Transact;

public partial class ATMCardPage : BasePage
{
    public ATMCardPage(ATMCardPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}