namespace Transact;

public partial class ConfirmTransferView : ContentView
{
    public ConfirmTransferView()
    {
        InitializeComponent();
    }
    
    public static readonly BindableProperty ConfirmDetailsProperty = BindableProperty.Create(
        nameof(ConfirmDetails), typeof(ObservableCollection<ConfirmDetailModel>), typeof(ConfirmTransferView)
    );
    public static readonly BindableProperty CaptionProperty = BindableProperty.Create(
        nameof(Caption), typeof(string), typeof(ConfirmTransferView), null,
        BindingMode.TwoWay
    );
    public static readonly BindableProperty MoneyProperty = BindableProperty.Create(
        nameof(Money), typeof(string), typeof(ConfirmTransferView), null,
        BindingMode.TwoWay
    );
    public static readonly BindableProperty NoteProperty = BindableProperty.Create(
        nameof(Note), typeof(string), typeof(ConfirmTransferView), null,
        BindingMode.TwoWay
    );
    
    public ObservableCollection<ConfirmDetailModel> ConfirmDetails
    {
        get => (ObservableCollection<ConfirmDetailModel>)GetValue(ConfirmDetailsProperty);
        set => SetValue(ConfirmDetailsProperty, value);
    }
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
    public string Note
    {
        get => (string)GetValue(NoteProperty);
        set => SetValue(NoteProperty, value);
    }
}