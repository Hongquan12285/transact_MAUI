namespace Transact;

public partial class SendMoneyPageViewModel(IAppNavigator appNavigator) : BaseViewModel(appNavigator)
{
    [RelayCommand]
    Task OtherBanksAsync() => AppNavigator.NavigateAsync(AppRoutes.OtherBanks);

    //[ObservableProperty] public ObservableCollection

}

