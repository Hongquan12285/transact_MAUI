using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class TransactionStatusFailedPage : Popup
{
    public TransactionStatusFailedPage()
	{
        InitializeComponent();
	}
    private void Close_Tapped(object sender, EventArgs e)
    {
        Close();
    }
}