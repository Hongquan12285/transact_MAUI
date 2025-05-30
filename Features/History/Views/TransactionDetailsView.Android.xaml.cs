namespace Transact;

public partial class TransactionDetailsView_Android : ContentView
{
    public TransactionDetailsView_Android()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TransactionDetailProperty = BindableProperty.Create(
        nameof(TransactionDetail), typeof(TransactionDetailModel), typeof(TransactionDetailsView_Android)
    );

    public TransactionDetailModel TransactionDetail
    {
        get => (TransactionDetailModel)GetValue(TransactionDetailProperty);
        set => SetValue(TransactionDetailProperty, value);
    }
}