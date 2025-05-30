namespace Transact;

public partial class FilterFormModel : BaseFormModel
{
    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập ngày đến")]
    [NotifyPropertyChangedFor(nameof(DateFromErrors))]
    [NotifyDataErrorInfo]
    DateTime? dateFrom;

    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập ngày đi")]
    [NotifyPropertyChangedFor(nameof(DateToErrors))]
    [NotifyDataErrorInfo]
    DateTime? dateTo;

    [ObservableProperty] string transactionType;
    [ObservableProperty] string chartView;
    public IEnumerable<ValidationResult> DateFromErrors => GetErrors(nameof(DateFrom));
    public IEnumerable<ValidationResult> DateToErrors => GetErrors(nameof(DateTo));

    protected override string[] ValidatableAndSupportPropertyNames =>
    [
        nameof(DateFrom),
        nameof(DateFromErrors),
        nameof(DateTo),
        nameof(DateToErrors),
    ];
}