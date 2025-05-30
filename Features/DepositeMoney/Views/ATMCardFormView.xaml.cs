namespace Transact;

public partial class ATMCardFormView : ContentView
{
    public ATMCardFormView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CaptionProperty = BindableProperty.Create(
        nameof(Caption), typeof(string), typeof(ATMCardFormView), null,
        BindingMode.TwoWay
    );

    public static readonly BindableProperty MoneyProperty = BindableProperty.Create(
        nameof(Money), typeof(string), typeof(ATMCardFormView), null,
        BindingMode.TwoWay
    );

    public string Caption
    {
        get => (string)GetValue(CaptionProperty);
        set => SetValue(CaptionProperty, value);
    }

    public string Money
    {
        get => (string)GetValue(MoneyProperty);
        set => SetValue(MoneyProperty, value);
    }
}