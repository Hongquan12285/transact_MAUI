namespace Transact;

public class RadioOption
{
    public string DisplayValue { get; set; } = null!;
    public object Value { get; set; } = null!;
    public string GroupRadio { get; set; } = null!;
    public bool IsChecked { get; set; } = false;
}
