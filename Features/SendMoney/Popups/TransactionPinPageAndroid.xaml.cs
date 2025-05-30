using CommunityToolkit.Maui.Views;

namespace Transact;

public partial class TransactionPinPageAndroid : Popup
{
	public TransactionPinPageAndroid()
	{
        InitializeComponent();
    }

    private void OnEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is Entry currentEntry && !string.IsNullOrEmpty(currentEntry.Text))
        {
            currentEntry.Text = currentEntry.Text.Length > 1
                ? currentEntry.Text.Substring(0, 1)
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
            else if (currentEntry == Entry4)
            {
                ValidatePin();
            }
        }
    }

    private async void ValidatePin() 
    {
        string enteredPin = $"{Entry1.Text}{Entry2.Text}{Entry3.Text}{Entry4.Text}";

        if(enteredPin !="1234")
        {
            foreach(var child in PinContainer.Children)
            {
                if(child is Border border)
                {
                    border.Stroke = Colors.Red;
                }
            }
            Entry1.TextColor = Colors.Red;
            Entry2.TextColor = Colors.Red;
            Entry3.TextColor = Colors.Red;
            Entry4.TextColor = Colors.Red;

            ErrorLabel.IsVisible = true;
        }
        else
        {
            ErrorLabel.IsVisible = false;
            Close();
            await Application.Current.MainPage.Navigation.PushAsync(new LoadingSendMoneyPage());
        }
    }
}