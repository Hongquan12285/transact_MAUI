namespace Transact;

public partial class HeaderNavigateView : ContentView
{
    public HeaderNavigateView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitlePageProperty = BindableProperty.Create(
        nameof(TitlePage), typeof(string), typeof(HeaderNavigateView), null,
        BindingMode.TwoWay
    );

    public static readonly BindableProperty IsBackProperty = BindableProperty.Create(
        nameof(IsBack), typeof(bool), typeof(HeaderNavigateView), false,
        BindingMode.TwoWay
    );

    public static readonly BindableProperty BackCommandProperty = BindableProperty.Create(
    nameof(BackCommand), typeof(IRelayCommand), typeof(HeaderNavigateView)
);

    public string TitlePage
    {
        get => (string)GetValue(TitlePageProperty);
        set => SetValue(TitlePageProperty, value);
    }

    public bool IsBack
    {
        get => (bool)GetValue(IsBackProperty);
        set => SetValue(IsBackProperty, value);
    }

    public IRelayCommand BackCommand
    {
        get => (IRelayCommand)GetValue(BackCommandProperty);
        set => SetValue(BackCommandProperty, value);
    }
}