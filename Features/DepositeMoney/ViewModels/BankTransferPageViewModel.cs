namespace Transact;

public partial class BankTransferPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] public ObservableCollection<ConfirmDetailModel> confirmDetailsModels;

    public override Task OnAppearingAsync()
    {
        ConfirmDetailsModels =
        [
            new ConfirmDetailModel { Title = "Bank", Content = "Transact App" },
            new ConfirmDetailModel { Title = "Account No.", Content = "8160515151" },
            new ConfirmDetailModel { Title = "Account Name", Content = "Patricia Yakubu John" }
        ];
        return Task.CompletedTask;
    }
}