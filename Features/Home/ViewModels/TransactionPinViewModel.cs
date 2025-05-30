namespace Transact
{
    public class TransactionPinViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
    {
        public TransactionFormModel Form { get; init; } = new();
    }
}
