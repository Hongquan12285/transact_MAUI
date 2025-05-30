using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class TransactionpinPopup : Popup
{
	public TransactionpinPopup(NotificationViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
        this.Color = Colors.Transparent;
    }
    
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Close();
    }
}