namespace Transact;

public partial class NavigatePageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [RelayCommand]
    private void ATMCardNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.ATMCard);

    [RelayCommand]
    private void BankTransferNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.BankTransfer);

    [RelayCommand]
    private void DepositMoneyNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.DepositMoney);

    [RelayCommand]
    private void HistoryNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.History);

    [RelayCommand]
    private void SuccessfulNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.Successful, args: new TransactionStatusModel
        {
            Caption = "Transaction Status",
            Note = "Deposit Made Successfully",
            Money = "N25,00.00",
            IsSuccess = true
        }).FireAndForget();

    [RelayCommand]
    private void FailureNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.Failure, args: new TransactionStatusModel
        {
            Caption = "Transaction Status",
            Note = "Deposit Failed. Try Again Later",
            Money = "N25,00.00",
            IsSuccess = false
        }).FireAndForget();

    [RelayCommand]
    private void TransactionDetailSuccessfulNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.TransactionDetail, args: new TransactionDetailModel
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

    [RelayCommand]
    private void TransactionDetailFailedNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.TransactionDetail, args: new TransactionDetailModel
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

    [RelayCommand]
    private void FilterNavigate() =>
        AppNavigator.NavigateAsync(AppRoutes.Filter).FireAndForget();
}