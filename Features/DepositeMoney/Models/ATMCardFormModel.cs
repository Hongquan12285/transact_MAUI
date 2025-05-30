namespace Transact;

public partial class ATMCardFormModel : BaseFormModel
{
    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập số thẻ")]
    [NotifyPropertyChangedFor(nameof(CardNumberErrors))]
    [NotifyDataErrorInfo]
    string cardNumber;

    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập số CVV")]
    [NotifyPropertyChangedFor(nameof(CvvErrors))]
    [NotifyDataErrorInfo]
    string cvv;

    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập hạn ngày")]
    [NotifyPropertyChangedFor(nameof(ExpiryDateErrors))]
    [NotifyDataErrorInfo]
    DateTime? expiryDate;

    [ObservableProperty]
    [Required(ErrorMessage = "Vui lòng nhập mã pin")]
    [NotifyPropertyChangedFor(nameof(CardPinErrors))]
    [NotifyDataErrorInfo]
    string cardPin;

    public IEnumerable<ValidationResult> CardNumberErrors => GetErrors(nameof(CardNumber));
    public IEnumerable<ValidationResult> CvvErrors => GetErrors(nameof(Cvv));
    public IEnumerable<ValidationResult> ExpiryDateErrors => GetErrors(nameof(ExpiryDate));
    public IEnumerable<ValidationResult> CardPinErrors => GetErrors(nameof(CardPin));

    protected override string[] ValidatableAndSupportPropertyNames =>
    [
        nameof(CardNumber),
        nameof(CardNumberErrors),
        nameof(Cvv),
        nameof(CvvErrors),
        nameof(ExpiryDate),
        nameof(ExpiryDateErrors),
        nameof(CardPin),
        nameof(CardPinErrors)
    ];
}