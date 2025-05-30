namespace Transact;

public class FirstItemValueConverter : IValueConverter, IMultiValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not IEnumerable items) return null;
        var enumerator = items.GetEnumerator();
        return enumerator.MoveNext() ? enumerator.Current : null;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public object? Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        return values?.FirstOrDefault();
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}