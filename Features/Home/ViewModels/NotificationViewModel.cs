namespace Transact;

public partial class NotificationViewModel : NavigationAwareBaseViewModel
{
    public ObservableCollection<NotificationItem> Notifications { get; }
    private static bool _toggle;

    public TransactionFormModel Form { get; init; } = new();
    public NotificationViewModel(IAppNavigator appNavigator) : base(appNavigator)
    {
        // Command to navigate or close popup

        // Sample data
        Notifications = new ObservableCollection<NotificationItem>
            {
               new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
             new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
              new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
              new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"},
              new NotificationItem{StatusIcon = "success_icon.png", Title = "Transaction Successful",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Money Sent"},
            new NotificationItem{StatusIcon = "failed_icon.png", Title = "Transaction Failed",Subtitle = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA",Amount = "₦58,250.00",ActionText = "Deposit"}
            };
    }

    [RelayCommand]
    private async Task ClosePopupAsync()
    {
        // Close popup or navigate back
        await AppNavigator.GoBackAsync();
    }

    [RelayCommand]
    private void TransactionDetail()
    {
        if (_toggle)
            AppNavigator.NavigateAsync(UriHelper.StandardPath(AppRoutes.TransactionDetail), animated: true, args: new TransactionDetailModel
            {
                Category = "Money Sent",
                Money = "N25,00.00",
                Status = "Successful",
                Bank = "Stanbic IBTC Bank",
                AccountNo = "9811008835",
                AccountName = "Yakubu Precious Agba",
                From = "Patricia Yakubu John",
                Date = "1st Jan, 2024 08:32",
                TransactionNumber = "9653016392746063",
                Remark = "Remark"
            }).FireAndForget();

        else
            AppNavigator.NavigateAsync(UriHelper.StandardPath(AppRoutes.TransactionDetail), animated:true, args: new TransactionDetailModel
            {
                Category = "Money Sent",
                Money = "N25,00.00",
                Status = "Failed",
                Bank = "Stanbic IBTC Bank",
                AccountNo = "9811008835",
                AccountName = "Yakubu Precious Agba",
                From = "Patricia Yakubu John",
                Date = "1st Jan, 2024 08:32",
                TransactionNumber = "9653016392746063",
                Remark = "Medicine Payment"
            }).FireAndForget();
        _toggle = !_toggle;
    }
}
