namespace Transact;
public partial class TransactionDetailsPage_WinUI : BasePage
{
    public TransactionDetailsPage_WinUI(TransactionDetailsPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}