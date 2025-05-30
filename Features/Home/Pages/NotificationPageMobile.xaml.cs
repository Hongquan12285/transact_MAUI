namespace Transact;

public partial class NotificationPageMobile : ContentPage
{
	public NotificationPageMobile(NotificationViewModel vm)
    {
		InitializeComponent();
        BindingContext = vm;
    }
}