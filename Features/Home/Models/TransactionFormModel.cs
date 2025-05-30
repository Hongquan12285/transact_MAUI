namespace Transact;

public partial class TransactionFormModel : BaseFormModel
{
    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập mã PIN")]
    [RegularExpression(@"^\d{4}$", ErrorMessage = "Mã PIN phải có 4 chữ số")]
    [NotifyPropertyChangedFor(nameof(TransactionPinErrors))]
    [NotifyDataErrorInfo]
    private string transactionPin;

    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập lại mã PIN")]
    [NotifyPropertyChangedFor(nameof(RepeatTransactionPinErrors))]
    [NotifyDataErrorInfo]
    private string repeatTransactionPin;

    public IEnumerable<ValidationResult> TransactionPinErrors => GetErrors(nameof(TransactionPin));
    public IEnumerable<ValidationResult> RepeatTransactionPinErrors => GetErrors(nameof(RepeatTransactionPin));

    protected override string[] ValidatableAndSupportPropertyNames =>
    [
        nameof(TransactionPin),
        nameof(TransactionPinErrors),
        nameof(RepeatTransactionPin),
        nameof(RepeatTransactionPinErrors),
    ];
}
