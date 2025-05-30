using System.Text.RegularExpressions;
using static System.String;

namespace Transact;

public partial class InputControl : ContentView
{
    private string _previousText = Empty;

    public InputControl()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty LabelProperty = BindableProperty.Create(
        nameof(Label), typeof(string), typeof(InputControl)
    );

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        nameof(Placeholder), typeof(string), typeof(InputControl)
    );

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(
        nameof(IsPassword), typeof(bool), typeof(InputControl), false
    );

    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }

    public static readonly BindableProperty IsClearProperty = BindableProperty.Create(
        nameof(IsClear), typeof(bool), typeof(InputControl), false
    );

    public bool IsClear
    {
        get => (bool)GetValue(IsClearProperty);
        set => SetValue(IsClearProperty, value);
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(InputControl), null, BindingMode.TwoWay
    );

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly BindableProperty BackgroundControlProperty = BindableProperty.Create(
        nameof(BackgroundControl), typeof(Color), typeof(InputControl), AppColors.White, BindingMode.TwoWay
    );

    public Color BackgroundControl
    {
        get => (Color)GetValue(BackgroundControlProperty);
        set => SetValue(BackgroundControlProperty, value);
    }

    public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(
        nameof(Keyboard), typeof(Keyboard), typeof(InputControl), Keyboard.Default
    );

    public Keyboard Keyboard
    {
        get => (Keyboard)GetValue(KeyboardProperty);
        set => SetValue(KeyboardProperty, value);
    }

    public static readonly BindableProperty ErrorsProperty = BindableProperty.Create(
        nameof(Errors), typeof(IEnumerable<ValidationResult>), typeof(InputControl), null, BindingMode.TwoWay
    );

    public IEnumerable<ValidationResult> Errors
    {
        get => (IEnumerable<ValidationResult>)GetValue(ErrorsProperty);
        set => SetValue(ErrorsProperty, value);
    }

    public static readonly BindableProperty IsValidProperty = BindableProperty.Create(
        nameof(IsValid),
        typeof(bool),
        typeof(InputControl),
        true,
        BindingMode.OneWay,
        propertyChanged: HandleIsValidChanged
    );

    private static void HandleIsValidChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not InputControl entry) return;
        entry.SfTextInputLayout.ErrorText =
            (bool)newValue ? Empty : Join(", ", entry.Errors.Select(e => e.ErrorMessage));
    }

    public bool IsValid
    {
        get => (bool)GetValue(IsValidProperty);
        set => SetValue(IsValidProperty, value);
    }

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        if (e.IsFocused)
        {
            SfTextInputLayout.ErrorText = Empty;
            EntryUnderline.BackgroundColor = AppColors.BorderGrey;
            return;
        }

        EntryUnderline.BackgroundColor = Colors.Transparent;
        SfTextInputLayout.ErrorText =
            IsValid ? Empty : Join(", ", Errors.Select(e => e.ErrorMessage));
    }

    private void OnClearClicked(object? sender, TappedEventArgs e) => Text = Empty;

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is not Entry entry) return;
        IsClear = !string.IsNullOrEmpty(entry.Text);
        if (Keyboard != Keyboard.Numeric) return;
        var regex = new Regex(@"^\d+(\.\d{1,2})?$");
        if (!IsNullOrEmpty(e.NewTextValue) && !regex.IsMatch(e.NewTextValue))
            entry.Text = _previousText;
        else _previousText = e.NewTextValue;
    }
}