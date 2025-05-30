using CommunityToolkit.Maui.Views;
namespace Transact;

public partial class TransactionPinPage : Popup
{
	public TransactionPinPage()
	{
		InitializeComponent();
    }

	private void TransactionStatusFailedPage_Clicked(object sender, EventArgs e)
	{
        this.Close();

        var parentPage = Application.Current.MainPage;
        parentPage.ShowPopup(new TransactionStatusFailedPage());
    }

	private void Close_Tapped(object sender, EventArgs e)
	{
		Close();
	}

    private void OnEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
		if (sender is Entry currentEntry && !string.IsNullOrEmpty(currentEntry.Text)) 
		{
			currentEntry.Text = currentEntry.Text.Length > 1 
				? currentEntry.Text.Substring(0,1)
				: currentEntry.Text;

			if (currentEntry == Entry1)
			{
				Entry2.Focus();
			}
			else if (currentEntry == Entry2)
			{
				Entry3.Focus();
			}
			else if (currentEntry == Entry3) 
			{
				Entry4.Focus();
			}
			else if(currentEntry == Entry4)
			{
				currentEntry.Unfocus();
			}
		}
    }
}