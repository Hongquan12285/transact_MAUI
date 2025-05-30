namespace Transact;

public partial class FilterPopupViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] private ObservableCollection<RadioOption> transactionTypeOptions;
    [ObservableProperty] private ObservableCollection<RadioOption> chartViewOptions;
    [ObservableProperty] private object selectionValue;
    
    public FilterFormModel Form { get; init; } = new();

    public override Task OnAppearingAsync()
    {
        TransactionTypeOptions =
        [
            new RadioOption
            {
                DisplayValue = "All Transactions", Value = "All Transactions", GroupRadio = "TransactionTypeGroup",
                IsChecked = true
            },
            new RadioOption { DisplayValue = "Deposit", Value = "Deposit", GroupRadio = "TransactionTypeGroup" },
            new RadioOption { DisplayValue = "Money Sent", Value = "Money Sent", GroupRadio = "TransactionTypeGroup" },
        ];

        ChartViewOptions =
        [
            new RadioOption
                { DisplayValue = "Daily", Value = "Daily", GroupRadio = "ChartViewGroup", IsChecked = true },
            new RadioOption { DisplayValue = "Weekly", Value = "Weekly", GroupRadio = "ChartViewGroup" },
            new RadioOption { DisplayValue = "Monthly", Value = "Monthly", GroupRadio = "ChartViewGroup" },
        ];
        return Task.CompletedTask;
    }
}