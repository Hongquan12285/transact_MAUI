namespace Transact;

public partial class TransactionPinPageMobile : ContentPage
{
	public TransactionPinPageMobile(TransactionPinViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}