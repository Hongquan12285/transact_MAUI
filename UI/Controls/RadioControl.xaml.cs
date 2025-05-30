namespace Transact;

public partial class RadioControl : ContentView
{
    public RadioControl()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    public static readonly BindableProperty BackgroundControlProperty = BindableProperty.Create(
        nameof(BackgroundControl), typeof(Color), typeof(RadioControl)
    );

    public static readonly BindableProperty RadioOptionsProperty = BindableProperty.Create(
        nameof(RadioOptions), typeof(ObservableCollection<RadioOption>), typeof(RadioControl)
    );

    public static readonly BindableProperty SelectionValueProperty = BindableProperty.Create(
        nameof(SelectionValue), typeof(object), typeof(RadioControl), null, BindingMode.TwoWay
    );

    public Color BackgroundControl
    {
        get => (Color)GetValue(BackgroundControlProperty);
        set => SetValue(BackgroundControlProperty, value);
    }

    public ObservableCollection<RadioOption> RadioOptions
    {
        get => (ObservableCollection<RadioOption>)GetValue(RadioOptionsProperty);
        set => SetValue(RadioOptionsProperty, value);
    }

    public object SelectionValue
    {
        get => GetValue(SelectionValueProperty);
        set => SetValue(SelectionValueProperty, value);
    }

    private void OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        if (sender is not RadioButton radioButton || !e.Value) return;
        SelectionValue = radioButton.Value;
    }

    private void OnLoaded(object? sender, EventArgs e)
    {
        foreach (var radioOption in RadioOptions)
        {
            if (radioOption.IsChecked) SelectionValue = radioOption.Value;
        }
    }
}
