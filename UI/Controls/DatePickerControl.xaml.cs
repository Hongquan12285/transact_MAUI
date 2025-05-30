using Syncfusion.Maui.Toolkit.TextInputLayout;
using System.ComponentModel;
using Telerik.Maui.Controls;
using static System.String;

namespace Transact;

public partial class DatePickerControl : ContentView
{
    public DatePickerControl()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty LabelProperty = BindableProperty.Create(
        nameof(Label), typeof(string), typeof(DatePickerControl)
    );

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }

    public static readonly BindableProperty BackgroundControlProperty = BindableProperty.Create(
        nameof(BackgroundControl), typeof(Color), typeof(DatePickerControl), AppColors.White, BindingMode.TwoWay
    );

    public Color BackgroundControl
    {
        get => (Color)GetValue(BackgroundControlProperty);
        set => SetValue(BackgroundControlProperty, value);
    }

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        nameof(Placeholder), typeof(string), typeof(DatePickerControl)
    );

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public static readonly BindableProperty DisplayStringFormatProperty = BindableProperty.Create(
        nameof(DisplayStringFormat), typeof(string), typeof(DatePickerControl)
    );

    public string DisplayStringFormat
    {
        get => (string)GetValue(DisplayStringFormatProperty);
        set => SetValue(DisplayStringFormatProperty, value);
    }

    public static readonly BindableProperty SpinnerFormatProperty = BindableProperty.Create(
        nameof(SpinnerFormat), typeof(string), typeof(DatePickerControl)
    );

    public string SpinnerFormat
    {
        get => (string)GetValue(SpinnerFormatProperty);
        set => SetValue(SpinnerFormatProperty, value);
    }

    public DateTime? Date
    {
        get => (DateTime?)GetValue(DateProperty);
        set => SetValue(DateProperty, value);
    }

    public static readonly BindableProperty DateProperty = BindableProperty.Create(
        nameof(Date), typeof(DateTime?), typeof(DatePickerControl), null, BindingMode.TwoWay
    );

    public static readonly BindableProperty IsNotEmptyProperty = BindableProperty.Create(
        nameof(IsNotEmpty), typeof(bool), typeof(InputControl), false
    );

    public bool IsNotEmpty
    {
        get => (bool)GetValue(IsNotEmptyProperty);
        set => SetValue(IsNotEmptyProperty, value);
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
        if (bindable is not DatePickerControl datePicker) return;
        datePicker.ErrorMessage.Text =
            (bool)newValue ? Empty : Join(", ", datePicker.Errors.Select(e => e.ErrorMessage));
    }

    public bool IsValid
    {
        get => (bool)GetValue(IsValidProperty);
        set => SetValue(IsValidProperty, value);
    }

    private void DatePicker_Focused(object sender, FocusEventArgs e)
    {
        if (e.IsFocused)
        {
            ErrorMessage.Text = Empty;
            return;
        }

        ErrorMessage.Text =
            IsValid ? Empty : Join(", ", Errors.Select(e => e.ErrorMessage));
    }

    private void ValueChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (sender is not RadDatePicker picker) return;
        IsNotEmpty = picker.Date.HasValue;
    }
}