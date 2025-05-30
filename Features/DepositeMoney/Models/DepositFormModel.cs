namespace Transact;

public partial class DepositFormModel : BaseFormModel
{
    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập đặt cọc")]
    [NotifyPropertyChangedFor(nameof(DepositAmountErrors))]
    [NotifyDataErrorInfo]
    string depositAmount;

    [ObservableProperty] string depositType;
    public IEnumerable<ValidationResult> DepositAmountErrors => GetErrors(nameof(DepositAmount));

    protected override string[] ValidatableAndSupportPropertyNames =>
    [
        nameof(DepositAmount),
        nameof(DepositAmountErrors),
    ];
}