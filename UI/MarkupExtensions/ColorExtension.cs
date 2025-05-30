namespace Transact;

[ContentProperty(nameof(Value))]
public class ColorExtension : IMarkupExtension
{
    public Color Value { get; set; }

    public float Alpha { get; set; } = -1;

    public object? ProvideValue(IServiceProvider serviceProvider)
    {
        return Value?.WithAlpha(Alpha is > 0 and < 1 ? Alpha : 1);
    }
}