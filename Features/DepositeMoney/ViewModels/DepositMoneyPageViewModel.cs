namespace Transact;

public partial class DepositMoneyPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] private ObservableCollection<RadioOption> depositTypeOptions;
    public DepositFormModel Form { get; init; } = new();

    public async override Task OnAppearingAsync()
    {
        await base.OnAppearingAsync();

        DepositTypeOptions =
        [
            new RadioOption
            {
                DisplayValue = "ATM Card", Value = "ATM Card", GroupRadio = "DepositTypeGroup",
                IsChecked = true
            },
            new RadioOption
            {
                DisplayValue = "Bank Transfer", Value = "Bank Transfer", GroupRadio = "DepositTypeGroup"
            },
        ];
    }

    [RelayCommand]
    private void Deposit()
    {
        switch (Form.DepositType)
        {
            case "ATM Card":
                AppNavigator.NavigateAsync(AppRoutes.ATMCard);
                break;
            case "Bank Transfer":
                AppNavigator.NavigateAsync(AppRoutes.BankTransfer);
                break;
        }
    }
}