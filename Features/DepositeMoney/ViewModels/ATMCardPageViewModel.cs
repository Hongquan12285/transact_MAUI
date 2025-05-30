namespace Transact;

public partial class ATMCardPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    public ATMCardFormModel Form { get; init; } = new();
    private bool _toggle;

    [RelayCommand]
    private void Deposit()
    {
        if (_toggle)
            AppNavigator.NavigateAsync(AppRoutes.Successful, args: new TransactionStatusModel
            {
                Caption = "Transaction Status",
                Note = "Deposit Made Successfully",
                Money = "N25,00.00",
                IsSuccess = true
            }).FireAndForget();
        else
            AppNavigator.NavigateAsync(AppRoutes.Failure, args: new TransactionStatusModel
            {
                Caption = "Transaction Status",
                Note = "Deposit Failed. Try Again Later",
                Money = "N25,00.00",
                IsSuccess = false
            }).FireAndForget();
        _toggle = !_toggle;
    }
}