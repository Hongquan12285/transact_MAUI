namespace Transact;

public partial class ConfirmDetailsPageViewModel(IAppNavigator appNavigator) : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] 
    public ObservableCollection<ConfirmDetailsModel> confirmDetailsModels;

    public override Task OnAppearingAsync()
    {
        ConfirmDetailsModels = new ObservableCollection<ConfirmDetailsModel>
        { 
            new ConfirmDetailsModel { Title = "Bank", Content = "GT Bank" },
            new ConfirmDetailsModel { Title = "Account No.", Content = "1234567890" },
            new ConfirmDetailsModel { Title = "Account Name", Content = "Tohib Olawole Chibuka" },
            new ConfirmDetailsModel { Title = "Remark", Content = "Medicine Fees" }
        };
        return Task.CompletedTask;
    }
}

