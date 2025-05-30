namespace Transact;

public partial class NotificationPopupViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] private TransactionStatusModel transactionStatus;
    protected override void OnInit(IDictionary<string, object> query)
    {
        base.OnInit(query);
        var data = query.GetData<TransactionStatusModel>();
        if (data != null) TransactionStatus = data;
    }
}