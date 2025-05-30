namespace Transact;

public partial class TransactionDetailsPage_Android : BasePage
{
    public TransactionDetailsPage_Android(TransactionDetailsPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}