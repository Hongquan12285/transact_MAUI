namespace Transact;

public partial class TransactionDetailsView_WinUI : ContentView
{
    public TransactionDetailsView_WinUI()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TransactionDetailProperty = BindableProperty.Create(
        nameof(TransactionDetail), typeof(TransactionDetailModel), typeof(TransactionDetailsView_WinUI)
    );

    public TransactionDetailModel TransactionDetail
    {
        get => (TransactionDetailModel)GetValue(TransactionDetailProperty);
        set => SetValue(TransactionDetailProperty, value);
    }
}